namespace BaiTap
{
    partial class frmQLLop
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
            lvLop = new ListView();
            txtMaLop = new TextBox();
            btnThem = new Button();
            txtTenLop = new TextBox();
            txtSiSo = new TextBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lbnDanhDachLop = new Label();
            lbnThongTinLop = new Label();
            lbnMaLop = new Label();
            btnTenLop = new Label();
            btnSiSo = new Label();
            SuspendLayout();
            // 
            // lvLop
            // 
            lvLop.Location = new Point(12, 60);
            lvLop.Name = "lvLop";
            lvLop.Size = new Size(582, 256);
            lvLop.TabIndex = 0;
            lvLop.UseCompatibleStateImageBehavior = false;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(87, 354);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(250, 23);
            txtMaLop.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(365, 337);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 40);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(87, 388);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(250, 23);
            txtTenLop.TabIndex = 3;
            // 
            // txtSiSo
            // 
            txtSiSo.Location = new Point(87, 417);
            txtSiSo.Name = "txtSiSo";
            txtSiSo.Size = new Size(250, 23);
            txtSiSo.TabIndex = 4;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(475, 336);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 41);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(365, 399);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 41);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(475, 397);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 41);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // lbnDanhDachLop
            // 
            lbnDanhDachLop.AutoSize = true;
            lbnDanhDachLop.Location = new Point(12, 28);
            lbnDanhDachLop.Name = "lbnDanhDachLop";
            lbnDanhDachLop.Size = new Size(82, 15);
            lbnDanhDachLop.TabIndex = 8;
            lbnDanhDachLop.Text = "Danh sách lớp";
            // 
            // lbnThongTinLop
            // 
            lbnThongTinLop.AutoSize = true;
            lbnThongTinLop.Location = new Point(37, 330);
            lbnThongTinLop.Name = "lbnThongTinLop";
            lbnThongTinLop.Size = new Size(79, 15);
            lbnThongTinLop.TabIndex = 9;
            lbnThongTinLop.Text = "Thông tin lớp";
            // 
            // lbnMaLop
            // 
            lbnMaLop.AutoSize = true;
            lbnMaLop.Location = new Point(37, 357);
            lbnMaLop.Name = "lbnMaLop";
            lbnMaLop.Size = new Size(44, 15);
            lbnMaLop.TabIndex = 10;
            lbnMaLop.Text = "Mã lớp";
            // 
            // btnTenLop
            // 
            btnTenLop.AutoSize = true;
            btnTenLop.Location = new Point(35, 391);
            btnTenLop.Name = "btnTenLop";
            btnTenLop.Size = new Size(46, 15);
            btnTenLop.TabIndex = 11;
            btnTenLop.Text = "Tên lớp";
            // 
            // btnSiSo
            // 
            btnSiSo.AutoSize = true;
            btnSiSo.Location = new Point(37, 420);
            btnSiSo.Name = "btnSiSo";
            btnSiSo.Size = new Size(31, 15);
            btnSiSo.TabIndex = 12;
            btnSiSo.Text = "Sỉ số";
            // 
            // frmQLLop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 452);
            Controls.Add(btnSiSo);
            Controls.Add(btnTenLop);
            Controls.Add(lbnMaLop);
            Controls.Add(lbnThongTinLop);
            Controls.Add(lbnDanhDachLop);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(txtSiSo);
            Controls.Add(txtTenLop);
            Controls.Add(btnThem);
            Controls.Add(txtMaLop);
            Controls.Add(lvLop);
            Name = "frmQLLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Lớp";
            Load += frmQLLop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvLop;
        private TextBox txtMaLop;
        private Button btnThem;
        private TextBox txtTenLop;
        private TextBox txtSiSo;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Label lbnDanhDachLop;
        private Label lbnThongTinLop;
        private Label lbnMaLop;
        private Label btnTenLop;
        private Label btnSiSo;
    }
}