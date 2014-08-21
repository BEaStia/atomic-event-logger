using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnomalEvent.Classes;

namespace AnomalEvent
{
	public partial class JournalEventForm : Form
	{
		public JournalEventForm()
		{
			InitializeComponent();
		}

		private void AddNewItemClick(object sender, EventArgs e)
		{
            ProgressAddEventForm addEventForm = new ProgressAddEventForm();
            addEventForm.Closed += addEventForm_Closed;
		    addEventForm.ShowDialog();
		}

        void addEventForm_Closed(object sender, EventArgs e)
        {
            this.Refresh();
            Update();
        }


	    private void JournalEventForm_Load(object sender, EventArgs e)
        {
            if (Authorizer.Instance.Guest == 1)
            {
                bindingNavigatorAddNewItem.Enabled = false;
            }
	        //List<AnEvent> events = AnEvent.StationEvents;
	        Update();
	        var now = DateTime.Now;
	        dateTimePicker1.Value = new DateTime(now.Year,now.Month,1);
	        dateTimePicker2.Value = now;
        }

	    private void Update()
	    {
            DataSet ds = new DataSet();
            var sql = "select * from AnEvents";
            SqlCommand command = new SqlCommand(sql, AnomalEventConnection.Connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
	    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProgressAddEventForm addEventForm = new ProgressAddEventForm();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            List<AnEvent> events = AnEvent.getList();
            var obj = events.Where((x) => x.Id == int.Parse(row.Cells["id"].Value.ToString())).First();
            addEventForm.Ev = obj;
            addEventForm.Closed += addEventForm_Closed;
            addEventForm.ShowDialog();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Sort();
        }

	    void Sort()
	    {
            DataSet ds = new DataSet();
            var sql = "select * from AnEvents";
            SqlCommand command = new SqlCommand(sql, AnomalEventConnection.Connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            DataView dv = ds.Tables[0].DefaultView;
            //dataGridView1.DataSource = dt;
	        dataGridView1.DataSource = dv;
            var query = "EventDateTime > '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") +"' AND EventDateTime < '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss")+"'";
	        dv.RowFilter = query;
	    }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(textBox1.Text);
            var list = from _event in AnEvent.getList() where _event.Id == id select _event;
            var _Event = list.First();

            ProgressAddEventForm addEventForm = new ProgressAddEventForm();
            addEventForm.Ev = _Event;
            addEventForm.Closed += addEventForm_Closed;
            addEventForm.ShowDialog();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProgressAddEventForm addEventForm = new ProgressAddEventForm();
            addEventForm.Ev = AnEvent.getList()[int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())];
            addEventForm.Closed += addEventForm_Closed;
            addEventForm.ShowDialog();
        }

        private void bndMain_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorFindButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }
	}
}
