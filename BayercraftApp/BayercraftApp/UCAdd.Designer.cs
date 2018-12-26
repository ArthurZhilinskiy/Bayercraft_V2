namespace BayercraftApp
{
    partial class UCAdd
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.cmbMarks = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddNewProduct = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrice = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescription = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNewMark = new MetroFramework.Controls.MetroButton();
            this.tbMark = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnClose);
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(670, 510);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnClose
            // 
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnClose.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Location = new System.Drawing.Point(573, 472);
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
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.cmbCategory);
            this.groupBox2.Controls.Add(this.cmbMarks);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAddNewProduct);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(0, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 355);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Новый товар";
            // 
            // btnBrowse
            // 
            this.btnBrowse.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBrowse.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnBrowse.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBrowse.Location = new System.Drawing.Point(391, 225);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(194, 23);
            this.btnBrowse.Style = MetroFramework.MetroColorStyle.White;
            this.btnBrowse.TabIndex = 28;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.Text = "Обзор";
            this.btnBrowse.UseCustomBackColor = true;
            this.btnBrowse.UseCustomForeColor = true;
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BayercraftApp.Properties.Resources.icons8_unsplash_80;
            this.pictureBox1.Location = new System.Drawing.Point(391, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
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
            this.cmbCategory.Location = new System.Drawing.Point(451, 32);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.PromptText = "Выберите категорию";
            this.cmbCategory.Size = new System.Drawing.Size(168, 29);
            this.cmbCategory.TabIndex = 26;
            this.cmbCategory.UseSelectable = true;
            // 
            // cmbMarks
            // 
            this.cmbMarks.FormattingEnabled = true;
            this.cmbMarks.ItemHeight = 23;
            this.cmbMarks.Location = new System.Drawing.Point(142, 295);
            this.cmbMarks.Name = "cmbMarks";
            this.cmbMarks.PromptText = "Выберите производителя";
            this.cmbMarks.Size = new System.Drawing.Size(210, 29);
            this.cmbMarks.TabIndex = 26;
            this.cmbMarks.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(359, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Категория:";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNewProduct.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddNewProduct.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnAddNewProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProduct.Location = new System.Drawing.Point(442, 298);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(91, 23);
            this.btnAddNewProduct.Style = MetroFramework.MetroColorStyle.White;
            this.btnAddNewProduct.TabIndex = 25;
            this.btnAddNewProduct.TabStop = false;
            this.btnAddNewProduct.Text = "Добавить";
            this.btnAddNewProduct.UseCustomBackColor = true;
            this.btnAddNewProduct.UseCustomForeColor = true;
            this.btnAddNewProduct.UseSelectable = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(68, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Марка:";
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
            this.tbPrice.Location = new System.Drawing.Point(142, 265);
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
            this.label3.Location = new System.Drawing.Point(81, 263);
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
            this.tbDescription.Location = new System.Drawing.Point(142, 65);
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
            this.label2.Location = new System.Drawing.Point(45, 64);
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
            this.tbName.Location = new System.Drawing.Point(142, 35);
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
            this.label5.Location = new System.Drawing.Point(387, 79);
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
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Название:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNewMark);
            this.groupBox1.Controls.Add(this.tbMark);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 102);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новая марка автомобиля";
            // 
            // btnAddNewMark
            // 
            this.btnAddNewMark.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNewMark.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddNewMark.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnAddNewMark.ForeColor = System.Drawing.Color.White;
            this.btnAddNewMark.Location = new System.Drawing.Point(442, 51);
            this.btnAddNewMark.Name = "btnAddNewMark";
            this.btnAddNewMark.Size = new System.Drawing.Size(91, 23);
            this.btnAddNewMark.Style = MetroFramework.MetroColorStyle.White;
            this.btnAddNewMark.TabIndex = 19;
            this.btnAddNewMark.TabStop = false;
            this.btnAddNewMark.Text = "Добавить";
            this.btnAddNewMark.UseCustomBackColor = true;
            this.btnAddNewMark.UseCustomForeColor = true;
            this.btnAddNewMark.UseSelectable = true;
            this.btnAddNewMark.Click += new System.EventHandler(this.btnAddNewMark_Click);
            // 
            // tbMark
            // 
            // 
            // 
            // 
            this.tbMark.CustomButton.Image = null;
            this.tbMark.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.tbMark.CustomButton.Name = "";
            this.tbMark.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMark.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMark.CustomButton.TabIndex = 1;
            this.tbMark.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMark.CustomButton.UseSelectable = true;
            this.tbMark.CustomButton.Visible = false;
            this.tbMark.DisplayIcon = true;
            this.tbMark.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbMark.Lines = new string[0];
            this.tbMark.Location = new System.Drawing.Point(226, 51);
            this.tbMark.MaxLength = 32767;
            this.tbMark.Name = "tbMark";
            this.tbMark.PasswordChar = '\0';
            this.tbMark.PromptText = "Введите название марки";
            this.tbMark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMark.SelectedText = "";
            this.tbMark.SelectionLength = 0;
            this.tbMark.SelectionStart = 0;
            this.tbMark.ShortcutsEnabled = true;
            this.tbMark.Size = new System.Drawing.Size(210, 23);
            this.tbMark.TabIndex = 18;
            this.tbMark.UseSelectable = true;
            this.tbMark.WaterMark = "Введите название марки";
            this.tbMark.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMark.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(152, 51);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Марка:";
            // 
            // UCAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroPanel1);
            this.Name = "UCAdd";
            this.Size = new System.Drawing.Size(670, 510);
            this.metroPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox cmbMarks;
        private MetroFramework.Controls.MetroButton btnAddNewProduct;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox tbPrice;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox tbDescription;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnAddNewMark;
        private MetroFramework.Controls.MetroTextBox tbMark;
        private System.Windows.Forms.Label btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroComboBox cmbCategory;
        private System.Windows.Forms.Label label6;
    }
}
