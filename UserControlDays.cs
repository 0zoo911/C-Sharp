using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class UserControlDays : UserControl
    {
        string date;
        DateTime now = DateTime.Now;

        public UserControlDays()
        {
            InitializeComponent();
        }

        public UserControlDays(string date)
        {
            InitializeComponent();
            this.date = date;
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numdays)
        {
            Ibdays.Text = numdays + "";
            date += Ibdays.Text +"일";

            if (now.DayOfWeek == DayOfWeek.Sunday)
            {
                Ibdays.ForeColor = Color.Red;
                Ibdays.Text = numdays + "";
                date += Ibdays.Text + "일";
            }

        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(date);
            form3.ShowDialog();        
        }

    }
}
