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
    public partial class FrmHomework1 : Form
    {
        public FrmHomework1()
        {
            InitializeComponent();
        }

        private void ShowMonthCalendar(int month)
        {
            MonthCalendar monthCalendar = new MonthCalendar();
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            monthCalendar.ShowToday = false;
            monthCalendar.ShowTodayCircle = false;

            Form calendarForm = new Form();
            calendarForm.Text = "เดือน" + month;
            calendarForm.Controls.Add(monthCalendar);
            calendarForm.StartPosition = FormStartPosition.CenterScreen;
            calendarForm.ClientSize = new Size(monthCalendar.Width, monthCalendar.Height);
            calendarForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            calendarForm.MaximizeBox = false;
            calendarForm.MinimizeBox = false;
            calendarForm.ControlBox = true;
            calendarForm.ShowDialog();
        }

        private void btMonth1_Click(object sender, EventArgs e)
        {
            ShowMonthCalendar(1);
        }

        private void btMonth2_Click(object sender, EventArgs e)
        {
            ShowMonthCalendar(2);
        }

        private void btMonth3_Click(object sender, EventArgs e)
        {
            ShowMonthCalendar(3);
        }

        private void btMonth4_Click(object sender, EventArgs e)
        {
            ShowMonthCalendar(4);
        }

        private void btMonth5_Click(object sender, EventArgs e)
        {
            ShowMonthCalendar(5);
        }

        private void btMonth6_Click(object sender, EventArgs e)
        {
            ShowMonthCalendar(6);
        }

        private void btMonth7_Click(object sender, EventArgs e)
        {
            ShowMonthCalendar(7);
        }

        private void btMonth8_Click(object sender, EventArgs e)
        {
            ShowMonthCalendar(8);
        }

        private void btMonth9_Click(object sender, EventArgs e)
        {
            ShowMonthCalendar(9);
        }

        private void btMonth10_Click(object sender, EventArgs e)
        {
            ShowMonthCalendar(10);
        }

        private void btMonth11_Click(object sender, EventArgs e)
        {
            ShowMonthCalendar(11);
        }

        private void btMonth12_Click(object sender, EventArgs e)
        {
            ShowMonthCalendar(12);
        }

        private void FrmHomework1_Load(object sender, EventArgs e)
        {

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
    }
}
