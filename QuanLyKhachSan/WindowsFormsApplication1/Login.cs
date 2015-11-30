using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_but_ok_Click(object sender, EventArgs e)
        {
            string user_name = Login_uname_box.Text;
            string pword = Login_pword_box.Text;
            QLKS formQLKS = new QLKS();
            formQLKS.ShowDialog();
            this.Close();
            
            //kiem tra csdl xem co nguoi dung
            
        }
    }
}
