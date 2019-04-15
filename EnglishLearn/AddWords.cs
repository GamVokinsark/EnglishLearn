using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EnglishLearn
{
    public partial class AddWords : UserControl
    {
        private StreamWriter file;
        public Form1 root;
        private string alp;
        private int len;
        private string key;
        private List<string> linesEng;
        private List<string> linesTran;

        public AddWords()
        {
            InitializeComponent();
            
            alp = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            len = alp.Length;
            key = "thelonglongstoryaboutonemyday";
            linesEng = new List<string>();
            linesTran = new List<string>();
        }

        public void getStartString()
        {
            linesEng.Clear();
            linesTran.Clear();
            StreamReader gets = new StreamReader("Dictionary.dat");
            string temp1;
            string temp2;
            while (true)
            {
                temp1 = gets.ReadLine();
                temp2 = gets.ReadLine();
                if (temp1 == null || temp2 == null)
                {
                    gets.Close();
                    return;
                }
                linesEng.Add(decryption(temp1));
                linesTran.Add(decryption(temp2));
            }
        }

        private string encryption(string inp)
        {
            string result = "";
            char t;

            for (int i = 0; i < inp.Length; i++)
                if (alp.Contains(char.ToLower(inp[i])))
                {
                    t = alp[(alp.IndexOf(char.ToLower(inp[i])) + alp.IndexOf(key[i % key.Length])) % len];
                    result += char.IsLower(inp[i]) ? t : char.ToUpper(t);
                }
                else
                    result += inp[i];

            return result;
        }

        private string decryption(string inp)
        {
            string result = "";
            char t;

            for (int i = 0; i < inp.Length; i++)
                if (alp.Contains(char.ToLower(inp[i])))
                {
                    t = alp[(alp.IndexOf(char.ToLower(inp[i])) + len - alp.IndexOf(key[i % key.Length])) % len];
                    result += char.IsLower(inp[i]) ? t : char.ToUpper(t);
                }
                else
                    result += inp[i];

            return result;
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            root.escape(1);
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            string temp1 = inpEng.Text;
            string temp2 = inpTran.Text;
            if (temp1 == "" || temp2 == "")
                return;

            for(int i = 0; i < linesEng.Count; i++)
                if (temp1 == linesEng[i] || temp2 == linesTran[i])
                {
                    MessageBox.Show("Одно или оба выражения уже есть в словаре.", "Оповещение");
                    return;
                }

            linesEng.Add(temp1);
            linesTran.Add(temp2);
            file = new StreamWriter("Dictionary.dat", true);
            file.WriteLine(encryption(temp1));
            file.WriteLine(encryption(temp2));
            file.Close();
            inpEng.Text = "";
            inpTran.Text = "";
        }

        private void insert(string temp1, string temp2, StreamWriter file)
        {
            for (int i = 0; i < linesEng.Count; i++)
                if (temp1 == linesEng[i] || temp2 == linesTran[i])
                    return;

            linesEng.Add(temp1);
            linesTran.Add(temp2);
            
            file.WriteLine(encryption(temp1));
            file.WriteLine(encryption(temp2));
        }

        private void clearBut_Click(object sender, EventArgs e)
        {
            inpEng.Text = "";
            inpTran.Text = "";
        }

        private void currectLine(string inp, out string left, out string right)
        {
            if (inp.Contains("["))
            {
                left = inp.Substring(0, inp.IndexOf('[') - 1);
                right = inp.Contains(',') ? inp.Substring(inp.IndexOf('—') + 2, inp.IndexOf(',') - inp.IndexOf('—') - 2) : inp.Substring(inp.IndexOf('—') + 2);
            }
            else
            {
                left = inp.Substring(0, inp.IndexOf('—') - 1);
                right = inp.Contains(',') ? inp.Substring(inp.IndexOf('—') + 2, inp.IndexOf(',') - inp.IndexOf('—') - 2) : inp.Substring(inp.IndexOf('—') + 2);
            }
        }

        private void from_file_Click(object sender, EventArgs e)
        {
            string temp;
            string left;
            string right;
            bool func = false;
            if (!File.Exists("Insert.txt"))
            {
                (File.Create("Insert.txt")).Close();
                StreamWriter tw = new StreamWriter("Insert.txt");
                tw.WriteLine("—");
                tw.Close();
            }

            StreamReader file1 = new StreamReader("Insert.txt");
            temp = file1.ReadLine();
            if (temp == null)
            {
                MessageBox.Show("Для добавления нужно заполнить файл Insert.txt таким образом:\nEnglish_word — Translate\nСледующие пары добавлять с новой строки каждую.", "Оповещение");
                file1.Close();
                StreamWriter tw = new StreamWriter("Insert.txt");
                tw.WriteLine("—");
                tw.Close();
                return;
            }

            file = new StreamWriter("Dictionary.dat", true);

            while (temp != "0")
            {
                if (file1.EndOfStream)
                    break;

                if (temp == "")
                {
                    temp = file1.ReadLine();
                    continue;
                }

                if (!temp.Contains("—"))
                {
                    file.Close();
                    file1.Close();
                    File.Open("Insert.txt", FileMode.Truncate).Close();
                    return;
                }

                if(temp.Length < 3)
                {
                    temp = file1.ReadLine();
                    continue;
                }

                currectLine(temp, out left, out right);
                insert(left, right, file);
                temp = file1.ReadLine();
                func = true;
            }
            file.Close();
            file1.Close();
            if (func)
            {
                File.Open("Insert.txt", FileMode.Truncate).Close();
                MessageBox.Show("Слова добавлены", "Оповещение");
            }
            else
                MessageBox.Show("Для добавления нужно заполнить файл Insert.txt таким образом:\nEnglish_word — Translate\nСледующие пары добавлять с новой строки каждую.", "Оповещение");

        }

        private void delWords_Click(object sender, EventArgs e)
        {
            File.Open("Dictionary.dat", FileMode.Truncate).Close();
            linesEng.Clear();
            linesTran.Clear();
        }
    }
}
