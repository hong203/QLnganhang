namespace quanlynganhang_btn_
{
    partial class frmRutiten
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
            btntimkiem = new Button();
            txttentaikhoan1 = new TextBox();
            txtsotaikhoan1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox3 = new GroupBox();
            txtSoTienDaRut = new NumericUpDown();
            txtsodu = new TextBox();
            txttentaikhoan2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox4 = new GroupBox();
            textSoTienRut = new NumericUpDown();
            btnruttien = new Button();
            label8 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSoTienDaRut).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textSoTienRut).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btntimkiem);
            groupBox1.Controls.Add(txttentaikhoan1);
            groupBox1.Controls.Add(txtsotaikhoan1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(22, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(605, 211);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm tài khoản";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(213, 153);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(155, 42);
            btntimkiem.TabIndex = 2;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // txttentaikhoan1
            // 
            txttentaikhoan1.Location = new Point(213, 96);
            txttentaikhoan1.Name = "txttentaikhoan1";
            txttentaikhoan1.Size = new Size(272, 27);
            txttentaikhoan1.TabIndex = 1;
            // 
            // txtsotaikhoan1
            // 
            txtsotaikhoan1.Location = new Point(213, 32);
            txtsotaikhoan1.Name = "txtsotaikhoan1";
            txtsotaikhoan1.Size = new Size(272, 27);
            txtsotaikhoan1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 96);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 35);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 0;
            label2.Text = "Số tài khoản";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(22, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(605, 221);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách tài khoản";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(570, 189);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(407, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 24);
            label1.TabIndex = 4;
            label1.Text = "Rút tiền trong tài khoản";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSoTienDaRut);
            groupBox3.Controls.Add(txtsodu);
            groupBox3.Controls.Add(txttentaikhoan2);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(650, 272);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(498, 221);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin ghi chú";
            // 
            // txtSoTienDaRut
            // 
            txtSoTienDaRut.Location = new Point(175, 135);
            txtSoTienDaRut.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            txtSoTienDaRut.Name = "txtSoTienDaRut";
            txtSoTienDaRut.Size = new Size(247, 27);
            txtSoTienDaRut.TabIndex = 4;
            // 
            // txtsodu
            // 
            txtsodu.Location = new Point(175, 90);
            txtsodu.Name = "txtsodu";
            txtsodu.Size = new Size(247, 27);
            txtsodu.TabIndex = 1;
            // 
            // txttentaikhoan2
            // 
            txttentaikhoan2.Location = new Point(175, 48);
            txttentaikhoan2.Name = "txttentaikhoan2";
            txttentaikhoan2.Size = new Size(247, 27);
            txttentaikhoan2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 135);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 0;
            label6.Text = "Số tiền đã rút";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 90);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 0;
            label5.Text = "Số dư hiện tại";
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
            // groupBox4
            // 
            groupBox4.Controls.Add(textSoTienRut);
            groupBox4.Controls.Add(btnruttien);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(650, 47);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(498, 211);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rút tiền";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // textSoTienRut
            // 
            textSoTienRut.Location = new Point(186, 39);
            textSoTienRut.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            textSoTienRut.Name = "textSoTienRut";
            textSoTienRut.Size = new Size(150, 27);
            textSoTienRut.TabIndex = 4;
            // 
            // btnruttien
            // 
            btnruttien.Location = new Point(175, 156);
            btnruttien.Name = "btnruttien";
            btnruttien.Size = new Size(150, 37);
            btnruttien.TabIndex = 3;
            btnruttien.Text = "Rút tiền";
            btnruttien.UseVisualStyleBackColor = true;
            btnruttien.Click += btnruttien_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 39);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 2;
            label8.Text = "Số tiền cần rút";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 73);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 0;
            // 
            // frmRutiten
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 518);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmRutiten";
            Text = "frmRutiten";
            Load += frmRutiten_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSoTienDaRut).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textSoTienRut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btntimkiem;
        private TextBox txttentaikhoan1;
        private TextBox txtsotaikhoan1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox txtsodu;
        private TextBox txttentaikhoan2;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox4;
        private Label label7;
        private Label label8;
        private Button btnruttien;
        private NumericUpDown textSoTienRut;
        private NumericUpDown txtSoTienDaRut;
    }
}