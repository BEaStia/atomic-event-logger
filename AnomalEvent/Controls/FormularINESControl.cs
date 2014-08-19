using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnomalEvent.Controls
{
	public partial class FormularINESControl : UserControl
	{
		public FormularINESControl()
		{
			InitializeComponent();
		}

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxText(sender as CheckBox);
        }

	    private void CheckBoxText(CheckBox box)
	    {
	        if (box.Text == "Да")
	            box.Text = "Нет";
	        else
	            box.Text = "Да";
	    }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBoxText(sender as CheckBox);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxText(sender as CheckBox);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxText(sender as CheckBox);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxText(sender as CheckBox);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxText(sender as CheckBox);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxText(sender as CheckBox);
        }

        private void FormularINESControl_Load(object sender, EventArgs e)
        {

        }
	}
}
