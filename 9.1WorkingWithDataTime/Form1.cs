/*
 * Ana Mendes
 * anamendes23@gmail.com
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._1WorkingWithDataTime
{
    /*Creating DateTime objects
     *Getting DateTime from user
     * 
     *  DateTime is defined in .Net as a struct (a struct is
     *  very similar to a class, but is a light weight class)
     * */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*******************************BTN CURRENT DATE TIME*******************/
        private void btnCurrentDateTime_Click(object sender, EventArgs e)
        {
            //Display current Date & Time using the Now property
            DateTime currentDT = DateTime.Now;
            richTextBox1.Text =
                "ToLongDateString:  " + currentDT.ToLongDateString() + "\n" +
                "ToShortDateString: " + currentDT.ToShortDateString() + "\n" +
                "ToLongTimeString:  " + currentDT.ToLongTimeString() + "\n" +
                "ToShortTimeString: " + currentDT.ToShortTimeString() + "\n" +
                "ToString:          " + currentDT.ToString();
        }
        /*******************************BTN RANDOM DATE TIME********************/
        private void btnRandomDT_Click(object sender, EventArgs e)
        {
            //public DateTime( int year, int month, int day, 
            //                 int hour, int minute, int second)
            Random rand = new Random();
            int year = rand.Next(1970, 2010);
            int month = rand.Next(1, 13);
            int day = rand.Next(1, 29);
            int hour = rand.Next(24);
            int minute = rand.Next(60);
            int second = rand.Next(60);

            //create a DateTime
            DateTime dt = new DateTime(year, month, day, hour, minute, second);
            richTextBox1.Text = dt.ToString();

            //public static TimeSpan operator -(DateTime d1, DateTime d2)
            //TimeSpan is another object

            //number of days between current datetime and dt
            DateTime currentDT = DateTime.Now;
            TimeSpan ts = currentDT - dt;
            //number of total days between current datetime and dt
            double totalDays = ts.TotalDays;
            int days = ts.Days;
            richTextBox1.AppendText("\n\n" +
                "Total days difference between random datetime and current " +
                "datetime: " + totalDays + "\n" +
                "Days: " + days);
        }
        /*******************************BTN GET SELECTED DATE*******************/
        private void btnGetSelectedDate_Click(object sender, EventArgs e)
        {
            //get the Date the user selected
            DateTime date = dateTimePicker1.Value;
            //display it
            richTextBox1.Text = date.ToLongDateString();
        }
        /*******************************FORM LOAD*******************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            //set the maxDate (of datetimepicker1) to today's date
            dateTimePicker1.MaxDate = DateTime.Now;

            ///Change dateTimePicker to show time only
            //dateTimePicker only for time
            //could achieve the same thing in Design Mode
            //timePicker.Format = DateTimePickerFormat.Time;
            //timePicker.ShowUpDown = true;

            //or use custom
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm"; //only hours & minutes
            timePicker.ShowUpDown = true;
        }
        /******************************BTN CREATE DATETIME***********************/
        private void btnCreateDateTime_Click(object sender, EventArgs e)
        {
            //create new DateTime from today's datetime
            //1. create a DateTime that is one year ago
            DateTime currentDT = DateTime.Now;
            DateTime dt1 = currentDT.AddYears(-1);
            //2. create a DateTime that is 5 months ago
            DateTime dt2 = currentDT.AddMonths(-5);
            //3. create a DateTime that is 45 days ago
            DateTime dt3 = currentDT.AddDays(-45);
            //4. create a DateTime that is 30 hours ago
            DateTime dt4 = currentDT.AddHours(-30);
            //5. create a DateTime that is 3 years and 5 months
            //   in the future
            DateTime dt5 = currentDT.AddYears(3).AddMonths(5);
            //display current date and calculated dates
            richTextBox1.Text =
                "current datetime: " + currentDT.ToString() + "\n" +
                "one year ago: " + dt1.ToString() + "\n" +
                "5 months ago: " + dt2.ToString() + "\n" +
                "45 days ago: " + dt3.ToString() + "\n" +
                "30 hours ago: " + dt4.ToString() + "\n" +
                "3 years and 5 hours in the future: " + dt5.ToString();
        }
        /******************************BTN COMPUTE AGE***************************/
        private void btnComputeAge_Click(object sender, EventArgs e)
        {
            lblage.Text = "Your age is: ";
            //Have a user enter select birthdate
            DateTime birthdate = dateTimePicker1.Value;
            //display how old the user is in years
            int age = DateTime.Now.Year - birthdate.Year;
            lblage.Text += age; 
        }
    }
}
///Exercise:
///Have a user enter select birthdate
///display how old the user is in years
///
///research how to make the datetimepicker work for time
///
///Exercise:
///provide two datetimepickers to select departure time
///and return time (making sure that return time is ahead of departure time)
///determine and display how long the traveler be gone in months days and hours