using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Custbro
{
	public partial class Form1 : Form
	{
	
		public Form1()
		{
			InitializeComponent();
		}

		public void Refreshtest()
		{
			if (textBox1.Text == "http:/")
			{
				
			}
			else if (textBox1.Text.Length == 10  || textBox1.Text.Length <= 7)
			{
				MessageBox.Show("Please you did you enter a good Url or website");
			}
			else
			{
				textBox1.Text = webBrowser1.Url.ToString();
			}
		}
		public  void gotest()
		{
			if (textBox1.Text == "http:/")
			{
				MessageBox.Show("Please you did not enter Url or website");
			}
			else if (textBox1.Text.Length == 7 || textBox1.Text.Length <= 7)
			{
				MessageBox.Show("Please you did you enter a good Url or website");
			}
			else
			{
				UriTypeConverter uri = new UriTypeConverter();
				Uri link = uri.ConvertFromString(textBox1.Text) as Uri;
				webBrowser1.Url = link;
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			textBox1.Text = "http:/";
			timer1.Start();
		}

		private void GO_Click_1(object sender, EventArgs e)
		{
			if (textBox1.Text=="http:/")
			{
				MessageBox.Show("Please you did not enter Url or website");
			}
		    else	if (textBox1.Text.Length == 7 || textBox1.Text.Length <= 7)
			{
				MessageBox.Show("Please you did you enter a good Url or website");
			}
			else
			{
				UriTypeConverter uri = new UriTypeConverter();
				Uri link = uri.ConvertFromString(textBox1.Text) as Uri;
				webBrowser1.Url = link;
			}

		}

		private void Refresh_Click(object sender, EventArgs e)
		{

			Refreshtest();
		}

		private void Google_Click(object sender, EventArgs e)
		{
			textBox1.Text = "http://www.google.com";
		   UriTypeConverter uri = new UriTypeConverter();
			Uri link = uri.ConvertFromString(textBox1.Text) as Uri;
			webBrowser1.Url = link;
		}

		private void localFile_Click(object sender, EventArgs e)
		{
			textBox1.Text = "file:///C:/";
			UriTypeConverter uri = new UriTypeConverter();
			Uri link = uri.ConvertFromString(textBox1.Text) as Uri;
			webBrowser1.Url = link;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Refreshtest();
		}

		private void CommandLine_Click(object sender, EventArgs e)
		{
			Console.Beep();
			Console.WriteLine("hello world");
			Console.ReadLine();
		}

		private void Xampp_Click(object sender, EventArgs e)
		{
			textBox1.Text = "file:///C:/xampp/htdocs";
			UriTypeConverter uri = new UriTypeConverter();
			Uri link = uri.ConvertFromString(textBox1.Text) as Uri;
			webBrowser1.Url = link;
		}

		private void startxampp_Click(object sender, EventArgs e)
		{
			textBox1.Text = "file:///C:/xampp/xampp-control.exe";
			UriTypeConverter uri = new UriTypeConverter();
			Uri link = uri.ConvertFromString(textBox1.Text) as Uri;
			webBrowser1.Url = link;
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			gotest();
		}

		private void homepage_Click(object sender, EventArgs e)
		{
			textBox1.Text = " file:///C:/Users/user/source/repos/Custbro/Custbro/page.html";
			UriTypeConverter uri = new UriTypeConverter();
			Uri link = uri.ConvertFromString(textBox1.Text) as Uri;
			webBrowser1.Url = link;	  
		}
	}
}
