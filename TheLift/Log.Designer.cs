using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
namespace TheLift
{
    partial class Log
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.listView1 = new ListView();
            this.OperationID = ((ColumnHeader)(new ColumnHeader()));
            this.ElevatorStatus = ((ColumnHeader)(new ColumnHeader()));
            this.OperationTime = ((ColumnHeader)(new ColumnHeader()));
            this.OperationDate = ((ColumnHeader)(new ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new ColumnHeader[] {
            this.OperationID,
            this.ElevatorStatus,
            this.OperationTime,
            this.OperationDate});
            this.listView1.Dock = DockStyle.Fill;
            this.listView1.Location = new Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new Size(602, 302);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = View.Details;
            // 
            // OperationID
            // 
            this.OperationID.Text = "Operation ID";
            this.OperationID.Width = 94;
            // 
            // ElevatorStatus
            // 
            this.ElevatorStatus.Text = "Elevator Status";
            this.ElevatorStatus.Width = 195;
            // 
            // OperationTime
            // 
            this.OperationTime.Text = "Operation Time";
            this.OperationTime.Width = 158;
            // 
            // OperationDate
            // 
            this.OperationDate.Text = "Operation Date";
            this.OperationDate.Width = 600;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(602, 302);
            this.Controls.Add(this.listView1);
            this.Name = "Log";
            this.Text = "Log";
            this.Load += new EventHandler(this.Log_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader OperationID;
        private ColumnHeader ElevatorStatus;
        private ColumnHeader OperationTime;
        private ColumnHeader OperationDate;
    }
}