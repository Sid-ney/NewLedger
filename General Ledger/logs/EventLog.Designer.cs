namespace General_Ledger.logs
{
    partial class EventLog
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDebitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beforeValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afterValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalLedgerDataSet4 = new General_Ledger.GeneralLedgerDataSet4();
            this.eventLogTableAdapter = new General_Ledger.GeneralLedgerDataSet4TableAdapters.EventLogTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLedgerDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIDDataGridViewTextBoxColumn,
            this.accountTypeDataGridViewTextBoxColumn,
            this.creditDebitDataGridViewTextBoxColumn,
            this.beforeValueDataGridViewTextBoxColumn,
            this.afterValueDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.eventTimeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(325, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1062, 458);
            this.dataGridView1.TabIndex = 0;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            // 
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            // 
            // creditDebitDataGridViewTextBoxColumn
            // 
            this.creditDebitDataGridViewTextBoxColumn.DataPropertyName = "CreditDebit";
            this.creditDebitDataGridViewTextBoxColumn.HeaderText = "CreditDebit";
            this.creditDebitDataGridViewTextBoxColumn.Name = "creditDebitDataGridViewTextBoxColumn";
            // 
            // beforeValueDataGridViewTextBoxColumn
            // 
            this.beforeValueDataGridViewTextBoxColumn.DataPropertyName = "BeforeValue";
            this.beforeValueDataGridViewTextBoxColumn.HeaderText = "BeforeValue";
            this.beforeValueDataGridViewTextBoxColumn.Name = "beforeValueDataGridViewTextBoxColumn";
            // 
            // afterValueDataGridViewTextBoxColumn
            // 
            this.afterValueDataGridViewTextBoxColumn.DataPropertyName = "AfterValue";
            this.afterValueDataGridViewTextBoxColumn.HeaderText = "AfterValue";
            this.afterValueDataGridViewTextBoxColumn.Name = "afterValueDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            // 
            // eventTimeDataGridViewTextBoxColumn
            // 
            this.eventTimeDataGridViewTextBoxColumn.DataPropertyName = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.HeaderText = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.Name = "eventTimeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // eventLogBindingSource
            // 
            this.eventLogBindingSource.DataMember = "EventLog";
            this.eventLogBindingSource.DataSource = this.generalLedgerDataSet4;
            // 
            // generalLedgerDataSet4
            // 
            this.generalLedgerDataSet4.DataSetName = "GeneralLedgerDataSet4";
            this.generalLedgerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventLogTableAdapter
            // 
            this.eventLogTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(756, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Log";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(785, 722);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1713, 860);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EventLog";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLedgerDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GeneralLedgerDataSet4 generalLedgerDataSet4;
        private System.Windows.Forms.BindingSource eventLogBindingSource;
        private GeneralLedgerDataSet4TableAdapters.EventLogTableAdapter eventLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDebitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beforeValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afterValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}