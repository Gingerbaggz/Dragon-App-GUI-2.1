using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2._1_GUI
//Steven Chance
//MS539
//Assignment 2.1 Dragon GUI
//Estimated Time: 2 hours
//Actual Time: 3 hours and 31 minutes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected the " + (radioButton1.Checked ? "Wyvern" : radioButton2.Checked ? "Ice Dragon" : radioButton3.Checked ? "Sea Dragon" : "Lindworm") + " as your favorite dragon!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.worldanvil.com/w/nailara-saafris/a/wyvern-article");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://awoiaf.westeros.org/index.php/Ice_dragon");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://risingdawn.fandom.com/wiki/Sea_Dragon");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Lindworm");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
   
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
