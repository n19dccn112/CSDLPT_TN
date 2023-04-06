
namespace DXApplication1
{
    partial class formDangNhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnGV = new System.Windows.Forms.RadioButton();
            this.rbtnSV = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelTK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.txtTK);
            this.groupBox1.Controls.Add(this.cmbCoSo);
            this.groupBox1.Location = new System.Drawing.Point(137, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnGV);
            this.groupBox2.Controls.Add(this.rbtnSV);
            this.groupBox2.Location = new System.Drawing.Point(156, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 49);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // rbtnGV
            // 
            this.rbtnGV.AutoSize = true;
            this.rbtnGV.Location = new System.Drawing.Point(155, 19);
            this.rbtnGV.Name = "rbtnGV";
            this.rbtnGV.Size = new System.Drawing.Size(100, 24);
            this.rbtnGV.TabIndex = 1;
            this.rbtnGV.TabStop = true;
            this.rbtnGV.Text = "Giáo viên";
            this.rbtnGV.UseVisualStyleBackColor = true;
            this.rbtnGV.CheckedChanged += new System.EventHandler(this.rbtnGV_CheckedChanged);
            // 
            // rbtnSV
            // 
            this.rbtnSV.AutoSize = true;
            this.rbtnSV.Location = new System.Drawing.Point(29, 19);
            this.rbtnSV.Name = "rbtnSV";
            this.rbtnSV.Size = new System.Drawing.Size(102, 24);
            this.rbtnSV.TabIndex = 0;
            this.rbtnSV.TabStop = true;
            this.rbtnSV.Text = "Sinh Viên";
            this.rbtnSV.UseVisualStyleBackColor = true;
            this.rbtnSV.CheckedChanged += new System.EventHandler(this.rbtnSV_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Location = new System.Drawing.Point(61, 98);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(78, 20);
            this.labelTK.TabIndex = 4;
            this.labelTK.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cơ sở";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(169, 155);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(274, 26);
            this.txtMK.TabIndex = 2;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(169, 98);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(274, 26);
            this.txtTK.TabIndex = 1;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(169, 42);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(274, 28);
            this.cmbCoSo.TabIndex = 0;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(254, 344);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(113, 38);
            this.btnDangNhap.TabIndex = 1;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(432, 344);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 38);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // formDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.groupBox1);
            this.Name = "formDangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.formDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnGV;
        private System.Windows.Forms.RadioButton rbtnSV;
    }
}