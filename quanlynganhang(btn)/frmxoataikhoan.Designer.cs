namespace quanlynganhang_btn_
{
    partial class frmxoataikhoan
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
            groupBox1 = new GroupBox();
            btnkiemtra = new Button();
            txttentaikhoan1 = new TextBox();
            txtsotaikhoan1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btnguitien = new Button();
            txtCCCD = new TextBox();
            txtemail = new TextBox();
            txtsotaikhoan2 = new TextBox();
            txttentaikhoan2 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnxoa = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnkiemtra);
            groupBox1.Controls.Add(txttentaikhoan1);
            groupBox1.Controls.Add(txtsotaikhoan1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(22, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 211);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kiểm tra tài khoản cần xóa";
            // 
            // btnkiemtra
            // 
            btnkiemtra.Location = new Point(175, 156);
            btnkiemtra.Name = "btnkiemtra";
            btnkiemtra.Size = new Size(94, 29);
            btnkiemtra.TabIndex = 2;
            btnkiemtra.Text = "Kiểm tra";
            btnkiemtra.UseVisualStyleBackColor = true;
            btnkiemtra.Click += btnkiemtra_Click;
            // 
            // txttentaikhoan1
            // 
            txttentaikhoan1.Location = new Point(136, 96);
            txttentaikhoan1.Name = "txttentaikhoan1";
            txttentaikhoan1.Size = new Size(185, 27);
            txttentaikhoan1.TabIndex = 1;
            // 
            // txtsotaikhoan1
            // 
            txtsotaikhoan1.Location = new Point(136, 36);
            txtsotaikhoan1.Name = "txtsotaikhoan1";
            txtsotaikhoan1.Size = new Size(185, 27);
            txtsotaikhoan1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 99);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 39);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 0;
            label2.Text = "Số tài khoản";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(430, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(548, 211);
            dataGridView1.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnguitien);
            groupBox3.Controls.Add(txtCCCD);
            groupBox3.Controls.Add(txtemail);
            groupBox3.Controls.Add(txtsotaikhoan2);
            groupBox3.Controls.Add(txttentaikhoan2);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(12, 261);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(370, 263);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm tài khoản";
            // 
            // btnguitien
            // 
            btnguitien.Location = new Point(857, 154);
            btnguitien.Name = "btnguitien";
            btnguitien.Size = new Size(122, 47);
            btnguitien.TabIndex = 3;
            btnguitien.Text = "Gửi tiền";
            btnguitien.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(144, 174);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(177, 27);
            txtCCCD.TabIndex = 1;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(144, 132);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(177, 27);
            txtemail.TabIndex = 1;
            // 
            // txtsotaikhoan2
            // 
            txtsotaikhoan2.Location = new Point(144, 90);
            txtsotaikhoan2.Name = "txtsotaikhoan2";
            txtsotaikhoan2.Size = new Size(177, 27);
            txtsotaikhoan2.TabIndex = 1;
            // 
            // txttentaikhoan2
            // 
            txttentaikhoan2.Location = new Point(144, 49);
            txttentaikhoan2.Name = "txttentaikhoan2";
            txttentaikhoan2.Size = new Size(177, 27);
            txttentaikhoan2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 181);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 0;
            label7.Text = "CCCD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 135);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 0;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 90);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 0;
            label5.Text = "Số tài khoản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 48);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 0;
            label4.Text = "Tên tài khoản";
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(430, 278);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(107, 59);
            btnxoa.TabIndex = 8;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // frmxoataikhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 563);
            Controls.Add(btnxoa);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "frmxoataikhoan";
            Text = "frmxoataikhoan";
            Load += frmxoataikhoan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnkiemtra;
        private TextBox txttentaikhoan1;
        private TextBox txtsotaikhoan1;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button btnguitien;
        private TextBox txtCCCD;
        private TextBox txtemail;
        private TextBox txtsotaikhoan2;
        private TextBox txttentaikhoan2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnxoa;
    }
}