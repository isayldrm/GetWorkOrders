using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkOrders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OracleConnection conn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.105)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=INFOR)));user id=CLONE; Password=CLONE; ");
        DataTable dbListe = new DataTable("Work Orders");

        private void Form1_Load(object sender, EventArgs e)
        {
            GetRecord();
        }

        public void GetRecord()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                
                using (OracleDataAdapter adapter = new OracleDataAdapter("select evt_code, uco_desc, UCO_TEXTCODE from r5events evt inner join r5ucodes uco on (EVT.EVT_STATUS=UCO.UCO_CODE)", conn))
                {
                    adapter.Fill(dbListe);
                    WorkOrderList.DataSource = dbListe;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource sourceDesc = new BindingSource();
            sourceDesc.DataSource = WorkOrderList.DataSource;
            sourceDesc.Filter = "EVT_CODE LIKE '%" + txtSearch.Text + "%'";
            WorkOrderList.DataSource = sourceDesc;
        }

        int evtCode;
      
        private void WorkOrderList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //info tab for work order
            try
            {
                evtCode = Convert.ToInt32(WorkOrderList.Rows[WorkOrderList.CurrentRow.Index].Cells["EVT_CODE"].Value);


                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string record = "SELECT * FROM R5EVENTS WHERE EVT_CODE=:CODE";
                OracleCommand command = new OracleCommand(record, conn);
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("CODE", evtCode));
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtInfo.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //comments tab for work order
            try
            {
                evtCode = Convert.ToInt32(WorkOrderList.Rows[WorkOrderList.CurrentRow.Index].Cells["EVT_CODE"].Value);


                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string record = "SELECT * FROM R5ADDETAILS WHERE ADD_CODE=:CODE";
                OracleCommand command = new OracleCommand(record, conn);
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("CODE", evtCode));
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtComments.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //BookedHours tab for work order
            try
            {
                evtCode = Convert.ToInt32(WorkOrderList.Rows[WorkOrderList.CurrentRow.Index].Cells["EVT_CODE"].Value);


                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string record = "SELECT * FROM R5BOOKEDHOURS WHERE BOO_EVENT=:CODE";
                OracleCommand command = new OracleCommand(record, conn);
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("CODE", evtCode));
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtBookedHours.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Documents tab for work order 
            try
            {
                evtCode = Convert.ToInt32(WorkOrderList.Rows[WorkOrderList.CurrentRow.Index].Cells["EVT_CODE"].Value);


                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string record = "SELECT * FROM R5DOCENTITIES WHERE DAE_CODE=:CODE";
                OracleCommand command = new OracleCommand(record, conn);
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("CODE", evtCode));
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtDocuments.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Materials tab for work order
            try
            {
                evtCode = Convert.ToInt32(WorkOrderList.Rows[WorkOrderList.CurrentRow.Index].Cells["EVT_CODE"].Value);


                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string record = "SELECT * FROM R5TRANSLINES WHERE TRL_EVENT=:CODE";
                OracleCommand command = new OracleCommand(record, conn);
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("CODE", evtCode));
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtMaterials.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Log tab for work order
            try
            {
                evtCode = Convert.ToInt32(WorkOrderList.Rows[WorkOrderList.CurrentRow.Index].Cells["EVT_CODE"].Value);


                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string record = "SELECT * FROM TR_MOBIL_EVENTLOG WHERE EXPLANANTION LIKE :CODE";
                OracleCommand command = new OracleCommand(record, conn);
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("CODE", evtCode));
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtLogs.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Control tab for work order
            try
            {
                evtCode = Convert.ToInt32(WorkOrderList.Rows[WorkOrderList.CurrentRow.Index].Cells["EVT_CODE"].Value);


                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string record = "SELECT * FROM R5ACTCHECKLISTS WHERE ACK_EVENT =:CODE";
                OracleCommand command = new OracleCommand(record, conn);
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("CODE", evtCode));
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtControlLists.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Activity tab for work order
            try
            {
                evtCode = Convert.ToInt32(WorkOrderList.Rows[WorkOrderList.CurrentRow.Index].Cells["EVT_CODE"].Value);


                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string record = "select * from R5ACTIVITIES where act_event =:CODE";
                OracleCommand command = new OracleCommand(record, conn);
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("CODE", evtCode));
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtActivity.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
