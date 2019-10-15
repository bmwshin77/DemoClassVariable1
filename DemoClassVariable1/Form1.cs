using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DemoClassVariable1
{
    public partial class Form1 : Form
    {

        private double overallTotalDouble;
        private int totalAdditions;
        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Hover(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Red;
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            exitButton.BackColor = DefaultBackColor;
        }

        private void firstNumTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void secondNumTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //local variable declaration

            double firstNumberDouble = 0;
            double secondNumberDouble = 0;
            double totalDouble;

            totalAdditions++; // or totalAdditions +=1;

            if (!Regex.IsMatch(firstNumTextBox.Text, @"^[0-9]+$") || !Regex.IsMatch(secondNumTextBox.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please enter a number");
                firstNumTextBox.Text = "0";
                secondNumTextBox.Text = "0";
                firstNumTextBox.Focus();
                totalAdditions = 0;
            }
                                         
            // Use Convert Class Method
            firstNumberDouble = Convert.ToDouble(firstNumTextBox.Text);
            // Use Parse 
            secondNumberDouble = double.Parse(secondNumTextBox.Text);

            totalDouble = firstNumberDouble + secondNumberDouble;

            labelTotal.Text = Convert.ToString(totalDouble);

            
            totalCountLabel.Text = Convert.ToString(totalAdditions);

            overallTotalDouble += totalDouble;
            overallTotalLabel.Text = overallTotalDouble.ToString ();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumTextBox.Text = "";
            firstNumTextBox.ForeColor = Color.Blue;
            secondNumTextBox.Text = "";
            secondNumTextBox.ForeColor = Color.Red;
            labelTotal.Text = "";
            totalCountLabel.Text = "";
            totalAdditions = 0;
            overallTotalLabel.Text = "";
            overallTotalDouble = 0;
        }

        //private void firstNumTextBox_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(firstNumTextBox.Text))
        //    {
        //        e.Cancel = true;
        //        firstNumTextBox.Focus();
        //        errorProvider.SetError(firstNumTextBox, "Please enter a valid number");
        //    }

        //    else
        //    {
        //        e.Cancel = true;
        //        errorProvider.SetError(firstNumTextBox, null);
        //    }
        //}
    }

    //TODO 
//Currently, you have a textbox that has some text in it.

//You are to change the behavior such that when a user clicks on the text box,

//The textbox clears
//Textbox fore color changes to black or blue(more visible)
//Exit Button behavior:

//when the mouse hovers over the exit button, color should change to Red
//when the mouse leaves the exit button, color should change back to default
}
