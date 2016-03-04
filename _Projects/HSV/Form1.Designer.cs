namespace HSV
{
    partial class frmHSV
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
            this.lblColor = new System.Windows.Forms.Label();
            this.tbR = new System.Windows.Forms.TrackBar();
            this.tbG = new System.Windows.Forms.TrackBar();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbH = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbS = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tbV = new System.Windows.Forms.TrackBar();
            this.pbV = new System.Windows.Forms.PictureBox();
            this.pbS = new System.Windows.Forms.PictureBox();
            this.pbB = new System.Windows.Forms.PictureBox();
            this.pbG = new System.Windows.Forms.PictureBox();
            this.pbR = new System.Windows.Forms.PictureBox();
            this.pbH = new System.Windows.Forms.PictureBox();
            this.lblR = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Black;
            this.lblColor.Location = new System.Drawing.Point(610, 22);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(154, 319);
            this.lblColor.TabIndex = 6;
            // 
            // tbR
            // 
            this.tbR.AutoSize = false;
            this.tbR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbR.Location = new System.Drawing.Point(20, 1);
            this.tbR.Margin = new System.Windows.Forms.Padding(0);
            this.tbR.Maximum = 255;
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(537, 26);
            this.tbR.TabIndex = 7;
            this.tbR.TickFrequency = 8;
            this.tbR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbR.Scroll += new System.EventHandler(this.tbR_Scroll);
            // 
            // tbG
            // 
            this.tbG.AutoSize = false;
            this.tbG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbG.Location = new System.Drawing.Point(20, 51);
            this.tbG.Margin = new System.Windows.Forms.Padding(0);
            this.tbG.Maximum = 255;
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(537, 26);
            this.tbG.TabIndex = 9;
            this.tbG.TickFrequency = 8;
            this.tbG.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbG.Scroll += new System.EventHandler(this.tbG_Scroll);
            // 
            // tbB
            // 
            this.tbB.AutoSize = false;
            this.tbB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbB.Location = new System.Drawing.Point(20, 101);
            this.tbB.Margin = new System.Windows.Forms.Padding(0);
            this.tbB.Maximum = 255;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(537, 26);
            this.tbB.TabIndex = 11;
            this.tbB.TickFrequency = 8;
            this.tbB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbB.Scroll += new System.EventHandler(this.tbB_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "B";
            // 
            // tbH
            // 
            this.tbH.AutoSize = false;
            this.tbH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbH.Location = new System.Drawing.Point(20, 187);
            this.tbH.Margin = new System.Windows.Forms.Padding(0);
            this.tbH.Maximum = 360;
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(537, 26);
            this.tbH.TabIndex = 16;
            this.tbH.TickFrequency = 8;
            this.tbH.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbH.Scroll += new System.EventHandler(this.tbH_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "H";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "S";
            // 
            // tbS
            // 
            this.tbS.AutoSize = false;
            this.tbS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbS.Location = new System.Drawing.Point(20, 237);
            this.tbS.Margin = new System.Windows.Forms.Padding(0);
            this.tbS.Maximum = 100;
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(537, 26);
            this.tbS.TabIndex = 20;
            this.tbS.TickFrequency = 8;
            this.tbS.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbS.Scroll += new System.EventHandler(this.tbS_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "V";
            // 
            // tbV
            // 
            this.tbV.AutoSize = false;
            this.tbV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbV.Location = new System.Drawing.Point(20, 287);
            this.tbV.Margin = new System.Windows.Forms.Padding(0);
            this.tbV.Maximum = 100;
            this.tbV.Name = "tbV";
            this.tbV.Size = new System.Drawing.Size(537, 26);
            this.tbV.TabIndex = 24;
            this.tbV.TickFrequency = 8;
            this.tbV.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbV.Scroll += new System.EventHandler(this.tbV_Scroll);
            // 
            // pbV
            // 
            this.pbV.Image = global::HSV.Properties.Resources.v;
            this.pbV.Location = new System.Drawing.Point(33, 308);
            this.pbV.Name = "pbV";
            this.pbV.Size = new System.Drawing.Size(512, 27);
            this.pbV.TabIndex = 22;
            this.pbV.TabStop = false;
            // 
            // pbS
            // 
            this.pbS.Image = global::HSV.Properties.Resources.s;
            this.pbS.Location = new System.Drawing.Point(33, 258);
            this.pbS.Name = "pbS";
            this.pbS.Size = new System.Drawing.Size(512, 27);
            this.pbS.TabIndex = 18;
            this.pbS.TabStop = false;
            // 
            // pbB
            // 
            this.pbB.Image = global::HSV.Properties.Resources.b;
            this.pbB.Location = new System.Drawing.Point(33, 122);
            this.pbB.Name = "pbB";
            this.pbB.Size = new System.Drawing.Size(512, 27);
            this.pbB.TabIndex = 5;
            this.pbB.TabStop = false;
            // 
            // pbG
            // 
            this.pbG.Image = global::HSV.Properties.Resources.g;
            this.pbG.Location = new System.Drawing.Point(33, 72);
            this.pbG.Name = "pbG";
            this.pbG.Size = new System.Drawing.Size(512, 27);
            this.pbG.TabIndex = 4;
            this.pbG.TabStop = false;
            // 
            // pbR
            // 
            this.pbR.Image = global::HSV.Properties.Resources.r;
            this.pbR.Location = new System.Drawing.Point(33, 22);
            this.pbR.Name = "pbR";
            this.pbR.Size = new System.Drawing.Size(512, 27);
            this.pbR.TabIndex = 3;
            this.pbR.TabStop = false;
            // 
            // pbH
            // 
            this.pbH.Image = global::HSV.Properties.Resources.grad;
            this.pbH.Location = new System.Drawing.Point(33, 208);
            this.pbH.Name = "pbH";
            this.pbH.Size = new System.Drawing.Size(512, 27);
            this.pbH.TabIndex = 0;
            this.pbH.TabStop = false;
            // 
            // lblR
            // 
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblR.Location = new System.Drawing.Point(557, 21);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(42, 27);
            this.lblR.TabIndex = 26;
            this.lblR.Text = "0";
            this.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblG
            // 
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblG.Location = new System.Drawing.Point(557, 71);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(42, 27);
            this.lblG.TabIndex = 27;
            this.lblG.Text = "0";
            this.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblB
            // 
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblB.Location = new System.Drawing.Point(557, 121);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(42, 27);
            this.lblB.TabIndex = 28;
            this.lblB.Text = "0";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblH
            // 
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblH.Location = new System.Drawing.Point(557, 210);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(42, 27);
            this.lblH.TabIndex = 29;
            this.lblH.Text = "0";
            this.lblH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblS
            // 
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblS.Location = new System.Drawing.Point(557, 260);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(42, 27);
            this.lblS.TabIndex = 30;
            this.lblS.Text = "0";
            this.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblV
            // 
            this.lblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblV.Location = new System.Drawing.Point(557, 310);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(42, 27);
            this.lblV.TabIndex = 31;
            this.lblV.Text = "0";
            this.lblV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmHSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 360);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.pbV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbV);
            this.Controls.Add(this.pbS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.pbB);
            this.Controls.Add(this.pbG);
            this.Controls.Add(this.pbR);
            this.Controls.Add(this.pbH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.lblColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HSV";
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbH;
        private System.Windows.Forms.PictureBox pbR;
        private System.Windows.Forms.PictureBox pbG;
        private System.Windows.Forms.PictureBox pbB;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TrackBar tbR;
        private System.Windows.Forms.TrackBar tbG;
        private System.Windows.Forms.TrackBar tbB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbS;
        private System.Windows.Forms.PictureBox pbV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tbV;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblV;
    }
}

