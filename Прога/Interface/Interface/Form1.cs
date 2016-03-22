using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Interface
{

    public partial class Form1 : Form
    {
        //static SqlConnection conn;
        //static string stringConnection = "Data Source=HP\\HP;Initial Catalog=praktika;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet8.avtor". При необходимости она может быть перемещена или удалена.
            this.avtorTableAdapter2.Fill(this.praktikaDataSet8.avtor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet5.avtor". При необходимости она может быть перемещена или удалена.
            this.avtorTableAdapter1.Fill(this.praktikaDataSet5.avtor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet1.avtor". При необходимости она может быть перемещена или удалена.
            this.avtorTableAdapter.Fill(this.praktikaDataSet1.avtor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet.GetMetrik". При необходимости она может быть перемещена или удалена.
            //this.getMetrikTableAdapter.Fill(this.praktikaDataSet.GetMetrik);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 learn = new Form2();
            learn.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 search = new Form4();
            search.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.name_bookTableAdapter1.Fill(this.praktikaDataSet7.Name_book, comboBox1.SelectedValue.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
            //начало
            string filename = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Текстовые файлы(*.txt)|*.txt" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                filename = openFileDialog1.FileName;

            using (StreamReader sr = new StreamReader(filename, Encoding.GetEncoding(1251)))
            {
                using (StreamWriter outfile = new StreamWriter("input.txt"))
                {
                    outfile.Write(sr.ReadToEnd());
                    outfile.Close();
                }
                sr.Close();
            }
            int time_mystem = System.IO.File.ReadAllLines("input.txt").Length;
            System.Diagnostics.Process.Start("cmd.exe", "/C" + "mystem.exe -in input.txt output.txt");
            System.Threading.Thread.Sleep(15*time_mystem);
            int time_mystem2 = System.IO.File.ReadAllLines("output.txt").Length;
            MessageBox.Show(time_mystem2.ToString());

            using (StreamReader fs = new StreamReader("output.txt"))
            {
                string temp;
                
                while ((temp = fs.ReadLine()) != null)
                {
                    //MessageBox.Show(temp.ToString());
                    Regex newReg = new Regex("=.*?(=|,)");
                    Match m = newReg.Match(temp);
                    //MessageBox.Show(temp.ToString());
                    //MessageBox.Show(m.ToString());
                    switch (m.ToString())
                    {
                        case ("=S,"): MessageBox.Show("Sychect"); break;
                        case ("=S="): MessageBox.Show("Sychect"); break;
                        case ("=ANUM,"): MessageBox.Show("pril"); break;
                        case ("=ANUM="): MessageBox.Show("pril"); break;
                        case ("=SPRO,"): MessageBox.Show("mest"); break;
                        case ("=SPRO="): MessageBox.Show("mest"); break;
                        case ("=V,"): MessageBox.Show("glag"); break;
                        case ("=V="): MessageBox.Show("glag"); break;
                        case ("=ADV,"): MessageBox.Show("narech"); break;
                        case ("=ADV="): MessageBox.Show("narech"); break;
                        case ("=INTJ,"): MessageBox.Show("megd"); break;
                        case ("=INTJ="): MessageBox.Show("megd"); break;
                        case ("=PART,"): MessageBox.Show("glag"); break;
                        case ("=PART="): MessageBox.Show("glag"); break;

                    }
                }
                fs.Close();
            }
            File.Open("output.txt", FileMode.Truncate).Close(); //очищение файла
            File.Open("input.txt", FileMode.Truncate).Close(); //очищение файла
            //конец
             * */
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 setting = new Form5();
            setting.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Refresh();
            this.avtorTableAdapter1.Fill(this.praktikaDataSet5.avtor);
            this.avtorTableAdapter2.Fill(this.praktikaDataSet8.avtor);
            this.avtorTableAdapter.Fill(this.praktikaDataSet1.avtor);
        }
    }
}
