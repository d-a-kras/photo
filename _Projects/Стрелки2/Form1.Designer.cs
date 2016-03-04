namespace Стрелки2
{
    partial class frmArrows2
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
            this.pnlField = new System.Windows.Forms.Panel();
            this.chPrizel = new System.Windows.Forms.CheckBox();
            this.lblDist = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblTargetX = new System.Windows.Forms.Label();
            this.lblTargetY = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnShot = new System.Windows.Forms.Button();
            this.tmrShot = new System.Windows.Forms.Timer(this.components);
            this.pbField = new System.Windows.Forms.PictureBox();
            this.pnlField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbField)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlField
            // 
            this.pnlField.AutoScroll = true;
            this.pnlField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlField.Controls.Add(this.pbField);
            this.pnlField.Location = new System.Drawing.Point(0, 0);
            this.pnlField.Name = "pnlField";
            this.pnlField.Size = new System.Drawing.Size(780, 600);
            this.pnlField.TabIndex = 1;
            // 
            // chPrizel
            // 
            this.chPrizel.AutoSize = true;
            this.chPrizel.BackColor = System.Drawing.Color.Transparent;
            this.chPrizel.Checked = true;
            this.chPrizel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chPrizel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chPrizel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chPrizel.Location = new System.Drawing.Point(797, 109);
            this.chPrizel.Name = "chPrizel";
            this.chPrizel.Size = new System.Drawing.Size(83, 20);
            this.chPrizel.TabIndex = 23;
            this.chPrizel.Text = "Прицел";
            this.chPrizel.UseVisualStyleBackColor = false;
            this.chPrizel.CheckedChanged += new System.EventHandler(this.chPrizel_CheckedChanged);
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.BackColor = System.Drawing.Color.Transparent;
            this.lblDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDist.Location = new System.Drawing.Point(794, 84);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(99, 16);
            this.lblDist.TabIndex = 22;
            this.lblDist.Text = "Дистанция =";
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.BackColor = System.Drawing.Color.Transparent;
            this.lblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblV.Location = new System.Drawing.Point(794, 59);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(89, 16);
            this.lblV.TabIndex = 21;
            this.lblV.Text = "Скорость =";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.BackColor = System.Drawing.Color.Transparent;
            this.lblAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAngle.Location = new System.Drawing.Point(794, 34);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(55, 16);
            this.lblAngle.TabIndex = 20;
            this.lblAngle.Text = "Угол =";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.BackColor = System.Drawing.Color.Transparent;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblH.Location = new System.Drawing.Point(794, 9);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(74, 16);
            this.lblH.TabIndex = 19;
            this.lblH.Text = "Высота =";
            // 
            // lblTargetX
            // 
            this.lblTargetX.AutoSize = true;
            this.lblTargetX.BackColor = System.Drawing.Color.Transparent;
            this.lblTargetX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTargetX.Location = new System.Drawing.Point(794, 175);
            this.lblTargetX.Name = "lblTargetX";
            this.lblTargetX.Size = new System.Drawing.Size(69, 16);
            this.lblTargetX.TabIndex = 24;
            this.lblTargetX.Text = "Цель X =";
            // 
            // lblTargetY
            // 
            this.lblTargetY.AutoSize = true;
            this.lblTargetY.BackColor = System.Drawing.Color.Transparent;
            this.lblTargetY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTargetY.Location = new System.Drawing.Point(794, 200);
            this.lblTargetY.Name = "lblTargetY";
            this.lblTargetY.Size = new System.Drawing.Size(70, 16);
            this.lblTargetY.TabIndex = 25;
            this.lblTargetY.Text = "Цель Y =";
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.ForeColor = System.Drawing.Color.Green;
            this.btnLoad.Location = new System.Drawing.Point(797, 498);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(146, 31);
            this.btnLoad.TabIndex = 26;
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
            this.btnShot.Location = new System.Drawing.Point(797, 549);
            this.btnShot.Name = "btnShot";
            this.btnShot.Size = new System.Drawing.Size(146, 31);
            this.btnShot.TabIndex = 27;
            this.btnShot.Text = "Пли!";
            this.btnShot.UseVisualStyleBackColor = true;
            this.btnShot.Click += new System.EventHandler(this.btnShot_Click);
            // 
            // tmrShot
            // 
            this.tmrShot.Interval = 20;
            this.tmrShot.Tick += new System.EventHandler(this.tmrShot_Tick);
            // 
            // pbField
            // 
            this.pbField.BackgroundImage = global::Стрелки2.Properties.Resources.sky;
            this.pbField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbField.Location = new System.Drawing.Point(0, 0);
            this.pbField.Name = "pbField";
            this.pbField.Size = new System.Drawing.Size(2048, 580);
            this.pbField.TabIndex = 1;
            this.pbField.TabStop = false;
            this.pbField.Paint += new System.Windows.Forms.PaintEventHandler(this.pbField_Paint);
            this.pbField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbField_MouseDown);
            this.pbField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbField_MouseMove);
            this.pbField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbField_MouseUp);
            // 
            // frmArrows2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 602);
            this.Controls.Add(this.btnShot);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblTargetY);
            this.Controls.Add(this.lblTargetX);
            this.Controls.Add(this.chPrizel);
            this.Controls.Add(this.pnlField);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblAngle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmArrows2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дальнобойные стрелки";
            this.pnlField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlField;
        private System.Windows.Forms.PictureBox pbField;
        private System.Windows.Forms.CheckBox chPrizel;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblTargetX;
        private System.Windows.Forms.Label lblTargetY;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnShot;
        private System.Windows.Forms.Timer tmrShot;
    }
}

