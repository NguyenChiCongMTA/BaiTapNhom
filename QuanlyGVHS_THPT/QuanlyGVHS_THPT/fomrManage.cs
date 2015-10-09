using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyGVHS_THPT
{
    public partial class fomrManage : Form
    {
        public fomrManage()
        {
            InitializeComponent();
        }

        private void but_Them_Click(object sender, EventArgs e)
        {
            //goi classThem
            //
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            //goi classTim.timtheoid
            //neu tim duoc:
            //goi classxoatheoid
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //goi classTim.timtheoID
            //neu tim duoc update thong tin ...
        }

        private void butSuaGV_Click(object sender, EventArgs e)
        {
            //goi classTim.timGV...
            //tim duoc update thong tin..
           // classTim.TimTheoID(
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ///goi classThem.themGV
            classThem.them_GV(new classGV(themgv_boxName.Text,themgv_dt.Value,themgv_boxDC.Text,themgv_boxSDT.Text,themgv_boxChmon.Text));

        }

        private void gvTim_but_Click(object sender, EventArgs e)
        {
            classGV gv = classTim.TimGVTheoID(suagv_boxID.Text);
            //..đưa dữ liệu vào các box
        }

        private void butSuaGV_Click_1(object sender, EventArgs e)
        {
            classGV new_gv = new classGV(suagv_boxHoten.Text, suagv_dt.Value, suagv_boxDC.Text, suagv_boxSDT.Text, suagv_boxChmon.Text);
            //classThem.them_GV(new_gv); thông báo sửa thành công hay không.
        }

        private void gvxoa_okBut_Click(object sender, EventArgs e)
        {
            classGV gv = classTim.TimGVTheoID(xoagv_boxID.Text) ;
            //đưa dữ liệu vào các box.

        }

        private void button2_Click(object sender, EventArgs e)//xóa gv
        {
            //classGV gv = classTim.TimGVTheoID(xoagv_boxID.Text);
            classXoa.XoaGV(xoagv_boxID.Text);
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /// hiển thị bảng hướng dẫn
        }
    }
}
