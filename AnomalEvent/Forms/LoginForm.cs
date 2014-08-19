using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnomalEvent.Classes;

namespace AnomalEvent.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                okButton.PerformClick();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            if (Authorizer.IsCorrect(textBox1.Text, textBox2.Text))
            {
                
                Authorizer.Instance = Authorizer.GetUser(textBox1.Text);
                ShowEvents();  
            }
            else
            {
                label3.ForeColor = Color.HotPink;
                label3.BackColor = Color.White;
                label3.Text = "Неверные данные!";
            }
        }

        void ShowEvents()
        {
            var eventform = new JournalEventForm();
            eventform.Show();
            eventform.Closed += eventform_Closed;
            this.Hide();
        }

        void eventform_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
//            GuestForm guessform = new GuestForm();
//            guessform.ShowDialog();
            Authorizer.Instance = new User(){Guest = 1};
            ShowEvents();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
