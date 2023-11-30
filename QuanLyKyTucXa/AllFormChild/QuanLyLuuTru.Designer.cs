namespace QuanLyKyTucXa.AllFormChild
{
	partial class QuanLyLuuTru
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.txtKTx = new System.Windows.Forms.Label();
            this.cbKhu = new System.Windows.Forms.ComboBox();
            this.btChon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTang = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(650, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý lưu trú";
            // 
            // txtKTx
            // 
            this.txtKTx.AutoSize = true;
            this.txtKTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKTx.Location = new System.Drawing.Point(71, 142);
            this.txtKTx.Name = "txtKTx";
            this.txtKTx.Size = new System.Drawing.Size(48, 25);
            this.txtKTx.TabIndex = 1;
            this.txtKTx.Text = "Khu";
            // 
            // cbKhu
            // 
            this.cbKhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhu.FormattingEnabled = true;
            this.cbKhu.Location = new System.Drawing.Point(185, 139);
            this.cbKhu.Name = "cbKhu";
            this.cbKhu.Size = new System.Drawing.Size(146, 33);
            this.cbKhu.TabIndex = 2;
            this.cbKhu.SelectedIndexChanged += new System.EventHandler(this.cbKhu_SelectedIndexChanged);
            // 
            // btChon
            // 
            this.btChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChon.Location = new System.Drawing.Point(1005, 132);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(164, 48);
            this.btChon.TabIndex = 3;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tầng";
            // 
            // cbTang
            // 
            this.cbTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTang.FormattingEnabled = true;
            this.cbTang.Location = new System.Drawing.Point(521, 139);
            this.cbTang.Name = "cbTang";
            this.cbTang.Size = new System.Drawing.Size(121, 33);
            this.cbTang.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 194);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1469, 624);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(738, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tải lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuanLyLuuTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cbTang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btChon);
            this.Controls.Add(this.cbKhu);
            this.Controls.Add(this.txtKTx);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyLuuTru";
            this.Size = new System.Drawing.Size(1560, 1014);
            this.Load += new System.EventHandler(this.QuanLyLuuTru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label txtKTx;
		private System.Windows.Forms.ComboBox cbKhu;
		private System.Windows.Forms.Button btChon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbTang;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button button1;
	}
}
