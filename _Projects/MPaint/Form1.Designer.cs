namespace MPaint
{
    partial class frmMPaint
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnInvalidate = new System.Windows.Forms.Button();
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
            this.btnMPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.btnMPaint_Paint);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Green;
            this.btnRefresh.Location = new System.Drawing.Point(0, 270);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 31);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh!";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnInvalidate
            // 
            this.btnInvalidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvalidate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvalidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvalidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInvalidate.ForeColor = System.Drawing.Color.Green;
            this.btnInvalidate.Location = new System.Drawing.Point(169, 270);
            this.btnInvalidate.Name = "btnInvalidate";
            this.btnInvalidate.Size = new System.Drawing.Size(115, 31);
            this.btnInvalidate.TabIndex = 20;
            this.btnInvalidate.Text = "Invalidate!";
            this.btnInvalidate.UseVisualStyleBackColor = true;
            this.btnInvalidate.Click += new System.EventHandler(this.btnInvalidate_Click);
            // 
            // frmMPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.btnInvalidate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMPaint);
            this.MaximizeBox = false;
            this.Name = "frmMPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MPaint";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMPaint_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMPaint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnInvalidate;
    }
}

