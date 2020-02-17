using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage.Controller;

namespace Storage.View
{
    public partial class ProductsForm : Form
    {

        private ProductController productController;
        public ProductsForm(ProductController productController)
        {
            this.productController = productController;
            InitializeComponent();
        }

        private void SetDataGridDataSource()
        {
            products_dataGridView.DataSource = productController.GetProductTypesDataSource();
            products_dataGridView.Columns[0].Visible = false;
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            SetDataGridDataSource();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddProductType APT = new AddProductType(productController);
            APT.Owner = this;
            if (APT.ShowDialog() == DialogResult.OK)
                SetDataGridDataSource();
        }
    }
}
