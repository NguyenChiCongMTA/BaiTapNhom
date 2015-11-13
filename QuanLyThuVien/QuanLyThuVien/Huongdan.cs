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
    public partial class Huongdan : Form
    {
        public Huongdan()
        {
            
            InitializeComponent();
            webBrowser1.Navigate(Application.StartupPath + "\\huongdan.html") ;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
