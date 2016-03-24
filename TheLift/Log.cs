using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using static TheLift.GlobalVariables;

namespace TheLift
{
    public partial class Log : Form
    {
        public Log()
        {
            //Initializes All the components
            InitializeComponent();
            //This makes sure that the user cannot resize the program
            FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void Log_Load(object sender, EventArgs e)
        {
            //This will refresh the list once Log is loaded.
            refreshList();
        }


        public void refreshList()
        {
            //Initializes new string called dbConnection
            string dbConnection = null;
            //Creates a new OleDbConnection called connection
            OleDbConnection connection;
            //Create a new OleDbAdapter called oledbAdapter
            OleDbDataAdapter oledbAdapter;
            //Creates new dataset called ds for the database results
            DataSet ds = new DataSet();
            //This is the string that identifies the connection of the database
            dbConnection = "Provider=" + providerPath + ";" + @"data source="+ dbPath +"";
            //This identifies the variable connection as a new OleDbConnection containing the dbConnection string
            connection = new OleDbConnection(dbConnection);
            //This will try to select all the records from the database and it will add them to listview
            try
            {
                //This will open the connection to the database 
                connection.Open();
                //This willl identifiy the adapter with the sql statement
                oledbAdapter = new OleDbDataAdapter("SELECT * from Operations ORDER BY OperationID DESC", connection);
                //This will fill the adapter into the dataset
                oledbAdapter.Fill(ds);
                //This will dispose of the adapter
                oledbAdapter.Dispose();
                //This will close the connection with the database
                connection.Close();
                DataTable dtable = ds.Tables[0];
                listView1.Items.Clear();
                // Display items in the ListView control
                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    // Only row that have not been deleted
                    if (drow.RowState != DataRowState.Deleted)
                    {
                        // Define the list items
                        ListViewItem lvi = new ListViewItem(drow["OperationID"].ToString());
                        lvi.SubItems.Add(drow["ElevatorStatus"].ToString());
                        lvi.SubItems.Add(drow["OperationTime"].ToString());
                        lvi.SubItems.Add(drow["OperationDate"].ToString());

                        // Add the list items to the ListView
                        listView1.Items.Add(lvi);
                    }
                    var max = listView1.Items.Cast<ListViewItem>().Max(x => int.Parse(x.SubItems[0].Text));
                }
            }
            //This will catch a error if one occurs within the statement
            catch (Exception a)
            {
                //This will display the error in a messagebox
                MessageBox.Show("Error" + a);

            }

        }

        }
    }

