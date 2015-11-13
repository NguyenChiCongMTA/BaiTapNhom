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
    public partial class QL_Form : Form
    {
        public QL_Form()
        {
            InitializeComponent();
        }

        private void tab_QLN_Click(object sender, EventArgs e)
        {
            //Load các loại hàng vào list Loại hàng
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string loaihang = QLN_listLoai.Items.
            //Cap nhat vao csdl
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cập nhật csdl với thông tin xuất hàng ở các box bên phải

        }

        private void QLX_linkTim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //tim trong csdl hàng có id tương ứng, đổ vảo các box
        }

        private void linkHD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //show form chứa html hướng dẫn lên
        }
    }
}
