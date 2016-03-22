using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form3 : Form
    {
        static SqlConnection conn;
        static string stringConnection = "Data Source=HP\\HP;Initial Catalog=praktika;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(stringConnection))
                if (textBox1.Text != "")
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [avtor] (name) VALUES (@a1)", conn);
                    cmd.Parameters.AddWithValue("@a1", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Автор добавлен: " + textBox1.Text.ToString());
                    this.Close();
                    
                }
                else
                    MessageBox.Show("Введите имя автора");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet9.books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.praktikaDataSet9.books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet8.avtor". При необходимости она может быть перемещена или удалена.
            this.avtorTableAdapter.Fill(this.praktikaDataSet8.avtor);

        }

        private void button4_Click(object sender, EventArgs e)
        {  
            this.Close();
        }

       
    }
}
