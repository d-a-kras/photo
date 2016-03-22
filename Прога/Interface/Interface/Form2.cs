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
using System.Diagnostics;

namespace Interface
{

    public partial class Form2 : Form
    {
        static int N = 21; //количество метрик 
        static public int pril = 0;
        static public int glagol = 0;
        static public int sysh = 0;
        static public int mest = 0;
        static public int narech = 0;
        static public int megd = 0;
        static public int chast = 0;
        static public bool flag = true;
        public static class perem
        {
            public static float[] nums = new float[N];
            public static string filename;

        }


        public static void read_mysteam(string s)
        {
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

        static string slov_glas = "аеёиоуэюяeyuioa";
        static string slov_soglas = "йцкнгшщзхфвпрлджчсмтбqwrtpsdfghjklzxcvbnm";
        static SqlConnection conn;
        static string stringConnection = "Data Source=HP\\HP;Initial Catalog=praktika;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Текстовые файлы(*.txt)|*.txt" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                perem.filename = openFileDialog1.FileName;
            textBox2.Text = perem.filename;
        }


        private void button2_Click(object sender, EventArgs e)
        {

            //File.Open("output.txt", FileMode.Open).Close();
            this.avtorTableAdapter.Fill(this.praktikaDataSet1.avtor);
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            using (conn = new SqlConnection(stringConnection))
                if (perem.filename != null)
                {

                    conn.Open();
                    //    avtor = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    string s = "";
                    if (textBox1.Text != "Введите название книги" && textBox1.Text != "")
                    {
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        comboBox1.Visible = false;
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        richTextBox1.Visible = true;
                        progressBar1.Visible = true;
                        for (int i = 0; i < perem.nums.Length; i++)
                        {
                            perem.nums[i] = 0;
                        }
                        using (StreamReader sr = new StreamReader(perem.filename, Encoding.GetEncoding(1251)))
                        {
                            s = sr.ReadToEnd();
                            using (StreamWriter sr2 = new StreamWriter("input.txt"))
                            {
                                sr2.Write(s);
                                sr2.Close();
                            }
                        }
                        //int time_mystem = File.ReadAllLines("input.txt").Length;
                        //System.Diagnostics.Process.Start("cmd.exe", "/C" + "mystem.exe -in input.txt output.txt");

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


                        //System.Threading.Thread.Sleep(time_mystem);

                        //System.Threading.Thread.Sleep(800);
                        /*
                        while (true)
                        {
                            try
                            {
                                using (StreamReader sr2 = new StreamReader("output.txt", Encoding.GetEncoding(1251)))
                                {
                                    string temp = "";
                                    while ((temp = sr2.ReadLine()) != null)
                                    {
                                        list_output.Add(temp);
                                    }
                                    sr2.Close();
                                    break;
                                }
                            }
                            catch { }
                        }*/
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
                        /*
                        using (StreamReader sr2 = new StreamReader("output.txt", Encoding.GetEncoding(1251)))
                        {
                            string temp = "";
                            while ((temp = sr2.ReadLine()) != null)
                            {
                                list_output.Add(temp);
                            }
                            sr2.Close();
                        }
                         */
                        progressBar1.Maximum = s.Length + list_output.Count;
                        progressBar1.Minimum = 0;
                        progressBar1.Value = 0;
                        progressBar1.Step = 1;
                        //MessageBox.Show(s.Length.ToString());
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
                        int dlina = 0;
                        int max_dlina = 0;
                        List<float> list3000 = new List<float>();
                        List<float> list10000 = new List<float>();
                        List<float> list100000 = new List<float>();

                        for (int i = 0; i < s.Length; i++)
                        {
                           
                            if ((s[i] != '.') && (s[i] != '!') && (s[i] != '?') && (s[i] != '\n')) dlina++;
                            else
                            {
                                if (max_dlina < dlina)
                                    max_dlina = dlina;
                                dlina = 0;
                            }
                            if (s[i] == ',') perem.nums[0]++;

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
                            if (s[i] == '?') vopr++;
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
                            progressBar1.PerformStep();
                        }
                        //MessageBox.Show(max_dlina.ToString());
                        //int length_output = File.ReadAllLines("output.txt").Length;
                        //MessageBox.Show(time_mystem2.ToString());
                        //sw.Start();
                        //int time2 = File.ReadAllText("input.txt").Length;
                        //MessageBox.Show(time2.ToString());
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
                        } */

                        foreach (string k in list_output)
                        {
                            read_mysteam(k);
                            progressBar1.PerformStep();
                        }
                        //sw.Stop();
                        //MessageBox.Show(sw.Elapsed.ToString());
                        File.Open("output.txt", FileMode.Truncate).Close(); //очищение файла
                        File.Open("input.txt", FileMode.Truncate).Close(); //очищение файла
                        //File.Open("output.txt", FileMode.Open).Close();

                        if (count_diol != 0)
                            perem.nums[3] = s.Length / count_diol;
                        else perem.nums[3] = 0;

                        if (count != 0)
                            perem.nums[4] = s.Length / count;
                        else perem.nums[4] = s.Length;


                        perem.nums[5] = list3000.Average();
                        perem.nums[6] = list10000.Average();
                        perem.nums[7] = list100000.Average();
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
                        //    SqlDataReader myReader = null;

                        //  SqlCommand id = new SqlCommand(@"SELECT key_avtor FROM avtor WHERE name = '" + avtor + "'", conn);
                        //   myReader = id.ExecuteReader();
                        // myReader.Read();
                        //   this.comboBox1.SelectedIndexChanged+=new EventHandler(comboBox1_SelectedIndexChanged);
                        //   myReader.Read();
                        //  avtor = comboBox1.SelectedValue.ToString();   //comboBox1.Items[comboBox1.SelectedIndex].ToString(); ;
                        int id1 = int.Parse(comboBox1.SelectedValue.ToString()); //(int)myReader["key_avtor"];
                        //   int id1 = int.Parse(myReader[0].ToString());
                        progressBar1.PerformStep();
                        SqlCommand cmd = new SqlCommand("INSERT INTO [books] (metrik_zapyatie, metrilk_glasnie, metrik_soglasnie," +
                            " metrik_dolya_dialog, metrik_SDP, key_avtor, metrik_USA_3000, metrik_USA_10000, metrik_USA_100000, name_book," +
                            "metrik_voskl_znak, metrik_vopr_znak, metrik_voskl_znak2, metrik_voskl_znak3, metrik_troetochie, metrik_max_dlina," +
                            "metrik_pril, metrik_glagol, metrik_sysh, metrik_mest, metrik_narech, metrik_megd, metrik_chast)" +
                            " VALUES (@a1,@a2,@a3,@a4,@a7,@a6,@a8,@a9,@a10,@a11,@a12,@a13,@a14,@a15,@a16,@a17,@a18," +
                            "@a19,@a20,@a21,@a22,@a23,@a24)", conn);
                        cmd.Parameters.AddWithValue("@a1", perem.nums[0]);
                        cmd.Parameters.AddWithValue("@a2", perem.nums[1]);
                        cmd.Parameters.AddWithValue("@a3", perem.nums[2]);
                        cmd.Parameters.AddWithValue("@a4", perem.nums[3]);
                        cmd.Parameters.AddWithValue("@a7", perem.nums[4]);
                        //  myReader.Close();
                        cmd.Parameters.AddWithValue("@a11", textBox1.Text);
                        cmd.Parameters.AddWithValue("@a6", id1);
                        cmd.Parameters.AddWithValue("@a8", perem.nums[5]);
                        cmd.Parameters.AddWithValue("@a9", perem.nums[6]);
                        cmd.Parameters.AddWithValue("@a10", perem.nums[7]);
                        cmd.Parameters.AddWithValue("@a12", perem.nums[8]);
                        cmd.Parameters.AddWithValue("@a13", perem.nums[9]);
                        cmd.Parameters.AddWithValue("@a14", perem.nums[10]);
                        cmd.Parameters.AddWithValue("@a15", perem.nums[11]);
                        cmd.Parameters.AddWithValue("@a16", perem.nums[12]);
                        cmd.Parameters.AddWithValue("@a17", perem.nums[13]);
                        cmd.Parameters.AddWithValue("@a18", perem.nums[14]);
                        cmd.Parameters.AddWithValue("@a19", perem.nums[15]);
                        cmd.Parameters.AddWithValue("@a20", perem.nums[16]);
                        cmd.Parameters.AddWithValue("@a21", perem.nums[17]);
                        cmd.Parameters.AddWithValue("@a22", perem.nums[18]);
                        cmd.Parameters.AddWithValue("@a23", perem.nums[19]);
                        cmd.Parameters.AddWithValue("@a24", perem.nums[20]);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        //sw.Stop();
                        //MessageBox.Show(sw.Elapsed.ToString());
                        progressBar1.Value = 0;
                        flag = true;
                        button1.Visible = true;
                        button2.Visible = true;
                        button3.Visible = true;
                        button4.Visible = true;
                        comboBox1.Visible = true;
                        textBox1.Visible = true;
                        textBox2.Visible = true;
                        richTextBox1.Visible = false;
                        progressBar1.Visible = false;
                        MessageBox.Show("Текст добавлен");
                    }
                    else
                        MessageBox.Show("Введите название книги");
                }
                else
                    MessageBox.Show("Выберите файл");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet4.avtor". При необходимости она может быть перемещена или удалена.
            this.avtorTableAdapter1.Fill(this.praktikaDataSet4.avtor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet1.avtor". При необходимости она может быть перемещена или удалена.
            this.avtorTableAdapter.Fill(this.praktikaDataSet1.avtor);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 addavtor = new Form3();
            DialogResult d_res = addavtor.ShowDialog();
            if (d_res == DialogResult.OK)
            {
                this.avtorTableAdapter1.Fill(this.praktikaDataSet4.avtor);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = "";
                flag = false;
            }
        }

    }
}