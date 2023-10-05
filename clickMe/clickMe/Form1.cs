using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int clickCounter = 0;
        private void clickBtn_Click(object sender, EventArgs e)
        {
            clickCounter++;
            lblClick.Text = "Number of Clicks: " + clickCounter;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
