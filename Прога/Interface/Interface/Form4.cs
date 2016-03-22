using System;
using System.Collections;
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
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Interface
{
    public partial class Form4 : Form
    {
        static int N = 21; //количество метрик
        static SqlConnection conn;
        static string stringConnection = "Data Source=HP\\HP;Initial Catalog=praktika;Integrated Security=True";
        static string slov_glas = "аеёиоуэюяeyuioa";
        static string slov_soglas = "йцкнгшщзхфвпрлджчсмтбqwrtpsdfghjklzxcvbnm";
        static string avtor2;
        static int id_text;
        static public int pril = 0;
        static public int glagol = 0;
        static public int sysh = 0;
        static public int mest = 0;
        static public int narech = 0;
        static public int megd = 0;
        static public int chast = 0;

        public static void read_mysteam(string s) {
            Regex newReg = new Regex("=.*?(=|,)");        
            Match m = newReg.Match(s);
            //MessageBox.Show(temp.ToString());
            //MessageBox.Show(m.ToString());
            switch (m.ToString())
            {
                case ("=ANUM,"): pril++; break;
                case ("=ANUM="): pril++; break;
                case ("=V,"): glagol++; break;
                case ("=V="): glagol++; break;
                case ("=S,"): sysh++; break;
                case ("=S="): sysh++; break;
                case ("=SPRO,"): mest++; break;
                case ("=SPRO="): mest++; break;
                case ("=ADV,"): narech++; break;
                case ("=ADV="): narech++; break;
                case ("=INTJ,"): megd++; break;
                case ("=INTJ="): megd++; break;
                case ("=PART,"): chast++; break;
                case ("=PART="): chast++; break;
            }
        }

        public static class perem
        {
            public static float[] nums = new float[N];
            public static string filename;
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Текстовые файлы(*.txt)|*.txt" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                perem.filename = openFileDialog1.FileName;
            textBox1.Text = perem.filename;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            Column1.Visible = false;
            Column2.Visible = false;
            dataGridView1.Visible = false;
            textBox1.Visible = false;
            richTextBox1.Visible = true;
            progressBar1.Visible = true;
            dataGridView1.Rows.Clear();
            if (textBox1.Text != "")
            {
                string s = "";
                using (StreamReader sr = new StreamReader(perem.filename, Encoding.GetEncoding(1251)))
                {
                    s = sr.ReadToEnd();
                    using (StreamWriter sr2 = new StreamWriter("input.txt"))
                    {
                        sr2.Write(s);
                        sr2.Close();
                    }
                }
               // System.Diagnostics.Process.Start("cmd.exe", "/C" + "mystem.exe -in input.txt output.txt");
               // System.Threading.Thread.Sleep(time_mystem);

                Process p = new Process();
                ProcessStartInfo ss = new ProcessStartInfo();
                ss.FileName = "cmd.exe";
                //ss.CreateNoWindow = false;
                ss.CreateNoWindow = true;
                ss.WindowStyle = ProcessWindowStyle.Hidden;
                //ss.WindowStyle = ProcessWindowStyle.Normal;
                ss.Arguments = "/C" + "mystem.exe -in input.txt output.txt";
                p.StartInfo = ss;
                p.Start();
                p.WaitForExit();

                List<string> list_output = new List<string>();
                using (StreamReader sr2 = new StreamReader("output.txt", Encoding.GetEncoding(1251)))
                {
                    string temp = "";
                    while ((temp = sr2.ReadLine()) != null)
                    {
                        list_output.Add(temp);
                    }
                    sr2.Close();
                }

                progressBar1.Maximum = s.Length + list_output.Count;
                progressBar1.Minimum = 0;
                progressBar1.Step = 1;
                if (s.Length != 0)
                {
                    for (int i = 0; i < perem.nums.Length; i++) perem.nums[i] = 0;
                    int count = 0;
                    int count_diol = 0;
                    int count3000 = 0;
                    int count10000 = 0;
                    int count100000 = 0;
                    int voskl1 = 0;
                    int voskl2 = 0;
                    int voskl3 = 0;
                    int vopr = 0;
                    int trtoch = 0;
                    pril = 0;
                    glagol = 0;
                    sysh = 0;
                    mest = 0;
                    narech = 0;
                    megd = 0;
                    chast = 0;
                    List<float> list3000 = new List<float>();
                    List<float> list10000 = new List<float>();
                    List<float> list100000 = new List<float>();
                    int dlina = 0;
                    int max_dlina = 0;
                    for (int i = 0; i < s.Length; i++)
                    {
                        progressBar1.PerformStep();
                        if ((s[i] != '.') && (s[i] != '!') && (s[i] != '?') && (s[i] != '\n')) dlina++;
                        else
                        {
                            if (max_dlina < dlina)
                                max_dlina = dlina;
                            dlina = 0;
                        }
                        if (s[i] == ',') perem.nums[0]++;
                        if (s[i] == '?') vopr++;


                        for (int j = 0; j < slov_glas.Length; j++)
                        {
                            if (s[i] == slov_glas[j]) perem.nums[1]++;
                        }
                        for (int j = 0; j < slov_soglas.Length; j++)
                        {
                            if (s[i] == slov_soglas[j]) perem.nums[2]++;
                        }
                        if (s[i] == '.')
                        {
                            count++;
                            count3000++;
                            count10000++;
                            count100000++;
                        }

                        if (i < s.Length - 2)
                            if ((s[i] == '.' && s[i + 1] == '-') || (s[i] == '.' && s[i + 2] == '-')) count_diol++;
                        if (i % 3000 == 0)
                        {
                            list3000.Add(count3000);
                            count3000 = 0;
                        }
                        if (i % 10000 == 0)
                        {
                            list10000.Add(count10000);
                            count10000 = 0;
                        }
                        if (i % 100000 == 0)
                        {
                            list100000.Add(count100000);
                            count100000 = 0;
                        }
                        if ((i < s.Length - 2) && (s[i] == '.') && (s[i + 1] == '.') && (s[i + 2] == '.')) trtoch++;
                        if (s[i] == '!')
                        {
                            voskl1++;
                            if ((i < s.Length - 1) && (s[i + 1] == '!'))
                            {
                                voskl2++;
                                if ((i < s.Length - 2) && (s[i + 2] == '!'))
                                    voskl3++;
                            }
                        }
                    }
                    //int time_mystem2 = System.IO.File.ReadAllLines("output.txt").Length;
                    //MessageBox.Show(time_mystem2.ToString());
                    /*
                    using (StreamReader fs = new StreamReader("output.txt"))
                    {
                        string temp;
                        while ((temp = fs.ReadLine()) != null)
                        {
                            progressBar1.PerformStep();
                            Regex newReg = new Regex("=.*?(=|,)");
                            Match m = newReg.Match(temp);
                            //MessageBox.Show(temp.ToString());
                            //MessageBox.Show(m.ToString());
                            switch (m.ToString())
                            {
                                case ("=ANUM,"): pril++; break;
                                case ("=ANUM="): pril++; break;
                                case ("=V,"): glagol++; break;
                                case ("=V="): glagol++; break;
                                case ("=S,"): sysh++; break;
                                case ("=S="): sysh++; break;
                                case ("=SPRO,"): mest++; break;
                                case ("=SPRO="): mest++; break;
                                case ("=ADV,"): narech++; break;
                                case ("=ADV="): narech++; break;
                                case ("=INTJ,"): megd++; break;
                                case ("=INTJ="): megd++; break;
                                case ("=PART,"): chast++; break;
                                case ("=PART="): chast++; break;
                            }
                        }

                        //Parallel.ForEach<string>(list_string, read_mysteam);
                        fs.Close();
                    }*/
                    foreach (string k in list_output)
                    {
                        read_mysteam(k);
                        progressBar1.PerformStep();
                    }
                    File.Open("output.txt", FileMode.Truncate).Close(); //очищение файла
                    File.Open("input.txt", FileMode.Truncate).Close(); //очищение файла
                    // MessageBox.Show("Прилагательных : " + pril.ToString()); // количество прилагательных
                    // MessageBox.Show("Глаголов :" + glagol.ToString()); //количество глаголов
                    if (count_diol != 0)
                        perem.nums[6] = s.Length / count_diol;
                    else perem.nums[6] = 0;

                    if (count != 0)
                        perem.nums[7] = s.Length / count;
                    else perem.nums[7] = s.Length;
                    perem.nums[3] = list3000.Average();
                    perem.nums[4] = list10000.Average();
                    perem.nums[5] = list100000.Average();
                    perem.nums[8] = voskl1;
                    perem.nums[9] = vopr;
                    perem.nums[10] = voskl2;
                    perem.nums[11] = voskl3;
                    perem.nums[12] = trtoch;
                    perem.nums[13] = max_dlina;
                    perem.nums[14] = pril;
                    perem.nums[15] = glagol;
                    perem.nums[16] = sysh;
                    perem.nums[17] = mest;
                    perem.nums[18] = narech;
                    perem.nums[19] = megd;
                    perem.nums[20] = chast;
                }
                else MessageBox.Show("Файл пустой");

                List<int> list_key = new List<int>();
                List<List<float>> list = new List<List<float>>();
                list.Add(new List<float>());
                List<string> list_avtor = new List<string>();
                List<int> list_id = new List<int>();
                for (int k = 0; k < (N - 1); k++) list.Add(new List<float>());
                using (conn = new SqlConnection(stringConnection))
                {
                    conn.Open();
                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = "SELECT * FROM books";
                    SqlDataReader reader = myCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        list_key.Add(int.Parse(reader[2].ToString()));
                        for (int i = 0; i < N; i++)
                            list[i].Add(float.Parse(reader[i + 3].ToString()));
                    }
                    conn.Close();
                }

                using (conn = new SqlConnection(stringConnection))
                {
                    conn.Open();
                    SqlCommand myCommand3 = conn.CreateCommand();
                    myCommand3.CommandText = "SELECT key_avtor FROM books WHERE metrik_zapyatie = " + (int)perem.nums[0] +
                        " AND metrilk_glasnie = " + (int)perem.nums[1] + " AND metrik_soglasnie = " + (int)perem.nums[2] +
                        " AND metrik_dolya_dialog = " + (int)perem.nums[6] + " AND metrik_SDP = " + (int)perem.nums[7] +
                        " AND metrik_voskl_znak = " + (int)perem.nums[8] + " AND metrik_vopr_znak = " + (int)perem.nums[9] +
                        " AND metrik_voskl_znak2 = " + (int)perem.nums[10] + " AND metrik_voskl_znak3 = " + (int)perem.nums[11] +
                            " AND metrik_troetochie = " + (int)perem.nums[12] +
                            " AND metrik_pril = " + (int)perem.nums[14] + " AND metrik_glagol = " + (int)perem.nums[15] +
                            " AND metrik_sysh = " + (int)perem.nums[16] + " AND metrik_mest = " + (int)perem.nums[17] +
                            " AND metrik_megd = " + (int)perem.nums[19] + " AND metrik_chast = " + (int)perem.nums[20];
                    SqlDataReader reader3 = myCommand3.ExecuteReader();
                    while (reader3.Read())
                        id_text = (int)reader3[0];
                    conn.Close();
                    // MessageBox.Show(id_text.ToString());
                }
                for (int j = 0; j < N; j++)
                {
                    float max = list[j].Max();
                    if (max < perem.nums[j]) max = perem.nums[j];
                    float min = list[j].Min();
                    if (min > perem.nums[j]) min = perem.nums[j];
                    perem.nums[j] = ((perem.nums[j] - min) / (max - min));
                    // MessageBox.Show(perem.nums[j].ToString());
                    for (int b = 0; b < list[j].Count; b++)
                        list[j][b] = ((list[j][b] - min) / (max - min));
                }

                for (int id = 1; id <= list_key.Max(); id++)
                {
                    int tochek_avtor = 0;
                    int tochek = 0;
                    double answer = 0;
                    for (int numb = 0; numb < list_key.Count; numb++)
                    {
                        if (list_key[numb] == id)
                        {
                            tochek_avtor++;
                            double summ = 0;
                            for (int i = 0; i < N; i++)
                            {
                                summ = (list[i][numb] - perem.nums[i]) + summ;
                                summ = Math.Pow(summ, 2);
                                //MessageBox.Show(Math.Pow(summ, 2).ToString());
                            }
                            summ = Math.Sqrt(summ);
                            if (summ < 1)
                                tochek = tochek + 1;
                        }
                    }

                    if (tochek_avtor != 0)
                    {
                        using (conn = new SqlConnection(stringConnection))
                        {
                            conn.Open();
                            answer = (double)tochek / (double)tochek_avtor;
                            if ((id_text == id) && (id_text != null)) answer = 1;
                            SqlCommand myCommand2 = conn.CreateCommand();
                            myCommand2.CommandText = "SELECT * FROM avtor WHERE key_avtor = " + id;
                            SqlDataReader reader2 = myCommand2.ExecuteReader();
                            while (reader2.Read())
                            {
                                // list_avtor.Add(reader2[0].ToString());
                                // list_id.Add(int.Parse(reader2[1].ToString()));
                                avtor2 = reader2[1].ToString();
                            }
                            //MessageBox.Show("Это автор номер : "+id+"    вероятность - "+ answer.ToString()+" %");
                            DataGridViewCell firstCell = new DataGridViewTextBoxCell();
                            DataGridViewCell secondCell = new DataGridViewTextBoxCell();
                            DataGridViewRow row = new DataGridViewRow();
                            firstCell.Value = avtor2.ToString();
                            secondCell.Value = (answer * 100).ToString();
                            row.Cells.AddRange(firstCell, secondCell);
                            this.dataGridView1.Rows.Add(row);
                            conn.Close();

                        }
                    }
                }
            }
            else MessageBox.Show("Файл не выбран");
            progressBar1.Value = 0;
            button1.Visible = true;
            button2.Visible = true;
            Column1.Visible = true;
            Column2.Visible = true;
            dataGridView1.Visible = true;
            textBox1.Visible = true;
            richTextBox1.Visible = false;
            progressBar1.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}