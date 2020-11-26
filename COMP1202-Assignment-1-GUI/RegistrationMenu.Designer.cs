namespace COMP1202_Assignment_1_GUI
{
    partial class RegistrationMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEvents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.dgvRegistrations = new System.Windows.Forms.DataGridView();
            this.rowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddRSVP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRegistrations);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddRSVP);
            this.groupBox2.Controls.Add(this.btnBackToMenu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbEvents);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbCustomers);
            this.groupBox2.Location = new System.Drawing.Point(12, 439);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add RSVP";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackToMenu.Location = new System.Drawing.Point(375, 139);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(87, 23);
            this.btnBackToMenu.TabIndex = 4;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event";
            // 
            // cmbEvents
            // 
            this.cmbEvents.FormattingEnabled = true;
            this.cmbEvents.Location = new System.Drawing.Point(135, 77);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Size = new System.Drawing.Size(327, 21);
            this.cmbEvents.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(135, 27);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(327, 21);
            this.cmbCustomers.TabIndex = 0;
            // 
            // dgvRegistrations
            // 
            this.dgvRegistrations.AllowUserToAddRows = false;
            this.dgvRegistrations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistrations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowID,
            this.rowEvent,
            this.rowCustomer,
            this.rowDate});
            this.dgvRegistrations.Location = new System.Drawing.Point(6, 19);
            this.dgvRegistrations.Name = "dgvRegistrations";
            this.dgvRegistrations.RowHeadersVisible = false;
            this.dgvRegistrations.RowHeadersWidth = 51;
            this.dgvRegistrations.Size = new System.Drawing.Size(485, 397);
            this.dgvRegistrations.TabIndex = 1;
            // 
            // rowID
            // 
            this.rowID.HeaderText = "ID";
            this.rowID.Name = "rowID";
            // 
            // rowEvent
            // 
            this.rowEvent.HeaderText = "Event";
            this.rowEvent.Name = "rowEvent";
            // 
            // rowCustomer
            // 
            this.rowCustomer.HeaderText = "Customer";
            this.rowCustomer.Name = "rowCustomer";
            // 
            // rowDate
            // 
            this.rowDate.HeaderText = "Date";
            this.rowDate.Name = "rowDate";
            // 
            // btnAddRSVP
            // 
            this.btnAddRSVP.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddRSVP.Location = new System.Drawing.Point(221, 139);
            this.btnAddRSVP.Name = "btnAddRSVP";
            this.btnAddRSVP.Size = new System.Drawing.Size(87, 23);
            this.btnAddRSVP.TabIndex = 5;
            this.btnAddRSVP.Text = "Add RSVP";
            this.btnAddRSVP.UseVisualStyleBackColor = false;
            this.btnAddRSVP.Click += new System.EventHandler(this.btnAddRSVP_Click);
            // 
            // RegistrationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrationMenu";
            this.Text = "RegistrationMenu";
            this.Load += new System.EventHandler(this.RegistrationMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.DataGridView dgvRegistrations;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDate;
        private System.Windows.Forms.Button btnAddRSVP;
    }
}