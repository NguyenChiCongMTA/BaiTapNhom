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
    public partial class DPform : Form
    {
        public DPform()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DP_butOK_Click(object sender, EventArgs e)
        {
            DP_panPT.Enabled = true;
            //truy van csdl tim phong trong thoi gian dat
            //Mỗi hàng kết quả tìm được có 1 cột thuộc kiểu checked box
           

        }

        private void DP_butXN_Click(object sender, EventArgs e)
        {
            
            // //phòng nào đặt thì check hàng tương ứng , cập nhật những phòng được check vào csdl
            this.Close();
        }
    }
}
