namespace BayercraftApp
{
    partial class UCChange
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChangeProduct = new MetroFramework.Controls.MetroButton();
            this.tbPrice = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescription = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnClose);
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(617, 396);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnClose
            // 
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnClose.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Location = new System.Drawing.Point(511, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 23);
            this.btnClose.Style = MetroFramework.MetroColorStyle.White;
            this.btnClose.TabIndex = 21;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Назад";
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.cmbCategory);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnChangeProduct);
            this.groupBox2.Controls.Add(this.tbPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(0, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 356);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Реактирование товара";
            // 
            // btnBrowse
            // 
            this.btnBrowse.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBrowse.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnBrowse.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBrowse.Location = new System.Drawing.Point(374, 229);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(194, 23);
            this.btnBrowse.Style = MetroFramework.MetroColorStyle.White;
            this.btnBrowse.TabIndex = 28;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.Text = "Обзор";
            this.btnBrowse.UseCustomBackColor = true;
            this.btnBrowse.UseCustomForeColor = true;
            this.btnBrowse.UseSelectable = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 23;
            this.cmbCategory.Items.AddRange(new object[] {
            "Блок и головка цилиндров",
            "Включение двигателя",
            "Внутренние отделка и оснащение",
            "Генератор",
            "Двигатель и подвеска",
            "Зажигание двигателя",
            "Инжекционнная система запитки",
            "Инструмент",
            "КПП",
            "Кузов и листовые панели",
            "Мост и полуось дифференциала",
            "Навесные части и стекла",
            "Наружная отделка и оснащение",
            "Освещение",
            "Охлаждение",
            "Подвеска и колеса",
            "Рулевое управление",
            "Система климатизации",
            "Тормоза"});
            this.cmbCategory.Location = new System.Drawing.Point(434, 36);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.PromptText = "Выберите категорию";
            this.cmbCategory.Size = new System.Drawing.Size(168, 29);
            this.cmbCategory.TabIndex = 26;
            this.cmbCategory.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(342, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Категория:";
            // 
            // btnChangeProduct
            // 
            this.btnChangeProduct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnChangeProduct.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnChangeProduct.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnChangeProduct.ForeColor = System.Drawing.Color.White;
            this.btnChangeProduct.Location = new System.Drawing.Point(425, 302);
            this.btnChangeProduct.Name = "btnChangeProduct";
            this.btnChangeProduct.Size = new System.Drawing.Size(91, 23);
            this.btnChangeProduct.Style = MetroFramework.MetroColorStyle.White;
            this.btnChangeProduct.TabIndex = 25;
            this.btnChangeProduct.TabStop = false;
            this.btnChangeProduct.Text = "Применить";
            this.btnChangeProduct.UseCustomBackColor = true;
            this.btnChangeProduct.UseCustomForeColor = true;
            this.btnChangeProduct.UseSelectable = true;
            this.btnChangeProduct.Click += new System.EventHandler(this.btnChangeProduct_Click);
            // 
            // tbPrice
            // 
            // 
            // 
            // 
            this.tbPrice.CustomButton.Image = null;
            this.tbPrice.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.tbPrice.CustomButton.Name = "";
            this.tbPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPrice.CustomButton.TabIndex = 1;
            this.tbPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPrice.CustomButton.UseSelectable = true;
            this.tbPrice.CustomButton.Visible = false;
            this.tbPrice.DisplayIcon = true;
            this.tbPrice.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbPrice.Lines = new string[0];
            this.tbPrice.Location = new System.Drawing.Point(125, 269);
            this.tbPrice.MaxLength = 32767;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PromptText = "Введите цену товара";
            this.tbPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPrice.SelectedText = "";
            this.tbPrice.SelectionLength = 0;
            this.tbPrice.SelectionStart = 0;
            this.tbPrice.ShortcutsEnabled = true;
            this.tbPrice.Size = new System.Drawing.Size(210, 23);
            this.tbPrice.TabIndex = 22;
            this.tbPrice.UseSelectable = true;
            this.tbPrice.WaterMark = "Введите цену товара";
            this.tbPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(64, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Цена:";
            // 
            // tbDescription
            // 
            // 
            // 
            // 
            this.tbDescription.CustomButton.Image = null;
            this.tbDescription.CustomButton.Location = new System.Drawing.Point(18, 2);
            this.tbDescription.CustomButton.Name = "";
            this.tbDescription.CustomButton.Size = new System.Drawing.Size(189, 189);
            this.tbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDescription.CustomButton.TabIndex = 1;
            this.tbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDescription.CustomButton.UseSelectable = true;
            this.tbDescription.CustomButton.Visible = false;
            this.tbDescription.DisplayIcon = true;
            this.tbDescription.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbDescription.Lines = new string[0];
            this.tbDescription.Location = new System.Drawing.Point(125, 69);
            this.tbDescription.MaxLength = 32767;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PasswordChar = '\0';
            this.tbDescription.PromptText = "Введите описание товара";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescription.SelectedText = "";
            this.tbDescription.SelectionLength = 0;
            this.tbDescription.SelectionStart = 0;
            this.tbDescription.ShortcutsEnabled = true;
            this.tbDescription.Size = new System.Drawing.Size(210, 194);
            this.tbDescription.TabIndex = 23;
            this.tbDescription.UseSelectable = true;
            this.tbDescription.WaterMark = "Введите описание товара";
            this.tbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Описание:";
            // 
            // tbName
            // 
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.CustomButton.Visible = false;
            this.tbName.DisplayIcon = true;
            this.tbName.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(125, 39);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PromptText = "Введите название товара";
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(210, 23);
            this.tbName.TabIndex = 24;
            this.tbName.UseSelectable = true;
            this.tbName.WaterMark = "Введите название товара";
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(370, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Изображение:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Название:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BayercraftApp.Properties.Resources.icons8_unsplash_80;
            this.pictureBox1.Location = new System.Drawing.Point(374, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // UCChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "UCChange";
            this.Size = new System.Drawing.Size(617, 396);
            this.metroPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroButton btnChangeProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroComboBox cmbCategory;
        public MetroFramework.Controls.MetroTextBox tbPrice;
        public MetroFramework.Controls.MetroTextBox tbDescription;
        public MetroFramework.Controls.MetroTextBox tbName;
    }
}
