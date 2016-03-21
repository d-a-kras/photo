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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чБToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеркалоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обрезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обрезатьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lv = new MyButton();
            this.pn = new MyButton();
            this.bp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(150, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(66, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(77, 22);
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
            this.эффектыToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.эффектыToolStripMenuItem.Text = "Эффекты";
            // 
            // чБToolStripMenuItem
            // 
            this.чБToolStripMenuItem.Name = "чБToolStripMenuItem";
            this.чБToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.чБToolStripMenuItem.Text = "ЧБ";
            this.чБToolStripMenuItem.Click += new System.EventHandler(this.чБToolStripMenuItem_Click);
            // 
            // зеркалоToolStripMenuItem
            // 
            this.зеркалоToolStripMenuItem.Name = "зеркалоToolStripMenuItem";
            this.зеркалоToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.зеркалоToolStripMenuItem.Text = "Зеркало";
            this.зеркалоToolStripMenuItem.Click += new System.EventHandler(this.зеркалоToolStripMenuItem_Click);
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // обрезатьToolStripMenuItem1
            // 
            this.обрезатьToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обрезатьToolStripMenuItem2});
            this.обрезатьToolStripMenuItem1.Name = "обрезатьToolStripMenuItem1";
            this.обрезатьToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.обрезатьToolStripMenuItem1.Text = "Инструменты";
            this.обрезатьToolStripMenuItem1.Click += new System.EventHandler(this.обрезатьToolStripMenuItem1_Click);
            // 
            // обрезатьToolStripMenuItem2
            // 
            this.обрезатьToolStripMenuItem2.Name = "обрезатьToolStripMenuItem2";
            this.обрезатьToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.обрезатьToolStripMenuItem2.Text = "Обрезать";
            this.обрезатьToolStripMenuItem2.Click += new System.EventHandler(this.обрезатьToolStripMenuItem2_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(53, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // lv
            // 
            this.lv.Location = new System.Drawing.Point(48, 70);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(27, 24);
            this.lv.TabIndex = 7;
            this.lv.Text = "myButton1";
            this.lv.UseVisualStyleBackColor = true;
            // 
            // pn
            // 
            this.pn.Location = new System.Drawing.Point(235, 192);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(32, 24);
            this.pn.TabIndex = 8;
            this.pn.Text = "myButton2";
            this.pn.UseVisualStyleBackColor = true;
            // 
            // bp
            // 
            this.bp.Location = new System.Drawing.Point(398, 37);
            this.bp.Name = "bp";
            this.bp.Size = new System.Drawing.Size(82, 23);
            this.bp.TabIndex = 9;
            this.bp.Text = "подтвердить";
            this.bp.UseVisualStyleBackColor = true;
            this.bp.Click += new System.EventHandler(this.bp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 309);
            this.Controls.Add(this.bp);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
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
        private MyButton lv;
        private MyButton pn;
        private System.Windows.Forms.Button bp;
    }
}

