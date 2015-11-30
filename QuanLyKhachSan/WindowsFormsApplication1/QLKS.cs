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
    public partial class QLKS : Form
    {
        public QLKS()
        {
            InitializeComponent();
            //Load từ csdl vào 2 datagridview, thêm 1 cột là button đê click vào sửa hàng tương ứng trên csdl
        }

        private void ok_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLP_radioSP_CheckedChanged(object sender, EventArgs e)
        {
            QLP_TP_boxID.Enabled = !QLP_TP_boxID.Enabled;
        }

        private void QLP_radioTGthue_CheckedChanged(object sender, EventArgs e)
        {
            QLP_TP_boxID.Enabled = !QLP_TP_boxID.Enabled;
        }

        private void QLP_TP_butOK_Click(object sender, EventArgs e)
        {
            //Trả kq ra bảng theo loại tìm kiếm đã chọn
            if (QLP_radioSP.Checked)
            {
            }
            else
                if (QLP_radioTGthue.Checked)
                {
                }
                else
                {
                    MessageBox.Show("Chưa chọn và điền đủ thông tin!");
                    return;
                }
        }

        private void QLKH_Tim_radioID_CheckedChanged(object sender, EventArgs e)
        {
            QLKH_Tim_boxID.Enabled = true;
        }

        private void QLKH_Tim_radioTen_CheckedChanged(object sender, EventArgs e)
        {
            QLKH_Tim_boxTen.Enabled = !QLKH_Tim_boxTen.Enabled;
        }

        private void QLKH_Tim_radioTG_CheckedChanged(object sender, EventArgs e)
        {
            QLKH_Tim_pan.Enabled = !QLKH_Tim_pan.Enabled;
        }

        private void QLKH_Tim_butOK_Click(object sender, EventArgs e)
        {
            //Tìm theo loại đã chọn, đổ vào csdl
            if (QLKH_Tim_radioID.Checked)
            {
            }
            if (QLKH_Tim_radioTen.Checked)
            {
            }
            if (QLKH_Tim_radioTG.Checked)
            {
            }
            
        }

        private void QLDP_butThemDP_Click(object sender, EventArgs e)
        {
            DPform formDP = new DPform();
            formDP.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HuongDan formHD = new HuongDan();
            formHD.ShowDialog();
        }

    }
}
