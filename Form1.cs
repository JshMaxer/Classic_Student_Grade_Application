using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classic_Student_Grade_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            if (txtenglish.Text.Equals("") || txthistory.Text.Equals("") || txtmath.Text.Equals("") || txtname.Text.Equals("") || txtscience.Text.Equals("") || txtsports.Text.Equals(""))
            {
                MessageBox.Show("Field is blank", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    double english = Convert.ToDouble(txtenglish.Text);
                    double math = Convert.ToDouble(txtmath.Text);
                    double science = Convert.ToDouble(txtscience.Text);
                    double sports = Convert.ToDouble(txtsports.Text);
                    double history = Convert.ToDouble(txthistory.Text);

                    double average = (english + math + science + sports + history) / 5;

                    if (average >= 75 && average <= 100)
                    {
                        MessageBox.Show("     The Student passed.\nThe general average of " + txtname.Text + " is " + average, "School", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtenglish.Text = null;
                        txtsports.Text = null;
                        txthistory.Text = null;
                        txtmath.Text = null;
                        txtscience.Text = null;
                        txtname.Text = null;
                    }
                    else if (average <= 74 && average >= 51)
                    {
                        MessageBox.Show("     The Student failed.\nThe general average of " + txtname.Text + " is " + average, "School", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtenglish.Text = null;
                        txtsports.Text = null;
                        txthistory.Text = null;
                        txtmath.Text = null;
                        txtscience.Text = null;
                        txtname.Text = null;
                    }
                    else if (average > 100)
                    {
                        MessageBox.Show("     The Student Grade exceed limit.", "School", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtenglish.Text = null;
                        txtsports.Text = null;
                        txthistory.Text = null;
                        txtmath.Text = null;
                        txtscience.Text = null;
                        txtname.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("     The Student dropped.\nThe general average of " + txtname.Text + " is " + average, "School", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtenglish.Text = null;
                        txtsports.Text = null;
                        txthistory.Text = null;
                        txtmath.Text = null;
                        txtscience.Text = null;
                        txtname.Text = null;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something Wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
