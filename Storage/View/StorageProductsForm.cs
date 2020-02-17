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
    public partial class StorageProductsForm : Form
    {
        private ProductController productController;
        public StorageProductsForm(Controller.ProductController productController)
        {
            this.productController = productController;
            InitializeComponent();

            ToolStripMenuItem tool = new ToolStripMenuItem("Продать");
            tool.Click += tool_Click;
            contextMenuStrip1.Items.Add(tool);
        }

        private void tool_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in products_dataGridView.SelectedRows)
            {
                productController.ChangeStatus(Convert.ToInt32(row.Cells["Id"].Value), 3);
            }
            SetDataGridDataSource();
        }

        private void SetDataGridDataSource()
        {
            products_dataGridView.DataSource = productController.GetProductsDataSource(2);
            products_dataGridView.Columns[0].Visible = false;
            products_dataGridView.Columns[2].Visible = false;
            products_dataGridView.Columns[4].Visible = false;

            products_dataGridView.Columns[1].HeaderText = "Товар";
            products_dataGridView.Columns[3].HeaderText = "Тип";
            products_dataGridView.Columns[5].HeaderText = "Статус";
            products_dataGridView.Columns[6].HeaderText = "Дата статуса";
        }

        private void StorageProductsForm_Load(object sender, EventArgs e)
        {
            SetDataGridDataSource();
        }

        private void products_dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                products_dataGridView.Rows[products_dataGridView.SelectedRows[0].Index].Selected = false;
                products_dataGridView.Rows[e.RowIndex].Selected = true;
                products_dataGridView.Rows[e.RowIndex].ContextMenuStrip = contextMenuStrip1;
                contextMenuStrip1.Show(Cursor.Position);
                products_dataGridView.Rows[e.RowIndex].ContextMenuStrip = null;
            }
        }
    }
}
