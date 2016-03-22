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
    public partial class Form5 : Form
    {
        static SqlConnection conn;
        static string stringConnection = "Data Source=HP\\HP;Initial Catalog=praktika;Integrated Security=True";
 
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet9.books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.praktikaDataSet9.books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet8.avtor". При необходимости она может быть перемещена или удалена.
            this.avtorTableAdapter.Fill(this.praktikaDataSet8.avtor);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            using (conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                int id1 = int.Parse(comboBox1.SelectedValue.ToString());
                SqlCommand cmd2 = new SqlCommand("DELETE FROM dbo.books WHERE key_avtor = '" + id1 + "'", conn);
                SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Avtor WHERE key_avtor = '" + id1 + "'", conn);
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Удален автор (и его книги) : "+ comboBox1.Text.ToString());
                conn.Close();
                //this.DialogResult = DialogResult.OK;

            }
            this.avtorTableAdapter.Fill(this.praktikaDataSet8.avtor);
            this.booksTableAdapter.Fill(this.praktikaDataSet9.books); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                int id3 = int.Parse(comboBox2.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand("DELETE FROM dbo.books WHERE key_book = '" + id3 + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Удална книга : " + comboBox2.Text.ToString());
                conn.Close();
                this.DialogResult = DialogResult.OK;

            }
            this.booksTableAdapter.Fill(this.praktikaDataSet9.books); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
//кластерный анализ и визиализация резцультатов