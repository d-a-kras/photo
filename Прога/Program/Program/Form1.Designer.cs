namespace Program
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьконтрастностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветовойБалансToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повыситьРезкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чБToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеркалоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чБ2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рамка1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектКрасныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.старинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектКраскиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коллажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 112);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(346, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.яркостьконтрастностьToolStripMenuItem,
            this.цветовойБалансToolStripMenuItem,
            this.повыситьРезкостьToolStripMenuItem,
            this.размытьToolStripMenuItem,
            this.чБToolStripMenuItem,
            this.зеркалоToolStripMenuItem,
            this.инверсияToolStripMenuItem,
            this.резкостьToolStripMenuItem,
            this.чБ2ToolStripMenuItem,
            this.рамка1ToolStripMenuItem,
            this.эффектКрасныйToolStripMenuItem,
            this.старинаToolStripMenuItem,
            this.эффектКраскиToolStripMenuItem,
            this.эффект2ToolStripMenuItem,
            this.коллажToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem2.Text = "Фильтры";
            // 
            // яркостьконтрастностьToolStripMenuItem
            // 
            this.яркостьконтрастностьToolStripMenuItem.Name = "яркостьконтрастностьToolStripMenuItem";
            this.яркостьконтрастностьToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.яркостьконтрастностьToolStripMenuItem.Text = "Яркость/контрастность";
            this.яркостьконтрастностьToolStripMenuItem.Click += new System.EventHandler(this.яркостьконтрастностьToolStripMenuItem_Click);
            // 
            // цветовойБалансToolStripMenuItem
            // 
            this.цветовойБалансToolStripMenuItem.Name = "цветовойБалансToolStripMenuItem";
            this.цветовойБалансToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.цветовойБалансToolStripMenuItem.Text = "Цветовой баланс";
            this.цветовойБалансToolStripMenuItem.Click += new System.EventHandler(this.цветовойБалансToolStripMenuItem_Click);
            // 
            // повыситьРезкостьToolStripMenuItem
            // 
            this.повыситьРезкостьToolStripMenuItem.Name = "повыситьРезкостьToolStripMenuItem";
            this.повыситьРезкостьToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.повыситьРезкостьToolStripMenuItem.Text = "Повысить резкость";
            this.повыситьРезкостьToolStripMenuItem.Click += new System.EventHandler(this.повыситьРезкостьToolStripMenuItem_Click);
            // 
            // размытьToolStripMenuItem
            // 
            this.размытьToolStripMenuItem.Name = "размытьToolStripMenuItem";
            this.размытьToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.размытьToolStripMenuItem.Text = "Размыть";
            this.размытьToolStripMenuItem.Click += new System.EventHandler(this.размытьToolStripMenuItem_Click);
            // 
            // чБToolStripMenuItem
            // 
            this.чБToolStripMenuItem.Name = "чБToolStripMenuItem";
            this.чБToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.чБToolStripMenuItem.Text = "ЧБ";
            this.чБToolStripMenuItem.Click += new System.EventHandler(this.чБToolStripMenuItem_Click);
            // 
            // зеркалоToolStripMenuItem
            // 
            this.зеркалоToolStripMenuItem.Name = "зеркалоToolStripMenuItem";
            this.зеркалоToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.зеркалоToolStripMenuItem.Text = "Зеркало";
            this.зеркалоToolStripMenuItem.Click += new System.EventHandler(this.зеркалоToolStripMenuItem_Click);
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.резкостьToolStripMenuItem.Text = "резкость";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // чБ2ToolStripMenuItem
            // 
            this.чБ2ToolStripMenuItem.Name = "чБ2ToolStripMenuItem";
            this.чБ2ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.чБ2ToolStripMenuItem.Text = "ЧБ2";
            this.чБ2ToolStripMenuItem.Click += new System.EventHandler(this.чБ2ToolStripMenuItem_Click_1);
            // 
            // рамка1ToolStripMenuItem
            // 
            this.рамка1ToolStripMenuItem.Name = "рамка1ToolStripMenuItem";
            this.рамка1ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.рамка1ToolStripMenuItem.Text = "рамка1";
            this.рамка1ToolStripMenuItem.Click += new System.EventHandler(this.рамка1ToolStripMenuItem_Click);
            // 
            // эффектКрасныйToolStripMenuItem
            // 
            this.эффектКрасныйToolStripMenuItem.Name = "эффектКрасныйToolStripMenuItem";
            this.эффектКрасныйToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.эффектКрасныйToolStripMenuItem.Text = "эффект красный";
            this.эффектКрасныйToolStripMenuItem.Click += new System.EventHandler(this.эффектКрасныйToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // старинаToolStripMenuItem
            // 
            this.старинаToolStripMenuItem.Name = "старинаToolStripMenuItem";
            this.старинаToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.старинаToolStripMenuItem.Text = "старина";
            this.старинаToolStripMenuItem.Click += new System.EventHandler(this.старинаToolStripMenuItem_Click);
            // 
            // эффектКраскиToolStripMenuItem
            // 
            this.эффектКраскиToolStripMenuItem.Name = "эффектКраскиToolStripMenuItem";
            this.эффектКраскиToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.эффектКраскиToolStripMenuItem.Text = "эффект краски";
            this.эффектКраскиToolStripMenuItem.Click += new System.EventHandler(this.эффектКраскиToolStripMenuItem_Click);
            // 
            // эффект2ToolStripMenuItem
            // 
            this.эффект2ToolStripMenuItem.Name = "эффект2ToolStripMenuItem";
            this.эффект2ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.эффект2ToolStripMenuItem.Text = "эффект 2";
            this.эффект2ToolStripMenuItem.Click += new System.EventHandler(this.эффект2ToolStripMenuItem_Click);
            // 
            // коллажToolStripMenuItem
            // 
            this.коллажToolStripMenuItem.Name = "коллажToolStripMenuItem";
            this.коллажToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.коллажToolStripMenuItem.Text = "коллаж";
            this.коллажToolStripMenuItem.Click += new System.EventHandler(this.коллажToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 290);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem яркостьконтрастностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветовойБалансToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повыситьРезкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чБToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеркалоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чБ2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рамка1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффектКрасныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem старинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффектКраскиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коллажToolStripMenuItem;
    }
}

