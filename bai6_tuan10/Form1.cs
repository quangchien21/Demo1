using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6_tuan10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_ten_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            if (txt_ten.Text == "" || txt_csdl.Text == "" || txt_ctdl.Text == "" || txt_ltw.Text == "" || txt_tdc.Text == "")
            {
                MessageBox.Show("Nhap du lieu sinh vien!");
            }
            else
            {
                double a = Convert.ToDouble(txt_csdl.Text);
                double b = Convert.ToDouble(txt_ctdl.Text);
                double c = Convert.ToDouble(txt_ltw.Text);
                double d = Convert.ToDouble(txt_tdc.Text);
                double dtb;
                string str = "";
                dtb = Math.Round((( a + b + c + d ) / 4),3);
                if(dtb  < 5 )
                {
                    str = "Yeu";
                }
                else if(5 <= dtb && dtb < 6.5)
                {
                    str = " Khá";
                }
                else if(dtb > 8)
                {
                    str = "Gioi";
                }
                txt_hienthi.Text = txt_ten.ToString();
                txt_hienthi.Text += "\r\n Điểm trung bình: " + dtb.ToString();
                txt_hienthi.Text += "\r\n Xếp loại: " + str;


            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult rt = MessageBox.Show("Bạn có thực sự muốn thoát không?","Thông báo!",MessageBoxButtons.YesNo);
            if(rt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_ten.Text = "";
            txt_csdl.Text = "";
            txt_ctdl.Text = "";
            txt_hienthi.Text = "";
            txt_ltw.Text = "";
            txt_tdc.Text = "";

        }
    }
}
