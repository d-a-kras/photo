namespace LineJoin
{
    partial class frmLineJoin
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
            this.btnMiter = new System.Windows.Forms.Button();
            this.btnMiterClipped = new System.Windows.Forms.Button();
            this.btnBevel = new System.Windows.Forms.Button();
            this.btnRound = new System.Windows.Forms.Button();
            this.btnNewLines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMiter
            // 
            this.btnMiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMiter.Location = new System.Drawing.Point(138, 402);
            this.btnMiter.Name = "btnMiter";
            this.btnMiter.Size = new System.Drawing.Size(120, 34);
            this.btnMiter.TabIndex = 0;
            this.btnMiter.Text = "Miter";
            this.btnMiter.UseVisualStyleBackColor = true;
            this.btnMiter.Click += new System.EventHandler(this.btnMiter_Click);
            // 
            // btnMiterClipped
            // 
            this.btnMiterClipped.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiterClipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMiterClipped.Location = new System.Drawing.Point(264, 402);
            this.btnMiterClipped.Name = "btnMiterClipped";
            this.btnMiterClipped.Size = new System.Drawing.Size(120, 34);
            this.btnMiterClipped.TabIndex = 1;
            this.btnMiterClipped.Text = "MiterClipped";
            this.btnMiterClipped.UseVisualStyleBackColor = true;
            this.btnMiterClipped.Click += new System.EventHandler(this.btnMiterClipped_Click);
            // 
            // btnBevel
            // 
            this.btnBevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBevel.Location = new System.Drawing.Point(12, 402);
            this.btnBevel.Name = "btnBevel";
            this.btnBevel.Size = new System.Drawing.Size(120, 34);
            this.btnBevel.TabIndex = 2;
            this.btnBevel.Text = "Bevel";
            this.btnBevel.UseVisualStyleBackColor = true;
            this.btnBevel.Click += new System.EventHandler(this.btnBevel_Click);
            // 
            // btnRound
            // 
            this.btnRound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRound.Location = new System.Drawing.Point(390, 402);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(120, 34);
            this.btnRound.TabIndex = 3;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // btnNewLines
            // 
            this.btnNewLines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewLines.Location = new System.Drawing.Point(12, 362);
            this.btnNewLines.Name = "btnNewLines";
            this.btnNewLines.Size = new System.Drawing.Size(498, 34);
            this.btnNewLines.TabIndex = 4;
            this.btnNewLines.Text = "Новые линии";
            this.btnNewLines.UseVisualStyleBackColor = true;
            this.btnNewLines.Click += new System.EventHandler(this.btnNewLines_Click);
            // 
            // frmLineJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 448);
            this.Controls.Add(this.btnNewLines);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.btnBevel);
            this.Controls.Add(this.btnMiterClipped);
            this.Controls.Add(this.btnMiter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLineJoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LineJoin ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frnLineJoin_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMiter;
        private System.Windows.Forms.Button btnMiterClipped;
        private System.Windows.Forms.Button btnBevel;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Button btnNewLines;
    }
}

