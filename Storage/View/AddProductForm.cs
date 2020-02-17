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
    public partial class AddProductForm : Form
    {
        private ProductController productController;
        public AddProductForm(ProductController productController)
        {
            this.productController = productController;
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productName_textBox.Text)) return;
            productController.AddProduct(productName_textBox.Text, Convert.ToInt32(productType_comboBox.SelectedValue));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            productType_comboBox.DataSource = productController.GetProductTypesDataSource();
            productType_comboBox.DisplayMember = "Title";
            productType_comboBox.ValueMember = "Id";
        }
    }
}
