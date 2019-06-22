using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double nume1,nume2,oper,oper2,nume3;
           switch (comboBox1.SelectedIndex)
            {

                case 0:
                     nume1 = double.Parse(num1.Text);
                     nume2 = double.Parse(num2.Text);
                     oper = (nume1 * nume2);
                     oper2 = (2 * nume1 + 2 * nume2);
                     area.Text = oper.ToString();
                     perimetro.Text = oper2.ToString();
                     
                     
                    break;

                case 1:
                    nume1 = double.Parse(num1.Text);
                    nume2 = double.Parse(num2.Text);
                    oper = (nume1 * nume2/2);
                    oper2 = (nume1 * 3);
                    area.Text = oper.ToString();
                    perimetro.Text = oper2.ToString();
                    break;

                case 2:
                    
                    nume1 = double.Parse(percirculo.Text);
                    oper = (3.1416*nume1*nume1);
                    oper2 = (2*3.1416*nume1);
                    perimetro.Text = oper2.ToString();
                    area.Text = oper.ToString();
                    break;

                case 3:
                    nume1 = double.Parse(num1.Text);
                    oper = (nume1 * nume1);
                    oper2 = (4*nume1);
                    area.Text = oper.ToString();
                    perimetro.Text = oper2.ToString();


                    break;



            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                pictureBox1.ImageLocation = "C:/Users/Alex/Desktop/trabajo1/" + comboBox1.Text + ".png";
                percirculo.Hide();
                radio.Hide();
                num1.Show();
                num2.Show();
                altura.Show();
                bas.Show();
            }
            else
            {
              if (comboBox1.SelectedIndex == 1)
                {
                    pictureBox1.ImageLocation = "C:/Users/Alex/Desktop/trabajo1/" + comboBox1.Text + ".png";
                    percirculo.Hide();
                    radio.Hide();
                    num1.Show();
                    num2.Show();
                    altura.Show();
                    bas.Show();
                }
                else
                {
                    if (comboBox1.SelectedIndex == 2)
                    {
                        pictureBox1.ImageLocation = "C:/Users/Alex/Desktop/trabajo1/" + comboBox1.Text + ".jpg";
                        num1.Hide();
                        num2.Hide();
                        altura.Hide();
                        bas.Hide();
                        percirculo.Show();
                        radio.Show();
                    }
                    else
                    {
                        pictureBox1.ImageLocation = "C:/Users/Alex/Desktop/trabajo1/" + comboBox1.Text + ".png";
                        num2.Hide();
                        percirculo.Hide();
                        radio.Hide();
                        num1.Show();
                        altura.Show();
                    }
                }
            }
        }

        private void Limpia_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            percirculo.Clear();
        }
    }
}
