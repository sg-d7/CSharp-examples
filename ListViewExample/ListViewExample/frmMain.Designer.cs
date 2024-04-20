
namespace ListViewExample
{
    partial class frmMain
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
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Text Item 1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Text Item 2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Text Item 3"}, -1);
            this.lvDesignTime = new System.Windows.Forms.ListView();
            this.lvRunTime = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFillUp = new System.Windows.Forms.Button();
            this.btnDeleteSel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDesignTime
            // 
            this.lvDesignTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDesignTime.FullRowSelect = true;
            this.lvDesignTime.GridLines = true;
            this.lvDesignTime.HideSelection = false;
            this.lvDesignTime.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15});
            this.lvDesignTime.Location = new System.Drawing.Point(15, 46);
            this.lvDesignTime.Name = "lvDesignTime";
            this.lvDesignTime.Size = new System.Drawing.Size(341, 262);
            this.lvDesignTime.TabIndex = 0;
            this.lvDesignTime.UseCompatibleStateImageBehavior = false;
            this.lvDesignTime.View = System.Windows.Forms.View.Details;
            // 
            // lvRunTime
            // 
            this.lvRunTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvRunTime.FullRowSelect = true;
            this.lvRunTime.GridLines = true;
            this.lvRunTime.HideSelection = false;
            this.lvRunTime.Location = new System.Drawing.Point(378, 46);
            this.lvRunTime.Name = "lvRunTime";
            this.lvRunTime.Size = new System.Drawing.Size(341, 262);
            this.lvRunTime.TabIndex = 1;
            this.lvRunTime.UseCompatibleStateImageBehavior = false;
            this.lvRunTime.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listview View: Detail\r\nDesign time fill up items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Text";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "#";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Text";
            this.columnHeader4.Width = 200;
            // 
            // btnFillUp
            // 
            this.btnFillUp.Location = new System.Drawing.Point(378, 314);
            this.btnFillUp.Name = "btnFillUp";
            this.btnFillUp.Size = new System.Drawing.Size(123, 23);
            this.btnFillUp.TabIndex = 4;
            this.btnFillUp.Text = "Add 10 item";
            this.btnFillUp.UseVisualStyleBackColor = true;
            this.btnFillUp.Click += new System.EventHandler(this.btnFillUp_Click);
            // 
            // btnDeleteSel
            // 
            this.btnDeleteSel.Location = new System.Drawing.Point(507, 314);
            this.btnDeleteSel.Name = "btnDeleteSel";
            this.btnDeleteSel.Size = new System.Drawing.Size(123, 23);
            this.btnDeleteSel.TabIndex = 5;
            this.btnDeleteSel.Text = "Delete selected";
            this.btnDeleteSel.UseVisualStyleBackColor = true;
            this.btnDeleteSel.Click += new System.EventHandler(this.btnDeleteSel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 350);
            this.Controls.Add(this.btnDeleteSel);
            this.Controls.Add(this.btnFillUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvRunTime);
            this.Controls.Add(this.lvDesignTime);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDesignTime;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvRunTime;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFillUp;
        private System.Windows.Forms.Button btnDeleteSel;
    }
}

