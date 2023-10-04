using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACE.BIT.ADEV;
using Yang.Jiajia.Business;
using System.Data.OleDb;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

/*
 * Name: Jiajia Yang
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 5
 * Created: 2023-04-18
 * Updated: 2023-04-21
 * This code still with some problem : when same edit action happened, user must click enter or click other button so that the data will be saved.
 */

namespace Yang.Jiajia.RRCAGApp
{


    public partial class VehicleDataForm : ACE.BIT.ADEV.Forms.VehicleDataForm
    {
        private OleDbConnection connection;

        private OleDbCommand command;

        private OleDbDataAdapter adapter;

        private DataTable dataTable;

        private OleDbCommandBuilder builder;

        private FormClosingEventHandler formClosingEventHandler;


        public VehicleDataForm()
        {
            try
            {
                InitializeComponent();
            }
            catch
            {
                //When an error occurs before the form is shown, a dialog message is shown and the form is closed.
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            //Invoke events:

            this.Load += VehicleDataForm_Load;

            //MnuFileSave is active when the dataTable is modified.
            this.dgvVehicles.CellValueChanged += DgvVehicles_CellValueChanged1;

            //when a row is added in the dgvVehicles, the event will be invoked.
            this.dgvVehicles.UserAddedRow += DgvVehicles_UserAddedRow;

            //Invoke the event when menu save is clicked.
            this.mnuFileSave.Click += MnuFileSave_Click;

            //Invoke the event when menu Close is clicked.
            this.mnuFileClose.Click += MnuFileClose_Click;

            //MnuFileDeleted is active when the selection is changed.
            this.dgvVehicles.SelectionChanged += DgvVehicles_SelectionChanged;
            //Invoke the event when menu delete is clicked.
            this.mnuEditDelete.Click += MnuEditDelete_Click;

            //create a delegate of the closing event handler.When this form is closing (any closing command) the delegate is invoked.
            formClosingEventHandler = new FormClosingEventHandler(VehicleData_FormClosing);
            this.FormClosing += formClosingEventHandler;

        }

        /// <summary>
        /// Occurs when the form load.
        /// </summary>
        private void VehicleDataForm_Load(object sender, EventArgs e)
        {
            //inherit from ACE.BIT.ADEV.Forms.VehicleDataForm
            ////Save menu item disabled
            //this.mnuFileSave.Enabled = false;
            ////Delete menu item disabled
            //this.mnuEditDelete.Enabled = false;

            //title
            this.Text = "Vehicle Data";
            //maximized
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            //DataGridView-inherit from ACE.BIT.ADEV.Forms.VehicleDataForm
            ////Disable the ability for users to delete rows.
            //this.dgvVehicles.AllowUserToDeleteRows = false;
            ////Disable the ability for users to resize rows.
            //this.dgvVehicles.AllowUserToResizeRows = false;
            ////Auto size columns using Fill mode.
            //this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dgvVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            ////Disable the ability for users to select multiple rows.
            //this.dgvVehicles.MultiSelect = false;

            //Populated with all the vehicle data from the database.
            DataPopulated();


        }

        /// <summary>
        /// Occurs when a new row is added, set value for the hidden column soldby as 0 automatically.
        /// </summary>
        private void DgvVehicles_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.dgvVehicles.Rows[e.Row.Index - 1].Cells[9].Value = 0;
        }

        /// <summary>
        /// Occurs when Cell value changed, the menu save item is enabled.
        /// </summary>
        private void DgvVehicles_CellValueChanged1(object sender, DataGridViewCellEventArgs e)
        {
            //this.dgvVehicles.EndEdit();

            this.mnuFileSave.Enabled = true;

        }


        /// <summary>
        /// Initialize the component of this form.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // VehicleDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(1424, 810);
            this.Name = "VehicleDataForm";



            this.ResumeLayout(false);
            this.PerformLayout();

        }


