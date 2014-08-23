using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;
using AnomalEvent.Classes;
using Dapper.Contrib.Extensions;

namespace AnomalEvent.Forms
{
	public partial class CorrectiveActionReportForm : Form
	{
	    public CorrectiveMeasure Action;
	    private List<Department> departments;
	    private List<User> users;
	    public AnEvent anEvent;
		public CorrectiveActionReportForm()
		{
			InitializeComponent();
		}

        private void CorrectiveActionReportForm_Load(object sender, EventArgs e)
        {
            if (Authorizer.Instance.Guest == 1)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                textBox1.Enabled = false;
                
                textBox3.Enabled = false;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
                richTextBox3.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                checkBox1.Enabled = false;
            }
            textBox2.Enabled = false;
            departments = Department.getList();
            users = User.getList().Where((x) => x.IsPerson == 1).ToList();

            foreach (var department in departments)
            {
                comboBox3.Items.Add(department.Name);
            }
            foreach (var user in users)
            {
                if (user.IsPerson == 1)
                {
                    comboBox1.Items.Add(user.Name);
                    comboBox2.Items.Add(user.Name);
                }
            }
            if (Action != null)
            {
                User _user = users.First(x => x.Id == Action.ExecutorId.Value);
                foreach (String item in comboBox1.Items)
                {
                    if (item == _user.Name)
                    {
                        comboBox1.SelectedIndex = comboBox1.Items.IndexOf(item);
                    }
                }
                _user = users.First(x => x.Id == Action.CuratorId.Value);
                foreach (String item in comboBox2.Items)
                {
                    if (item == _user.Name)
                    {
                        comboBox2.SelectedIndex = comboBox2.Items.IndexOf(item);
                    }
                }
                Department department = departments.First(x => x.Id == Action.DepartmentId);
                foreach (String item in comboBox3.Items)
                {
                    if (item == department.Name)
                    {
                        comboBox3.SelectedIndex = comboBox3.Items.IndexOf(item);
                    }
                }
                this.dateTimePicker1.Value = Action.DateEnd;
                this.dateTimePicker2.Value = Action.MemoDate;
                textBox2.Text = Action.Id.ToString();
                textBox3.Text = this.Action.MemoNumber;
                richTextBox1.Text = this.Action.Content;
                richTextBox2.Text = this.Action.Compliance;
                richTextBox3.Text = this.Action.FailReason;

            }
            else
            {
                Action = new CorrectiveMeasure();
                Action.EventId = this.anEvent.Id;
                Action.DateEnd = this.dateTimePicker1.Value;
                Action.MemoDate = this.dateTimePicker1.Value;
                Action.Finished = 0;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = users.First(x => x.Name == (sender as ComboBox).SelectedItem.ToString());
            Action.ExecutorId = user.Id;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = users.First(x => x.Name == (sender as ComboBox).SelectedItem.ToString());
            Action.CuratorId = user.Id;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Action.DateEnd = (sender as DateTimePicker).Value;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Action.Content = (sender as RichTextBox).Text;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            Action.Compliance = (sender as RichTextBox).Text;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            Action.FailReason = (sender as RichTextBox).Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Action.MemoNumber = (sender as TextBox).Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Action.MemoDate = (sender as DateTimePicker).Value;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Action.MemoNumber = (sender as TextBox).Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var department = departments.First(x => x.Name == (sender as ComboBox).SelectedItem.ToString());
            Action.DepartmentId = department.Id;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
                Action.Finished = 1;
            else
                Action.Finished = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Authorizer.Instance.Guest != 1)
            {
                if (Action.Id == null)
                {
                    SqlMapperExtensions.Insert(AnomalEventConnection.Connection, Action);
                }
                else
                {
                    SqlMapperExtensions.Update(AnomalEventConnection.Connection, Action);
                }
            }
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.Action.Name = (sender as TextBox).Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.Action.ExecutionStatus = (sender as TextBox).Text;
        }


	}
}
