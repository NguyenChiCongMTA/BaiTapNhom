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

            int stt = classThem.them(in_boxName.Text, in_boxQq.Text, in_boxNS.Value, in_boxDV.Text, in_boxCV.Text ,in_boxBL.Text);
            if (stt == -1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm lỗi");

        }

        private void butDel_Click(object sender, EventArgs e)
        {
            int stt = classXoa.xoa(xoa_boxID.Text);
            if (stt == -1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm lỗi");

        }

        private void sua_butTim_Click(object sender, EventArgs e)
        {
           int stt =  classSua.sua(sua_boxID.Text);
           if (stt == -1)
               MessageBox.Show("Thêm thành công");
           else
               MessageBox.Show("Thêm lỗi");

        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
