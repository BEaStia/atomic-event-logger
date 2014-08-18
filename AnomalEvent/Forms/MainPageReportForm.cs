using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnomalEvent.Forms
{
	public partial class MainPageReportForm : Form
	{
		public MainPageReportForm()
		{
			InitializeComponent();
		}

        private void button3_Click(object sender, EventArgs e)
        {
            ConsequenceViolationReportForm consequenceViolationReportForm = new ConsequenceViolationReportForm();
            consequenceViolationReportForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	}
}
