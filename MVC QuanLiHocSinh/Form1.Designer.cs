namespace MVC_QuanLiHocSinh
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
            this.GrBox_hs_info = new System.Windows.Forms.GroupBox();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtx_dienthoai = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.tbl_HS = new System.Windows.Forms.ListView();
            this.Grid_tblHS = new System.Windows.Forms.DataGridView();
            this.GrBox_hs_info.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_tblHS)).BeginInit();
            this.SuspendLayout();
            // 
            // GrBox_hs_info
            // 
            this.GrBox_hs_info.Controls.Add(this.cb_lop);
            this.GrBox_hs_info.Controls.Add(this.date_ngaysinh);
            this.GrBox_hs_info.Controls.Add(this.txtx_dienthoai);
            this.GrBox_hs_info.Controls.Add(this.txt_diachi);
            this.GrBox_hs_info.Controls.Add(this.txt_hoten);
            this.GrBox_hs_info.Controls.Add(this.label5);
            this.GrBox_hs_info.Controls.Add(this.label4);
            this.GrBox_hs_info.Controls.Add(this.label3);
            this.GrBox_hs_info.Controls.Add(this.label2);
            this.GrBox_hs_info.Controls.Add(this.label1);
            this.GrBox_hs_info.Location = new System.Drawing.Point(47, 23);
            this.GrBox_hs_info.Name = "GrBox_hs_info";
            this.GrBox_hs_info.Size = new System.Drawing.Size(641, 158);
            this.GrBox_hs_info.TabIndex = 0;
            this.GrBox_hs_info.TabStop = false;
            this.GrBox_hs_info.Text = "Thông Tinh Học Sinh";
            // 
            // cb_lop
            // 
            this.cb_lop.DisplayMember = "41,42,43,44,45";
            this.cb_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(514, 81);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(71, 21);
            this.cb_lop.TabIndex = 11;
            this.cb_lop.ValueMember = "41,42,43,44,45";
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaysinh.Location = new System.Drawing.Point(115, 120);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.Size = new System.Drawing.Size(102, 20);
            this.date_ngaysinh.TabIndex = 10;
            // 
            // txtx_dienthoai
            // 
            this.txtx_dienthoai.Location = new System.Drawing.Point(514, 40);
            this.txtx_dienthoai.Name = "txtx_dienthoai";
            this.txtx_dienthoai.Size = new System.Drawing.Size(115, 20);
            this.txtx_dienthoai.TabIndex = 9;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(115, 82);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(284, 20);
            this.txt_diachi.TabIndex = 8;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(115, 39);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(203, 20);
            this.txt_hoten.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa Chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Và Tên";
            // 
            // bt_them
            // 
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.ImageIndex = 3;
            this.bt_them.Location = new System.Drawing.Point(158, 14);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(86, 27);
            this.bt_them.TabIndex = 1;
            this.bt_them.Text = "ADD";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(289, 14);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(86, 27);
            this.bt_sua.TabIndex = 2;
            this.bt_sua.Text = "UPDATE";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(543, 14);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(86, 27);
            this.bt_thoat.TabIndex = 3;
            this.bt_thoat.Text = "EXIT";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Controls.Add(this.bt_thoat);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Location = new System.Drawing.Point(47, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 51);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(415, 14);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(86, 27);
            this.bt_xoa.TabIndex = 4;
            this.bt_xoa.Text = "DELETE";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // tbl_HS
            // 
            this.tbl_HS.FullRowSelect = true;
            this.tbl_HS.GridLines = true;
            this.tbl_HS.Location = new System.Drawing.Point(47, 249);
            this.tbl_HS.Name = "tbl_HS";
            this.tbl_HS.Size = new System.Drawing.Size(641, 124);
            this.tbl_HS.TabIndex = 5;
            this.tbl_HS.UseCompatibleStateImageBehavior = false;
            // 
            // Grid_tblHS
            // 
            this.Grid_tblHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_tblHS.Location = new System.Drawing.Point(47, 379);
            this.Grid_tblHS.Name = "Grid_tblHS";
            this.Grid_tblHS.ReadOnly = true;
            this.Grid_tblHS.Size = new System.Drawing.Size(641, 147);
            this.Grid_tblHS.TabIndex = 6;
            this.Grid_tblHS.SelectionChanged += new System.EventHandler(this.HocSinhInfor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 538);
            this.Controls.Add(this.Grid_tblHS);
            this.Controls.Add(this.tbl_HS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrBox_hs_info);
            this.Name = "Form1";
            this.Text = "Học Sinh Infor";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrBox_hs_info.ResumeLayout(false);
            this.GrBox_hs_info.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_tblHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrBox_hs_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtx_dienthoai;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.ListView tbl_HS;
        private System.Windows.Forms.DataGridView Grid_tblHS;
    }
}

