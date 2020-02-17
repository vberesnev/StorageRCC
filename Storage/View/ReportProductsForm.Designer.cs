namespace Storage.View
{
    partial class ReportProductsForm
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
            this.products_dataGridView = new System.Windows.Forms.DataGridView();
            this.filter_groupBox = new System.Windows.Forms.GroupBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.filter_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.end_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.begin_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_checkBox = new System.Windows.Forms.CheckBox();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.counter_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.products_dataGridView)).BeginInit();
            this.filter_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // products_dataGridView
            // 
            this.products_dataGridView.AllowUserToAddRows = false;
            this.products_dataGridView.AllowUserToDeleteRows = false;
            this.products_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.products_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_dataGridView.Location = new System.Drawing.Point(13, 121);
            this.products_dataGridView.Name = "products_dataGridView";
            this.products_dataGridView.ReadOnly = true;
            this.products_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products_dataGridView.Size = new System.Drawing.Size(459, 179);
            this.products_dataGridView.TabIndex = 3;
            // 
            // filter_groupBox
            // 
            this.filter_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filter_groupBox.Controls.Add(this.reset_button);
            this.filter_groupBox.Controls.Add(this.filter_button);
            this.filter_groupBox.Controls.Add(this.label3);
            this.filter_groupBox.Controls.Add(this.end_dateTimePicker);
            this.filter_groupBox.Controls.Add(this.label2);
            this.filter_groupBox.Controls.Add(this.begin_dateTimePicker);
            this.filter_groupBox.Controls.Add(this.data_checkBox);
            this.filter_groupBox.Controls.Add(this.status_comboBox);
            this.filter_groupBox.Controls.Add(this.label1);
            this.filter_groupBox.Location = new System.Drawing.Point(13, 13);
            this.filter_groupBox.Name = "filter_groupBox";
            this.filter_groupBox.Size = new System.Drawing.Size(459, 102);
            this.filter_groupBox.TabIndex = 4;
            this.filter_groupBox.TabStop = false;
            this.filter_groupBox.Text = "Фильтр";
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(368, 72);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 8;
            this.reset_button.Text = "Сбросить";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // filter_button
            // 
            this.filter_button.Location = new System.Drawing.Point(368, 43);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(75, 23);
            this.filter_button.TabIndex = 7;
            this.filter_button.Text = "Применить";
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "по";
            // 
            // end_dateTimePicker
            // 
            this.end_dateTimePicker.Enabled = false;
            this.end_dateTimePicker.Location = new System.Drawing.Point(199, 72);
            this.end_dateTimePicker.Name = "end_dateTimePicker";
            this.end_dateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.end_dateTimePicker.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "с";
            // 
            // begin_dateTimePicker
            // 
            this.begin_dateTimePicker.Enabled = false;
            this.begin_dateTimePicker.Location = new System.Drawing.Point(31, 72);
            this.begin_dateTimePicker.Name = "begin_dateTimePicker";
            this.begin_dateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.begin_dateTimePicker.TabIndex = 3;
            // 
            // data_checkBox
            // 
            this.data_checkBox.AutoSize = true;
            this.data_checkBox.Location = new System.Drawing.Point(10, 49);
            this.data_checkBox.Name = "data_checkBox";
            this.data_checkBox.Size = new System.Drawing.Size(52, 17);
            this.data_checkBox.TabIndex = 2;
            this.data_checkBox.Text = "Дата";
            this.data_checkBox.UseVisualStyleBackColor = true;
            this.data_checkBox.CheckedChanged += new System.EventHandler(this.data_checkBox_CheckedChanged);
            // 
            // status_comboBox
            // 
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Location = new System.Drawing.Point(65, 17);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(220, 21);
            this.status_comboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус";
            // 
            // counter_label
            // 
            this.counter_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.counter_label.AutoSize = true;
            this.counter_label.Location = new System.Drawing.Point(400, 332);
            this.counter_label.Name = "counter_label";
            this.counter_label.Size = new System.Drawing.Size(40, 13);
            this.counter_label.TabIndex = 5;
            this.counter_label.Text = "Итого:";
            // 
            // ReportProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 354);
            this.Controls.Add(this.counter_label);
            this.Controls.Add(this.filter_groupBox);
            this.Controls.Add(this.products_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportProductsForm";
            this.Text = "ReceivedProductsForm";
            this.Load += new System.EventHandler(this.ReportProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.products_dataGridView)).EndInit();
            this.filter_groupBox.ResumeLayout(false);
            this.filter_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView products_dataGridView;
        private System.Windows.Forms.GroupBox filter_groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker end_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker begin_dateTimePicker;
        private System.Windows.Forms.CheckBox data_checkBox;
        private System.Windows.Forms.ComboBox status_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.Label counter_label;
    }
}