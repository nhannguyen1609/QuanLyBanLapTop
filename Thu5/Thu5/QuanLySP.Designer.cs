﻿namespace Thu5
{
    partial class QuanLySP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_xinchao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.cbb_hang = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(84, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 40);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(32, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHÀO MỪNG ĐẾN VỚI HỆ THỐNG QUẢN LÝ BÁN LAPTOP";
            // 
            // lb_xinchao
            // 
            this.lb_xinchao.AutoSize = true;
            this.lb_xinchao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xinchao.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_xinchao.Location = new System.Drawing.Point(655, 55);
            this.lb_xinchao.Name = "lb_xinchao";
            this.lb_xinchao.Size = new System.Drawing.Size(111, 16);
            this.lb_xinchao.TabIndex = 29;
            this.lb_xinchao.Text = "Xin chào quản lý !";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 391);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_edit);
            this.panel2.Controls.Add(this.bt_add);
            this.panel2.Controls.Add(this.bt_delete);
            this.panel2.Location = new System.Drawing.Point(645, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 38);
            this.panel2.TabIndex = 13;
            // 
            // bt_edit
            // 
            this.bt_edit.BackgroundImage = global::Thu5.Properties.Resources.if_081_Pen_183209;
            this.bt_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_edit.Location = new System.Drawing.Point(6, 6);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(28, 26);
            this.bt_edit.TabIndex = 15;
            this.bt_edit.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            this.bt_add.BackgroundImage = global::Thu5.Properties.Resources.if_list_add_118777;
            this.bt_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_add.Location = new System.Drawing.Point(40, 6);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(27, 26);
            this.bt_add.TabIndex = 14;
            this.bt_add.UseVisualStyleBackColor = true;
            // 
            // bt_delete
            // 
            this.bt_delete.BackgroundImage = global::Thu5.Properties.Resources.if_basket_1814090;
            this.bt_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_delete.Location = new System.Drawing.Point(73, 6);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(30, 26);
            this.bt_delete.TabIndex = 13;
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_timkiem);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.cbb_hang);
            this.panel3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Location = new System.Drawing.Point(6, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 38);
            this.panel3.TabIndex = 29;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_timkiem.Location = new System.Drawing.Point(3, 8);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(220, 20);
            this.txt_timkiem.TabIndex = 27;
            this.txt_timkiem.Text = "Nhập tên sản phẩm cần tìm kiếm";
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Thu5.Properties.Resources.if_system_search_118797;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(356, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 26);
            this.button5.TabIndex = 26;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // cbb_hang
            // 
            this.cbb_hang.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbb_hang.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbb_hang.FormattingEnabled = true;
            this.cbb_hang.Items.AddRange(new object[] {
            "Asus",
            "Dell",
            "HP"});
            this.cbb_hang.Location = new System.Drawing.Point(229, 7);
            this.cbb_hang.Name = "cbb_hang";
            this.cbb_hang.Size = new System.Drawing.Size(121, 21);
            this.cbb_hang.TabIndex = 25;
            this.cbb_hang.Text = "Hãng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(9, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 323);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.Hang,
            this.DonGia,
            this.SoLuong,
            this.NgayNhap,
            this.MoTa});
            this.dataGridView1.Location = new System.Drawing.Point(12, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 75;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 125;
            // 
            // Hang
            // 
            this.Hang.HeaderText = "Hãng";
            this.Hang.Name = "Hang";
            this.Hang.Width = 75;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 75;
            // 
            // NgayNhap
            // 
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // MoTa
            // 
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 200;
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(12, 471);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 33);
            this.bt_thoat.TabIndex = 31;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            // 
            // QuanLySP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 516);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.lb_xinchao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLySP";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.QuanLySP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_xinchao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbb_hang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
    }
}