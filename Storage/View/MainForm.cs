using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage.View;
using Storage.Controller;

namespace Storage
{
    public partial class MainForm : Form
    {

        private ProductController productController;
        
        public MainForm()
        {
            productController = new ProductController();
            InitializeComponent();
        }

        private void productTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            ProductsForm PF = new ProductsForm(productController);
            PF.MdiParent = this;
            PF.Dock = DockStyle.Fill;
            PF.Show();
            
        }

        private void receivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            ReceivedProductsForm RPF = new ReceivedProductsForm(productController);
            RPF.MdiParent = this;
            RPF.Dock = DockStyle.Fill;
            RPF.Show();
        }

        private void inStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            StorageProductsForm SPF = new StorageProductsForm(productController);
            SPF.MdiParent = this;
            SPF.Dock = DockStyle.Fill;
            SPF.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            SellsProductsForm SPF = new SellsProductsForm(productController);
            SPF.MdiParent = this;
            SPF.Dock = DockStyle.Fill;
            SPF.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            ReportProductsForm RPF = new ReportProductsForm(productController);
            RPF.MdiParent = this;
            RPF.Dock = DockStyle.Fill;
            RPF.Show();
        }
    }
}
