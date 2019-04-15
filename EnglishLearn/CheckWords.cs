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
    public partial class CheckWords : UserControl
    {
        public Form1 root;
        private bool checkEW = true;
        private List<string> linesEng;
        private List<string> linesTran;
        private string alp;
        private int len;
        private string key;
        private int curWord = 0;
        private int tempVar = 0;
        private int variant = 0;
        private int firstWord = 0;
        private int lastWord = 0;
        private int count = 0;
        private int currect = 0;
        private int mistakes = 0;
        private int skipped = 0;
        private bool wrong = false;
        private Random rnd = new Random(Environment.TickCount);

        public void renewVars()
        {
            linesEng.Clear();
            linesTran.Clear();
            getStartString();
            inpBetw1.Text = linesEng.Count > 0 ? (1).ToString() : (0).ToString();
            inpBetw2.Text = linesEng.Count.ToString();
            inpRand.Text = linesEng.Count.ToString();
        }

        public CheckWords()
        {
            InitializeComponent();
            alp = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            len = alp.Length;
            key = "thelonglongstoryaboutonemyday";
            linesEng = new List<string>();
            linesTran = new List<string>();
            rBAll.ForeColor = Color.FromArgb(255, 196, 185, 56);
            chEW.ForeColor = Color.FromArgb(255, 196, 185, 56);
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

        public void getStartString()
        {
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
            root.escape(0);
            chEW.Enabled = true;
            chT.Enabled = true;
            input.Text = "";
            output.Text = "";
            startBut.Visible = true;
            checkBut.Visible = false;
            nextBut.Visible = false;
            messageLb.Visible = false;
            infoPanel.Visible = false;
            nextBut.Text = "Next";
        }

        private void chEW_CheckedChanged(object sender, EventArgs e)
        {
            chEW.ForeColor = Color.FromArgb(255, 196, 185, 56);
            chT.ForeColor = Color.FromArgb(255, 240, 240, 240);
            checkEW = true;
            inpLb.Text = "English word";
            outpLb.Text = "Translation";
        }

        private void chT_CheckedChanged(object sender, EventArgs e)
        {
            chEW.ForeColor = Color.FromArgb(255, 240, 240, 240);
            chT.ForeColor = Color.FromArgb(255, 196, 185, 56);
            checkEW = false;
            inpLb.Text = "Translation";
            outpLb.Text = "English word";
        }

        private void startBut_Click(object sender, EventArgs e)
        {
            int temp;
            variant = tempVar;
            if (linesEng.Count <= 0)
            {
                MessageBox.Show("Словарь пуст! Пожалуйста, заполните его через меню \'Adding words\'.", "Пустой словарь");
                return;
            }
            
            switch(variant)
            {
                case 0:
                    count = linesEng.Count;
                    wordsLb.Text = count.ToString();
                    curWord = 0;
                    break;
                case 1:
                    if(!int.TryParse(inpBetw1.Text, out firstWord))
                    {
                        MessageBox.Show("В поле ввода для режима \'Between\' можно вводить только числа!", "Неправильный ввод");
                        firstWord = 0;
                        return;
                    }

                    if (!int.TryParse(inpBetw2.Text, out lastWord))
                    {
                        MessageBox.Show("В поле ввода для режима \'Between\' можно вводить только числа!", "Неправильный ввод");
                        lastWord = 0;
                        return;
                    }

                    if (lastWord > linesEng.Count || lastWord < 0)
                        lastWord = linesEng.Count;

                    if (firstWord > linesEng.Count - 1 || firstWord < 1)
                        firstWord = 1;

                    if (firstWord > lastWord)
                    {
                        temp = firstWord;
                        firstWord = lastWord;
                        lastWord = temp;
                    }

                    curWord = firstWord - 1;
                    inpBetw1.Text = firstWord.ToString();
                        inpBetw2.Text = lastWord.ToString();
                        wordsLb.Text = (lastWord - firstWord + 1).ToString();
                    break;
                case 2:
                    if (!int.TryParse(inpRand.Text, out count))
                    {
                        MessageBox.Show("В поле ввода для режима \'Random\' можно вводить только числа!", "Неправильный ввод");
                        count = 0;
                        return;
                    }

                    if (count < 0)
                    {
                        count = 0;
                        return;
                    }

                    if (count > linesEng.Count)
                        count = linesEng.Count;
                    curWord = rnd.Next(0, linesEng.Count);
                    wordsLb.Text = count.ToString();
                    inpRand.Text = count.ToString();
                    count--;
                    break;
                default:
                    firstWord = 0;
                    lastWord = 0;
                    count = 0;
                    break;
            }
            chEW.Enabled = false;
            chT.Enabled = false;
            startBut.Visible = false;
            checkBut.Visible = true;
            
            output.Text = checkEW ? linesTran[curWord] : linesEng[curWord];

            currect = 0;
            mistakes = 0;
            skipped = 0;
            currectLb.Text = currect.ToString();
            mistakesLb.Text = mistakes.ToString();
            skippedLb.Text = skipped.ToString();
            infoPanel.Visible = true;
        }

        private void checkBut_Click(object sender, EventArgs e)
        {
            if (input.Text.ToLower() == (checkEW ? linesEng[curWord].ToLower() : linesTran[curWord].ToLower()))
            {
                currectLb.Text = (++currect).ToString();
                nextBut.Text = "Next";
                messageLb.Text = "Right!";
                messageLb.ForeColor = Color.FromArgb(255, 0, 255, 0);
                messageLb.Visible = true;
                checkBut.Visible = false;
                nextBut.Visible = true;
                wrong = false;
            }
            else
            {
                mistakesLb.Text = (++mistakes).ToString();
                messageLb.Text = "Wrong!";
                messageLb.ForeColor = Color.FromArgb(255, 255, 0, 0);
                messageLb.Visible = true;
                nextBut.Visible = true;
                nextBut.Text = "Skip";
                wrong = true;
            }
            input.Focus();
        }

        private void nextBut_Click(object sender, EventArgs e)
        {
            curWord = variant < 2 ? curWord + 1 : rnd.Next(0, linesEng.Count);
            bool reas = variant == 0 ? (curWord == linesEng.Count ? true : false) : variant == 1 ? (curWord == lastWord ? true : false) : --count < 0 ? true : false;

            if (wrong)
            {
                skippedLb.Text = (++skipped).ToString();
                wrong = false;
            }

            if (reas)
            {
                nextBut.Text = "Next";
                curWord = 0;
                startBut.Visible = true;
                checkBut.Visible = false;
                nextBut.Visible = false;
                messageLb.Visible = false;
                input.Text = "";
                output.Text = "";
                chEW.Enabled = true;
                chT.Enabled = true;
                return;
            }
            nextBut.Text = "Next";
            output.Text = checkEW ? linesTran[curWord] : linesEng[curWord];
            input.Text = "";
            checkBut.Visible = true;
            nextBut.Visible = false;
            messageLb.Visible = false;
        }

        private void rBAll_CheckedChanged(object sender, EventArgs e)
        {
            rBAll.ForeColor = Color.FromArgb(255, 196, 185, 56);

            rBBetween.ForeColor = Color.FromArgb(255, 240, 240, 240);
            rBRandom.ForeColor = Color.FromArgb(255, 240, 240, 240);
            betwLb.ForeColor = Color.FromArgb(255, 240, 240, 240);
            randLb.ForeColor = Color.FromArgb(255, 240, 240, 240);

            tempVar = 0;
            inpBetw1.ReadOnly = true;
            inpBetw2.ReadOnly = true;
            inpRand.ReadOnly = true;
        }

        private void rBBetween_CheckedChanged(object sender, EventArgs e)
        {
            rBBetween.ForeColor = Color.FromArgb(255, 196, 185, 56);
            betwLb.ForeColor = Color.FromArgb(255, 196, 185, 56);

            rBAll.ForeColor = Color.FromArgb(255, 240, 240, 240);
            rBRandom.ForeColor = Color.FromArgb(255, 240, 240, 240);
            randLb.ForeColor = Color.FromArgb(255, 240, 240, 240);

            tempVar = 1;
            inpBetw1.ReadOnly = false;
            inpBetw2.ReadOnly = false;
            inpRand.ReadOnly = true;
            inpBetw1.Text = linesEng.Count > 0 ? (1).ToString() : (0).ToString();
            inpBetw2.Text = linesEng.Count.ToString();
        }

        private void rBRandom_CheckedChanged(object sender, EventArgs e)
        {
            rBRandom.ForeColor = Color.FromArgb(255, 196, 185, 56);
            randLb.ForeColor = Color.FromArgb(255, 196, 185, 56);

            rBAll.ForeColor = Color.FromArgb(255, 240, 240, 240);
            rBBetween.ForeColor = Color.FromArgb(255, 240, 240, 240);
            betwLb.ForeColor = Color.FromArgb(255, 240, 240, 240);

            tempVar = 2;
            inpBetw1.ReadOnly = true;
            inpBetw2.ReadOnly = true;
            inpRand.ReadOnly = false;
            inpRand.Text = linesEng.Count.ToString();
        }
        
    }
}
