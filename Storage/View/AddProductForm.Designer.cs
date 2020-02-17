namespace Storage.View
{
    partial class AddProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.productName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productType_comboBox = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // productName_textBox
            // 
            this.productName_textBox.Location = new System.Drawing.Point(16, 30);
            this.productName_textBox.Name = "productName_textBox";
            this.productName_textBox.Size = new System.Drawing.Size(260, 20);
            this.productName_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип";
            // 
            // productType_comboBox
            // 
            this.productType_comboBox.FormattingEnabled = true;
            this.productType_comboBox.Location = new System.Drawing.Point(16, 87);
            this.productType_comboBox.Name = "productType_comboBox";
            this.productType_comboBox.Size = new System.Drawing.Size(260, 21);
            this.productType_comboBox.TabIndex = 3;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(201, 154);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 189);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.productType_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productName_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddProductForm";
            this.Text = "Добавить товар";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productType_comboBox;
        private System.Windows.Forms.Button save_button;
    }
}