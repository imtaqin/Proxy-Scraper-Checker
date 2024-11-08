using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;
using System.IO;

namespace Proxy_Scraper_and_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Directory.CreateDirectory(Environment.CurrentDirectory + @"\\Results");
        }

        public string[] daftarProxy;
        public string tipeProxy;

        string waktuSekarang = DateTime.Now.ToString("dd-MM-yyyy h-mm-ss");

        private void tulisKeFile(string tipeProxy, string proxy)
        {
            try
            {
                string namaFile = Environment.CurrentDirectory + @"\\Results\\[GOOD] " + tipeProxy + " Proxies " + waktuSekarang + ".txt";
                File.AppendAllText(namaFile, proxy + Environment.NewLine);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Gagal menulis ke file: {ex.Message}");
            }
        }

        private void ambilProxy(string tipeProxy)
        {
            var daftarUrl = new[]
            {
                $"https://api.proxyscrape.com/v2/?request=getproxies&protocol={tipeProxy}&timeout=10000&country=all&ssl=all&anonymity=all",
                "https://free-proxy-list.net/",
                "https://www.freeproxy.world/?type=&anonymity=&country=&speed=&port=&page=1",
                "https://spys.one/en/free-proxy-list/"
            };

            var daftarProxyList = new List<string>();
            HttpRequest permintaan = new HttpRequest();

            foreach (var url in daftarUrl)
            {
                try
                {
                    string respons = permintaan.Get(url).ToString();
                    if (url.Contains("free-proxy-list.net"))
                    {
                        var cocok = Regex.Matches(respons, @"<td>(\d+\.\d+\.\d+\.\d+)</td><td>(\d+)</td>");
                        foreach (Match match in cocok)
                        {
                            daftarProxyList.Add($"{match.Groups[1].Value}:{match.Groups[2].Value}");
                        }
                    }
                    else if (url.Contains("freeproxy.world"))
                    {
                        var cocok = Regex.Matches(respons, @"<td class=""show-ip-div"">\s*([\d.]+)\s*</td>\s*<td>\s*<a href=""/\?port=\d+"">(\d+)</a>");
                        foreach (Match match in cocok)
                        {
                            daftarProxyList.Add($"{match.Groups[1].Value}:{match.Groups[2].Value}");
                        }
                    }
                    else if (url.Contains("spys.one"))
                    {
                        var cocok = Regex.Matches(respons, @"<font class=""spy14"">([\d.]+).*?<font class=""spy2"">:</font>(\d+)</font>");
                        foreach (Match match in cocok)
                        {
                            daftarProxyList.Add($"{match.Groups[1].Value}:{match.Groups[2].Value}");
                        }
                    }
                    else
                    {
                        daftarProxyList.AddRange(respons.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
                    }
                }
                catch (HttpException ex)
                {
                    MessageBox.Show($"Gagal mengambil proxy dari {url}: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan saat mengambil proxy dari {url}: {ex.Message}");
                }
            }

            daftarProxy = daftarProxyList.ToArray();
            label_TotalProxy.Text = daftarProxy.Length.ToString();
        }

        private void periksaProxy(string proxy)
        {
            string urlUji = "https://google.com";
            HttpRequest permintaan = new HttpRequest();

            try
            {
                if (radioButton_Http.Checked)
                {
                    permintaan.Proxy = HttpProxyClient.Parse(proxy);
                    tipeProxy = "HTTP";
                }
                else if (radioButton_Socks4.Checked)
                {
                    permintaan.Proxy = Socks4ProxyClient.Parse(proxy);
                    tipeProxy = "Socks4";
                }
                else if (radioButton_Socks5.Checked)
                {
                    permintaan.Proxy = Socks5ProxyClient.Parse(proxy);
                    tipeProxy = "Socks5";
                }

                var respons = permintaan.Get(urlUji).ToString();
                textBox_Results.Text += proxy + Environment.NewLine;
                label_GoodProxy.Text = (int.Parse(label_GoodProxy.Text) + 1).ToString();

                tulisKeFile(tipeProxy, proxy);
            }
            catch (HttpException)
            {
                label_BadProxy.Text = (int.Parse(label_BadProxy.Text) + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kesalahan saat memeriksa proxy {proxy}: {ex.Message}");
            }
        }

        private void subTugas()
        {
            var tasks =
                from proxy in daftarProxy
                select Task.Factory.StartNew(() => periksaProxy(proxy));
            Task.WaitAll(tasks.ToArray());
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (radioButton_Http.Checked)
                ambilProxy("http");
            else if (radioButton_Socks4.Checked)
                ambilProxy("socks4");
            else if (radioButton_Socks5.Checked)
                ambilProxy("socks5");

            Thread thread = new Thread(subTugas)
            {
                IsBackground = true
            };
            thread.Start();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmLogin = new Form2();
            frmLogin.ShowDialog();
        }
    }
}
