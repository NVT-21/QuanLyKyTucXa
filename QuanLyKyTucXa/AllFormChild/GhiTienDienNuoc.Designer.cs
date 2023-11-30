namespace QuanLyKyTucXa.AllFormChild
{
	partial class GhiTienDienNuoc
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
            this.lbDN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridP = new System.Windows.Forms.DataGridView();
            this.SoDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btL = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKhu = new System.Windows.Forms.ComboBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dGEdit = new System.Windows.Forms.DataGridView();
            this.btedit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDN
            // 
            this.lbDN.AutoSize = true;
            this.lbDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDN.ForeColor = System.Drawing.Color.Red;
            this.lbDN.Location = new System.Drawing.Point(723, 42);
            this.lbDN.Name = "lbDN";
            this.lbDN.Size = new System.Drawing.Size(228, 29);
            this.lbDN.TabIndex = 0;
            this.lbDN.Text = "Ghi Số Điện Nước ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tháng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm ";
            // 
            // dataGridP
            // 
            this.dataGridP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoDien,
            this.SoNuoc});
            this.dataGridP.Location = new System.Drawing.Point(138, 310);
            this.dataGridP.Name = "dataGridP";
            this.dataGridP.RowHeadersWidth = 51;
            this.dataGridP.RowTemplate.Height = 24;
            this.dataGridP.Size = new System.Drawing.Size(1318, 373);
            this.dataGridP.TabIndex = 3;
            this.dataGridP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridP_CellContentClick);
            // 
            // SoDien
            // 
            this.SoDien.HeaderText = "SoDien";
            this.SoDien.MinimumWidth = 6;
            this.SoDien.Name = "SoDien";
            this.SoDien.Width = 125;
            // 
            // SoNuoc
            // 
            this.SoNuoc.HeaderText = "SoNuoc";
            this.SoNuoc.MinimumWidth = 6;
            this.SoNuoc.Name = "SoNuoc";
            this.SoNuoc.Width = 125;
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(551, 136);
            this.txtNam.Name = "txtNam";
            this.txtNam.ReadOnly = true;
            this.txtNam.Size = new System.Drawing.Size(121, 30);
            this.txtNam.TabIndex = 5;
            // 
            // btL
            // 
            this.btL.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btL.IconColor = System.Drawing.Color.Black;
            this.btL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btL.Location = new System.Drawing.Point(1317, 724);
            this.btL.Name = "btL";
            this.btL.Size = new System.Drawing.Size(139, 35);
            this.btL.TabIndex = 6;
            this.btL.Text = "Lưu";
            this.btL.UseVisualStyleBackColor = true;
            this.btL.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khu";
            // 
            // cbKhu
            // 
            this.cbKhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhu.FormattingEnabled = true;
            this.cbKhu.Location = new System.Drawing.Point(232, 215);
            this.cbKhu.Name = "cbKhu";
            this.cbKhu.Size = new System.Drawing.Size(165, 33);
            this.cbKhu.TabIndex = 8;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ChargingStation;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(464, 214);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(191, 39);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.Text = "Tạo mới ";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // cbThang
            // 
            this.cbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(232, 133);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 33);
            this.cbThang.TabIndex = 10;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(728, 214);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(205, 39);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "Sửa ";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // dGEdit
            // 
            this.dGEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGEdit.Location = new System.Drawing.Point(138, 310);
            this.dGEdit.Name = "dGEdit";
            this.dGEdit.RowHeadersWidth = 51;
            this.dGEdit.RowTemplate.Height = 24;
            this.dGEdit.Size = new System.Drawing.Size(1318, 373);
            this.dGEdit.TabIndex = 12;
            // 
            // btedit
            // 
            this.btedit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btedit.IconColor = System.Drawing.Color.Black;
            this.btedit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btedit.Location = new System.Drawing.Point(1317, 724);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(139, 35);
            this.btedit.TabIndex = 13;
            this.btedit.Text = "Lưu";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // GhiTienDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.dGEdit);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.cbKhu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btL);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.dataGridP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDN);
            this.Name = "GhiTienDienNuoc";
            this.Size = new System.Drawing.Size(1497, 903);
            this.Load += new System.EventHandler(this.GhiTienDienNuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbDN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridP;
		private System.Windows.Forms.TextBox txtNam;
		private FontAwesome.Sharp.IconButton btL;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbKhu;
		private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.ComboBox cbThang;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNuoc;
        private System.Windows.Forms.DataGridView dGEdit;
        private FontAwesome.Sharp.IconButton btedit;
    }
}
