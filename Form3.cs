using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Form3 : Form
    {
        int days, month, year;
        DateTime date;
        MySqlConnection conn = new MySqlConnection();

        public Form3()
        {
            InitializeComponent();
            //db연결
            conn = new MySqlConnection("Server=localhost;Database=daily;Uid=dailyuser;Pwd=kimyj1547@@;");
        }

        public Form3(string Dates) //폼 연결을위해 생성자 추가
        {
            InitializeComponent();
            this.date = DateTime.Parse(Dates);
            //db연결
            conn = new MySqlConnection("Server=localhost;Database=daily;Uid=dailyuser;Pwd=kimyj1547@@;");
        }

        private void Form3_Form_Load(object sender, EventArgs e)
        {
            cal();
            mem();
            acc();
        }

        //일간 일정을 나타내기 위한 코드
        public void cal()
        {
            conn.Open();
            string sql = "SELECT ID, Month, Day, Content FROM daily.calander limit 5";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if ((string)rdr["Month"] == date.Month.ToString() && (string)rdr["Day"] == date.Day.ToString())
                    listBox1.Items.Add(rdr["Month"] + "월" + rdr["Day"] + "일 " + rdr["Content"]);
            }
            rdr.Close();
            conn.Close();
        }

        //일간 메모를 나타내기 위한 코드
        public void mem()
        {
            conn.Open();
            string Memo = "SELECT Date, Title, Diary, Month, Day FROM daily.memo limit 5";
            MySqlCommand cmd2 = new MySqlCommand(Memo, conn);
            MySqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                if ((string)rdr2["Month"] == date.Month.ToString() && (string)rdr2["Day"] == date.Day.ToString())
                {
                    listBox2.Items.Add(rdr2["Month"] + "월" + rdr2["Day"] + "일 " + "제목 : " + rdr2["Title"]);
                    listBox2.Items.Add(rdr2["Diary"]);
                }
            }
            rdr2.Close();
            conn.Close();
        }

        //일간 가계부를 나타내기 위한 코드
        public void acc()
        {
            conn.Open();
            string Account = "SELECT Contect, Month, Day, Profit, Spending, PureProfit, Type FROM daily.account";
            MySqlCommand cmd3 = new MySqlCommand(Account, conn);
            MySqlDataReader rdr3 = cmd3.ExecuteReader();
            while (rdr3.Read())
            {
                if ((string)rdr3["Month"] == date.Month.ToString() && (string)rdr3["Day"] == date.Day.ToString())
                {
                    if ((string)rdr3["Type"] == "수익")
                    {
                        listBox3.Items.Add(rdr3["Month"] + "월 " + rdr3["Day"] + "일 " + rdr3["Type"]);
                        listBox3.Items.Add(rdr3["Contect"] + " " + rdr3["Profit"] + "원 ");
                    }
                    if ((string)rdr3["Type"] == "지출")
                    {
                        listBox3.Items.Add(rdr3["Month"] + "월 " + rdr3["Day"] + "일 " + rdr3["Type"]);
                        listBox3.Items.Add(rdr3["Contect"] + " " + rdr3["Spending"] + "원 ");
                    }
                    if ((string)rdr3["Type"] == "순수익")
                    {
                        listBox3.Items.Add(rdr3["Month"] + "월 " + rdr3["Day"] + "일 " + rdr3["Type"]);
                        listBox3.Items.Add(rdr3["Contect"] + " " + rdr3["PureProfit"] + "원 ");
                    }
                }
            }
            rdr3.Close();
            conn.Close();
        }
    }
}
