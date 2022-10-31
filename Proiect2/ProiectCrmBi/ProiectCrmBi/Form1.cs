using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectCrmBi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.pnlCustomer.Controls.Count > 0)
                this.pnlCustomer.Controls.RemoveAt(0);
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlCustomer.Controls.Add(form);
            this.pnlCustomer.Tag = form;
            form.Show();
        }

        private void btnLoyalCustomers_Click(object sender, EventArgs e)
        {
            loadForm(new LoyalCustomersForm());            
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            loadForm(new ComplaintsForm());
        }

        private void btnCustomerType_Click(object sender, EventArgs e)
        {
            loadForm(new BadPromptPayersForm());
        }

        private void btnCustomerAnalysis_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerAnalysisForm());

        }
    }
}
