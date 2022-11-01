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
    public partial class LoyalCustomersForm : Form
    {
        public LoyalCustomersForm()
        {
            InitializeComponent();
        }

        private void LoyalCustomersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.Customer' table. You can move, or remove it, as needed.
            
        }

        private void btnLoadLoyalCustomers_Click(object sender, EventArgs e)
        {
            /*try
            {
                customerBindingSource.EndEdit();
                customerTableAdapter.Update(modelDataSet.Customer);
                MessageBox.Show("You successfully loaded the loyal customers", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/


        }
    }
}
