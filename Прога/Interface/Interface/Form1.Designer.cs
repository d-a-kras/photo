namespace Interface
{
    partial class Form1
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
            this.getMetrikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet = new Interface.praktikaDataSet();
            this.getMetrikTableAdapter = new Interface.praktikaDataSetTableAdapters.GetMetrikTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.avtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet1 = new Interface.praktikaDataSet1();
            this.avtorTableAdapter = new Interface.praktikaDataSet1TableAdapters.avtorTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namebookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet7 = new Interface.praktikaDataSet7();
            this.praktikaDataSet6 = new Interface.praktikaDataSet6();
            this.namebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.name_bookTableAdapter = new Interface.praktikaDataSet6TableAdapters.Name_bookTableAdapter();
            this.praktikaDataSet5 = new Interface.praktikaDataSet5();
            this.avtorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.avtorTableAdapter1 = new Interface.praktikaDataSet5TableAdapters.avtorTableAdapter();
            this.praktikaDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.name_bookTableAdapter1 = new Interface.praktikaDataSet7TableAdapters.Name_bookTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.praktikaDataSet8 = new Interface.praktikaDataSet8();
            this.avtorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.avtorTableAdapter2 = new Interface.praktikaDataSet8TableAdapters.avtorTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.getMetrikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namebookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namebookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // getMetrikBindingSource
            // 
            this.getMetrikBindingSource.DataMember = "GetMetrik";
            this.getMetrikBindingSource.DataSource = this.praktikaDataSet;
            // 
            // praktikaDataSet
            // 
            this.praktikaDataSet.DataSetName = "praktikaDataSet";
            this.praktikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getMetrikTableAdapter
            // 
            this.getMetrikTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.avtorBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "name";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Определить автора";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Обучить систему";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namebookDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.namebookBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(220, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(244, 194);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // namebookDataGridViewTextBoxColumn
            // 
            this.namebookDataGridViewTextBoxColumn.DataPropertyName = "name_book";
            this.namebookDataGridViewTextBoxColumn.HeaderText = "Название_книги";
            this.namebookDataGridViewTextBoxColumn.Name = "namebookDataGridViewTextBoxColumn";
            this.namebookDataGridViewTextBoxColumn.ReadOnly = true;
            this.namebookDataGridViewTextBoxColumn.Width = 200;
            // 
            // namebookBindingSource1
            // 
            this.namebookBindingSource1.DataMember = "Name_book";
            this.namebookBindingSource1.DataSource = this.praktikaDataSet7;
            // 
            // praktikaDataSet7
            // 
            this.praktikaDataSet7.DataSetName = "praktikaDataSet7";
            this.praktikaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // praktikaDataSet6
            // 
            this.praktikaDataSet6.DataSetName = "praktikaDataSet6";
            this.praktikaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // namebookBindingSource
            // 
            this.namebookBindingSource.DataMember = "Name_book";
            this.namebookBindingSource.DataSource = this.praktikaDataSet6;
            // 
            // name_bookTableAdapter
            // 
            this.name_bookTableAdapter.ClearBeforeFill = true;
            // 
            // praktikaDataSet5
            // 
            this.praktikaDataSet5.DataSetName = "praktikaDataSet5";
            this.praktikaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtorBindingSource1
            // 
            this.avtorBindingSource1.DataMember = "avtor";
            this.avtorBindingSource1.DataSource = this.praktikaDataSet5;
            // 
            // avtorTableAdapter1
            // 
            this.avtorTableAdapter1.ClearBeforeFill = true;
            // 
            // praktikaDataSet5BindingSource
            // 
            this.praktikaDataSet5BindingSource.DataSource = this.praktikaDataSet5;
            this.praktikaDataSet5BindingSource.Position = 0;
            // 
            // name_bookTableAdapter1
            // 
            this.name_bookTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // praktikaDataSet8
            // 
            this.praktikaDataSet8.DataSetName = "praktikaDataSet8";
            this.praktikaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtorBindingSource2
            // 
            this.avtorBindingSource2.DataMember = "avtor";
            this.avtorBindingSource2.DataSource = this.praktikaDataSet8;
            // 
            // avtorTableAdapter2
            // 
            this.avtorTableAdapter2.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 41);
            this.button4.TabIndex = 11;
            this.button4.Text = "Редактиривание базы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(12, 126);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 32);
            this.button5.TabIndex = 12;
            this.button5.Text = "Обновить базу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 346);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getMetrikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namebookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namebookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private praktikaDataSet praktikaDataSet;
        private System.Windows.Forms.BindingSource getMetrikBindingSource;
        private praktikaDataSetTableAdapters.GetMetrikTableAdapter getMetrikTableAdapter;
        private praktikaDataSet1 praktikaDataSet1;
        private System.Windows.Forms.BindingSource avtorBindingSource;
        private praktikaDataSet1TableAdapters.avtorTableAdapter avtorTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource namebookBindingSource;
        private praktikaDataSet6 praktikaDataSet6;
        private praktikaDataSet6TableAdapters.Name_bookTableAdapter name_bookTableAdapter;
        private praktikaDataSet5 praktikaDataSet5;
        private System.Windows.Forms.BindingSource avtorBindingSource1;
        private praktikaDataSet5TableAdapters.avtorTableAdapter avtorTableAdapter1;
        private System.Windows.Forms.BindingSource praktikaDataSet5BindingSource;
        private System.Windows.Forms.BindingSource namebookBindingSource1;
        private praktikaDataSet7 praktikaDataSet7;
        private praktikaDataSet7TableAdapters.Name_bookTableAdapter name_bookTableAdapter1;
        private System.Windows.Forms.Button button1;
        private praktikaDataSet8 praktikaDataSet8;
        private System.Windows.Forms.BindingSource avtorBindingSource2;
        private praktikaDataSet8TableAdapters.avtorTableAdapter avtorTableAdapter2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

