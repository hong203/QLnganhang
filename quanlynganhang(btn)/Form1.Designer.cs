namespace quanlynganhang_btn_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btntaotaikhoan = new Button();
            btnguitien = new Button();
            btnchuyenkhoan = new Button();
            btnruttien = new Button();
            btnktsodu = new Button();
            label1 = new Label();
            btnxoataikhoan = new Button();
            SuspendLayout();
            // 
            // btntaotaikhoan
            // 
            btntaotaikhoan.Location = new Point(306, 168);
            btntaotaikhoan.Margin = new Padding(4, 4, 4, 4);
            btntaotaikhoan.Name = "btntaotaikhoan";
            btntaotaikhoan.Size = new Size(154, 58);
            btntaotaikhoan.TabIndex = 0;
            btntaotaikhoan.Text = "Tạo tài khoản";
            btntaotaikhoan.UseVisualStyleBackColor = true;
            btntaotaikhoan.Click += btntaotaikhoan_Click;
            // 
            // btnguitien
            // 
            btnguitien.Location = new Point(306, 259);
            btnguitien.Margin = new Padding(4, 4, 4, 4);
            btnguitien.Name = "btnguitien";
            btnguitien.Size = new Size(154, 55);
            btnguitien.TabIndex = 0;
            btnguitien.Text = "Gửi tiền";
            btnguitien.UseVisualStyleBackColor = true;
            btnguitien.Click += btnguitien_Click;
            // 
            // btnchuyenkhoan
            // 
            btnchuyenkhoan.Location = new Point(306, 356);
            btnchuyenkhoan.Margin = new Padding(4, 4, 4, 4);
            btnchuyenkhoan.Name = "btnchuyenkhoan";
            btnchuyenkhoan.Size = new Size(154, 56);
            btnchuyenkhoan.TabIndex = 0;
            btnchuyenkhoan.Text = "Chuyển khoản";
            btnchuyenkhoan.UseVisualStyleBackColor = true;
            btnchuyenkhoan.Click += frmChuyentien_Click;
            // 
            // btnruttien
            // 
            btnruttien.Location = new Point(585, 168);
            btnruttien.Margin = new Padding(4, 4, 4, 4);
            btnruttien.Name = "btnruttien";
            btnruttien.Size = new Size(149, 58);
            btnruttien.TabIndex = 0;
            btnruttien.Text = "Rút tiền";
            btnruttien.UseVisualStyleBackColor = true;
            btnruttien.Click += btnruttien_Click;
            // 
            // btnktsodu
            // 
            btnktsodu.Location = new Point(585, 259);
            btnktsodu.Margin = new Padding(4, 4, 4, 4);
            btnktsodu.Name = "btnktsodu";
            btnktsodu.Size = new Size(149, 55);
            btnktsodu.TabIndex = 0;
            btnktsodu.Text = "Kiểm tra số dư";
            btnktsodu.UseVisualStyleBackColor = true;
            btnktsodu.Click += btnktsodu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(320, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(386, 49);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ NGÂN HÀNG";
            // 
            // btnxoataikhoan
            // 
            btnxoataikhoan.Location = new Point(585, 356);
            btnxoataikhoan.Margin = new Padding(4, 4, 4, 4);
            btnxoataikhoan.Name = "btnxoataikhoan";
            btnxoataikhoan.Size = new Size(149, 56);
            btnxoataikhoan.TabIndex = 2;
            btnxoataikhoan.Text = "Xóa tài khoản";
            btnxoataikhoan.UseVisualStyleBackColor = true;
            btnxoataikhoan.Click += btnxoataikhoan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnxoataikhoan);
            Controls.Add(label1);
            Controls.Add(btnktsodu);
            Controls.Add(btnruttien);
            Controls.Add(btnchuyenkhoan);
            Controls.Add(btnguitien);
            Controls.Add(btntaotaikhoan);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Hệ thống quản lý ngân hàng";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btntaotaikhoan;
        private Button btnguitien;
        private Button btnchuyenkhoan;
        private Button btnruttien;
        private Button btnktsodu;
        private Label label1;
        private Button btnxoataikhoan;
    }
}