using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using AnomalEvent.Classes;
using AnomalEvent.Forms;
using Dapper.Contrib.Extensions;

namespace AnomalEvent
{
	public partial class ProgressAddEventForm : Form
	{
	    public AnEvent Ev;
	    public List<User> users;
        public List<Category> categories;
        public List<Department> departments;
		public ProgressAddEventForm()
		{
			InitializeComponent();
		}

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Ev.EventDateTime = (sender as DateTimePicker).Value;
        }

	    private void Save()
	    {
            if (Authorizer.Instance.Guest != 1)
            {
                if (Ev.Id == null)
                {
                    SqlMapperExtensions.Insert(AnomalEventConnection.Connection, Ev);
                }
                else
                {
                    SqlMapperExtensions.Update(AnomalEventConnection.Connection, Ev);
                }
            }
            
	    }

        private void butOk_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void Formular_Click(object sender, EventArgs e)
        {
            Forms.Formular _formular = new Formular();
            _formular.ShowDialog();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            Ev.Report = fileDialog.FileName;
            
        }

	    private void UpdateReportLabel()
	    {
	        if (Ev.Report != null && Ev.Report != "")
	        {
	            OpenReportButton.Enabled = true;
	        }
	        else
	            OpenReportButton.Enabled = false;
	    }

	    private void ProgressAddEventForm_Load(object sender, EventArgs e)
	    {
	        if (Authorizer.Instance.Guest == 1)
	        {
	            this.ShortDescription.Enabled = false;
	            this.CreateReport.Enabled = false;
	            this.DepartmentComboBox.Enabled = false;
	            this.reg_id.Enabled = false;
	            this.CategoryComboBox.Enabled = false;
	            this.ClassifiedByComboBox.Enabled = false;
	            this.RegisteredByComboBox.Enabled = false;
                this.ReportButton.Enabled = false;   
	        }
	        Boolean new_ev = true;
	        if (this.Ev == null)
	            Ev = new AnEvent();
	        else
	        {
	            new_ev = false;
	        }
	        reg_id.Enabled = false;
	        users = User.getList();
	        foreach (var user in users)
	        {
	            RegisteredByComboBox.Items.Add(user.Name);
	            ClassifiedByComboBox.Items.Add(user.Name);
	        }
	        departments = Department.getList();
	        foreach (var department in departments)
	        {
	            DepartmentComboBox.Items.Add(department.Name);
	        }
	        categories = Category.getList();
	        foreach (var category in categories)
	        {
	            CategoryComboBox.Items.Add(category.Name);
	        }
	        if (!new_ev)
	        {

	            User _user = users.Where((x) => x.Id == Ev.RegisteredBy.Value).First();
	            foreach (String item in RegisteredByComboBox.Items)
	            {
	                if (item == _user.Name)
	                {
	                    RegisteredByComboBox.SelectedIndex = RegisteredByComboBox.Items.IndexOf(item);
	                }
	            }
                _user = users.Where((x) => x.Id == Ev.ClassifiedBy.Value).First();
	            foreach (String item in ClassifiedByComboBox.Items)
	            {
	                if (item == _user.Name)
	                {
	                    ClassifiedByComboBox.SelectedIndex = ClassifiedByComboBox.Items.IndexOf(item);
	                }
	            }
	            Department department = departments.Where((x) => x.Id == Ev.DepartmentId).First();
	            foreach (String item in DepartmentComboBox.Items)
	            {
	                if (item == department.Name)
	                {
	                    DepartmentComboBox.SelectedIndex = DepartmentComboBox.Items.IndexOf(item);
	                }
	            }
	            Category category = categories.Where((x) => x.Id == Ev.EventCategoryId).First();

	            foreach (String item in CategoryComboBox.Items)
	            {
	                if (item == category.Name)
	                {
	                    CategoryComboBox.SelectedIndex = CategoryComboBox.Items.IndexOf(item);
	                }
	            }
	            this.eventDate.Value = Ev.EventDateTime;
	            this.reg_id.Text = Ev.Id.Value.ToString();
	            this.ShortDescription.Text = Ev.Description;
	        }
	        else
	        {
	            this.eventDate.Value = DateTime.Now;
	        }
            UpdateReportLabel();
	    }

	    private void RegisteredByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = users.First(x => x.Name == (sender as ComboBox).SelectedItem.ToString());
            Ev.RegisteredBy = user.Id;
        }

        private void reg_id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var department = departments.First(x => x.Name == (sender as ComboBox).SelectedItem.ToString());
            Ev.DepartmentId = department.Id;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = categories.First(x => x.Name == (sender as ComboBox).SelectedItem.ToString());
            Ev.EventCategoryId = category.Id;
        }

        private void ClassifiedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = users.First(x => x.Name == (sender as ComboBox).SelectedItem.ToString());
            Ev.ClassifiedBy = user.Id;
        }

        private void ShortDescription_TextChanged(object sender, EventArgs e)
        {
            Ev.Description = (sender as RichTextBox).Text;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPageReportForm mainPageReportForm = new MainPageReportForm();
            mainPageReportForm.ShowDialog();
        }

        private void OpenReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Ev.Report);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!this.Ev.Id.HasValue)
            {
                this.Save();
            }
            JournalMeasureForm measures = new JournalMeasureForm();
            measures.EventId = this.Ev.Id.Value;
            measures.Closed += measures_Closed;
            measures.ShowDialog();
            this.Hide();
        }

        void measures_Closed(object sender, EventArgs e)
        {
            this.Show();
        }
	}
}
