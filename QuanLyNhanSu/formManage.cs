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
    public partial class formManage : Form
    {
        public formManage()
        {
            InitializeComponent();
        }

        private void tabTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            classNV nv = new classNV();
            nv.hoten = in_boxName.Text;
            nv.ns = in_boxNS.Value;
            nv.quequan = in_boxQq.Text;
            nv.donvi = in_boxDV.Text;
            nv.hesoluong = int.Parse(in_boxBL.Text);
            nv.socmnd = in_boxCMND.Text;
            nv.sodienthoai = in_BoxDT.Text;
            string mess = connect.insert(nv) ? "Them thanh cong " : "Them that bai";
            //dataGridView1.DataSource = new connect().LoadData();
            MessageBox.Show(mess);
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            
        }

        private void sua_butTim_Click(object sender, EventArgs e)
        {
           
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void in_boxBL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
