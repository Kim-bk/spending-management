﻿
namespace QuanLyChiTieu
{
    partial class frmNhapChiTieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapChiTieu));
            this.pnlNhapChiTieu = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtepickerNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbDanhMuc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.grvLichSu = new System.Windows.Forms.DataGridView();
            this.pnlNhapChiTieu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNhapChiTieu
            // 
            this.pnlNhapChiTieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlNhapChiTieu.Controls.Add(this.cbbDanhMuc);
            this.pnlNhapChiTieu.Controls.Add(this.label5);
            this.pnlNhapChiTieu.Controls.Add(this.btnThem);
            this.pnlNhapChiTieu.Controls.Add(this.txtChi);
            this.pnlNhapChiTieu.Controls.Add(this.label4);
            this.pnlNhapChiTieu.Controls.Add(this.txtDienGiai);
            this.pnlNhapChiTieu.Controls.Add(this.label3);
            this.pnlNhapChiTieu.Controls.Add(this.label2);
            this.pnlNhapChiTieu.Controls.Add(this.dtepickerNgayNhap);
            this.pnlNhapChiTieu.Controls.Add(this.label1);
            this.pnlNhapChiTieu.Location = new System.Drawing.Point(21, 39);
            this.pnlNhapChiTieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlNhapChiTieu.Name = "pnlNhapChiTieu";
            this.pnlNhapChiTieu.Size = new System.Drawing.Size(796, 860);
            this.pnlNhapChiTieu.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(227, 539);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 50);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtChi
            // 
            this.txtChi.Location = new System.Drawing.Point(227, 422);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(420, 26);
            this.txtChi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(35, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chi:";
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Location = new System.Drawing.Point(227, 343);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(420, 26);
            this.txtDienGiai.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(35, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Diễn giải: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày nhập:";
            // 
            // dtepickerNgayNhap
            // 
            this.dtepickerNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtepickerNgayNhap.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dtepickerNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtepickerNgayNhap.Location = new System.Drawing.Point(227, 195);
            this.dtepickerNgayNhap.Name = "dtepickerNgayNhap";
            this.dtepickerNgayNhap.Size = new System.Drawing.Size(420, 40);
            this.dtepickerNgayNhap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(146, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP CHI TIÊU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(35, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Danh mục:";
            // 
            // cbbDanhMuc
            // 
            this.cbbDanhMuc.FormattingEnabled = true;
            this.cbbDanhMuc.Location = new System.Drawing.Point(227, 276);
            this.cbbDanhMuc.Name = "cbbDanhMuc";
            this.cbbDanhMuc.Size = new System.Drawing.Size(420, 28);
            this.cbbDanhMuc.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.grvLichSu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(1083, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 860);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(293, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 63);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lịch sử";
            // 
            // grvLichSu
            // 
            this.grvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.grvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLichSu.Location = new System.Drawing.Point(27, 195);
            this.grvLichSu.Name = "grvLichSu";
            this.grvLichSu.RowHeadersWidth = 62;
            this.grvLichSu.RowTemplate.Height = 28;
            this.grvLichSu.Size = new System.Drawing.Size(731, 620);
            this.grvLichSu.TabIndex = 11;
            // 
            // frmNhapChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 809);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNhapChiTieu);
            this.Name = "frmNhapChiTieu";
            this.Text = "frmNhapChiTieu";
            this.pnlNhapChiTieu.ResumeLayout(false);
            this.pnlNhapChiTieu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichSu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNhapChiTieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtepickerNgayNhap;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbDanhMuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grvLichSu;
    }
}