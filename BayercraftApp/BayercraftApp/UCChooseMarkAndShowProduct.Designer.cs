namespace BayercraftApp
{
    partial class UCChooseMarkAndShowProduct
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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.lNameCategory = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Label();
            this.cmbMarks = new MetroFramework.Controls.MetroComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lNameUser = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.flowLayoutPanel1);
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
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.lNameUser);
            this.metroPanel2.Controls.Add(this.lNameCategory);
            this.metroPanel2.Controls.Add(this.btnCancel);
            this.metroPanel2.Controls.Add(this.cmbMarks);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(664, 90);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // lNameCategory
            // 
            this.lNameCategory.AutoSize = true;
            this.lNameCategory.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNameCategory.ForeColor = System.Drawing.Color.Red;
            this.lNameCategory.Location = new System.Drawing.Point(3, 10);
            this.lNameCategory.Name = "lNameCategory";
            this.lNameCategory.Size = new System.Drawing.Size(257, 27);
            this.lNameCategory.TabIndex = 15;
            this.lNameCategory.Text = "Блок и головка цилиндров";
            this.lNameCategory.TextChanged += new System.EventHandler(this.lNameCategory_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(3, 57);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 19);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Производитель:";
            // 
            // cmbMarks
            // 
            this.cmbMarks.FormattingEnabled = true;
            this.cmbMarks.ItemHeight = 23;
            this.cmbMarks.Location = new System.Drawing.Point(127, 52);
            this.cmbMarks.Name = "cmbMarks";
            this.cmbMarks.PromptText = "Выберите производителя";
            this.cmbMarks.Size = new System.Drawing.Size(203, 29);
            this.cmbMarks.TabIndex = 2;
            this.cmbMarks.UseSelectable = true;
            this.cmbMarks.SelectedIndexChanged += new System.EventHandler(this.cmbMarks_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 99);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(660, 408);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lNameUser
            // 
            this.lNameUser.AutoSize = true;
            this.lNameUser.Location = new System.Drawing.Point(550, 24);
            this.lNameUser.Name = "lNameUser";
            this.lNameUser.Size = new System.Drawing.Size(35, 13);
            this.lNameUser.TabIndex = 16;
            this.lNameUser.Text = "label1";
            this.lNameUser.Visible = false;
            // 
            // UCChooseMarkAndShowProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroPanel1);
            this.Name = "UCChooseMarkAndShowProduct";
            this.Size = new System.Drawing.Size(670, 510);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label btnCancel;
        public System.Windows.Forms.Label lNameCategory;
        public MetroFramework.Controls.MetroComboBox cmbMarks;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public MetroFramework.Controls.MetroPanel metroPanel2;
        public System.Windows.Forms.Label lNameUser;
    }
}
