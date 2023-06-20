using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace YazılımYapımı
{
    public partial class Form3 : Form
    {
        private int month;
        private int year;
        public static int static_year;
        public static int static_month;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);

            lbDate.Text = monthName + " " + year;
            static_month = month;
            static_year = year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayOfWeek = (int)startOfMonth.DayOfWeek + 1;

            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= daysInMonth; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                flowLayoutPanel1.Controls.Add(ucDays);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            month--;
            static_month = month;
            static_year = year;

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
            lbDate.Text = monthName + " " + year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayOfWeek = (int)startOfMonth.DayOfWeek + 1;

            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= daysInMonth; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                flowLayoutPanel1.Controls.Add(ucDays);
            }

            button1.Enabled = lbDate.Text != "Kasım 2023";
            button2.Enabled = lbDate.Text != "Ocak 2023";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            month++;
            static_month = month;
            static_year = year;

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
            lbDate.Text = monthName + " " + year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayOfWeek = (int)startOfMonth.DayOfWeek + 1;

            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= daysInMonth; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                flowLayoutPanel1.Controls.Add(ucDays);
            }

            button1.Enabled = lbDate.Text != "Aralık 2023";
            button2.Enabled = lbDate.Text != "Şubat 2023";
        }
    }
}