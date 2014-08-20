using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnomalEvent.Classes;

namespace AnomalEvent.Forms
{
    public partial class JournalMeasureForm : Form
    {
        private List<Department> departments;
        private List<AnEvent> events;
        private List<User> users;
        public int ExecutorId;
        public int DepartmentId;
        public int EventId; 

        public JournalMeasureForm()
        {
            InitializeComponent();
        }

        private void JournalMeasureForm_Load(object sender, EventArgs e)
        {
            users = User.getList().Where((x) => x.IsPerson == 1).ToList();
            departments = Department.getList();
            events = AnEvent.getList();
            Update();
            foreach (var user in users)
            {
                comboBox1.Items.Add(user.Name);
            }
            foreach (var department in departments)
            {
                comboBox2.Items.Add(department.Name);
            }
            foreach (var anEvent in events)
            {
                comboBox3.Items.Add(anEvent.Id);
            }
            if (EventId != null && EventId != 0)
            {
                AnEvent anEvent = events.First(x => x.Id == this.EventId);
                foreach (String item in comboBox3.Items)
                {
                    if (item == anEvent.Id.ToString())
                    {
                        comboBox3.SelectedIndex = comboBox3.Items.IndexOf(item);
                    }
                }
            }
        }

        private void Update()
        {
            DataSet ds = new DataSet();
            var sql = "select * from CorrectiveMeasure";
            SqlCommand command = new SqlCommand(sql, AnomalEventConnection.Connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            CorrectiveActionReportForm reportForm = new CorrectiveActionReportForm();
            reportForm.anEvent = new AnEvent();
            reportForm.anEvent.Id = int.Parse(comboBox3.SelectedItem.ToString());
            reportForm.Closed += addEventForm_Closed;
            reportForm.ShowDialog();
        }

        private void addEventForm_Closed(object sender, EventArgs e)
        {
            this.Refresh();
            Update();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
                    
        }


    }
}
