using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace PPT2PDF_Reg_Generator
{
	public partial class PPT2PDF_Reg_Wizard : Form
	{
		private string regFileName = "PPT2PDF.reg";
		private string vbsFileName = "PPT2PDF.vbs";


		public PPT2PDF_Reg_Wizard()
		{
			InitializeComponent();
		}

		private void PPT2PDF_Reg_Wizard_Load(object sender, EventArgs e)
		{
		}

		private void btnStep1_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				string vbsDirPath = folderBrowserDialog1.SelectedPath;

				string vbsResourceFileName = "vbs.txt";
				string vbsFileContent = "";
				string vbsFilePath = "";

				vbsFileContent = GetContentFromResourceByFileName(vbsResourceFileName);

				vbsFilePath = vbsDirPath + "\\" + vbsFileName;
				StreamWriter sw = null;

				try
				{
					sw = new StreamWriter(vbsFilePath);
					sw.Write(vbsFileContent);
				}
				catch (Exception)
				{
					throw;
				}
				finally
				{
					sw.Close();
				}

				btnStep1.Enabled = false;
				btnStep2.Enabled = true;

				btnStep1.Text = "脚本文件已成功生成在所选文件夹下";
			}
		}

		private void btnStep2_Click(object sender, EventArgs e)
		{
			string regFileString = "";
			string regFilePath = "";
			string regResourceFileName = "reg.txt";
			string regFileDir = folderBrowserDialog1.SelectedPath;


			regFilePath = regFileDir + "\\" + regFileName;
			regFileString = GetContentFromResourceByFileName(regResourceFileName);
			regFileString = regFileString.Replace("@vbspath", regFileDir.Replace("\\", "\\\\") + "\\\\" + vbsFileName);


			StreamWriter sw = null;

			try
			{
				sw = new StreamWriter(regFilePath, false, Encoding.GetEncoding("GB2312"));
				sw.Write(regFileString);
				sw.Close();

				btnStep2.Text = "注册文件已成功生成在脚本所在文件夹下";
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				sw.Close();
			}

			btnStep2.Enabled = false;
			btnStep3.Enabled = true;
		}

		private string GetContentFromResourceByFileName(string fileName)
		{
			Assembly asm = Assembly.GetExecutingAssembly();
			string localNameSpace = this.GetType().Namespace;
			Stream s = asm.GetManifestResourceStream(localNameSpace + "." + fileName);
			StreamReader sr = new StreamReader(s);

			string content = sr.ReadToEnd();

			return content;
		}

		private void btnStep3_Click(object sender, EventArgs e)
		{
			string regFilePath = folderBrowserDialog1.SelectedPath + "\\" + regFileName;

			try
			{
				if (File.Exists(regFilePath))
				{
					regFilePath = @"""" + regFilePath + @"""";

					if (MessageBox.Show("确定要导入注册表文件吗？", "问题", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
					{
						Process.Start("regedit", string.Format(" /s {0}", regFilePath));
					}
					btnStep3.Enabled = false;
					btnStep3.Text = "注册表文件已成功导入，可通过右键菜单转换";
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}