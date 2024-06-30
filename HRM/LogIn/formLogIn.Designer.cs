namespace HRM.LogIn
{
    partial class formLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.textBoxPasswoed = new System.Windows.Forms.TextBox();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "PassWord:";
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaNV.Location = new System.Drawing.Point(399, 93);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(210, 28);
            this.textBoxMaNV.TabIndex = 2;
            // 
            // textBoxPasswoed
            // 
            this.textBoxPasswoed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswoed.Location = new System.Drawing.Point(399, 164);
            this.textBoxPasswoed.Name = "textBoxPasswoed";
            this.textBoxPasswoed.Size = new System.Drawing.Size(210, 28);
            this.textBoxPasswoed.TabIndex = 3;
            this.textBoxPasswoed.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogin.ImageOptions.SvgImage")));
            this.btnLogin.Location = new System.Drawing.Point(281, 249);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(175, 38);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Location = new System.Drawing.Point(504, 249);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 38);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // formLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 436);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxPasswoed);
            this.Controls.Add(this.textBoxMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formLogIn";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.TextBox textBoxPasswoed;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}