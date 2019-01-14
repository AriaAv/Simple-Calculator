using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mycalc3
{
    public partial class Form1 : Form
    {   double x, y, z;
        string op;
        Boolean f;
        public Form1()
        {
            InitializeComponent();
        }
                private void Numbers(object sender, EventArgs e)
        {
            if (f == true)
            {
                txtdisplay.Text = "";
                f = false;
            }
                    txtdisplay.Text += ((Button)sender).Text;
        }
                private void Operators(object sender, EventArgs e)
        {
            if (op != null)
                btnequal_Click(null, null);
              x = Convert.ToDouble(txtdisplay.Text);
           // txtdisplay.Text = "";
            f = true;
            op = ((Button)sender).Text;
        }
                private void btnequal_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(txtdisplay.Text);
            switch (op) {
                case "+":
                    z = x + y;
                    break;
                case "-":
                    z = x - y;
                    break;
                case "*":
                    z = x * y;
                    break;
                case "/":
                    z = x / y;
                    break;
          
            }
            txtdisplay.Text = z.ToString();
           op = null;
        }

                private void btnonoff_Click(object sender, EventArgs e)
                {
                    //if (panel1.Enabled == false)
                    //    panel1.Enabled = true;
                    //else
                    //    panel1.Enabled = false;
                    panel1.Enabled = !panel1.Enabled;
                    if (btnonoff.Text == "Off")
                        btnonoff.Text = "On";
                    else
                        btnonoff.Text = "Off";
                }

                private void button22_Click(object sender, EventArgs e)
                    
                {
                    if(txtdisplay.Text.Length>0)
                   txtdisplay.Text= txtdisplay.Text.Substring(0, txtdisplay.Text.Length - 1);
                }

                private void txtdisplay_TextChanged(object sender, EventArgs e)
                {
                  //  button22.Enabled = Convert.ToBoolean(txtdisplay.Text.Length);
                }

                private void Form1_Load(object sender, EventArgs e)
                {
                   // txtdisplay_TextChanged(null, null);
                }

                private void btnpoint_Click(object sender, EventArgs e)
                {
                    if(txtdisplay.Text.Contains(".")==false)
                    txtdisplay.Text += '.';
                }

                private void button1_Click(object sender, EventArgs e)
                {
                    
                    MessageBox.Show(txtdisplay.Text.Contains("67").ToString());
                }

                private void btnonoff_KeyPress(object sender, KeyPressEventArgs e)
                {
                    
                    MessageBox.Show("I m in btnonoff Keypress : " + e.KeyChar.ToString());
                }

                private void Form1_KeyPress(object sender, KeyPressEventArgs e)
                {
                    foreach (Control x in panel1.Controls)
                        if (x.Text == e.KeyChar.ToString())
                        {
                            x.Focus();
                            x.ForeColor = Color.Red;
                        }
                        else
                            x.ForeColor = Color.Black;
                    

                    Button b = new Button();
                    b.Text = e.KeyChar.ToString();

                    if (e.KeyChar >= '0' && e.KeyChar <= '9')
                        Numbers(b, null);
                    else if (e.KeyChar == '+' || e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '-')
                        Operators(b, null);
                    else if (e.KeyChar == '=')
                        btnequal_Click(null, null);
                }
    }
}
