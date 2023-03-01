using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace azimuth_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Input coordinates only numerically
        private void inputx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inputy1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inputx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inputy2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void calculatebotton_Click(object sender, EventArgs e)
        {
        //UTM coordinates of points
            double x1 = Convert.ToDouble(inputx1.Text);
            double x2 = Convert.ToDouble(inputx2.Text);
            double y1 = Convert.ToDouble(inputy1.Text);
            double y2 = Convert.ToDouble(inputy2.Text);

         //calculation of azimuth in degree and radians
            double dx = x2 - x1;
            double dy = y2 - y1;
            double azimuthRad = Math.Atan(dy / dx);
            double azimuthDeg = azimuthRad * (180 / Math.PI);

         //calculating azimuth in first & second quarter(NE & SE)
            if (dx > 0)
                if (dy > 0)
                {
                    azimuthDeg = 90 - azimuthDeg;
                    azimuthRad = (Math.PI / 2) - azimuthRad;
                }
                else
                {
                    azimuthDeg = 90 - azimuthDeg;
                    azimuthRad = (Math.PI / 2) - azimuthRad;
                }
         //calculating azimuth in third & fourth quarter(SW & NW)
            else if (dx < 0)
                if (dy < 0)
                {
                    azimuthDeg = 270 - azimuthDeg;
                    azimuthRad = (Math.PI / 2) * 3 - azimuthRad;
                }
                else
                {
                    azimuthDeg = 270 - azimuthDeg;
                    azimuthRad = (Math.PI / 2) * 3 - azimuthRad;

                }

         // result

            boxAzDeg.Text = azimuthDeg.ToString();
            boxAzRad.Text = azimuthRad.ToString();


        }

        private void boxAzDeg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

     
