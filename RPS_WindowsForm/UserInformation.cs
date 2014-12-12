/******************************************************************************
 * Keith Emery
 * IS 253
 * 2014/11/23
 * UserInformation.cs presents a form to collect user ID, First and Last Name.
 * The form allows the user to navigate through the User's table, add, remove 
 * and update records.
 * 
 * NOTE:    Considerable code that has been commented has been left for evaluation
 *          purposes.
 * 
 * ***************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace RPS_WindowsForm
{
    public partial class UserInformation : BaseForm
    {
        
        public UserInformation()
        {
            InitializeComponent();
        }

        // An early attempt
  /*      private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);
        } */

        DatabaseConnection objConnect;      // an object for the connection through which the form communicates with the database
        string conString;                   // the connection string (saved in project properties)

        DataSet dataSet;                    // the intermediate between DB Table data and form data
        DataRow dataRow;                    // a specific table row that can be manipulated

        int MaxRows;                        // used for navigation
        int inc = 0;                        // used to track location in the table when navigating

        /// <summary>
        /// Load form level data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void UserInformation_Load(object sender, EventArgs e)
        {            
            // Used in an early attempt, may be useful later
            //this.usersTableAdapter.Fill(this.usersDataSet.Users);

            // get a connection
            try
            {
                objConnect = new DatabaseConnection();
                conString = Properties.Settings.Default.UsersConnectionString;
                objConnect.connection_string = conString;
                objConnect.Sql = Properties.Settings.Default.SQL;
                dataSet = objConnect.GetConnection;
      //        DataTable t = dataSet.Tables[0]; // Tried this to perform an explicit commit
  
                MaxRows = dataSet.Tables[0].Rows.Count; // Tried changing index to Users from 0
                MessageBox.Show("rows in the table: " + MaxRows.ToString());    // troubleshooting feedback
                NavigateRecords();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// Handles navigational capabilities for Next, First, Last buttons by displaying the data for the current record.
        /// </summary>
        private void NavigateRecords()
        {
            MessageBox.Show("value of inc = " + inc.ToString() + "\n" + "value of MaxRows = " + MaxRows.ToString());
            dataRow = dataSet.Tables[0].Rows[inc];
            txt_ID.Text = dataRow.ItemArray.GetValue(0).ToString();
            txt_firstName.Text = dataRow.ItemArray.GetValue(1).ToString();
            txt_lastName.Text = dataRow.ItemArray.GetValue(2).ToString();
 //         dataRow = dataSet.Tables[0].Rows[inc];
        }

        /// <summary>
        /// Saves entries from textboxes to database (needs validation validation procedure).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saveData_Click(object sender, EventArgs e)
        {

            // Adds a row to the Table
     /*       DataRow row = dataSet.Tables[0].NewRow();  // changed index from 0 to "Users"
            row[0] = txt_ID.Text;
            row[1] = txt_firstName.Text;
            row[2] = txt_lastName.Text;
            dataSet.Tables[0].Rows.Add(row);  // changed index from 0 to "Users" */

            /***************************
            SqlConnection connection = new SqlConnection(conString); // for commit
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            SqlTransaction transaction;
            transaction = connection.BeginTransaction("Users");
            command.Connection = connection;
            command.Transaction = transaction;
            /***************************/

            try
            {
                // Trying to explicitly insert data.
                /**************************************************************************/

                string cmdString = "INSERT INTO Users (Id, firstName, lastName) VALUES (@val1, @val2, @val3)";
                string connString = conString;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = cmdString;
                        comm.Parameters.AddWithValue("@val1", txt_ID.Text);
                        comm.Parameters.AddWithValue("@val2", txt_firstName.Text);
                        comm.Parameters.AddWithValue("@val3", txt_lastName.Text);
                        try
                        {
                            conn.Open();
                            comm.ExecuteNonQuery();
               //             comm.CommandText = "commit";
                            this.tableAdapterManager.UpdateAll(this.usersDataSet);
                            MaxRows++;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message + "inside literals block");
                        }
                    }
                }
                /**************************************************************************/


                objConnect.UpdateDatabase(dataSet);
                dataSet.AcceptChanges();                // commit changes
   //             transaction.Commit();
                MaxRows += 1;
                inc = MaxRows - 1;
                
            MessageBox.Show("Database Updated");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            btn_cancel.Enabled = false;
            btn_saveData.Enabled = false;
            btn_addNew.Enabled = true;
        }

        /// <summary>
        /// Adds a new user to the database and manages buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addNew_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            txt_ID.Focus();
            txt_firstName.Clear();
            txt_lastName.Clear();

            btn_addNew.Enabled = false;
            btn_saveData.Enabled = true;
            btn_cancel.Enabled = true;
        }

        /// <summary>
        /// Cancels the current event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            NavigateRecords();
            btn_cancel.Enabled = false;
            btn_saveData.Enabled = false;
            btn_addNew.Enabled = true;
        }

        /// <summary>
        /// Moves cursor to the next row in the Table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_next_Click(object sender, EventArgs e)
        {
            if(inc != MaxRows - 1)
            {
                inc++;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("No more rows.");
            }
        }

        /// <summary>
        /// Moves the cursor backward in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            if(inc > 0)
            {
                inc--;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("First Record");
            }
        }

        /// <summary>
        /// Moves the cursor to the first record in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_first_Click(object sender, EventArgs e)
        {
            if(inc != 0)
            {
                inc = 0;
                NavigateRecords();
            }
        }

        /// <summary>
        /// Moves the cursor to the last record in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_last_Click(object sender, EventArgs e)
        {
            if(inc != MaxRows - 1)
            {
                inc = MaxRows - 1;
                NavigateRecords();
            }
        }

        /// <summary>
        /// Places the current content from the form in the appropriate row in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet.Tables[0].Rows[inc];

            row[0] = txt_ID.Text;
            row[1] = txt_firstName.Text;
            row[2] = txt_lastName.Text;

            try
            {
                objConnect.UpdateDatabase(dataSet);
                MessageBox.Show("Record Updated");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// Deletes the current record from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet.Tables[0].Rows[inc].Delete();
                objConnect.UpdateDatabase(dataSet);

                MaxRows = dataSet.Tables[0].Rows.Count;
                inc--;
                NavigateRecords();

                MessageBox.Show("Record Deleted");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// Loads the game menu screen and closes this window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_continue_Click(object sender, EventArgs e)
        {
            ChooseGame game = new ChooseGame();
            game.Show();
            this.Close();
        }

    }
}

