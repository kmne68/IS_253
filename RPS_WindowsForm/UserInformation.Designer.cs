using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace RPS_WindowsForm
{
    partial class UserInformation : BaseForm
    {
 
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new RPS_WindowsForm.UsersDataSet();
            this.btn_saveData = new System.Windows.Forms.Button();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new RPS_WindowsForm.UsersDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new RPS_WindowsForm.UsersDataSetTableAdapters.TableAdapterManager();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.txt_firstName);
            this.pnl_main.Controls.Add(lastNameLabel);
            this.pnl_main.Controls.Add(firstNameLabel);
            this.pnl_main.Controls.Add(idLabel);
            this.pnl_main.Controls.Add(this.txt_ID);
            this.pnl_main.Controls.Add(this.txt_lastName);
            // 
            // btn_continue
            // 
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(51, 71);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 18);
            idLabel.TabIndex = 6;
            idLabel.Text = "Id:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(51, 111);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(73, 18);
            firstNameLabel.TabIndex = 8;
            firstNameLabel.Text = "first Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(51, 150);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(69, 18);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "last Name:";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_saveData
            // 
            this.btn_saveData.Enabled = false;
            this.btn_saveData.Location = new System.Drawing.Point(550, 313);
            this.btn_saveData.Margin = new System.Windows.Forms.Padding(4);
            this.btn_saveData.Name = "btn_saveData";
            this.btn_saveData.Size = new System.Drawing.Size(112, 32);
            this.btn_saveData.TabIndex = 5;
            this.btn_saveData.Text = "Save";
            this.btn_saveData.UseVisualStyleBackColor = true;
            this.btn_saveData.Click += new System.EventHandler(this.btn_saveData_Click);
            // 
            // btn_addNew
            // 
            this.btn_addNew.Location = new System.Drawing.Point(381, 313);
            this.btn_addNew.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(112, 32);
            this.btn_addNew.TabIndex = 12;
            this.btn_addNew.Text = "Add New";
            this.btn_addNew.UseVisualStyleBackColor = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Enabled = false;
            this.btn_cancel.Location = new System.Drawing.Point(724, 313);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 32);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(181, 67);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(148, 25);
            this.txt_ID.TabIndex = 14;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(181, 107);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(148, 25);
            this.txt_firstName.TabIndex = 15;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(181, 146);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(148, 25);
            this.txt_lastName.TabIndex = 16;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gameInstancesTableAdapter = null;
            this.tableAdapterManager.GamesTableAdapter = null;
            this.tableAdapterManager.OutcomesTableAdapter = null;
            this.tableAdapterManager.RPSThrowsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RPS_WindowsForm.UsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(20, 313);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(112, 32);
            this.btn_next.TabIndex = 17;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(201, 313);
            this.btn_previous.Margin = new System.Windows.Forms.Padding(4);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(112, 32);
            this.btn_previous.TabIndex = 18;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(20, 384);
            this.btn_first.Margin = new System.Windows.Forms.Padding(4);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(112, 32);
            this.btn_first.TabIndex = 19;
            this.btn_first.Text = "First";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(201, 384);
            this.btn_last.Margin = new System.Windows.Forms.Padding(4);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(112, 32);
            this.btn_last.TabIndex = 20;
            this.btn_last.Text = "Last";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(381, 384);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 32);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(550, 384);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 32);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addNew);
            this.Controls.Add(this.btn_saveData);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserInformation";
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.UserInformation_Load);
            this.Controls.SetChildIndex(this.btn_saveData, 0);
            this.Controls.SetChildIndex(this.btn_addNew, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.btn_next, 0);
            this.Controls.SetChildIndex(this.btn_previous, 0);
            this.Controls.SetChildIndex(this.btn_first, 0);
            this.Controls.SetChildIndex(this.btn_last, 0);
            this.Controls.SetChildIndex(this.btn_update, 0);
            this.Controls.SetChildIndex(this.btn_delete, 0);
            this.Controls.SetChildIndex(this.btn_continue, 0);
            this.Controls.SetChildIndex(this.pnl_main, 0);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UsersDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private UsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_saveData;
        private Button btn_addNew;
        private Button btn_cancel;
        private TextBox txt_ID;
        private TextBox txt_firstName;
        private TextBox txt_lastName;
        private Button btn_next;
        private Button btn_previous;
        private Button btn_first;
        private Button btn_last;
        private Button btn_update;
        private Button btn_delete;
    }
}
