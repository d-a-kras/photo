namespace WindowsFormsApplication1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обрезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обрезатьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.чБToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеркалоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 193);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 203);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(588, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 415);
            this.panel2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1,
            this.сохранитьToolStripMenuItem1,
            this.эффектыToolStripMenuItem,
            this.обрезатьToolStripMenuItem1,
            this.выходToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(94, 29);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(110, 29);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // эффектыToolStripMenuItem
            // 
            this.эффектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чБToolStripMenuItem,
            this.зеркалоToolStripMenuItem,
            this.инверсияToolStripMenuItem});
            this.эффектыToolStripMenuItem.Name = "эффектыToolStripMenuItem";
            this.эффектыToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.эффектыToolStripMenuItem.Text = "Эффекты";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(76, 29);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // обрезатьToolStripMenuItem1
            // 
            this.обрезатьToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обрезатьToolStripMenuItem2});
            this.обрезатьToolStripMenuItem1.Name = "обрезатьToolStripMenuItem1";
            this.обрезатьToolStripMenuItem1.Size = new System.Drawing.Size(134, 29);
            this.обрезатьToolStripMenuItem1.Text = "Инструменты";
            this.обрезатьToolStripMenuItem1.Click += new System.EventHandler(this.обрезатьToolStripMenuItem1_Click);
            // 
            // обрезатьToolStripMenuItem2
            // 
            this.обрезатьToolStripMenuItem2.Name = "обрезатьToolStripMenuItem2";
            this.обрезатьToolStripMenuItem2.Size = new System.Drawing.Size(198, 30);
            this.обрезатьToolStripMenuItem2.Text = "Обрезать";
            this.обрезатьToolStripMenuItem2.Click += new System.EventHandler(this.обрезатьToolStripMenuItem2_Click);
            // 
            // чБToolStripMenuItem
            // 
            this.чБToolStripMenuItem.Name = "чБToolStripMenuItem";
            this.чБToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.чБToolStripMenuItem.Text = "ЧБ";
            this.чБToolStripMenuItem.Click += new System.EventHandler(this.чБToolStripMenuItem_Click);
            // 
            // зеркалоToolStripMenuItem
            // 
            this.зеркалоToolStripMenuItem.Name = "зеркалоToolStripMenuItem";
            this.зеркалоToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.зеркалоToolStripMenuItem.Text = "Зеркало";
            this.зеркалоToolStripMenuItem.Click += new System.EventHandler(this.зеркалоToolStripMenuItem_Click);
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem эффектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обрезатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обрезатьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem чБToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеркалоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
    }
}

