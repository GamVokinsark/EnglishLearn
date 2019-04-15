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
    public partial class LearnWords : UserControl
    {
        public Form1 root;
        private List<string> linesEng;
        private List<string> linesTran;
        private string alp;
        private int len;
        private string key;
        private int curFirst = 0;

        /// <summary>
        /// Обновляет таблицу слов.
        /// </summary>
        /// <param name="cur">Текущая страница</param>
        private void renewTable(int cur)
        {
            int count = linesEng.Count - cur < 8 ? linesEng.Count - cur : 8;
            Label[,] massL = { { l1l, l2l, l3l, l4l, l5l, l6l, l7l, l8l }, { l1r, l2r, l3r, l4r, l5r, l6r, l7r, l8r } };
            Label[] massNumL = { numLb1, numLb2, numLb3, numLb4, numLb5, numLb6, numLb7, numLb8 };
            if (linesEng.Count - cur < 8)
                for (int i = linesEng.Count - cur; i < 8; i++)
                {
                    massL[0, i].Text = "-";
                    massL[1, i].Text = "-";
                    massNumL[i].Text = "-";
                }

            for (int i = 0; i < count; i++)
            {
                massL[0, i].Text = linesEng[i + cur];
                massL[1, i].Text = linesTran[i + cur];
                massNumL[i].Text = (i + cur + 1).ToString();
            }

            pageLb.Text = (cur / 8 + 1).ToString();
            wordsLb.Text = (linesEng.Count).ToString();
        }


        /// <summary>
        /// Заполнить таблицу
        /// </summary>
        public void fillTable()
        {
            curFirst = 0;
            renewTable(curFirst);

            if (linesEng.Count - curFirst <= 8)
                rightBut.Visible = false;
            else
                rightBut.Visible = true;
            leftBut.Visible = false;
        }

        public LearnWords()
        {
            InitializeComponent();
            alp = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            len = alp.Length;
            key = "thelonglongstoryaboutonemyday";
            linesEng = new List<string>();
            linesTran = new List<string>();
        }

        /// <summary>
        /// Расшифровка строки алгоритмом Виженера.
        /// </summary>
        /// <param name="inp">Входная строка для расшифровки</param>
        /// <returns></returns>
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

        private void backBut_Click(object sender, EventArgs e)
        {
            root.escape(2);
        }

        private void leftBut_Click(object sender, EventArgs e)
        {
            curFirst -= 8;
            if (curFirst < 0)
            {
                curFirst += 8;
                leftBut.Visible = false;
                return;
            }

            renewTable(curFirst);

            rightBut.Visible = true;
            if (curFirst / 8 > 0)
                leftBut.Visible = true;
            else
                leftBut.Visible = false;
        }

        private void rightBut_Click(object sender, EventArgs e)
        {
            curFirst += 8;
            if (curFirst > linesEng.Count)
            {
                curFirst -= 8;
                rightBut.Visible = false;
                return;
            }

            renewTable(curFirst);

            if (linesEng.Count - curFirst <= 8)
                rightBut.Visible = false;
            else
                rightBut.Visible = true;
            leftBut.Visible = true;
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

        private void renewFile()
        {
            StreamWriter file = new StreamWriter("Dictionary.dat", false);
            for (int i = 0; i < linesEng.Count; i++)
            {
                file.WriteLine(encryption(linesEng[i]));
                file.WriteLine(encryption(linesTran[i]));
            }
            file.Close();
        }

        private void del_Click(object sender, EventArgs e)
        {
            int curBut = (((PictureBox)sender).Parent.Location.Y - 40) / 38;
            if (curFirst + curBut > linesEng.Count - 1)
                return;

            linesEng.RemoveAt(curFirst + curBut);
            linesTran.RemoveAt(curFirst + curBut);

            if (linesEng.Count == 0)
                renewTable(0);

            if (linesEng.Count == curFirst)
            {
                leftBut_Click(null, null);
                rightBut.Visible = false;
            }
            else
                renewTable(curFirst);
            renewFile();
        }
        
    }
}
