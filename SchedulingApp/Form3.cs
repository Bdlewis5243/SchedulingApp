using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApp
{
    public partial class SubmittedWindow : Form
    {
        public SubmittedWindow()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get
            {
                return this.SubmittedLabel1.Text;
            }
            set
            {
                this.SubmittedLabel1.Text = value;
            }
        }


        private void SubmittedLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
