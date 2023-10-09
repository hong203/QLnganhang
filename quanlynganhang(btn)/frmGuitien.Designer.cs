namespace quanlynganhang_btn_
{
    partial class frmGuitien
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btntimkiem = new Button();
            txttentaikhoan1 = new TextBox();
            txtsotaikhoan1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btnguitien = new Button();
            label9 = new Label();
            label8 = new Label();
            txtCCCD = new TextBox();
            txtemail = new TextBox();
            txtsotienmuongui = new TextBox();
            txtsotaikhoan2 = new TextBox();
            txtsodutaikhoan = new TextBox();
            txttentaikhoan2 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(386, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 0;
            label1.Text = "Gửi tiền vào tài khoản";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btntimkiem);
            groupBox1.Controls.Add(txttentaikhoan1);
            groupBox1.Controls.Add(txtsotaikhoan1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(23, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 228);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm tài khoản";
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(212, 164);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(109, 44);
            btntimkiem.TabIndex = 2;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
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
            label3.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 39);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 0;
            label2.Text = "Số tài khoản";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(427, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(619, 234);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách tài khoản";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(607, 202);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnguitien);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtCCCD);
            groupBox3.Controls.Add(txtemail);
            groupBox3.Controls.Add(txtsotienmuongui);
            groupBox3.Controls.Add(txtsotaikhoan2);
            groupBox3.Controls.Add(txtsodutaikhoan);
            groupBox3.Controls.Add(txttentaikhoan2);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(23, 292);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1006, 221);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tài khoản";
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(473, 97);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 2;
            label9.Text = "Số tiền muốn gửi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(473, 44);
            label8.Name = "label8";
            label8.Size = new Size(113, 20);
            label8.TabIndex = 2;
            label8.Text = "Số dư tài khoản";
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
            // txtsotienmuongui
            // 
            txtsotienmuongui.Location = new Point(606, 94);
            txtsotienmuongui.Name = "txtsotienmuongui";
            txtsotienmuongui.Size = new Size(176, 27);
            txtsotienmuongui.TabIndex = 1;
            // 
            // txtsotaikhoan2
            // 
            txtsotaikhoan2.Location = new Point(144, 90);
            txtsotaikhoan2.Name = "txtsotaikhoan2";
            txtsotaikhoan2.Size = new Size(177, 27);
            txtsotaikhoan2.TabIndex = 1;
            // 
            // txtsodutaikhoan
            // 
            txtsodutaikhoan.Location = new Point(606, 44);
            txtsodutaikhoan.Name = "txtsodutaikhoan";
            txtsodutaikhoan.Size = new Size(176, 27);
            txtsodutaikhoan.TabIndex = 1;
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
            label7.Location = new Point(39, 177);
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
            // frmGuitien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 556);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmGuitien";
            Text = "frmGuitien";
            Load += frmGuitien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtsotaikhoan1;
        private Label label2;
        private TextBox txttentaikhoan1;
        private Label label3;
        private Button btntimkiem;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private TextBox txtCCCD;
        private TextBox txtemail;
        private TextBox txtsotaikhoan2;
        private TextBox txttentaikhoan2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnguitien;
        private Label label9;
        private Label label8;
        private TextBox txtsotienmuongui;
        private TextBox txtsodutaikhoan;
    }
}