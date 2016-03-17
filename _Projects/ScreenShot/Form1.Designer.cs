namespace ScreenShot
{
    partial class frmScreenShot
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
            this.btnDLL = new System.Windows.Forms.Button();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.pnlScreenShot = new System.Windows.Forms.Panel();
            this.pbScreenShot = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlScreenShot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenShot)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDLL
            // 
            this.btnDLL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDLL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDLL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDLL.ForeColor = System.Drawing.Color.Green;
            this.btnDLL.Location = new System.Drawing.Point(188, 518);
            this.btnDLL.Name = "btnDLL";
            this.btnDLL.Size = new System.Drawing.Size(130, 31);
            this.btnDLL.TabIndex = 19;
            this.btnDLL.Text = "Снимок (DLL)!";
            this.btnDLL.UseVisualStyleBackColor = true;
            this.btnDLL.Click += new System.EventHandler(this.btnScreenShot_Click);
            // 
            // btnGraphics
            // 
            this.btnGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGraphics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGraphics.ForeColor = System.Drawing.Color.Green;
            this.btnGraphics.Location = new System.Drawing.Point(12, 518);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(170, 31);
            this.btnGraphics.TabIndex = 21;
            this.btnGraphics.Text = "Снимок (Graphics)!";
            this.btnGraphics.UseVisualStyleBackColor = true;
            this.btnGraphics.Click += new System.EventHandler(this.btnGraphics_Click);
            // 
            // pnlScreenShot
            // 
            this.pnlScreenShot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlScreenShot.AutoScroll = true;
            this.pnlScreenShot.Controls.Add(this.pbScreenShot);
            this.pnlScreenShot.Location = new System.Drawing.Point(12, 12);
            this.pnlScreenShot.Name = "pnlScreenShot";
            this.pnlScreenShot.Size = new System.Drawing.Size(660, 500);
            this.pnlScreenShot.TabIndex = 22;
            this.pnlScreenShot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmScreenShot_MouseDown);
            this.pnlScreenShot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmScreenShot_MouseMove);
            this.pnlScreenShot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmScreenShot_MouseUp);
            // 
            // pbScreenShot
            // 
            this.pbScreenShot.BackColor = System.Drawing.Color.White;
            this.pbScreenShot.BackgroundImage = global::ScreenShot.Properties.Resources.тюльпаны;
            this.pbScreenShot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbScreenShot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbScreenShot.Location = new System.Drawing.Point(0, 0);
            this.pbScreenShot.Name = "pbScreenShot";
            this.pbScreenShot.Size = new System.Drawing.Size(640, 480);
            this.pbScreenShot.TabIndex = 21;
            this.pbScreenShot.TabStop = false;
            this.pbScreenShot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmScreenShot_MouseDown);
            this.pbScreenShot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmScreenShot_MouseMove);
            this.pbScreenShot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmScreenShot_MouseUp);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.Green;
            this.btnSave.Location = new System.Drawing.Point(561, 518);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 31);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Сохранить!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.Color.Green;
            this.btnClear.Location = new System.Drawing.Point(368, 518);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 31);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Стереть!";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmScreenShot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 561);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlScreenShot);
            this.Controls.Add(this.btnGraphics);
            this.Controls.Add(this.btnDLL);
            this.Name = "frmScreenShot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenShot";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmScreenShot_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmScreenShot_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmScreenShot_MouseUp);
            this.pnlScreenShot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenShot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDLL;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.Panel pnlScreenShot;
        private System.Windows.Forms.PictureBox pbScreenShot;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}

