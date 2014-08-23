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
        public int ExecutorId=-1;
        public int DepartmentId=-1;
        public int EventId=-1;
        public DateTime start;
        public DateTime end;

        public JournalMeasureForm()
        {
            InitializeComponent();
        }

        private void JournalMeasureForm_Load(object sender, EventArgs e)
        {
            start = new DateTime(DateTime.Now.Year,DateTime.Now.Month,1);
            end = DateTime.Now;
            users = User.getList().Where((x) => x.IsPerson == 1).ToList();
            departments = Department.getList();
            events = AnEvent.getList();
            UpdateItems();
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
                foreach (int _id in comboBox3.Items)
                {
                    if (_id == anEvent.Id)
                    {
                        comboBox3.SelectedIndex = comboBox3.Items.IndexOf(_id);
                    }
                }
            }
        }

        public new void Update()
        {
            UpdateItems();
            base.Update();
        }

        private void UpdateItems()
        {
            DataSet ds = new DataSet();
            var query = "select [Id] as 'Номер' ,[Name] as 'Наименование' " +
                      ",[Ex_Name] as 'Исполнитель', [Dep_Name] as 'Цех' ," +
                      "[Cur_Name] as 'Куратор' ,[DateEnd] as 'Дата' ,[Content] as 'Содержание' ,[ExecutionStatus] as 'Статус выполнения', " +
                      "[EventId] as 'Номер события' " +
                      "from CorrectiveMeasures"
                      +
                      " INNER JOIN (SELECT Id as Ex_Id, Name as Ex_Name FROM Users) table1 ON CorrectiveMeasures.ExecutorId=table1.Ex_Id" +
                      " INNER JOIN (SELECT Id as Cur_Id, Name as Cur_Name FROM Users) table2 ON CorrectiveMeasures.CuratorId=table2.Cur_Id" +
                      " INNER JOIN (SELECT ID as Dep_Id, Name as Dep_Name FROM Users) table3 ON CorrectiveMeasures.DepartmentId=table3.Dep_Id" +
                      " WHERE DateEnd > '" + start.ToString("yyyy-MM-dd HH:mm:ss") + "' AND DateEnd < '" +
                      end.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                    if (DepartmentId != -1)
                    {
                        query += " AND Dep_Id = " + DepartmentId;
                    }
                    if (ExecutorId != -1)
                    {
                        query += " AND Ex_Id = " + ExecutorId;
                    }
                    if (EventId != -1)
                    {
                        query += " AND EventId = " + EventId;
                    }
            SqlCommand command = new SqlCommand(query, AnomalEventConnection.Connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            DataView dv = ds.Tables[0].DefaultView;
            dataGridView1.DataSource = dv;
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
            var name = int.Parse((sender as ComboBox).SelectedItem.ToString());
            this.EventId = name;
            UpdateItems();
        }

        private void bndMain_RefreshItems(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = (sender as ComboBox).SelectedItem;
            this.DepartmentId = departments.First((x) => x.Name == name).Id.Value;
            UpdateItems();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = (sender as ComboBox).SelectedItem;
            this.ExecutorId = users.First((x) => x.Name == name).Id.Value;
            UpdateItems();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            start = (sender as DateTimePicker).Value;
            UpdateItems();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            end = (sender as DateTimePicker).Value;
            UpdateItems();
        }


    }
}
