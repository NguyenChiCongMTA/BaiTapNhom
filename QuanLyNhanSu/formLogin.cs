using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void logInBut_Click(object sender, EventArgs e)
        {
            if (connect.CheckUser(uNameBox.Text, pWordBox.Text) )
            {
                this.Hide();
                formManage main = new formManage();
                main.Show();
            }
            else
            {
                MessageBox.Show("Sai tai khoan hoac mat khau");
                
            }

            
        }
    }
}
