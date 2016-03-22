namespace Interface
{
    partial class Form3
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
            this.avtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet8 = new Interface.praktikaDataSet8();
            this.avtorTableAdapter = new Interface.praktikaDataSet8TableAdapters.avtorTableAdapter();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet9 = new Interface.praktikaDataSet9();
            this.praktikaDataSet5 = new Interface.praktikaDataSet5();
            this.praktikaDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Interface.praktikaDataSet9TableAdapters.booksTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // avtorBindingSource
            // 
            this.avtorBindingSource.DataMember = "avtor";
            this.avtorBindingSource.DataSource = this.praktikaDataSet8;
            // 
            // praktikaDataSet8
            // 
            this.praktikaDataSet8.DataSetName = "praktikaDataSet8";
            this.praktikaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtorTableAdapter
            // 
            this.avtorTableAdapter.ClearBeforeFill = true;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.praktikaDataSet9;
            // 
            // praktikaDataSet9
            // 
            this.praktikaDataSet9.DataSetName = "praktikaDataSet9";
            this.praktikaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // praktikaDataSet5
            // 
            this.praktikaDataSet5.DataSetName = "praktikaDataSet5";
            this.praktikaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // praktikaDataSet5BindingSource
            // 
            this.praktikaDataSet5BindingSource.DataSource = this.praktikaDataSet5;
            this.praktikaDataSet5BindingSource.Position = 0;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(66, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 184);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet5BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private praktikaDataSet8 praktikaDataSet8;
        private System.Windows.Forms.BindingSource avtorBindingSource;
        private praktikaDataSet8TableAdapters.avtorTableAdapter avtorTableAdapter;
        private System.Windows.Forms.BindingSource praktikaDataSet5BindingSource;
        private praktikaDataSet5 praktikaDataSet5;
        private praktikaDataSet9 praktikaDataSet9;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private praktikaDataSet9TableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.Button button4;
    }
}