namespace QuanLyKyTucXa.AllFormChild
{
	partial class PheDuyetHoSo
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
			this.dataGridPD = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridPD)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(763, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hồ sơ sinh viên ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dataGridPD
			// 
			this.dataGridPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridPD.Location = new System.Drawing.Point(40, 168);
			this.dataGridPD.Name = "dataGridPD";
			this.dataGridPD.RowHeadersWidth = 51;
			this.dataGridPD.RowTemplate.Height = 24;
			this.dataGridPD.Size = new System.Drawing.Size(1503, 331);
			this.dataGridPD.TabIndex = 1;
			this.dataGridPD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPD_CellClick);
			this.dataGridPD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridPD.SelectionChanged += new System.EventHandler(this.dataGridPD_SelectionChanged);
			// 
			// PheDuyetHoSo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridPD);
			this.Controls.Add(this.label1);
			this.Name = "PheDuyetHoSo";
			this.Size = new System.Drawing.Size(1576, 731);
			this.Load += new System.EventHandler(this.ThaoTacHoSo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridPD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridPD;
	}
}
