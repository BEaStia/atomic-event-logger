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
	public partial class InformationCardReportForm : Form
	{
		public InformationCardReportForm()
		{
			InitializeComponent();
		}

        private void button4_Click(object sender, EventArgs e)
        {
            CorrectiveActionReportForm correctiveActionReportForm = new CorrectiveActionReportForm();
            correctiveActionReportForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	}
}
