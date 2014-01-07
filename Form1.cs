using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsObjects
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Verify that something is in the text box
            //If there is something in the text box
            //      Add it to the list of items in the combo box
            //Otherwise
            //      Change the background of the textbox to red
            //      Otherwise tell the user to enter text
            if (txtInput.Text != String.Empty)
            {
                cboList.Items.Add(txtInput.Text);
                txtInput.Text = String.Empty;
            }
            else
            {
                txtInput.BackColor = Color.Red;
                lblStatus.Text = "You must enter a string value in the textbox.";
                MessageBox.Show("A problem has occurred. Check status bar.",
                    "Because The Teacher Said So",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtInput.BackColor = Color.White;
                lblStatus.Text = "Ready";
                txtInput.Focus();
            }
        }
    }
}
