namespace General_Ledger
{
    partial class ChartView
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normalSideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCatergoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountSubCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCreationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCreationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartOfAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalLedgerDataSet3 = new General_Ledger.GeneralLedgerDataSet3();
            this.generalLedgerDataSet = new General_Ledger.GeneralLedgerDataSet();
            this.generalLedgerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalLedgerDataSet2 = new General_Ledger.GeneralLedgerDataSet2();
            this.generalLedgerDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartOfAccountsTableAdapter = new General_Ledger.GeneralLedgerDataSet3TableAdapters.ChartOfAccountsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLedgerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLedgerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLedgerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLedgerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLedgerDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(728, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chart View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNameDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.accountDescriptionDataGridViewTextBoxColumn,
            this.normalSideDataGridViewTextBoxColumn,
            this.accountCatergoryDataGridViewTextBoxColumn,
            this.accountSubCategoryDataGridViewTextBoxColumn,
            this.initialBalanceDataGridViewTextBoxColumn,
            this.debitDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.accountCreationDateDataGridViewTextBoxColumn,
            this.accountCreationTimeDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.statementDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chartOfAccountsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1542, 624);
            this.dataGridView1.TabIndex = 1;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            this.accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.HeaderText = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            // 
            // accountDescriptionDataGridViewTextBoxColumn
            // 
            this.accountDescriptionDataGridViewTextBoxColumn.DataPropertyName = "AccountDescription";
            this.accountDescriptionDataGridViewTextBoxColumn.HeaderText = "AccountDescription";
            this.accountDescriptionDataGridViewTextBoxColumn.Name = "accountDescriptionDataGridViewTextBoxColumn";
            // 
            // normalSideDataGridViewTextBoxColumn
            // 
            this.normalSideDataGridViewTextBoxColumn.DataPropertyName = "NormalSide";
            this.normalSideDataGridViewTextBoxColumn.HeaderText = "NormalSide";
            this.normalSideDataGridViewTextBoxColumn.Name = "normalSideDataGridViewTextBoxColumn";
            // 
            // accountCatergoryDataGridViewTextBoxColumn
            // 
            this.accountCatergoryDataGridViewTextBoxColumn.DataPropertyName = "AccountCatergory";
            this.accountCatergoryDataGridViewTextBoxColumn.HeaderText = "AccountCatergory";
            this.accountCatergoryDataGridViewTextBoxColumn.Name = "accountCatergoryDataGridViewTextBoxColumn";
            // 
            // accountSubCategoryDataGridViewTextBoxColumn
            // 
            this.accountSubCategoryDataGridViewTextBoxColumn.DataPropertyName = "AccountSubCategory";
            this.accountSubCategoryDataGridViewTextBoxColumn.HeaderText = "AccountSubCategory";
            this.accountSubCategoryDataGridViewTextBoxColumn.Name = "accountSubCategoryDataGridViewTextBoxColumn";
            // 
            // initialBalanceDataGridViewTextBoxColumn
            // 
            this.initialBalanceDataGridViewTextBoxColumn.DataPropertyName = "InitialBalance";
            this.initialBalanceDataGridViewTextBoxColumn.HeaderText = "InitialBalance";
            this.initialBalanceDataGridViewTextBoxColumn.Name = "initialBalanceDataGridViewTextBoxColumn";
            // 
            // debitDataGridViewTextBoxColumn
            // 
            this.debitDataGridViewTextBoxColumn.DataPropertyName = "Debit";
            this.debitDataGridViewTextBoxColumn.HeaderText = "Debit";
            this.debitDataGridViewTextBoxColumn.Name = "debitDataGridViewTextBoxColumn";
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // accountCreationDateDataGridViewTextBoxColumn
            // 
            this.accountCreationDateDataGridViewTextBoxColumn.DataPropertyName = "AccountCreationDate";
            this.accountCreationDateDataGridViewTextBoxColumn.HeaderText = "AccountCreationDate";
            this.accountCreationDateDataGridViewTextBoxColumn.Name = "accountCreationDateDataGridViewTextBoxColumn";
            // 
            // accountCreationTimeDataGridViewTextBoxColumn
            // 
            this.accountCreationTimeDataGridViewTextBoxColumn.DataPropertyName = "AccountCreationTime";
            this.accountCreationTimeDataGridViewTextBoxColumn.HeaderText = "AccountCreationTime";
            this.accountCreationTimeDataGridViewTextBoxColumn.Name = "accountCreationTimeDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            // 
            // statementDataGridViewTextBoxColumn
            // 
            this.statementDataGridViewTextBoxColumn.DataPropertyName = "Statement";
            this.statementDataGridViewTextBoxColumn.HeaderText = "Statement";
            this.statementDataGridViewTextBoxColumn.Name = "statementDataGridViewTextBoxColumn";
            // 
            // chartOfAccountsBindingSource
            // 
            this.chartOfAccountsBindingSource.DataMember = "ChartOfAccounts";
            this.chartOfAccountsBindingSource.DataSource = this.generalLedgerDataSet3;
            // 
            // generalLedgerDataSet3
            // 
            this.generalLedgerDataSet3.DataSetName = "GeneralLedgerDataSet3";
            this.generalLedgerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generalLedgerDataSet
            // 
            this.generalLedgerDataSet.DataSetName = "GeneralLedgerDataSet";
            this.generalLedgerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generalLedgerDataSetBindingSource
            // 
            this.generalLedgerDataSetBindingSource.DataSource = this.generalLedgerDataSet;
            this.generalLedgerDataSetBindingSource.Position = 0;
            // 
            // generalLedgerDataSet2
            // 
            this.generalLedgerDataSet2.DataSetName = "GeneralLedgerDataSet2";
            this.generalLedgerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generalLedgerDataSet2BindingSource
            // 
            this.generalLedgerDataSet2BindingSource.DataSource = this.generalLedgerDataSet2;
            this.generalLedgerDataSet2BindingSource.Position = 0;
            // 
            // chartOfAccountsTableAdapter
            // 
            this.chartOfAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(733, 751);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 842);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ChartView";
            this.Text = "ChartView";
            this.Load += new System.EventHandler(this.ChartView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLedgerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLedgerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLedgerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLedgerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLedgerDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GeneralLedgerDataSet generalLedgerDataSet;
        private System.Windows.Forms.BindingSource generalLedgerDataSetBindingSource;
        private GeneralLedgerDataSet2 generalLedgerDataSet2;
        private System.Windows.Forms.BindingSource generalLedgerDataSet2BindingSource;
        private GeneralLedgerDataSet3 generalLedgerDataSet3;
        private System.Windows.Forms.BindingSource chartOfAccountsBindingSource;
        private GeneralLedgerDataSet3TableAdapters.ChartOfAccountsTableAdapter chartOfAccountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn normalSideDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCatergoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountSubCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCreationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCreationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statementDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}