        /// <summary>
        /// Populated with all the vehicle data from the database.
        /// </summary>
        private void DataPopulated()
        {
            try
            {
                //create a connection and open it
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\bin\Debug\DataBase\AMDatabase.mdb;";
                connection = new OleDbConnection(connectionString);
                connection.Open();

                //Initialize a new instance of the OleDbCommand class.
                string query = "SELECT * FROM VehicleStock";
                command = new OleDbCommand(query, connection);

                //Initialize a new instance of the OleDbDataAdapter class.
                adapter = new OleDbDataAdapter(command);

                //Initialize a new instance of the DataSet class.
                dataTable = new DataTable();

                //Fill the DataSet with the information from the table.
                adapter.Fill(dataTable);

                //Populate the DataGridView with the data from the DataTable.
                this.dgvVehicles.DataSource = dataTable;

                //Hide the columns from dgvVhicles
                DataGridViewColumn idColumn = this.dgvVehicles.Columns["ID"];
                DataGridViewColumn soldByColumn = this.dgvVehicles.Columns["SoldBy"];

                idColumn.Visible = false;
                soldByColumn.Visible = false;

                //Close the connection
                connection.Close();
            }
            catch
            {
                //When any exception occurs while retrieving the vehicle data, display the MessageBox
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        /// <summary>
        /// Occurs when the selection is changed, the Delete menu item is enabled if the dataTableView is not empty or new row.
        /// </summary>
        private void DgvVehicles_SelectionChanged(object sender, EventArgs e)
        {

            if (this.dgvVehicles.SelectedRows.Count == 1
                && this.dgvVehicles.CurrentRow != null
                && this.dgvVehicles.CurrentRow.Cells[0].Value != DBNull.Value //make sure the row is not new row,because the new row has no value in the ID column.
                && this.dgvVehicles.CurrentRow.Index >= 0)
            {
                this.Text = "*Vehicle Data";
                this.mnuEditDelete.Enabled = true;
            }
            else
            {

                this.mnuEditDelete.Enabled = false;// the status of the menu item is disabled must be set , otherwise after the first time the menu is enabled, the menu will always be enabled.

                if (this.mnuFileSave.Enabled)
                {
                    this.Text = "*Vehicle Data";
                }
                else
                {
                    this.Text = "Vehicle Data";
                }
            }

        }

        /// <summary>
        /// When the Delete menu item is clicked, the selected row is removed from the DataGridView and deleted from the database.
        /// </summary>
        private void MnuEditDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string stockItem = this.dgvVehicles.CurrentRow.Cells["StockNumber"].Value.ToString();
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to permanently delete stock item " + stockItem + " ?",
                    "Delete Stock Item",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes) // if click yes
                {
                    //The first way to delete the selected row:

                    ////Get the selected row
                    //DataGridViewRow selectedRow = this.dgvVehicles.CurrentRow;
                    ////Get the ID of the selected row
                    //int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    ////Delete the selected row from the database
                    //command = new OleDbCommand("DELETE FROM VehicleStock WHERE ID = @ID", connection);
                    //command.Parameters.AddWithValue("@ID", id);// this means 
                    //adapter.DeleteCommand = command;
                    ////Remove the selected row from the DataGridView
                    //this.dgvVehicles.Rows.Remove(selectedRow);

                    //The second way:
                    builder = new OleDbCommandBuilder(adapter);
                    adapter.DeleteCommand = builder.GetDeleteCommand();
                    dataTable.Rows[this.dgvVehicles.CurrentRow.Index].Delete();

                    adapter.Update(dataTable);

                    this.Text = "Vehicle Data";


                }
                else if (result == DialogResult.No) // if click no
                {
                    //Do nothing
                }


            }
            catch
            {
                //When any exception occurs while updating the database, show a dialog box
                MessageBox.Show(" An error occurred while deleting the selected vehicle.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// Occurs when the Close menu item is clicked, the form is closed.
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        /// <summary>
        /// When the Save menu item is clicked, all data changes are saved to the database. After a successful save, the Save menu item is disabled.
        /// </summary>
        private void MnuFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveChanges();

                this.Text = "Vehicle Data";

                //After a successful save, the Save menu item is disabled.
                this.mnuFileSave.Enabled = false;

            }
            catch
            {
                MessageBox.Show("An error occurred while saving the changes to the vehicle data.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// This event occurs when the FormClosingEventHandler is initialized and then called when the form is closing.
        /// </summary>
        private void VehicleData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.mnuFileSave.Enabled)
            {
                try
                {
                    DialogResult result = MessageBox.Show(
                        "Do you wish to save the changes?",
                        "Save",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button3);

                    if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }

                    if (result == DialogResult.No)
                    {
                        e.Cancel = false;
                    }

                    if (result == DialogResult.Yes)
                    {
                        SaveChanges();

                        e.Cancel = false;
                    }
                }
                catch
                {
                    DialogResult result = MessageBox.Show(
                        "An error occurred while saving the changes. Do you still wish to close?",
                        "Save Error",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }

                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }


            }


            //this.Close(); // this is not necessary, because the form will be closed automatically when the event is completed.otherwise will be invoke this.Closing event again.The iteration will be never end.




        }

        /// <summary>
        /// Method to save changes to the database.
        /// </summary>
        private void SaveChanges()
        {
            //When the Save menu item is clicked, all data changes are saved to the database
            builder = new OleDbCommandBuilder(adapter);//builder is used to generate the command to update the database automatically.

            //determine what the command should be used.????????
            if (command.Equals(DataRowState.Detached))
            {
                adapter.InsertCommand = builder.GetInsertCommand();

                dataTable.Rows[this.dgvVehicles.CurrentRow.Index].SetAdded();
            }

            if (command.Equals(DataRowState.Modified))
            {
                adapter.UpdateCommand = builder.GetUpdateCommand();

                dataTable.Rows[this.dgvVehicles.CurrentRow.Index].SetModified();
            }            
            adapter.Update(dataTable);

            //refresh the dataTable with the latest data from the database.
            dataTable.Clear();
            adapter.Fill(dataTable);


        }


    }
}

   

