﻿namespace Storage.View
{
    partial class ReceivedProductsForm
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
            this.components = new System.ComponentModel.Container();
            this.products_dataGridView = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.products_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // products_dataGridView
            // 
            this.products_dataGridView.AllowUserToAddRows = false;
            this.products_dataGridView.AllowUserToDeleteRows = false;
            this.products_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.products_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_dataGridView.Location = new System.Drawing.Point(12, 51);
            this.products_dataGridView.Name = "products_dataGridView";
            this.products_dataGridView.ReadOnly = true;
            this.products_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products_dataGridView.Size = new System.Drawing.Size(460, 242);
            this.products_dataGridView.TabIndex = 3;
            this.products_dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.products_dataGridView_CellMouseClick);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(12, 9);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ReceivedProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 305);
            this.Controls.Add(this.products_dataGridView);
            this.Controls.Add(this.add_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceivedProductsForm";
            this.Text = "ReceivedProductsForm";
            this.Load += new System.EventHandler(this.ReceivedProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.products_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView products_dataGridView;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}