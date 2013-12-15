using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PPT2PDF_Reg_Generator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void GenerateRegFile()
		{
			string regFileString = "";
			string regFilePath = "";
			string regFileName = "ms2std.reg";
			string vbsFilePath = txtVBSFilePath.Text;
			string regFileDir = vbsFilePath.Substring(0, vbsFilePath.LastIndexOf("\\") + 1);
			regFilePath = regFileDir + regFileName;

			StreamReader streamReader = new StreamReader(regFilePath, Encoding.GetEncoding("GB2312"));
			regFileString = streamReader.ReadToEnd();

			regFileString

			regFileString = regFileString.Replace("@vbspath", txtVBSFilePath.Text)
										 .Replace("@2PDF", "转换为PDF格式")
										 .Replace("@2RTF","转换为RTF格式");
			txtVBSFilePath.Text = regFileString;

			//StreamWriter streamWriter = new StreamWriter(regFileDir + "newreg.reg", false, new UTF8Encoding());
			//streamWriter.Write(regFileString);
			//streamWriter.Close();
			int i = 1;


		}

		private void btnOpenFileDialog_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtVBSFilePath.Text = openFileDialog1.FileName;
				GenerateRegFile();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "vbs文件|*.vbs";
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{

		}
	}


}
