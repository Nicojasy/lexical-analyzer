using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaI_2
{
    public partial class Form1 : Form
    {

        char w1 = 'A';
        bool check = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KewDown_F5(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check = true;
            Start();
        }

        private void Syntax(int number, string word, int numberT)
        {
            string delta = "";
            delta = delta + ((char)948);
            //delta += ((char)948);
            textBox2.Text += "(q" + number + "," + word + ") -> q" + numberT + Environment.NewLine;
        }

        private void Gram(char s, char w2)
        {
            textBox3.Text += w1 + " -> " + s + w2 + Environment.NewLine;
            w1 = w2;
        }

        public int Interstring(char[] Str, char[] dictionaryW, char[] dictionaryN, int i)
        {
            if (check == false) return i;
            for (; Str[i] == ' ' || Str[i] == '\n' || Str[i] == '\r'; i++) ;

            if (Str[i] == '}')
            {
                Gram(Str[i], 'h');
                Syntax(4, "}", 5);
                i++;
                return i;
            }

            int n = -1, m = -1;
            if (Str[i] == 'i' && Str[i + 1] == 'n' && Str[i + 2] == 't' && Str[i + 3] == ' ')
            {
                Gram(Str[i], 'E');
                Gram(Str[i], 'a');
                Gram(Str[i], 'b');
                i = i + 4;
                Syntax(4, "i", 21);
                Syntax(21, "n", 22);
                Syntax(22, "t", 23);
                for (; Str[i] == ' '; i++) ;
                int x = Array.IndexOf(dictionaryW, Str[i]);
                int y = Array.IndexOf(dictionaryN, Str[i]);
                if (x != -1 || y != -1)
                {
                    for (n = Array.IndexOf(dictionaryW, Str[i]), m = Array.IndexOf(dictionaryN, Str[i]); !(n == -1 && m == -1); n = Array.IndexOf(dictionaryW, Str[i]), m = Array.IndexOf(dictionaryN, Str[i]))
                    {
                        Gram(Str[i], 'c');
                        if (n != -1)
                        {
                            Syntax(23, "b", 24);
                            n = -1;
                        }
                        if (m != -1)
                        {
                            Syntax(23, "y", 24);
                            m = -1;
                        }
                        i++;
                        n = -1;
                        m = -1;
                    }
                    if (Str[i] == ' ')
                        for (; Str[i] == ' '; i++) ;
                    if (Str[i] == ';')
                    {
                        Gram(Str[i], 'd');
                        Syntax(25, ";", 4);
                        i++;
                        i = Interstring(Str, dictionaryW, dictionaryN, i);
                        return i;
                    }
                    else
                    {
                        if (Str[i] == '=')
                        {
                            Gram(Str[i], 'f');
                            Syntax(24, "=", 25);
                            i++;
                            if (Str[i] == ' ')
                            {
                                for (; Str[i] == ' '; i++) ;
                                //i++;
                                //if (Str[i] == ' ')
                                //    for (; Str[i] == ' '; i++) ;
                                y = -1;
                                y = Array.IndexOf(dictionaryN, Str[i]);
                                if (y != -1)
                                {
                                    for (m = Array.IndexOf(dictionaryN, Str[i]); !(m == -1); m = Array.IndexOf(dictionaryN, Str[i]))
                                    {
                                        Gram(Str[i], 'g');
                                        Syntax(25, "y", 25);
                                        m = -1;
                                        i++;
                                        m = -1;
                                    }
                                    if (Str[i] == ' ')
                                        for (; Str[i] == ' '; i++) ;
                                    if (Str[i] == ';')
                                    {
                                        Gram(Str[i], 'g');
                                        Syntax(25, ";", 4);
                                        i++;
                                        i = Interstring(Str, dictionaryW, dictionaryN, i);
                                        return i;
                                    }
                                    else check = false;
                                }
                                else check = false;
                            }
                            else check = false;
                        }
                        else check = false;
                    }
                }
                else check = false;
            }

            n = Array.IndexOf(dictionaryW, Str[i]);
            if (n != -1)
            {
                Gram(Str[i], 'i');
                Syntax(4, "b", 26);
                i++;
                for (n = Array.IndexOf(dictionaryW, Str[i]), m = Array.IndexOf(dictionaryN, Str[i]); !(n == -1 && m == -1 && Str[i] != '.'); n = Array.IndexOf(dictionaryW, Str[i]), m = Array.IndexOf(dictionaryN, Str[i]))
                {
                    Gram(Str[i], 'j');
                    if (Str[i] == '.')
                    {
                        Gram(Str[i], 'k');
                        Syntax(26, "b", 27);
                    }
                    if (n != -1)
                    {
                        Syntax(26, "b", 26);
                        n = -1;
                    }
                    if (m != -1)
                    {
                        Syntax(26, "y", 26);
                        m = -1;
                    }
                    i++;
                    n = -1;
                    m = -1;
                }
                if (Str[i] == '(')
                {
                    Gram(Str[i], 'm');
                    Syntax(28, "(", 29);
                    i++;
                    if (Str[i] == ' ')
                        for (; Str[i] == ' '; i++) ;
                    for (n = Array.IndexOf(dictionaryW, Str[i]), m = Array.IndexOf(dictionaryN, Str[i]); !(n == -1 && m == -1); n = Array.IndexOf(dictionaryW, Str[i]), m = Array.IndexOf(dictionaryN, Str[i]))
                    {
                        Gram(Str[i], 'p');
                        if (n != -1)
                        {
                            Syntax(30, "b", 30);
                            n = -1;
                        }
                        if (m != -1)
                        {
                            Syntax(30, "y", 30);
                            m = -1;
                        }
                        i++;
                        n = -1;
                        m = -1;
                    }
                    if (Str[i] == ' ')
                        for (; Str[i] == ' '; i++) ;
                    if (Str[i] == ')')
                    {
                        Gram(Str[i], 'p');
                        Syntax(30, ")", 31);
                        i++;
                        if (Str[i] == ' ')
                            for (; Str[i] == ' '; i++) ;
                        if (Str[i] == ';')
                        {
                            Gram(Str[i], 'q');
                            Syntax(31, "b", 4);
                            i++;
                            i = Interstring(Str, dictionaryW, dictionaryN, i);
                            return i;
                        }
                        else check = false;
                    }
                    else check = false;
                }
                else check = false;
            }
            else check = false;
            return i;
        }

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        ////////////////////////////////////////////////////////////////////////////////////\\
        public void Start()
        {
            char[] dictionaryW = new char[52];
            for (int z = 65, p = 0; z <= 90; z++, p++)
            {
                dictionaryW[p] = ((char)z);
            }
            for (int z = 97, p = 26; z <= 122; z++, p++)
            {
                dictionaryW[p] = ((char)z);
            }
            char[] dictionaryN = new char[10];
            for (int z = 48, p = 0; z <= 57; z++, p++)
            {
                dictionaryN[p] = ((char)z);
            }
            string SStr = textBox1.Text;
            char[] Str = new char[SStr.Length];
            for (int i = 0; Str.Length > i; i++)
            {
                Str[i] = SStr[i];
            }

            bool t = false;
            for (int i = 0; Str.Length > i;)
            {
                if (check == false) break;
                switch (Str[i])
                {
                    case 't':
                        Gram(Str[i], 'B');
                        i++;
                        Syntax(0, "t", 1);
                        if (t != false)
                        {
                            check = false;
                            break;
                        }
                        char[] StrT = { 'r', 'y' };
                        for (int j = 0; StrT.Length > j && Str[i] == StrT[j]; j++, i++)
                        {
                            if (j == 0)
                            {
                                Gram(Str[i], 'C');
                                Syntax(1, "r", 2);
                            }
                            if (j == 1)
                            {
                                Gram(Str[i], 'C');
                                Syntax(2, "y", 3);
                            }
                        }
                        if (Str[i] == ' ')
                            for (; Str[i] == ' '; i++) ;
                        if (Str[i] == '{')
                        {
                            Gram(Str[i], 'D');
                            Syntax(3, "{", 4);
                            i++;
                            t = true;
                            i = Interstring(Str, dictionaryW, dictionaryN, i);
                            for (; Str[i] == ' ' || Str[i] == '\n' || Str[i] == '\r'; i++) ;
                        }
                        else check = false;
                        break;
                    case 'c':
                        Gram(Str[i], 'E');
                        i++;
                        Syntax(5, "c", 6);
                        if (t != true)
                        {
                            check = false;
                            break;
                        }
                        char[] StrC = { 'a', 't', 'c', 'h', 'e' };
                        for (int j = 0; StrC.Length > j && Str[i] == StrC[j]; j++, i++)
                        {
                            if (j == 0)
                            {
                                Syntax(6, "a", 7);
                                Gram(Str[i], 'G');
                            }
                            if (j == 1)
                            {
                                Syntax(7, "t", 8);
                                Gram(Str[i], 'H');
                            }
                            if (j == 2)
                            {
                                Syntax(8, "c", 9);
                                Gram(Str[i], 'I');
                            }
                            if (j == 3)
                            {
                                Syntax(9, "h", 10);
                                Gram(Str[i], 'J');
                            }
                        }
                        if (Str[i] == ' ')
                            for (; Str[i] == ' '; i++) ;
                        if (Str[i] == '(')
                        {
                            Gram(Str[i], 'K');
                            i++;
                            Syntax(10, "(", 11);
                            if (Str[i] == ' ')
                                for (; Str[i] == ' '; i++) ;
                            int m1 = -1;
                            int n1 = -1;
                            int x = Array.IndexOf(dictionaryW, Str[i]);
                            if (x != -1)
                            {
                                Gram(Str[i], 'M');
                                i++;
                                Syntax(11, "b", 12);
                                for (m1 = Array.IndexOf(dictionaryN, Str[i]), n1 = Array.IndexOf(dictionaryW, Str[i]); !(n1 == -1 && m1 == -1); n1 = Array.IndexOf(dictionaryW, Str[i]), m1 = Array.IndexOf(dictionaryN, Str[i]))
                                {
                                    if (n1 != -1)
                                    {
                                        Gram(Str[i], 'N');
                                        Syntax(12, "b", 12);
                                        n1 = -1;
                                    }
                                    if (m1 != -1)
                                    {
                                        Gram(Str[i], 'N');
                                        Syntax(12, "y", 12);
                                        m1 = -1;
                                    }
                                    i++;
                                }
                                if (Str[i] == ' ')
                                {
                                    for (; Str[i] == ' '; i++) ;
                                    x = -1;
                                    x = Array.IndexOf(dictionaryW, Str[i]);
                                    if (x != -1)
                                    {
                                        Gram(Str[i], 'O');
                                        i++;
                                        m1 = -1;
                                        n1 = -1;
                                        Syntax(12, "b", 13);
                                        for (m1 = Array.IndexOf(dictionaryN, Str[i]), n1 = Array.IndexOf(dictionaryW, Str[i]); !(n1 == -1 && m1 == -1); n1 = Array.IndexOf(dictionaryW, Str[i]), m1 = Array.IndexOf(dictionaryN, Str[i]))
                                        {
                                            i++;
                                            if (n1 != -1)
                                            {
                                                Gram(Str[i], 'P');
                                                Syntax(13, "b", 13);
                                                n1 = -1;
                                            }
                                            if (m1 != -1)
                                            {
                                                Gram(Str[i], 'P');
                                                Syntax(13, "y", 13);
                                                m1 = -1;
                                            }
                                        }
                                        if (Str[i] == ' ')
                                            for (; Str[i] == ' '; i++) ;
                                        if (Str[i] == ')')
                                        {
                                            Gram(Str[i], 'P');
                                            Syntax(13, "y", 14);
                                            i++;
                                            if (Str[i] == ' ')
                                                for (; Str[i] == ' '; i++) ;
                                            if (Str[i] == '{')
                                            {
                                                Gram(Str[i], 'Q');
                                                i++;
                                                Syntax(14, "y", 4);
                                                t = true;
                                                i = Interstring(Str, dictionaryW, dictionaryN, i);
                                                for (; Str[i] == ' ' || Str[i] == '\n' || Str[i] == '\r'; i++) ;
                                            }
                                            else check = false;
                                        }
                                        else check = false;
                                    }
                                    else check = false;
                                }
                                else check = false;
                            }
                            else check = false;
                        }
                        else
                            check = false;
                        break;
                    case 'f':
                        Gram(Str[i], 'F');
                        i++;
                        Syntax(5, "f", 15);
                        if (t != true)
                        {
                            check = false;
                            break;
                        }
                        char[] StrF = { 'i', 'n', 'a', 'l', 'l', 'y' };
                        for (int j = 0; StrF.Length > j && Str[i] == StrF[j]; j++, i++)
                        {
                            if (j == 0) { Syntax(15, "i", 16); Gram(Str[i], 'S'); }
                            if (j == 1) { Syntax(16, "n", 17); Gram(Str[i], 'T'); }
                            if (j == 2) { Syntax(17, "a", 18); Gram(Str[i], 'U'); }
                            if (j == 3) { Syntax(18, "l", 19); Gram(Str[i], 'V'); }
                            if (j == 4) { Syntax(19, "l", 20); Gram(Str[i], 'W'); }
                            if (j == 5) { Syntax(20, "y", 14); Gram(Str[i], 'X'); }
                        }
                        if (Str[i] == ' ')
                            for (; Str[i] == ' '; i++) ;
                        if (Str[i] == '{')
                        {
                            Gram(Str[i], 'Y');
                            i++;
                            Syntax(14, "{", 4);
                            t = true;
                            i = Interstring(Str, dictionaryW, dictionaryN, i);
                            if (i < Str.Length)
                                for (; Str[i] == ' ' || Str[i] == '\n' || Str[i] == '\r'; i++) ;
                            else break;
                        }
                        else check = false;
                        break;
                    default:
                        if (Str[i] == '\n' || Str[i] == '\r' || Str[i] == ' ')
                            i++;
                        else
                            check = false;
                        break;
                }
            }
            if (check == false)
            {
                label2.Text = "Синтаксис погряз в ошибках!";
                label2.ForeColor = Color.Red;
                label3.Text = "Грамматика страдает!";
                label3.ForeColor = Color.Red;
            }
            else
            {
                label2.Text = "Синтаксис прекрасен!";
                label2.ForeColor = Color.Green;
                label3.Text = "Грамматика чудесна!";
                label3.ForeColor = Color.Green;
            }


            //...............................................//
            //...............................................//
            //...............................................//
            bool lexeme = false;
            string strL = "";
            string strL1 = "";
            int iw = 1;
            for (int i = 0; Str.Length > i; i++)
            {
                int n = -1;
                int m = -1;
                n = Array.IndexOf(dictionaryW, Str[i]);
                m = Array.IndexOf(dictionaryN, Str[i]);
                char[] ss = { '.', ';', '=', '(', ')', '{', '}' };
                bool s = false;
                string strSearch = "";
                foreach (char ss1 in ss)
                {
                    if (Str[i] == ss1)
                        s = true;
                }

                if (!(n == -1 && m == -1))
                {
                    if (lexeme == false)
                        lexeme = true;
                    if (strL1 == "")
                        strL1 += (i + 1);
                    strL += Str[i];
                }
                else
                {
                    if (lexeme == true)
                    {
                        lexeme = false;
                        if (strL.Length != 1)
                            strL1 = strL1 + "-" + i;
                        for (int k = 0; k <= dataGridView1.Rows.Count - 1; k++)
                                if (dataGridView1.Rows[k].Cells[2].Value != null && dataGridView1.Rows[k].Cells[2].Value.ToString() == strL)
                                    strSearch = dataGridView1.Rows[k].Cells[1].Value.ToString();
                        if (strSearch != "")
                        {
                            int intSearch = -1;
                            if (Int32.TryParse(strSearch, out intSearch))
                            {
                                AddLexeme(intSearch, strL, strL1, dictionaryW);
                            }
                            else MessageBox.Show(strSearch);
                            strSearch = "";
                        }
                        else
                        {
                            AddLexeme(iw, strL, strL1, dictionaryW);
                            iw++;
                        }
                        strL1 = "";
                        strL = "";
                    }
                    if (s == true)
                    {
                        strL += Str[i];
                        strL1 += (i+1);
                        for (int k = 0; k <= dataGridView1.Rows.Count - 1; k++)
                            if (dataGridView1.Rows[k].Cells[2].Value != null && dataGridView1.Rows[k].Cells[2].Value.ToString() == strL)
                                strSearch = dataGridView1.Rows[k].Cells[1].Value.ToString();
                        if (strSearch != "")
                        {
                            int intSearch = -1;
                            if (Int32.TryParse(strSearch, out intSearch))
                            {
                                AddLexeme(intSearch, strL, strL1, dictionaryW);
                            }
                            else MessageBox.Show(strSearch);
                            strSearch = "";
                        }
                        else
                        {
                            AddLexeme(iw, strL, strL1, dictionaryW);
                            iw++;
                        }
                        strL1 = "";
                        strL = "";
                    }
                }
            }

            dataGridView1.Rows[2].Cells[2].Selected = true;
        }

        private void AddLexeme(int iw, string strL, string strL1, char[] dictionaryW)
        {
            string strT = "";
            if (strL == "try" || strL == "catch" || strL == "finally" || strL == "int") strT = "ключевое слово";
            else
            if (strL == "{" || strL == ";" || strL == "." || strL == "(" || strL == ")" || strL == "}") strT = "специальный символ";
            else
            if (strL == "=") strT = "знак операции";
            else
            {
                int sl = -1;
                for (int i = 0; strL.Length > i; i++)
                {
                    sl = Array.IndexOf(dictionaryW, strL[i]);
                    if (sl != -1)
                    {
                        strT = "константа";
                        break;
                    }
                }
                if (strT != "константа")
                    strT = "идентификатор";
            }
            dataGridView1.Rows.Add(strT, iw, strL, strL1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}