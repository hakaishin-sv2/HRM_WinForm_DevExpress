using BusinessLayer;
using BusinessLayer.LogIn;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.LogIn
{
    public partial class formLogIn : DevExpress.XtraEditors.XtraForm
    {
        public formLogIn()
        {
            InitializeComponent();
        }
        User _us;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int manv = int.Parse( textBoxMaNV.Text);
            string password = textBoxPasswoed.Text;

            if(textBoxMaNV.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã nhân viên! ","Hướng dẫn",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(password == "")
            {
                MessageBox.Show("Bạn cần nhập password! ", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string hashpassword = PasswordHelper.HashPassword(password);
                _us = new User();
                var user_login = _us.getItemByManv(manv);
                if(user_login.MANV_LOGIN == manv && user_login.PASSWORD == password)
                {
                   int role = int.Parse(user_login.ROLE.ToString());
                    Session.User = new User(manv, password, role);
                    this.Hide();
                    //MessageBox.Show("Login Thành công", "Hướng dẫn", MessageBoxButtons.OK);
                    MainForm frmMain = new MainForm();
                    frmMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}