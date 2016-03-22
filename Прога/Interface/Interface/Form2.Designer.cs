namespace Interface
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.avtorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet4 = new Interface.praktikaDataSet4();
            this.avtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet1 = new Interface.praktikaDataSet1();
            this.avtorTableAdapter = new Interface.praktikaDataSet1TableAdapters.avtorTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.avtorTableAdapter1 = new Interface.praktikaDataSet4TableAdapters.avtorTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Введите название книги";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбрать текст";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.avtorBindingSource1;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "key_avtor";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // avtorBindingSource1
            // 
            this.avtorBindingSource1.DataMember = "avtor";
            this.avtorBindingSource1.DataSource = this.praktikaDataSet4;
            // 
            // praktikaDataSet4
            // 
            this.praktikaDataSet4.DataSetName = "praktikaDataSet4";
            this.praktikaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtorBindingSource
            // 
            this.avtorBindingSource.DataMember = "avtor";
            this.avtorBindingSource.DataSource = this.praktikaDataSet1;
            // 
            // praktikaDataSet1
            // 
            this.praktikaDataSet1.DataSetName = "praktikaDataSet1";
            this.praktikaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtorTableAdapter
            // 
            this.avtorTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "Добавить автора";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // avtorTableAdapter1
            // 
            this.avtorTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 44);
            this.button4.TabIndex = 7;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 232);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(290, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(10, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(290, 150);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Пожалуйста, подождите";
            this.richTextBox1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 266);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private praktikaDataSet1 praktikaDataSet1;
        private System.Windows.Forms.BindingSource avtorBindingSource;
        private praktikaDataSet1TableAdapters.avtorTableAdapter avtorTableAdapter;
        private System.Windows.Forms.Button button3;
        private praktikaDataSet4 praktikaDataSet4;
        private System.Windows.Forms.BindingSource avtorBindingSource1;
        private praktikaDataSet4TableAdapters.avtorTableAdapter avtorTableAdapter1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}