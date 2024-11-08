
namespace Proxy_Scraper_and_Checker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_Results = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Socks5 = new System.Windows.Forms.RadioButton();
            this.radioButton_Socks4 = new System.Windows.Forms.RadioButton();
            this.radioButton_Http = new System.Windows.Forms.RadioButton();
            this.button_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_TotalProxy = new System.Windows.Forms.Label();
            this.label_GoodProxy = new System.Windows.Forms.Label();
            this.label_BadProxy = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Results
            // 
            this.textBox_Results.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_Results.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Results.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox_Results.Location = new System.Drawing.Point(12, 40);
            this.textBox_Results.Multiline = true;
            this.textBox_Results.Name = "textBox_Results";
            this.textBox_Results.Size = new System.Drawing.Size(452, 172);
            this.textBox_Results.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Socks5);
            this.groupBox1.Controls.Add(this.radioButton_Socks4);
            this.groupBox1.Controls.Add(this.radioButton_Http);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(482, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy Type";
            // 
            // radioButton_Socks5
            // 
            this.radioButton_Socks5.AutoSize = true;
            this.radioButton_Socks5.Location = new System.Drawing.Point(169, 34);
            this.radioButton_Socks5.Name = "radioButton_Socks5";
            this.radioButton_Socks5.Size = new System.Drawing.Size(73, 21);
            this.radioButton_Socks5.TabIndex = 2;
            this.radioButton_Socks5.TabStop = true;
            this.radioButton_Socks5.Text = "Socks 5";
            this.radioButton_Socks5.UseVisualStyleBackColor = true;
            // 
            // radioButton_Socks4
            // 
            this.radioButton_Socks4.AutoSize = true;
            this.radioButton_Socks4.Location = new System.Drawing.Point(90, 34);
            this.radioButton_Socks4.Name = "radioButton_Socks4";
            this.radioButton_Socks4.Size = new System.Drawing.Size(73, 21);
            this.radioButton_Socks4.TabIndex = 1;
            this.radioButton_Socks4.TabStop = true;
            this.radioButton_Socks4.Text = "Socks 4";
            this.radioButton_Socks4.UseVisualStyleBackColor = true;
            // 
            // radioButton_Http
            // 
            this.radioButton_Http.AutoSize = true;
            this.radioButton_Http.Location = new System.Drawing.Point(13, 34);
            this.radioButton_Http.Name = "radioButton_Http";
            this.radioButton_Http.Size = new System.Drawing.Size(71, 21);
            this.radioButton_Http.TabIndex = 0;
            this.radioButton_Http.TabStop = true;
            this.radioButton_Http.Text = "HTTP/S";
            this.radioButton_Http.UseVisualStyleBackColor = true;
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.Black;
            this.button_Start.Location = new System.Drawing.Point(482, 127);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(268, 38);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Proxy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Good Proxy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bad Proxy";
            // 
            // label_TotalProxy
            // 
            this.label_TotalProxy.AutoSize = true;
            this.label_TotalProxy.Location = new System.Drawing.Point(560, 186);
            this.label_TotalProxy.Name = "label_TotalProxy";
            this.label_TotalProxy.Size = new System.Drawing.Size(15, 17);
            this.label_TotalProxy.TabIndex = 6;
            this.label_TotalProxy.Text = "0";
            // 
            // label_GoodProxy
            // 
            this.label_GoodProxy.AutoSize = true;
            this.label_GoodProxy.Location = new System.Drawing.Point(560, 221);
            this.label_GoodProxy.Name = "label_GoodProxy";
            this.label_GoodProxy.Size = new System.Drawing.Size(15, 17);
            this.label_GoodProxy.TabIndex = 7;
            this.label_GoodProxy.Text = "0";
            // 
            // label_BadProxy
            // 
            this.label_BadProxy.AutoSize = true;
            this.label_BadProxy.Location = new System.Drawing.Point(718, 186);
            this.label_BadProxy.Name = "label_BadProxy";
            this.label_BadProxy.Size = new System.Drawing.Size(15, 17);
            this.label_BadProxy.TabIndex = 8;
            this.label_BadProxy.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(106, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 25);
            this.textBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Url to Check :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(772, 271);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_BadProxy);
            this.Controls.Add(this.label_GoodProxy);
            this.Controls.Add(this.label_TotalProxy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Results);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proxy Scraper + Checker | @imtaqin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Results;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Socks5;
        private System.Windows.Forms.RadioButton radioButton_Socks4;
        private System.Windows.Forms.RadioButton radioButton_Http;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_TotalProxy;
        private System.Windows.Forms.Label label_GoodProxy;
        private System.Windows.Forms.Label label_BadProxy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

