using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft, int nTop, int nRight, int nBottom,
            int nWidthEllipse, int nHeightEllipse
            );

        int days, month, year;
        DateTime date;
        MySqlConnection conn = new MySqlConnection();

        //월간 일정을 나타내기 위한 코드
        public void cal()
        {
            conn.Open();
            string sql = "SELECT ID, Month, Day, Content FROM daily.calander ORDER BY Day";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if ((string)rdr["Month"] == textBox1.Text)
                {
                    Monthly_listBox1.Items.Add(rdr["Month"] + "월 " + rdr["Day"] + "일 " + rdr["Content"]);
                }

            }
            rdr.Close();
            conn.Close();
        }
        //월간 가계부를 나타내기 위한 코드
        public void acc()
        {
            conn.Open();
            string Account = "SELECT Contect, Month, Day, Profit, Spending, PureProfit, Type FROM daily.account";
            MySqlCommand cmd2 = new MySqlCommand(Account, conn);
            MySqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                if ((string)rdr2["Month"] == textBox1.Text)
                {
                    if ((string)rdr2["Type"] == "수익")
                    {
                        Monthly_Acc.Items.Add(rdr2["Month"] + "월 " + rdr2["Day"] + "일 " + rdr2["Type"]);
                        Monthly_Acc.Items.Add(rdr2["Contect"] + " " + rdr2["Profit"] + "원 ");
                    }
                    if ((string)rdr2["Type"] == "지출")
                    {
                        Monthly_Acc.Items.Add(rdr2["Month"] + "월 " + rdr2["Day"] + "일 " + rdr2["Type"]);
                        Monthly_Acc.Items.Add(rdr2["Contect"] + " " + rdr2["Spending"] + "원 ");
                    }
                    if ((string)rdr2["Type"] == "순수익")
                    {
                        Monthly_Acc.Items.Add(rdr2["Month"] + "월 " + rdr2["Day"] + "일 " + rdr2["Type"]);
                        Monthly_Acc.Items.Add(rdr2["Contect"] + " " + rdr2["PureProfit"] + "원 ");
                    }
                }
            }
            rdr2.Close();
            conn.Close();
        }

        public Form2()
        {
            InitializeComponent();
            //db연결
            conn = new MySqlConnection("Server=localhost;Database=daily;Uid=dailyuser;Pwd=kimyj1547@@;");
            cal();
            acc();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Form_Load(object sender, EventArgs e)
        {
            displayDays();

            cal();
            acc();
            Add_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Add_btn.Width, Add_btn.Height, 30, 30));
            Delete_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Delete_btn.Width, Delete_btn.Height, 30, 30));
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            textBox1.Text = month.ToString();

            DateTime startoftheMonth = new DateTime(year, month, 1);

            days = DateTime.DaysInMonth(year, month);

            int dayoftheWeek = Convert.ToInt32(startoftheMonth.DayOfWeek.ToString("d")) + 1;
            string Date = year.ToString() + "년" + month.ToString() + "월";

            for (int i = 1; i < dayoftheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                DayContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(Date);
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();

            month++;

            textBox1.Text = month.ToString();

            DateTime startoftheMonth = new DateTime(year, month, 1);

            days = DateTime.DaysInMonth(year, month);

            int dayoftheWeek = Convert.ToInt32(startoftheMonth.DayOfWeek.ToString("d")) + 1;
            string Date = year.ToString() + "년" + month.ToString() + "월";

            for (int i = 1; i < dayoftheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                DayContainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(Date);
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);
            }
            Monthly_listBox1.Items.Clear();
            Monthly_Acc.Items.Clear();
            cal();
            acc();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();

            month--;

            textBox1.Text = month.ToString();

            DateTime startoftheMonth = new DateTime(year, month, 1);

            days = DateTime.DaysInMonth(year, month);

            int dayoftheWeek = Convert.ToInt32(startoftheMonth.DayOfWeek.ToString("d")) + 1;

            string Date = year.ToString() + "년" + month.ToString() + "월";

            for (int i = 1; i < dayoftheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                DayContainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(Date);
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);
            }
            Monthly_listBox1.Items.Clear();
            Monthly_Acc.Items.Clear();
            cal();
            acc();
        }
    }
}
