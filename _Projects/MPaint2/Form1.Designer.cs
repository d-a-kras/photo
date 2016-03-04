namespace MPaint
{
    partial class frmMPaint2
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
            this.btnMPaint = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMPaint
            // 
            this.btnMPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMPaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMPaint.Location = new System.Drawing.Point(0, 0);
            this.btnMPaint.Name = "btnMPaint";
            this.btnMPaint.Size = new System.Drawing.Size(284, 264);
            this.btnMPaint.TabIndex = 0;
            this.btnMPaint.UseVisualStyleBackColor = true;
            // 
            // btnPaint
            // 
            this.btnPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPaint.ForeColor = System.Drawing.Color.Green;
            this.btnPaint.Location = new System.Drawing.Point(0, 270);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(115, 31);
            this.btnPaint.TabIndex = 19;
            this.btnPaint.Text = "Paint!";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // frmMPaint2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.btnMPaint);
            this.MaximizeBox = false;
            this.Name = "frmMPaint2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MPaint2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMPaint;
        private System.Windows.Forms.Button btnPaint;
    }
}

