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
    public partial class formManage : Form
    {
        public formManage()
        {
            
            InitializeComponent();
            qldg_dtBD.CustomFormat = "dd/MM/yyyy";
            qldg_dtBD.Format = DateTimePickerFormat.Custom;
            qldg_dtKT.CustomFormat = "dd/MM/yyyy";
            qldg_dtKT.Format = DateTimePickerFormat.Custom;

                           
        }

        private void qls_radioThem_CheckedChanged(object sender, EventArgs e)
        {
            panel_thongtin.Enabled = true;
            qls_linkTim.Enabled = true;
            qls_boxID.Enabled = false;
            qls_labTT.Enabled = true;
        }

        private void qls_radioSua_CheckedChanged(object sender, EventArgs e)
        {
            panel_thongtin.Enabled = true;
            qls_boxID.Enabled = true; 

        }

        private void qls_radioTim_CheckedChanged(object sender, EventArgs e)
        {
            panel_thongtin.Enabled = true;
            qls_boxTen.Enabled = false;
            qls_boxTG.Enabled = false;
            qls_labTT.Enabled = false;
            qls_boxSl.Enabled = false;
            qls_boxID.Enabled = true;
        }

        private void qls_radioXoa_CheckedChanged(object sender, EventArgs e)
        {
            panel_thongtin.Enabled = true;
            qls_boxID.Enabled = true;
            qls_boxTen.Enabled = false;
            qls_boxTG.Enabled = false;
            qls_labTT.Enabled = false;
            qls_boxSl.Enabled = false;
        }

        private void ok_but_Click(object sender, EventArgs e)
        {
            int stt = 1;
            if (qls_radioThem.Checked) // Nếu chọn thêm sách
            {
                stt = classThem.Them( new classSach(qls_boxTen.Text,qls_boxTG.Text,int.Parse(qls_boxSl.Text)) ) ;
                return;
            }

            if (qls_radioSua.Checked)//chọn sửa sách
            {
                stt = classSua.Sua(new classSach(qls_boxTen.Text, qls_boxTG.Text, int.Parse(qls_boxSl.Text)),qls_boxID.Text );
                
            }

            if (qls_radioTim.Checked) // chọn tìm sách
            {
                qls_labTT.Text = "Chưa xác định";
                classSach sach = classTim.Tim(qls_boxID.Text);
                if (sach != null)
                {
                    qls_boxTen.Text = sach.Ten;
                    qls_boxTG.Text = sach.TacGia;
                    qls_boxSl.Text = sach.sl.ToString();
                    if (sach.sl > 0)
                    {
                        qls_labTT.Text = "Còn sách";
                    }
                    else qls_labTT.Text = "Hết sách";
                }
                else stt = 0;
            }

            if (qls_radioXoa.Checked) // chọn xóa sách
            {
                classSach sach = classTim.Tim(qls_boxID.Text);
                if (sach != null)
                {
                    qls_boxTen.Text = sach.Ten;
                    qls_boxTG.Text = sach.TacGia;
                    qls_boxSl.Text = sach.sl.ToString();
                    if (sach.sl > 0)
                    {
                        qls_labTT.Text = "Còn sách";
                    }
                    else qls_labTT.Text = "Hết sách";
                    //truy vấn csdl để xóa sách 
                }
                else stt = 0;
                
            }
            if (stt == 1)
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Lỗi");
        }

        private void qls_linkTim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            classSach sach = classTim.Tim(qls_boxID.Text);
            if (sach != null)
            {
                qls_boxTen.Text = sach.Ten;
                qls_boxTG.Text = sach.TacGia;
                qls_boxSl.Text = sach.sl.ToString();
                if (sach.sl > 0)
                    qls_labTT.Text = "Còn sách";
                else qls_labTT.Text = "Hết sách";

            }
            else MessageBox.Show("Không tìm thấy");
        }

        public void them_docgia(object sender, EventArgs e)
        {
           // MessageBox.Show("them doc gia");
            classDocGia new_dg = new classDocGia(qldg_boxTen.Text, qldg_dtBD.Value, qldg_dtKT.Value, qldg_boxDV.Text);
            classThem.ThemDocGia(new_dg);
        }
        public void sua_docgia(object sender, EventArgs e)
        {
           
           // MessageBox.Show("sua doc gia");
            classDocGia new_dg = new classDocGia(qldg_boxTen.Text,qldg_dtBD.Value,qldg_dtKT.Value,qldg_boxDV.Text);
            classSua.SuaDocGia(new_dg, qldg_boxID.Text);
        }
        public void tim_docgia(object sender, EventArgs e)
        {
            classDocGia dg = classTim.TimDocGia(qldg_boxID.Text);
            qldg_boxID.Text= dg.id;
            qldg_boxTen.Text = dg.ten;
            qldg_dtBD.Value = dg.tgbd;
            qldg_dtKT.Value = dg.tgkt;
            qldg_boxDV.Text = dg.donvi;
           // MessageBox.Show("tim doc gia");
        }
        public void xoa_docgia(object sender, EventArgs e)
        {
             //xoa truc tiep tren csdl
            //MessageBox.Show("xoa doc gia");
        }
        private void qldg_radioThem_CheckedChanged(object sender, EventArgs e)
        {

            qldg_panel.Enabled = true;
            qldg_boxTen.Enabled = true;
            qldg_boxDV.Enabled = true;
            qldg_dtBD.Enabled = true;
            qldg_dtKT.Enabled = true;
            qldg_boxID.Enabled = false;
            qldg_butOK.Click -= them_docgia;
            qldg_butOK.Click -= xoa_docgia;
            qldg_butOK.Click -= sua_docgia;
            qldg_butOK.Click -= tim_docgia;
            qldg_butOK.Click += them_docgia;
           

            
        }

        private void qldg_radioSua_CheckedChanged(object sender, EventArgs e)
        {
            qldg_panel.Enabled = true;
            qldg_boxTen.Enabled = true;
            qldg_boxDV.Enabled = true;
            qldg_dtBD.Enabled = true;
            qldg_dtKT.Enabled = true;
            qldg_boxID.Enabled = false;
            qldg_butOK.Click -= them_docgia;
            qldg_butOK.Click -= xoa_docgia;
            qldg_butOK.Click -= sua_docgia;
            qldg_butOK.Click -= tim_docgia;
            qldg_butOK.Click += sua_docgia;
        }

        private void qldg_radioTim_CheckedChanged(object sender, EventArgs e)
        {
            qldg_panel.Enabled = true;
            qldg_boxTen.Enabled = false;
            qldg_boxDV.Enabled = false;
            qldg_dtBD.Enabled = false;
            qldg_dtKT.Enabled = false;
            qldg_boxID.Enabled = true;
            qldg_butOK.Click -= them_docgia;
            qldg_butOK.Click -= xoa_docgia;
            qldg_butOK.Click -= sua_docgia;
            qldg_butOK.Click -= tim_docgia;
            qldg_butOK.Click += tim_docgia;
        }

        private void qldg_radioXoa_CheckedChanged(object sender, EventArgs e)
        {
            qldg_panel.Enabled = true;
            qldg_boxTen.Enabled = false;
            qldg_boxDV.Enabled = false;
            qldg_dtBD.Enabled = false;
            qldg_dtKT.Enabled = false;
            qldg_boxID.Enabled = true;
            qldg_butOK.Click -= them_docgia;
            qldg_butOK.Click -= xoa_docgia;
            qldg_butOK.Click -= sua_docgia;
            qldg_butOK.Click -= tim_docgia;
            qldg_butOK.Click += xoa_docgia;
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Huongdan huongdan = new Huongdan();
            huongdan.ShowDialog();
            
        }

        private void tabQLS_Click(object sender, EventArgs e)
        {
            
        }

        private void qlmt_linkDG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            classDocGia docgia = classTim.TimDocGia(qlmt_boxDG.Text);
            if (docgia == null)
            {
                MessageBox.Show("không có độc giả này");
                return;
            }
            qlmt_labTen.Text = docgia.ten;
            qlmt_labDV.Text = docgia.donvi;
            
        }

        private void qlmt_lịnkSach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            classSach sach = classTim.Tim(qlmt_boxIDsach.Text);
            if (sach == null)
            {
                MessageBox.Show("Không tìm thấy sách này");
                return;
            }
            qlmt_labTenSach.Text = sach.Ten;
            qlmt_labTG.Text = sach.TacGia;
        }

        private void qlmt_boxDG_TextChanged(object sender, EventArgs e)
        {
            qlmt_labTen.Text = "";
            qlmt_labTG.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (qlmt_boxIDsach.Text != "" && qlmt_labTenSach.Text != "")
            {
                qlmt_listChon.Items.Add(qlmt_boxIDsach.Text + " ( " + qlmt_labTenSach.Text + " )");
            }
            else
            {
                MessageBox.Show("Không có sách nào được thêm");
                return;
            }
                
        }

        private void qlmt_boxDG_TextChanged_1(object sender, EventArgs e)
        {
            qlmt_labTen.Text = "";
            qlmt_labDV.Text = "";
            qlmt_listChon.Items.Clear();
        }

        private void qlmt_butOK_Click(object sender, EventArgs e)
        {
            if (qlmt_labTen.Text == "")
            {
                MessageBox.Show("Chưa có thông tin độc giả");
                return ;
            }
            if (qlmt_listChon.Items.Count ==0 )
            {
                MessageBox.Show("Chưa có sách nào được chọn");
                return;
            }
            for (int i = 0; i < qlmt_listChon.Items.Count; i++)
            {
                string bookid = "";
                string bookname = qlmt_listChon.Items[i].ToString();
                for (int j = 0; j < bookname.Length; j++)
                    if (bookname[i] == ' ')
                        break;
                    else
                    {
                        bookid += bookname[i];
                    }
                if (QLMT_radio_muon.Checked)
                {//kết nối csdl thêm 1 lượt mượn qlms_boxDG.Text và bookid
                }
                else
                {
                    //ket noi csdl xoa luot muon sach
                }

                    
            }
        }

        

        private void tab_TTMS_Click(object sender, EventArgs e)
        {
            //Đổ dữ liệu thông tin tất cả các lượt mượn ,trả sách vào datagridview, sắp xếp theo thời gian
            // thêm 1 cột trong data grid view chứa button, click vào button thì cập nhật lại thông tin của hàng tương ứng vào csdl
        }

        private void TTMS_linkTim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string id_dg = TTMS_boxID.Text;
            //tìm thông tin tất cả các lượt mượn, trả sách của đg tương ứng đổ vào data
        }



        
    }
}
