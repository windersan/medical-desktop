using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;

            ////////////////////////////////////////////////
            if (radioButton2.Checked == true) { i = i + 1; }
            if (radioButton9.Checked == true) { i = i + 1; }
            if (radioButton19.Checked == true) { i = i + 1; }
            if (radioButton14.Checked == true) { i = i + 1; }
            if (radioButton29.Checked == true) { i = i + 1; }
            if (radioButton34.Checked == true) { i = i + 1; }
            if (radioButton24.Checked == true) { i = i + 1; }
            if (radioButton69.Checked == true) { i = i + 1; }
            if (radioButton59.Checked == true) { i = i + 1; }
            if (radioButton64.Checked == true) { i = i + 1; }
            if (radioButton54.Checked == true) { i = i + 1; }
            if (radioButton44.Checked == true) { i = i + 1; }
            if (radioButton49.Checked == true) { i = i + 1; }
            if (radioButton39.Checked == true) { i = i + 1; }
            ////////////////////////////////////////////////
            if (radioButton3.Checked == true) { i = i + 2; }
            if (radioButton8.Checked == true) { i = i + 2; }
            if (radioButton18.Checked == true) { i = i + 2; }
            if (radioButton13.Checked == true) { i = i + 2; }
            if (radioButton28.Checked == true) { i = i + 2; }
            if (radioButton33.Checked == true) { i = i + 2; }
            if (radioButton23.Checked == true) { i = i + 2; }
            if (radioButton68.Checked == true) { i = i + 2; }
            if (radioButton58.Checked == true) { i = i + 2; }
            if (radioButton63.Checked == true) { i = i + 2; }
            if (radioButton53.Checked == true) { i = i + 2; }
            if (radioButton43.Checked == true) { i = i + 2; }
            if (radioButton48.Checked == true) { i = i + 2; }
            if (radioButton38.Checked == true) { i = i + 2; }
            ////////////////////////////////////////////////
            if (radioButton4.Checked == true) { i = i + 3; }
            if (radioButton7.Checked == true) { i = i + 3; }
            if (radioButton17.Checked == true) { i = i + 3; }
            if (radioButton12.Checked == true) { i = i + 3; }
            if (radioButton27.Checked == true) { i = i + 3; }
            if (radioButton32.Checked == true) { i = i + 3; }
            if (radioButton22.Checked == true) { i = i + 3; }
            if (radioButton67.Checked == true) { i = i + 3; }
            if (radioButton57.Checked == true) { i = i + 3; }
            if (radioButton62.Checked == true) { i = i + 3; }
            if (radioButton52.Checked == true) { i = i + 3; }
            if (radioButton42.Checked == true) { i = i + 3; }
            if (radioButton47.Checked == true) { i = i + 3; }
            if (radioButton37.Checked == true) { i = i + 3; }
            ////////////////////////////////////////////////
            if (radioButton5.Checked == true) { i = i + 4; }
            if (radioButton6.Checked == true) { i = i + 4; }
            if (radioButton16.Checked == true) { i = i + 4; }
            if (radioButton11.Checked == true) { i = i + 4; }
            if (radioButton26.Checked == true) { i = i + 4; }
            if (radioButton31.Checked == true) { i = i + 4; }
            if (radioButton21.Checked == true) { i = i + 4; }
            if (radioButton66.Checked == true) { i = i + 4; }
            if (radioButton56.Checked == true) { i = i + 4; }
            if (radioButton61.Checked == true) { i = i + 4; }
            if (radioButton51.Checked == true) { i = i + 4; }
            if (radioButton41.Checked == true) { i = i + 4; }
            if (radioButton46.Checked == true) { i = i + 4; }
            if (radioButton36.Checked == true) { i = i + 4; }
            ////////////////////////////////////////////////




            ////////////////////////////////////////////////
            label_result.Text = "Result: " + i;

            if (i < 7) {
                label_patient.Text = "Patient is at low risk for opioid abuse.";
                label_patient.ForeColor = Color.Green;
                label_patient.BackColor = Color.Transparent;
            }
            else if (i >= 7 && i <= 10) {
                label_patient.Text = "Patient is at moderate risk for opioid abuse.";
                label_patient.ForeColor = Color.Yellow;
                label_patient.BackColor = Color.Blue;
            }
            else if (i > 10) {
                label_patient.Text = "Patient is at high risk for opioid abuse.";
                label_patient.ForeColor = Color.Red;
                label_patient.BackColor = Color.Transparent;
            }
            ////////////////////////////////////////////////
            ////////////////////////////////////////////////
        }
    }
}
