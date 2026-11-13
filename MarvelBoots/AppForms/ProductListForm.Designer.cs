namespace MarvelBoots.AppForms
{
    partial class ProductListForm
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
            this.panelSearching = new System.Windows.Forms.Panel();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.labelSearching = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.groupBoxPrice = new System.Windows.Forms.GroupBox();
            this.expensiveFirst = new System.Windows.Forms.RadioButton();
            this.cheapFirst = new System.Windows.Forms.RadioButton();
            this.ordersButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelSearching.SuspendLayout();
            this.groupBoxPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelSearching);
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel1);
            // 
            // panelSearching
            // 
            this.panelSearching.Controls.Add(this.categoryComboBox);
            this.panelSearching.Controls.Add(this.labelSearching);
            this.panelSearching.Controls.Add(this.searchTextBox);
            this.panelSearching.Controls.Add(this.labelCategory);
            this.panelSearching.Controls.Add(this.groupBoxPrice);
            this.panelSearching.Controls.Add(this.ordersButton);
            this.panelSearching.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearching.Location = new System.Drawing.Point(0, 0);
            this.panelSearching.Name = "panelSearching";
            this.panelSearching.Size = new System.Drawing.Size(800, 50);
            this.panelSearching.TabIndex = 8;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Все категории",
            "Детская обувь",
            "Женская обувь",
            "Мужская обувь"});
            this.categoryComboBox.Location = new System.Drawing.Point(283, 15);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(147, 21);
            this.categoryComboBox.TabIndex = 4;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // labelSearching
            // 
            this.labelSearching.AutoSize = true;
            this.labelSearching.Location = new System.Drawing.Point(432, 19);
            this.labelSearching.Name = "labelSearching";
            this.labelSearching.Size = new System.Drawing.Size(39, 13);
            this.labelSearching.TabIndex = 3;
            this.labelSearching.Text = "Поиск:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Location = new System.Drawing.Point(477, 15);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(212, 21);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(218, 19);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(59, 13);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Категория:";
            // 
            // groupBoxPrice
            // 
            this.groupBoxPrice.Controls.Add(this.expensiveFirst);
            this.groupBoxPrice.Controls.Add(this.cheapFirst);
            this.groupBoxPrice.Location = new System.Drawing.Point(13, 2);
            this.groupBoxPrice.Name = "groupBoxPrice";
            this.groupBoxPrice.Size = new System.Drawing.Size(200, 44);
            this.groupBoxPrice.TabIndex = 0;
            this.groupBoxPrice.TabStop = false;
            this.groupBoxPrice.Text = "Цена";
            // 
            // expensiveFirst
            // 
            this.expensiveFirst.AutoSize = true;
            this.expensiveFirst.Location = new System.Drawing.Point(106, 17);
            this.expensiveFirst.Name = "expensiveFirst";
            this.expensiveFirst.Size = new System.Drawing.Size(62, 17);
            this.expensiveFirst.TabIndex = 1;
            this.expensiveFirst.Text = "Больше";
            this.expensiveFirst.UseVisualStyleBackColor = true;
            this.expensiveFirst.CheckedChanged += new System.EventHandler(this.expensiveFirst_CheckedChanged);
            // 
            // cheapFirst
            // 
            this.cheapFirst.AutoSize = true;
            this.cheapFirst.Checked = true;
            this.cheapFirst.Location = new System.Drawing.Point(22, 17);
            this.cheapFirst.Name = "cheapFirst";
            this.cheapFirst.Size = new System.Drawing.Size(65, 17);
            this.cheapFirst.TabIndex = 0;
            this.cheapFirst.TabStop = true;
            this.cheapFirst.Text = "Меньше";
            this.cheapFirst.UseVisualStyleBackColor = true;
            this.cheapFirst.CheckedChanged += new System.EventHandler(this.cheapFirst_CheckedChanged);
            // 
            // ordersButton
            // 
            this.ordersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.ordersButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersButton.Location = new System.Drawing.Point(713, 12);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(75, 27);
            this.ordersButton.TabIndex = 7;
            this.ordersButton.Text = "Заказы";
            this.ordersButton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 294);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ProductListForm";
            this.Text = "Каталог товаров";
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelSearching.ResumeLayout(false);
            this.panelSearching.PerformLayout();
            this.groupBoxPrice.ResumeLayout(false);
            this.groupBoxPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearching;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxPrice;
        private System.Windows.Forms.RadioButton expensiveFirst;
        private System.Windows.Forms.RadioButton cheapFirst;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label labelSearching;
        private System.Windows.Forms.Button ordersButton;
    }
}