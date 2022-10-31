namespace ProiectCrmBi
{
    partial class Form1
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
            this.btnComplaints = new System.Windows.Forms.Button();
            this.btnLoyalCustomers = new System.Windows.Forms.Button();
            this.btnCustomerType = new System.Windows.Forms.Button();
            this.btnCustomerAnalysis = new System.Windows.Forms.Button();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComplaints
            // 
            this.btnComplaints.Location = new System.Drawing.Point(12, 75);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Size = new System.Drawing.Size(124, 55);
            this.btnComplaints.TabIndex = 0;
            this.btnComplaints.Text = "Complaints";
            this.btnComplaints.UseVisualStyleBackColor = true;
            this.btnComplaints.Click += new System.EventHandler(this.btnComplaints_Click);
            // 
            // btnLoyalCustomers
            // 
            this.btnLoyalCustomers.Location = new System.Drawing.Point(12, 169);
            this.btnLoyalCustomers.Name = "btnLoyalCustomers";
            this.btnLoyalCustomers.Size = new System.Drawing.Size(124, 55);
            this.btnLoyalCustomers.TabIndex = 1;
            this.btnLoyalCustomers.Text = "Loyal customers";
            this.btnLoyalCustomers.UseVisualStyleBackColor = true;
            this.btnLoyalCustomers.Click += new System.EventHandler(this.btnLoyalCustomers_Click);
            // 
            // btnCustomerType
            // 
            this.btnCustomerType.Location = new System.Drawing.Point(12, 258);
            this.btnCustomerType.Name = "btnCustomerType";
            this.btnCustomerType.Size = new System.Drawing.Size(125, 55);
            this.btnCustomerType.TabIndex = 2;
            this.btnCustomerType.Text = "Bad/Prompt payers";
            this.btnCustomerType.UseVisualStyleBackColor = true;
            this.btnCustomerType.Click += new System.EventHandler(this.btnCustomerType_Click);
            // 
            // btnCustomerAnalysis
            // 
            this.btnCustomerAnalysis.Location = new System.Drawing.Point(12, 356);
            this.btnCustomerAnalysis.Name = "btnCustomerAnalysis";
            this.btnCustomerAnalysis.Size = new System.Drawing.Size(124, 55);
            this.btnCustomerAnalysis.TabIndex = 3;
            this.btnCustomerAnalysis.Text = "Customer Analysis";
            this.btnCustomerAnalysis.UseVisualStyleBackColor = true;
            this.btnCustomerAnalysis.Click += new System.EventHandler(this.btnCustomerAnalysis_Click);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Location = new System.Drawing.Point(143, 2);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(656, 452);
            this.pnlCustomer.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(48, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 16);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "CRM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.btnCustomerAnalysis);
            this.Controls.Add(this.btnCustomerType);
            this.Controls.Add(this.btnLoyalCustomers);
            this.Controls.Add(this.btnComplaints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComplaints;
        private System.Windows.Forms.Button btnLoyalCustomers;
        private System.Windows.Forms.Button btnCustomerType;
        private System.Windows.Forms.Button btnCustomerAnalysis;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblTitle;
    }
}

