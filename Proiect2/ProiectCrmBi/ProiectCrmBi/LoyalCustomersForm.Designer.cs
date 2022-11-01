namespace ProiectCrmBi
{
    partial class LoyalCustomersForm
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
            this.grdLoyalCustomers = new System.Windows.Forms.DataGridView();
            this.btnLoadLoyalCustomers = new System.Windows.Forms.Button();
            this.modelDataSet = new ProiectCrmBi.ModelDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new ProiectCrmBi.ModelDataSetTableAdapters.CustomerTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfPayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyOfSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueOfSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoyalCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLoyalCustomers
            // 
            this.grdLoyalCustomers.AccessibleName = "grdLoyalCustomers";
            this.grdLoyalCustomers.AutoGenerateColumns = false;
            this.grdLoyalCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLoyalCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.typeOfPayerDataGridViewTextBoxColumn,
            this.frequencyOfSalesDataGridViewTextBoxColumn,
            this.valueOfSalesDataGridViewTextBoxColumn});
            this.grdLoyalCustomers.DataSource = this.customerBindingSource;
            this.grdLoyalCustomers.Location = new System.Drawing.Point(25, 12);
            this.grdLoyalCustomers.Name = "grdLoyalCustomers";
            this.grdLoyalCustomers.RowHeadersWidth = 51;
            this.grdLoyalCustomers.RowTemplate.Height = 24;
            this.grdLoyalCustomers.Size = new System.Drawing.Size(614, 360);
            this.grdLoyalCustomers.TabIndex = 0;
            // 
            // btnLoadLoyalCustomers
            // 
            this.btnLoadLoyalCustomers.AccessibleName = "btnLoadLoyalCustomers";
            this.btnLoadLoyalCustomers.Location = new System.Drawing.Point(221, 392);
            this.btnLoadLoyalCustomers.Name = "btnLoadLoyalCustomers";
            this.btnLoadLoyalCustomers.Size = new System.Drawing.Size(217, 68);
            this.btnLoadLoyalCustomers.TabIndex = 1;
            this.btnLoadLoyalCustomers.Text = "Load Loyal Customers";
            this.btnLoadLoyalCustomers.UseVisualStyleBackColor = true;
            this.btnLoadLoyalCustomers.Click += new System.EventHandler(this.btnLoadLoyalCustomers_Click);
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.modelDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeOfPayerDataGridViewTextBoxColumn
            // 
            this.typeOfPayerDataGridViewTextBoxColumn.DataPropertyName = "typeOfPayer";
            this.typeOfPayerDataGridViewTextBoxColumn.HeaderText = "typeOfPayer";
            this.typeOfPayerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeOfPayerDataGridViewTextBoxColumn.Name = "typeOfPayerDataGridViewTextBoxColumn";
            this.typeOfPayerDataGridViewTextBoxColumn.Width = 125;
            // 
            // frequencyOfSalesDataGridViewTextBoxColumn
            // 
            this.frequencyOfSalesDataGridViewTextBoxColumn.DataPropertyName = " frequencyOfSales";
            this.frequencyOfSalesDataGridViewTextBoxColumn.HeaderText = " frequencyOfSales";
            this.frequencyOfSalesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frequencyOfSalesDataGridViewTextBoxColumn.Name = "frequencyOfSalesDataGridViewTextBoxColumn";
            this.frequencyOfSalesDataGridViewTextBoxColumn.Width = 125;
            // 
            // valueOfSalesDataGridViewTextBoxColumn
            // 
            this.valueOfSalesDataGridViewTextBoxColumn.DataPropertyName = "valueOfSales";
            this.valueOfSalesDataGridViewTextBoxColumn.HeaderText = "valueOfSales";
            this.valueOfSalesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valueOfSalesDataGridViewTextBoxColumn.Name = "valueOfSalesDataGridViewTextBoxColumn";
            this.valueOfSalesDataGridViewTextBoxColumn.Width = 125;
            // 
            // LoyalCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.btnLoadLoyalCustomers);
            this.Controls.Add(this.grdLoyalCustomers);
            this.Name = "LoyalCustomersForm";
            this.Text = "LoyalCustomersForm";
            this.Load += new System.EventHandler(this.LoyalCustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLoyalCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdLoyalCustomers;
        private System.Windows.Forms.Button btnLoadLoyalCustomers;
        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private ModelDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfPayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyOfSalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueOfSalesDataGridViewTextBoxColumn;
    }
}