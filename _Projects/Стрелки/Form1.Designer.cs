namespace Стрелки
{
    partial class frmArrows
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
            this.components = new System.ComponentModel.Container();
            this.lblH = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnShot = new System.Windows.Forms.Button();
            this.tmrShot = new System.Windows.Forms.Timer(this.components);
            this.lblDist = new System.Windows.Forms.Label();
            this.chPrizel = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.BackColor = System.Drawing.Color.Transparent;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblH.Location = new System.Drawing.Point(635, 9);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(74, 16);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "Высота =";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.BackColor = System.Drawing.Color.Transparent;
            this.lblAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAngle.Location = new System.Drawing.Point(635, 34);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(55, 16);
            this.lblAngle.TabIndex = 1;
            this.lblAngle.Text = "Угол =";
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.BackColor = System.Drawing.Color.Transparent;
            this.lblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblV.Location = new System.Drawing.Point(635, 59);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(89, 16);
            this.lblV.TabIndex = 2;
            this.lblV.Text = "Скорость =";
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.ForeColor = System.Drawing.Color.Green;
            this.btnLoad.Location = new System.Drawing.Point(139, 540);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 31);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Заря-жай!";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnShot
            // 
            this.btnShot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShot.ForeColor = System.Drawing.Color.Red;
            this.btnShot.Location = new System.Drawing.Point(245, 540);
            this.btnShot.Name = "btnShot";
            this.btnShot.Size = new System.Drawing.Size(100, 31);
            this.btnShot.TabIndex = 16;
            this.btnShot.Text = "Пли!";
            this.btnShot.UseVisualStyleBackColor = true;
            this.btnShot.Click += new System.EventHandler(this.btnShot_Click);
            // 
            // tmrShot
            // 
            this.tmrShot.Interval = 20;
            this.tmrShot.Tick += new System.EventHandler(this.tmrShot_Tick);
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.BackColor = System.Drawing.Color.Transparent;
            this.lblDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDist.Location = new System.Drawing.Point(635, 84);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(99, 16);
            this.lblDist.TabIndex = 17;
            this.lblDist.Text = "Дистанция =";
            // 
            // chPrizel
            // 
            this.chPrizel.AutoSize = true;
            this.chPrizel.BackColor = System.Drawing.Color.Transparent;
            this.chPrizel.Checked = true;
            this.chPrizel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chPrizel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chPrizel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chPrizel.Location = new System.Drawing.Point(638, 109);
            this.chPrizel.Name = "chPrizel";
            this.chPrizel.Size = new System.Drawing.Size(83, 20);
            this.chPrizel.TabIndex = 18;
            this.chPrizel.Text = "Прицел";
            this.chPrizel.UseVisualStyleBackColor = false;
            this.chPrizel.CheckedChanged += new System.EventHandler(this.chPrizel_CheckedChanged);
            // 
            // frmArrows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Стрелки.Properties.Resources.bHimmel_Classic_Bryce_Sunset_0ccl;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 574);
            this.Controls.Add(this.chPrizel);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.btnShot);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.lblH);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmArrows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меткие стрелки";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmArrows_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmArrows_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmArrows_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmArrows_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnShot;
        private System.Windows.Forms.Timer tmrShot;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.CheckBox chPrizel;
    }
}

