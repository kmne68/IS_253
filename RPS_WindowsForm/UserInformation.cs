using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;

namespace RPS_WindowsForm
{
    public partial class UserInformation : BaseForm
    {

/*        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RPS_Form());
        }  
*/        
        public UserInformation()
        {
            InitializeComponent();
        }


        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);
        }

        DatabaseConnection objConnect;
        string conString;

        DataSet dataSet;
        DataRow dataRow;

        int MaxRows;
        int inc = 0;

        private void UserInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Users' table. You can move, or remove it, as needed.
            
    //        this.usersTableAdapter.Fill(this.usersDataSet.Users);

            try
            {
                objConnect = new DatabaseConnection();
                conString = Properties.Settings.Default.UsersConnectionString;

                objConnect.connection_string = conString;
                objConnect.Sql = Properties.Settings.Default.SQL;

                dataSet = objConnect.GetConnection;
                MaxRows = dataSet.Tables[0].Rows.Count;
                MessageBox.Show("rows in the table: " + MaxRows.ToString());
                NavigateRecords();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

                private void NavigateRecords()
                {
                    dataRow = dataSet.Tables[0].Rows[inc];
                    txt_ID.Text = dataRow.ItemArray.GetValue(0).ToString();
                    txt_firstName.Text = dataRow.ItemArray.GetValue(1).ToString();
                    txt_lastName.Text = dataRow.ItemArray.GetValue(2).ToString();
           //         dataRow = dataSet.Tables[0].Rows[inc];
                }

        private void btn_saveData_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet.Tables[0].NewRow();
            row[0] = txt_ID.Text;
            row[1] = txt_firstName.Text;
            row[2] = txt_lastName.Text;
            dataSet.Tables[0].Rows.Add(row);

            try
            {
                objConnect.UpdateDatabase(dataSet);

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

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            txt_firstName.Clear();
            txt_lastName.Clear();

            btn_addNew.Enabled = false;
            btn_saveData.Enabled = true;
            btn_cancel.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            NavigateRecords();
            btn_cancel.Enabled = false;
            btn_saveData.Enabled = false;
            btn_addNew.Enabled = true;
        }

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

        private void btn_first_Click(object sender, EventArgs e)
        {
            if(inc != 0)
            {
                inc = 0;
                NavigateRecords();
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            if(inc != MaxRows - 1)
            {
                inc = MaxRows - 1;
                NavigateRecords();
            }
        }

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

        private void btn_continue_Click(object sender, EventArgs e)
        {
            RPS_Form rps = new RPS_Form();
            rps.Show();
        }
    }
}
