namespace Cats
{
    partial class Registration
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
            this.addButton = new System.Windows.Forms.Button();
            this.catsList = new System.Windows.Forms.ListView();
            this.catTypeBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 65);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // catsList
            // 
            this.catsList.Location = new System.Drawing.Point(151, 12);
            this.catsList.Name = "catsList";
            this.catsList.Size = new System.Drawing.Size(121, 237);
            this.catsList.TabIndex = 2;
            this.catsList.UseCompatibleStateImageBehavior = false;
            this.catsList.SelectedIndexChanged += new System.EventHandler(this.catsList_SelectedIndexChanged);
            // 
            // catTypeBox
            // 
            this.catTypeBox.FormattingEnabled = true;
            this.catTypeBox.Items.AddRange(new object[] {
            "Чёрный",
            "Белый",
            "Рыжий"});
            this.catTypeBox.Location = new System.Drawing.Point(12, 12);
            this.catTypeBox.Name = "catTypeBox";
            this.catTypeBox.Size = new System.Drawing.Size(121, 21);
            this.catTypeBox.TabIndex = 3;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(13, 39);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 4;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.catTypeBox);
            this.Controls.Add(this.catsList);
            this.Controls.Add(this.addButton);
            this.Name = "Registration";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView catsList;
        private System.Windows.Forms.ComboBox catTypeBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}

