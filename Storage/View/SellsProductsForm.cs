using Storage.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage.View
{
    public partial class SellsProductsForm : Form
    {
        private ProductController productController;
        public SellsProductsForm(Controller.ProductController productController)
        {
            this.productController = productController;
            InitializeComponent();
        }

        private void SetDataGridDataSource()
        {
            products_dataGridView.DataSource = productController.GetProductsDataSource(3);
            products_dataGridView.Columns[0].Visible = false;
            products_dataGridView.Columns[2].Visible = false;
            products_dataGridView.Columns[4].Visible = false;

            products_dataGridView.Columns[1].HeaderText = "Товар";
            products_dataGridView.Columns[3].HeaderText = "Тип";
            products_dataGridView.Columns[5].HeaderText = "Статус";
            products_dataGridView.Columns[6].HeaderText = "Дата статуса";
        }

        private void SellsProductsForm_Load(object sender, EventArgs e)
        {
            SetDataGridDataSource();
        }
    }
}
