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
    public partial class ReportProductsForm : Form
    {
        private ProductController productController;
        private Action<int> counter;
        public ReportProductsForm(Controller.ProductController productController)
        {
            this.productController = productController;
            InitializeComponent();
            counter = (x) => { counter_label.Text = $"Итого: {x}"; };
        }

        private void SetDataGridDataSource()
        {
            products_dataGridView.DataSource = productController.GetProductsDataSource();
            DrawDataGridView();
        }

        private void FilterDataGridDataSource(int statusId, DateTime begin, DateTime end)
        {
            products_dataGridView.DataSource = productController.FilterProductsDataSource(statusId, begin, end);
            DrawDataGridView();
        }

        private void DrawDataGridView()
        {
            products_dataGridView.Columns[0].Visible = false;
            products_dataGridView.Columns[2].Visible = false;
            products_dataGridView.Columns[4].Visible = false;

            products_dataGridView.Columns[1].HeaderText = "Товар";
            products_dataGridView.Columns[3].HeaderText = "Тип";
            products_dataGridView.Columns[5].HeaderText = "Статус";
            products_dataGridView.Columns[6].HeaderText = "Дата статуса";

            counter(products_dataGridView.Rows.Count);
        }

        private void ReportProductsForm_Load(object sender, EventArgs e)
        {
            SetDataGridDataSource();
            status_comboBox.DataSource = productController.GetStatusesDataSource();
            status_comboBox.DisplayMember = "Title";
            status_comboBox.ValueMember = "Id";
        }

        private void data_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                begin_dateTimePicker.Enabled = end_dateTimePicker.Enabled = checkBox.Checked;
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            status_comboBox.SelectedIndex = 0;
            data_checkBox.Checked = false;
            begin_dateTimePicker.Value = end_dateTimePicker.Value = DateTime.Now;
            SetDataGridDataSource();
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            if (end_dateTimePicker.Value.Date < begin_dateTimePicker.Value.Date) 
            {
                MessageBox.Show("Проверь даты");
                return;
            }
            if (data_checkBox.Checked)
                FilterDataGridDataSource(Convert.ToInt32(status_comboBox.SelectedValue),
                                         begin_dateTimePicker.Value.Date,
                                         end_dateTimePicker.Value.Date);
            else
                FilterDataGridDataSource(Convert.ToInt32(status_comboBox.SelectedValue),
                                         DateTime.MinValue.Date,
                                         DateTime.MaxValue.AddDays(-1).Date);
        }
    }
}
