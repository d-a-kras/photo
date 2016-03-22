namespace Interface
{
    partial class Form5
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
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.praktikaDataSet8 = new Interface.praktikaDataSet8();
            this.avtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtorTableAdapter = new Interface.praktikaDataSet8TableAdapters.avtorTableAdapter();
            this.praktikaDataSet9 = new Interface.praktikaDataSet9();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Interface.praktikaDataSet9TableAdapters.booksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 24);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить книгу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.booksBindingSource;
            this.comboBox2.DisplayMember = "name_book";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 24);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "key_book";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Удалить автора";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.avtorBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "key_avtor";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 37);
            this.button4.TabIndex = 10;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // praktikaDataSet8
            // 
            this.praktikaDataSet8.DataSetName = "praktikaDataSet8";
            this.praktikaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtorBindingSource
            // 
            this.avtorBindingSource.DataMember = "avtor";
            this.avtorBindingSource.DataSource = this.praktikaDataSet8;
            // 
            // avtorTableAdapter
            // 
            this.avtorTableAdapter.ClearBeforeFill = true;
            // 
            // praktikaDataSet9
            // 
            this.praktikaDataSet9.DataSetName = "praktikaDataSet9";
            this.praktikaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.praktikaDataSet9;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 272);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private praktikaDataSet8 praktikaDataSet8;
        private System.Windows.Forms.BindingSource avtorBindingSource;
        private praktikaDataSet8TableAdapters.avtorTableAdapter avtorTableAdapter;
        private praktikaDataSet9 praktikaDataSet9;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private praktikaDataSet9TableAdapters.booksTableAdapter booksTableAdapter;
    }
}