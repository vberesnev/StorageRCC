namespace Storage
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.catalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menuStrip
            // 
            this.main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogToolStripMenuItem,
            this.storageToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.main_menuStrip.Name = "main_menuStrip";
            this.main_menuStrip.Size = new System.Drawing.Size(800, 24);
            this.main_menuStrip.TabIndex = 1;
            this.main_menuStrip.Text = "menuStrip1";
            // 
            // catalogToolStripMenuItem
            // 
            this.catalogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productTypesToolStripMenuItem});
            this.catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            this.catalogToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.catalogToolStripMenuItem.Text = "Справочник";
            // 
            // productTypesToolStripMenuItem
            // 
            this.productTypesToolStripMenuItem.Name = "productTypesToolStripMenuItem";
            this.productTypesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productTypesToolStripMenuItem.Text = "Типы товаров";
            this.productTypesToolStripMenuItem.Click += new System.EventHandler(this.productTypesToolStripMenuItem_Click);
            // 
            // storageToolStripMenuItem
            // 
            this.storageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivedToolStripMenuItem,
            this.inStorageToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.storageToolStripMenuItem.Name = "storageToolStripMenuItem";
            this.storageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.storageToolStripMenuItem.Text = "Склад";
            // 
            // receivedToolStripMenuItem
            // 
            this.receivedToolStripMenuItem.Name = "receivedToolStripMenuItem";
            this.receivedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.receivedToolStripMenuItem.Text = "Приняты";
            this.receivedToolStripMenuItem.Click += new System.EventHandler(this.receivedToolStripMenuItem_Click);
            // 
            // inStorageToolStripMenuItem
            // 
            this.inStorageToolStripMenuItem.Name = "inStorageToolStripMenuItem";
            this.inStorageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inStorageToolStripMenuItem.Text = "На складе";
            this.inStorageToolStripMenuItem.Click += new System.EventHandler(this.inStorageToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salesToolStripMenuItem.Text = "Проданы";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.reportToolStripMenuItem.Text = "Отчёт";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.main_menuStrip;
            this.Name = "MainForm";
            this.Text = "Склад";
            this.main_menuStrip.ResumeLayout(false);
            this.main_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem catalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}

