namespace MarvelBoots.AppControls
{
    partial class ProductUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.pricePanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.manufacturerNameLabel = new System.Windows.Forms.Label();
            this.compositionLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.pricePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(18, 18);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 0;
            this.photoPictureBox.TabStop = false;
            // 
            // pricePanel
            // 
            this.pricePanel.Controls.Add(this.idLabel);
            this.pricePanel.Controls.Add(this.priceLabel);
            this.pricePanel.Location = new System.Drawing.Point(619, 18);
            this.pricePanel.Name = "pricePanel";
            this.pricePanel.Size = new System.Drawing.Size(100, 100);
            this.pricePanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.categoryLabel);
            this.mainPanel.Controls.Add(this.stockLabel);
            this.mainPanel.Controls.Add(this.compositionLabel);
            this.mainPanel.Controls.Add(this.manufacturerNameLabel);
            this.mainPanel.Location = new System.Drawing.Point(141, 18);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(457, 100);
            this.mainPanel.TabIndex = 2;
            // 
            // manufacturerNameLabel
            // 
            this.manufacturerNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.manufacturerNameLabel.Location = new System.Drawing.Point(0, 0);
            this.manufacturerNameLabel.Name = "manufacturerNameLabel";
            this.manufacturerNameLabel.Size = new System.Drawing.Size(457, 23);
            this.manufacturerNameLabel.TabIndex = 0;
            this.manufacturerNameLabel.Text = "Производство | Наименование";
            this.manufacturerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compositionLabel
            // 
            this.compositionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.compositionLabel.Location = new System.Drawing.Point(0, 78);
            this.compositionLabel.Name = "compositionLabel";
            this.compositionLabel.Size = new System.Drawing.Size(457, 22);
            this.compositionLabel.TabIndex = 1;
            this.compositionLabel.Text = "Состав";
            // 
            // stockLabel
            // 
            this.stockLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stockLabel.Location = new System.Drawing.Point(0, 51);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(457, 27);
            this.stockLabel.TabIndex = 2;
            this.stockLabel.Text = "Количество";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categoryLabel.Location = new System.Drawing.Point(0, 23);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(457, 28);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Категория";
            // 
            // priceLabel
            // 
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.priceLabel.Location = new System.Drawing.Point(0, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(100, 23);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Цена";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idLabel
            // 
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.idLabel.Location = new System.Drawing.Point(0, 77);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(100, 23);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.pricePanel);
            this.Controls.Add(this.photoPictureBox);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(738, 138);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.pricePanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Panel pricePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label manufacturerNameLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label compositionLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label idLabel;
    }
}
