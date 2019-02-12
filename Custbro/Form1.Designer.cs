using System.Windows.Forms;
namespace Custbro
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
		/// 
	
		
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.homepage = new System.Windows.Forms.Button();
			this.command = new System.Windows.Forms.Button();
			this.StartXampp = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.xammp = new System.Windows.Forms.Button();
			this.Google = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.refresh = new System.Windows.Forms.Button();
			this.go = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.Controls.Add(this.homepage);
			this.panel1.Controls.Add(this.command);
			this.panel1.Controls.Add(this.StartXampp);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.xammp);
			this.panel1.Controls.Add(this.Google);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1093, 61);
			this.panel1.TabIndex = 1;
			// 
			// homepage
			// 
			this.homepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.homepage.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.homepage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.homepage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.homepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.homepage.Location = new System.Drawing.Point(568, 13);
			this.homepage.Name = "homepage";
			this.homepage.Size = new System.Drawing.Size(102, 32);
			this.homepage.TabIndex = 6;
			this.homepage.Text = "Home page";
			this.homepage.UseVisualStyleBackColor = false;
			this.homepage.Click += new System.EventHandler(this.homepage_Click);
			// 
			// command
			// 
			this.command.AutoSize = true;
			this.command.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.command.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.command.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.command.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.command.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.command.Location = new System.Drawing.Point(460, 13);
			this.command.Name = "command";
			this.command.Size = new System.Drawing.Size(102, 32);
			this.command.TabIndex = 5;
			this.command.Text = "Comand Line ";
			this.command.UseVisualStyleBackColor = false;
			this.command.Click += new System.EventHandler(this.CommandLine_Click);
			// 
			// StartXampp
			// 
			this.StartXampp.AutoSize = true;
			this.StartXampp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.StartXampp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StartXampp.Location = new System.Drawing.Point(352, 12);
			this.StartXampp.Name = "StartXampp";
			this.StartXampp.Size = new System.Drawing.Size(102, 32);
			this.StartXampp.TabIndex = 4;
			this.StartXampp.Text = "Start Xampp";
			this.StartXampp.UseVisualStyleBackColor = false;
			this.StartXampp.Click += new System.EventHandler(this.startxampp_Click);
			// 
			// button5
			// 
			this.button5.AutoSize = true;
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(244, 12);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(102, 32);
			this.button5.TabIndex = 3;
			this.button5.Text = "Local folder";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.localFile_Click);
			// 
			// xammp
			// 
			this.xammp.AutoSize = true;
			this.xammp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.xammp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.xammp.Location = new System.Drawing.Point(136, 12);
			this.xammp.Name = "xammp";
			this.xammp.Size = new System.Drawing.Size(102, 32);
			this.xammp.TabIndex = 2;
			this.xammp.Text = "Xampp folder";
			this.xammp.UseVisualStyleBackColor = false;
			this.xammp.Click += new System.EventHandler(this.Xampp_Click);
			// 
			// Google
			// 
			this.Google.AutoSize = true;
			this.Google.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Google.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Google.ForeColor = System.Drawing.Color.Black;
			this.Google.Location = new System.Drawing.Point(13, 12);
			this.Google.Name = "Google";
			this.Google.Size = new System.Drawing.Size(117, 33);
			this.Google.TabIndex = 1;
			this.Google.Text = "Google";
			this.Google.UseVisualStyleBackColor = false;
			this.Google.Click += new System.EventHandler(this.Google_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.refresh);
			this.panel2.Controls.Add(this.go);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(680, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(413, 61);
			this.panel2.TabIndex = 0;
			// 
			// refresh
			// 
			this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refresh.Location = new System.Drawing.Point(335, 24);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(75, 23);
			this.refresh.TabIndex = 4;
			this.refresh.Text = "Refresh";
			this.refresh.UseVisualStyleBackColor = false;
			this.refresh.Click += new System.EventHandler(this.Refresh_Click);
			// 
			// go
			// 
			this.go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.go.Location = new System.Drawing.Point(254, 22);
			this.go.Name = "go";
			this.go.Size = new System.Drawing.Size(75, 23);
			this.go.TabIndex = 3;
			this.go.Text = "Go";
			this.go.UseVisualStyleBackColor = false;
			this.go.Click += new System.EventHandler(this.GO_Click_1);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(0, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(248, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(0, 61);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(1093, 389);
			this.webBrowser1.TabIndex = 2;
			this.webBrowser1.Url = new System.Uri(" file:///C:/Users/user/source/repos/Custbro/Custbro/page.html", System.UriKind.Absolute);
			// 
			// timer1
			// 
			this.timer1.Interval = 10000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1093, 450);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Welcome to Custbro";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}


		#endregion

		private Panel panel1;
		private WebBrowser webBrowser1;
		private Panel panel2;
		private Button go;
		private TextBox textBox1;
		private Button refresh;
		private Button xammp;
		private Button Google;
		private Button button5;
		private Button StartXampp;
		private Button command;
		private Timer timer1;
		private Button homepage;
		private OpenFileDialog openFileDialog1;
	}
}

