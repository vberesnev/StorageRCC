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

    public partial class AddProductType : Form
    {
        private ProductController productController;
        public AddProductType(ProductController productController)
        {
            this.productController = productController;
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productType_textBox.Text)) return;
            productController.AddProductType(productType_textBox.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
