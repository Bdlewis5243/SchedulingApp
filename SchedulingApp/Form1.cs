using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SchedulingApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //MeetingComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //AddNotesTextBox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        //SubmitButton
        private void submitButton_Click(object sender, EventArgs e)
        {
            //if valid input show submitted window

            //Your meeting with {Person} on {date}, from {start} until {end}, is scheduled
            string confirmation = "Your meeting with "+ MeetingComboBox.Text + " on " + dateTimePicker1.Text + ", from " + StartComboBox.Text + " until " + EndComboBox.Text + " is scheduled.";

            SubmittedWindow objSubmittedWindow = new SubmittedWindow();
            objSubmittedWindow.LabelText = confirmation;
            objSubmittedWindow.Show();

            //else show error window (not yet created)
        }

        //SettingsButton
        private void button2_Click(object sender, EventArgs e)
        {
            SettingsWindow objSettingsWindow = new SettingsWindow();
            objSettingsWindow.Show();
        }

        //TitleTextBox
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Calendar
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //NameTextBox
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
