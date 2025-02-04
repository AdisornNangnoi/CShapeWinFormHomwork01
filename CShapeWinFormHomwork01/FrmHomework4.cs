using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShapeWinFormHomwork01
{
    public partial class FrmHomework4 : Form
    {
        public FrmHomework4()
        {
            InitializeComponent();
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            FrmHomework1 frmHomework1 = new FrmHomework1();
            frmHomework1.Show();
            Hide();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            FrmHomework2 frmHomework2 = new FrmHomework2();
            frmHomework2.Show();
            Hide();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            FrmHomework3 frmHomework3 = new FrmHomework3();
            frmHomework3.Show();
            Hide();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            FrmHomework4 frmHomework4 = new FrmHomework4();
            frmHomework4.Show();
            Hide();
        }
        //tbAmountPeople
        private void tbAmountPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลข หรือปุ่มควบคุม เช่น Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }
        //btCal
        private void btCal_Click(object sender, EventArgs e)
        {
            //Validate
            if (tbAmountPeople.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนจำนวนคนด้วย");
            }
            else
            {
                int people = Convert.ToInt32(tbAmountPeople.Text.Trim());
                double pricePerPerson = 0;
                double totalPrice = 0;
                double discount = 0;
                double totalPay = 0;
                lbShowPeople.Text = people.ToString();
                if (rdJAVA.Checked)
                {
                    lbShowTopic.Text = "JAVA Developer";
                    pricePerPerson = 1000;
                }
                else if (rdAndroid.Checked)
                {
                    lbShowTopic.Text = "Android Developer";
                    pricePerPerson = 1200;
                }
                else if (rdiOS.Checked)
                {
                    lbShowTopic.Text = "iOS Developer";
                    pricePerPerson = 1400;
                }
                else // rdPHP
                {
                    lbShowTopic.Text = "PHP Developer";
                    pricePerPerson = 1600;
                }

                // คำนวณราคาก่อนหักส่วนลด
                totalPrice = pricePerPerson * people;

                // คำนวณส่วนลด
                if (people >= 2 && people <= 4)
                {
                    discount = totalPrice * 0.05; // ลด 5%
                }
                else if (people >= 5)
                {
                    discount = totalPrice * 0.10; // ลด 10%
                }

                // คำนวณราคาสุทธิ
                totalPay = totalPrice - discount;

                // แสดงผลลัพธ์
                lbShowPay.Text = totalPay.ToString("0.00");
            }
        }
        //btCancel
        private void btCancel_Click(object sender, EventArgs e)
        {
            tbAmountPeople.Clear();
            rdJAVA.Checked = true;
            lbShowTopic.Text = "XXX";
            lbShowPeople.Text = "XXX";
            lbShowPay.Text = "XXX";
        }
        //btClose
        private void btClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรมใช่มั้ย", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lbShowTopic_Click(object sender, EventArgs e)
        {

        }
    }
}
