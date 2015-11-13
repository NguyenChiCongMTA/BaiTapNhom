using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            //Application.EnableVisualStyles();
           
            //kết nối csdl , kiểm tra user name, pass word
            this.Hide();
            formManage ql = new formManage();
            ql.Show();
        }
    }
}
