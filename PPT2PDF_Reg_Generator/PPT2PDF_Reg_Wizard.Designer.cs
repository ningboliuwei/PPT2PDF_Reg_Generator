namespace PPT2PDF_Reg_Generator
{
	partial class PPT2PDF_Reg_Wizard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPT2PDF_Reg_Wizard));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnStep3 = new System.Windows.Forms.Button();
			this.btnStep2 = new System.Windows.Forms.Button();
			this.btnStep1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.btnStep3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnStep2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnStep1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 228);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnStep3
			// 
			this.btnStep3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnStep3.Enabled = false;
			this.btnStep3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnStep3.Location = new System.Drawing.Point(3, 141);
			this.btnStep3.Name = "btnStep3";
			this.btnStep3.Size = new System.Drawing.Size(391, 63);
			this.btnStep3.TabIndex = 2;
			this.btnStep3.Text = "第三步：导入注册表文件";
			this.btnStep3.UseVisualStyleBackColor = true;
			this.btnStep3.Click += new System.EventHandler(this.btnStep3_Click);
			// 
			// btnStep2
			// 
			this.btnStep2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnStep2.Enabled = false;
			this.btnStep2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnStep2.Location = new System.Drawing.Point(3, 72);
			this.btnStep2.Name = "btnStep2";
			this.btnStep2.Size = new System.Drawing.Size(391, 63);
			this.btnStep2.TabIndex = 1;
			this.btnStep2.Text = "第二步：生成注册表文件";
			this.btnStep2.UseVisualStyleBackColor = true;
			this.btnStep2.Click += new System.EventHandler(this.btnStep2_Click);
			// 
			// btnStep1
			// 
			this.btnStep1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnStep1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnStep1.Location = new System.Drawing.Point(3, 3);
			this.btnStep1.Name = "btnStep1";
			this.btnStep1.Size = new System.Drawing.Size(391, 63);
			this.btnStep1.TabIndex = 0;
			this.btnStep1.Text = "第一步：选择放置脚本文件的文件夹";
			this.btnStep1.UseVisualStyleBackColor = true;
			this.btnStep1.Click += new System.EventHandler(this.btnStep1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(3, 207);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(391, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "written by: @培根芝士牛堡 （bullfrog2000@sina.com）";
			// 
			// PPT2PDF_Reg_Wizard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 228);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PPT2PDF_Reg_Wizard";
			this.Text = "PPT2PDF";
			this.Load += new System.EventHandler(this.PPT2PDF_Reg_Wizard_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnStep3;
		private System.Windows.Forms.Button btnStep2;
		private System.Windows.Forms.Button btnStep1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label label1;

	}
}