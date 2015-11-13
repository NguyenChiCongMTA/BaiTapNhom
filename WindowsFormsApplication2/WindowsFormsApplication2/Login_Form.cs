using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_but_ok_Click(object sender, EventArgs e)
        {
            //Kiểm tra csdl để đăng nhập
            //đăng nhập ok:
            QL_Form qlfomr = new QL_Form();
            qlfomr.Show();
            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //show form html hướng dẫn lên
        }
    }
}
