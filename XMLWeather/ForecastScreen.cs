using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            day1();
            day2();
            day3();
            day4();
            day5();
            day6();
            day7();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void day1()
        {
            if (Convert.ToInt32(Form1.days[0].condition) >= 200 && Convert.ToInt32(Form1.days[0].condition) <= 300)
            {
                pictureBox1.Image = Properties.Resources._10;

            }
            else if (Convert.ToInt32(Form1.days[0].condition) >= 300 && Convert.ToInt32(Form1.days[0].condition) <= 400)
            {
                pictureBox1.Image = Properties.Resources._05;

            }
            else if (Convert.ToInt32(Form1.days[0].condition) >= 500 && Convert.ToInt32(Form1.days[0].condition) <= 600)
            {
                pictureBox1.Image = Properties.Resources._07;

            }
            else if (Convert.ToInt32(Form1.days[0].condition) >= 600 && Convert.ToInt32(Form1.days[0].condition) <= 700)
            {
                pictureBox1.Image = Properties.Resources._08;

            }
            else if (Convert.ToInt32(Form1.days[0].condition) >= 700 && Convert.ToInt32(Form1.days[0].condition) <= 800)
            {
                pictureBox1.Image = Properties.Resources._09;

            }
            else if (Convert.ToInt32(Form1.days[0].condition) == 800)
            {
                pictureBox1.Image = Properties.Resources._01;

            }
            else if (Convert.ToInt32(Form1.days[0].condition) >= 800 && Convert.ToInt32(Form1.days[0].condition) < 805)
            {
                pictureBox1.Image = Properties.Resources._04;

            }
            else
            {
                pictureBox1.Image = Properties.Resources._01;
            }
            date1.Text = "Monday";
            min1.Text = Form1.days[0].tempLow;
            max1.Text = Form1.days[0].tempHigh;
        }

        private void day2()
        {

            if (Convert.ToInt32(Form1.days[1].condition) >= 200 && Convert.ToInt32(Form1.days[1].condition) <= 300)
            {
                pictureBox2.Image = Properties.Resources._10;

            }
            else if (Convert.ToInt32(Form1.days[1].condition) >= 300 && Convert.ToInt32(Form1.days[1].condition) <= 400)
            {
                pictureBox2.Image = Properties.Resources._05;

            }
            else if (Convert.ToInt32(Form1.days[1].condition) >= 500 && Convert.ToInt32(Form1.days[1].condition) <= 600)
            {
                pictureBox2.Image = Properties.Resources._07;

            }
            else if (Convert.ToInt32(Form1.days[1].condition) >= 600 && Convert.ToInt32(Form1.days[1].condition) <= 700)
            {
                pictureBox2.Image = Properties.Resources._08;

            }
            else if (Convert.ToInt32(Form1.days[1].condition) >= 700 && Convert.ToInt32(Form1.days[1].condition) <= 800)
            {
                pictureBox2.Image = Properties.Resources._09;

            }
            else if (Convert.ToInt32(Form1.days[1].condition) == 800)
            {
                pictureBox2.Image = Properties.Resources._01;

            }
            else if (Convert.ToInt32(Form1.days[1].condition) >= 800 && Convert.ToInt32(Form1.days[1].condition) < 805)
            {
                pictureBox2.Image = Properties.Resources._04;

            }
            else
            {
                pictureBox2.Image = Properties.Resources._01;
            }
            date2.Text = "Tuesday";
            min2.Text = Form1.days[1].tempLow;
            max2.Text = Form1.days[1].tempHigh;
        }
        private void day3()
        {
            if (Convert.ToInt32(Form1.days[2].condition) >= 200 && Convert.ToInt32(Form1.days[2].condition) <= 300)
            {
                pictureBox3.Image = Properties.Resources._10;

            }
            else if (Convert.ToInt32(Form1.days[2].condition) >= 300 && Convert.ToInt32(Form1.days[2].condition) <= 400)
            {
                pictureBox3.Image = Properties.Resources._05;

            }
            else if (Convert.ToInt32(Form1.days[2].condition) >= 500 && Convert.ToInt32(Form1.days[2].condition) <= 600)
            {
                pictureBox3.Image = Properties.Resources._07;

            }
            else if (Convert.ToInt32(Form1.days[2].condition) >= 600 && Convert.ToInt32(Form1.days[2].condition) <= 700)
            {
                pictureBox3.Image = Properties.Resources._08;

            }
            else if (Convert.ToInt32(Form1.days[2].condition) >= 700 && Convert.ToInt32(Form1.days[2].condition) <= 800)
            {
                pictureBox3.Image = Properties.Resources._09;

            }
            else if (Convert.ToInt32(Form1.days[2].condition) == 800)
            {
                pictureBox3.Image = Properties.Resources._01;

            }
            else if (Convert.ToInt32(Form1.days[2].condition) >= 800 && Convert.ToInt32(Form1.days[2].condition) < 805)
            {
                pictureBox3.Image = Properties.Resources._04;

            }
            else
            {
                pictureBox3.Image = Properties.Resources._01;
            }
            date3.Text = "Wednesday";
            min3.Text = Form1.days[2].tempLow;
            max3.Text = Form1.days[2].tempHigh;
        }
        private void day4()
        {
            if (Convert.ToInt32(Form1.days[3].condition) >= 200 && Convert.ToInt32(Form1.days[3].condition) <= 300)
            {
                pictureBox4.Image = Properties.Resources._10;

            }
            else if (Convert.ToInt32(Form1.days[3].condition) >= 300 && Convert.ToInt32(Form1.days[3].condition) <= 400)
            {
                pictureBox4.Image = Properties.Resources._05;

            }
            else if (Convert.ToInt32(Form1.days[3].condition) >= 500 && Convert.ToInt32(Form1.days[3].condition) <= 600)
            {
                pictureBox4.Image = Properties.Resources._07;

            }
            else if (Convert.ToInt32(Form1.days[3].condition) >= 600 && Convert.ToInt32(Form1.days[3].condition) <= 700)
            {
                pictureBox4.Image = Properties.Resources._08;

            }
            else if (Convert.ToInt32(Form1.days[3].condition) >= 700 && Convert.ToInt32(Form1.days[3].condition) <= 800)
            {
                pictureBox4.Image = Properties.Resources._09;

            }
            else if (Convert.ToInt32(Form1.days[3].condition) == 800)
            {
                pictureBox4.Image = Properties.Resources._01;

            }
            else if (Convert.ToInt32(Form1.days[3].condition) >= 800 && Convert.ToInt32(Form1.days[3].condition) < 805)
            {
                pictureBox4.Image = Properties.Resources._04;

            }
            else
            {
                pictureBox4.Image = Properties.Resources._01;
            }
            date4.Text = "Thursday";
            min4.Text = Form1.days[3].tempLow;
            max4.Text = Form1.days[3].tempHigh;
        }
        private void day5()
        {
            if (Convert.ToInt32(Form1.days[4].condition) >= 200 && Convert.ToInt32(Form1.days[4].condition) <= 300)
            {
                pictureBox5.Image = Properties.Resources._10;

            }
            else if (Convert.ToInt32(Form1.days[4].condition) >= 300 && Convert.ToInt32(Form1.days[4].condition) <= 400)
            {
                pictureBox5.Image = Properties.Resources._05;

            }
            else if (Convert.ToInt32(Form1.days[4].condition) >= 500 && Convert.ToInt32(Form1.days[4].condition) <= 600)
            {
                pictureBox5.Image = Properties.Resources._07;

            }
            else if (Convert.ToInt32(Form1.days[4].condition) >= 600 && Convert.ToInt32(Form1.days[4].condition) <= 700)
            {
                pictureBox5.Image = Properties.Resources._08;

            }
            else if (Convert.ToInt32(Form1.days[4].condition) >= 700 && Convert.ToInt32(Form1.days[4].condition) <= 800)
            {
                pictureBox5.Image = Properties.Resources._09;

            }
            else if (Convert.ToInt32(Form1.days[4].condition) == 800)
            {
                pictureBox5.Image = Properties.Resources._01;

            }
            else if (Convert.ToInt32(Form1.days[4].condition) >= 800 && Convert.ToInt32(Form1.days[4].condition) < 805)
            {
                pictureBox5.Image = Properties.Resources._04;

            }
            else
            {
                pictureBox5.Image = Properties.Resources._01;
            }
            date5.Text = "Friday";
            min5.Text = Form1.days[4].tempLow;
            max5.Text = Form1.days[4].tempHigh;
        }
        private void day6()
        {

            if (Convert.ToInt32(Form1.days[5].condition) >= 200 && Convert.ToInt32(Form1.days[5].condition) <= 300)
            {
                pictureBox6.Image = Properties.Resources._10;

            }
            else if (Convert.ToInt32(Form1.days[5].condition) >= 300 && Convert.ToInt32(Form1.days[5].condition) <= 400)
            {
                pictureBox6.Image = Properties.Resources._05;

            }
            else if (Convert.ToInt32(Form1.days[5].condition) >= 500 && Convert.ToInt32(Form1.days[5].condition) <= 600)
            {
                pictureBox6.Image = Properties.Resources._07;

            }
            else if (Convert.ToInt32(Form1.days[5].condition) >= 600 && Convert.ToInt32(Form1.days[5].condition) <= 700)
            {
                pictureBox6.Image = Properties.Resources._08;

            }
            else if (Convert.ToInt32(Form1.days[5].condition) >= 700 && Convert.ToInt32(Form1.days[5].condition) <= 800)
            {
                pictureBox6.Image = Properties.Resources._09;

            }
            else if (Convert.ToInt32(Form1.days[5].condition) == 800)
            {
                pictureBox6.Image = Properties.Resources._01;

            }
            else if (Convert.ToInt32(Form1.days[5].condition) >= 800 && Convert.ToInt32(Form1.days[5].condition) < 805)
            {
                pictureBox6.Image = Properties.Resources._04;

            }
            else
            {
                pictureBox6.Image = Properties.Resources._01;
            }
            date6.Text = "Saturday";
            min6.Text = Form1.days[5].tempLow;
            max6.Text = Form1.days[5].tempHigh;
        }
        private void day7()
        {
            if (Convert.ToInt32(Form1.days[6].condition) >= 200 && Convert.ToInt32(Form1.days[6].condition) <= 300)
            {
                pictureBox7.Image = Properties.Resources._10;

            }
            else if (Convert.ToInt32(Form1.days[6].condition) >= 300 && Convert.ToInt32(Form1.days[6].condition) <= 400)
            {
                pictureBox7.Image = Properties.Resources._05;

            }
            else if (Convert.ToInt32(Form1.days[6].condition) >= 500 && Convert.ToInt32(Form1.days[6].condition) <= 600)
            {
                pictureBox7.Image = Properties.Resources._07;

            }
            else if (Convert.ToInt32(Form1.days[6].condition) >= 600 && Convert.ToInt32(Form1.days[6].condition) <= 700)
            {
                pictureBox7.Image = Properties.Resources._08;

            }
            else if (Convert.ToInt32(Form1.days[6].condition) >= 700 && Convert.ToInt32(Form1.days[6].condition) <= 800)
            {
                pictureBox7.Image = Properties.Resources._09;

            }
            else if (Convert.ToInt32(Form1.days[6].condition) == 800)
            {
                pictureBox7.Image = Properties.Resources._01;

            }
            else if (Convert.ToInt32(Form1.days[6].condition) >= 800 && Convert.ToInt32(Form1.days[6].condition) < 805)
            {
                pictureBox7.Image = Properties.Resources._04;

            }
            else
            {
                pictureBox7.Image = Properties.Resources._01;
            }
            date7.Text = "Sunday";
            min7.Text = Form1.days[6].tempLow;
            max7.Text = Form1.days[6].tempHigh;
        }
    }
}
