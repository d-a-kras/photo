namespace Circles
{
    partial class frmCircles
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
            this.hsbR = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hsbG = new System.Windows.Forms.HScrollBar();
            this.hsbB = new System.Windows.Forms.HScrollBar();
            this.lblR = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hsbA = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // hsbR
            // 
            this.hsbR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hsbR.Location = new System.Drawing.Point(43, 308);
            this.hsbR.Maximum = 264;
            this.hsbR.Name = "hsbR";
            this.hsbR.Size = new System.Drawing.Size(512, 18);
            this.hsbR.TabIndex = 0;
            this.hsbR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbR_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(12, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "B";
            // 
            // hsbG
            // 
            this.hsbG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hsbG.Location = new System.Drawing.Point(43, 346);
            this.hsbG.Maximum = 264;
            this.hsbG.Name = "hsbG";
            this.hsbG.Size = new System.Drawing.Size(512, 18);
            this.hsbG.TabIndex = 4;
            this.hsbG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbG_Scroll);
            // 
            // hsbB
            // 
            this.hsbB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hsbB.Location = new System.Drawing.Point(43, 383);
            this.hsbB.Maximum = 264;
            this.hsbB.Name = "hsbB";
            this.hsbB.Size = new System.Drawing.Size(512, 18);
            this.hsbB.TabIndex = 5;
            this.hsbB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbB_Scroll);
            // 
            // lblR
            // 
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblR.ForeColor = System.Drawing.Color.Red;
            this.lblR.Location = new System.Drawing.Point(570, 301);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(55, 25);
            this.lblR.TabIndex = 6;
            this.lblR.Text = "0";
            this.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblG
            // 
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblG.ForeColor = System.Drawing.Color.Green;
            this.lblG.Location = new System.Drawing.Point(570, 339);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(55, 25);
            this.lblG.TabIndex = 7;
            this.lblG.Text = "0";
            this.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblB
            // 
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblB.ForeColor = System.Drawing.Color.Blue;
            this.lblB.Location = new System.Drawing.Point(570, 376);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(55, 25);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "0";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblA
            // 
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblA.ForeColor = System.Drawing.Color.Black;
            this.lblA.Location = new System.Drawing.Point(570, 264);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(55, 25);
            this.lblA.TabIndex = 11;
            this.lblA.Text = "255";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "A";
            // 
            // hsbA
            // 
            this.hsbA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hsbA.Location = new System.Drawing.Point(43, 271);
            this.hsbA.Maximum = 264;
            this.hsbA.Name = "hsbA";
            this.hsbA.Size = new System.Drawing.Size(512, 18);
            this.hsbA.SmallChange = 2;
            this.hsbA.TabIndex = 9;
            this.hsbA.Value = 255;
            this.hsbA.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbA_Scroll);
            // 
            // frmCircles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 413);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hsbA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.hsbB);
            this.Controls.Add(this.hsbG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hsbR);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "frmCircles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circles";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCircles_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCircles_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmCircles_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hsbR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar hsbG;
        private System.Windows.Forms.HScrollBar hsbB;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar hsbA;
    }
}

