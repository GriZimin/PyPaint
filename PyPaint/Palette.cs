using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyPaint
{
    public partial class Palette : Form
    {
        int redVal=0, blueVal=0, greenVal=0; 
        Form1 mainForm;
        public Palette(Form1 f)
        {
            InitializeComponent();
            mainForm = f;
            sendMassege();
        }
        void sendMassege()
        {
            mainForm.currentColor = Color.FromArgb(redVal, greenVal , blueVal);
            thisColor.BackColor = Color.FromArgb(redVal, greenVal, blueVal);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RedTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(RedTB.Text) > 255)
                    RedTB.Text = "255";
                if (Convert.ToInt32(RedTB.Text) < 0)
                    RedTB.Text = "0";
                redVal = Convert.ToInt32(RedTB.Text);

                
            }
            catch
            {
                RedTB.Text = "0";
                redVal = 0;
            }
            redBar.Value = redVal;
            sendMassege();
        }

        

        private void buttonClear_Click(object sender, EventArgs e)
        {
            mainForm.Clear();
        }

        private void redBar_Scroll(object sender, EventArgs e)
        {
            RedTB.Text = redBar.Value.ToString();

        }

        private void greenBar_Scroll(object sender, EventArgs e)
        {
            GreenTB.Text = greenBar.Value.ToString();
        }

        private void blueBar_Scroll(object sender, EventArgs e)
        {
            BlueTB.Text = blueBar.Value.ToString();
        }

        private void GreenTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(GreenTB.Text) > 255)
                    GreenTB.Text = "255";
                if (Convert.ToInt32(GreenTB.Text) < 0)
                    GreenTB.Text = "0";
                greenVal = Convert.ToInt32(GreenTB.Text);


            }
            catch
            {
                GreenTB.Text = "0";    
                greenVal = 0;
            }
            greenBar.Value = greenVal;
            sendMassege();
        }

        private void BlueTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(BlueTB.Text) > 255)
                    BlueTB.Text = "255";
                if (Convert.ToInt32(BlueTB.Text) < 0)
                    BlueTB.Text = "0";
                blueVal = Convert.ToInt32(BlueTB.Text);


            }
            catch
            {
                BlueTB.Text = "0"; 
                blueVal = 0;
            }
            blueBar.Value = blueVal;
            sendMassege();
        }
    }
}
