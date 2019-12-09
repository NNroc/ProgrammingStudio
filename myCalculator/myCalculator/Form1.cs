using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Form1 : Form
    {
        static Stack<double> m = new Stack<double>(); //数字栈
        static Stack<char> s = new Stack<char>(); //符号栈

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDisplay.Text))
            {
                textDisplay.Text = "0.";
            }
            else if (textDisplay.Text[textDisplay.Text.Length - 1] >= '0' &&
                     textDisplay.Text[textDisplay.Text.Length - 1] <= '9')
            {
                textDisplay.Text += ".";
            }
            else
            {
                textDisplay.Text += "0.";
            }
        }

        private bool needNum()
        {
            if (!string.IsNullOrEmpty(textDisplay.Text))
            {
                if (textDisplay.Text[textDisplay.Text.Length - 1] >= '0' &&
                    textDisplay.Text[textDisplay.Text.Length - 1] <= '9')
                {
                    return true;
                }
                else if (textDisplay.Text[textDisplay.Text.Length - 1] == ')')
                {
                    return true;
                }
            }

            return false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            testResult.Clear();
            try
            {
                if (textDisplay.Text[textDisplay.Text.Length - 2] != 't')
                {
                    textDisplay.Text = textDisplay.Text.Substring(0, textDisplay.Text.Length - 1);
                }
                else
                {
                    textDisplay.Text = textDisplay.Text.Substring(0, textDisplay.Text.Length - 5);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("已经为空了，无法在退格了！", "错误", MessageBoxButtons.OK);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (needNum())
            {
                textDisplay.Text += "-";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (needNum())
            {
                textDisplay.Text += "+";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (needNum())
            {
                textDisplay.Text += "*";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (needNum())
            {
                textDisplay.Text += "/";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (needNum())
            {
                textDisplay.Text += "%";
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textDisplay.Text))
            {
                if ((textDisplay.Text[textDisplay.Text.Length - 1] < '0' ||
                     textDisplay.Text[textDisplay.Text.Length - 1] > '9') &&
                    textDisplay.Text[textDisplay.Text.Length - 1] != '.')
                {
                    textDisplay.Text += "sqrt(";
                    return;
                }
            }

            textDisplay.Text += "sqrt(";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            testResult.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textDisplay.Text))
            {
                if (!(textDisplay.Text[textDisplay.Text.Length - 1] >= '0' &&
                      textDisplay.Text[textDisplay.Text.Length - 1] <= '9') &&
                    textDisplay.Text[textDisplay.Text.Length - 1] != '.')
                {
                    textDisplay.Text += "(";
                }

                return;
            }

            textDisplay.Text += "(";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string text = textDisplay.Text;
            int num = 0;
            for (int i = 0; i < textDisplay.Text.Length; i++)
            {
                if (text[i] == '(')
                {
                    num++;
                }

                if (text[i] == ')')
                {
                    num--;
                }
            }

            if (num < 1)
            {
                return;
            }
            else
            {
                textDisplay.Text += ")";
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            return;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            return;
        }

        public static double PopStack()
        {
            double sum = 0;
            while (s.Count != 0)
            {
                double n1, n2;
                char s1;
                n2 = m.Pop();
                n1 = m.Pop();
                s1 = s.Pop();
                sum = Operat(n1, n2, s1);
                m.Push(sum);
            }

            return sum;
        }

        public static bool IsOperator(char c) //是否是操作符
        {
            if (c.Equals('+') || c.Equals('-') || c.Equals('*') || c.Equals('/') || c.Equals('%') ||
                c.Equals('(') || c.Equals(')') || c.Equals('s'))
                return true;
            return false;
        }

        public static bool IsOper(char c) //是否是运算符符
        {
            if (c.Equals('+') || c.Equals('-') || c.Equals('*') || c.Equals('/') || c.Equals('%'))
            {
                return true;
            }

            return false;
    }

        public static int OperatorPrecedence(char a) //操作符优先级
        {
            int i = 0;
            switch (a)
            {
                case '+':
                    i = 3;
                    break;
                case '-':
                    i = 3;
                    break;
                case '*':
                    i = 4;
                    break;
                case '/':
                    i = 4;
                    break;
                case '%':
                    i = 4;
                    break;
            }

            return i;
        }

        public static double Operat(double n1, double n2, char s1)
        {
            double sum = 0;
            switch (s1)
            {
                case '+':
                    sum = n1 + n2;
                    break;
                case '-':
                    sum = n1 - n2;
                    break;
                case '*':
                    sum = n1 * n2;
                    break;
                case '/':
                    sum = n1 / n2;
                    break;
                case '%':
                    sum = n1 % n2;
                    break;
            }

            return sum;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (testBrackets() && testPre())
            {
                Read();
              ////  MessageBox.Show("m:  "+m.Count.ToString());
               /// MessageBox.Show("s:  "+s.Count.ToString());
               /// 
                double use=m.Peek();
                while (m.Count>1&&s.Count>0)
                {
                    double n2 = m.Pop();
                    double n1 = m.Pop();
                    char t = s.Pop();
                    use = Operat(n1, n2, t);
                    m.Push(use);
                    ///MessageBox.Show(use.ToString());
                }
                testResult.Text = use.ToString();
            }

            m.Clear();
            s.Clear();
        }

        public void Read() //Read() 读值
        {
            string text = textDisplay.Text;
            for (int i = 0; i < text.Length; i++)
            {
                if (!IsOperator(text[i])) //数字和小数点
                {
                    string s = null;
                    while (i < text.Length && !IsOperator(text[i]))
                    {
                        s += text[i];
                        i++;
                    }

                    i--;
                    double mm = Convert.ToDouble(s);
                    m.Push(mm);
                    ///MessageBox.Show(mm.ToString());///////////
                }
                else if (IsOper(text[i])) //+ - * / 
                {
                    if (s.Count.Equals(0) || s.Peek().Equals('(') || s.Peek().Equals('s'))
                    {
                        s.Push(text[i]);
                       /// MessageBox.Show(text[i].ToString());//////////
                    }
                    else if (OperatorPrecedence(text[i]) > OperatorPrecedence(s.Peek()))
                    {
                        s.Push(text[i]);
                       /// MessageBox.Show(text[i].ToString());////////////////
                    }
                    else if (s.Count != 0 && m.Count >= 2)
                    {
                        double n1, n2;
                        char s1;
                        n2 = m.Pop();
                        n1 = m.Pop();
                        s1 = s.Pop();
                        double sum = Operat(n1, n2, s1);
                        m.Push(sum);
                       /// MessageBox.Show(sum.ToString());////////////////
                        s.Push(text[i]);
                       /// MessageBox.Show(text[i].ToString());////////////////

                    }
                }
                else // s、（ 和 ）
                {
                    if (text[i].Equals('(') || text[i].Equals('s'))
                    {
                        s.Push(text[i]);
                        ///MessageBox.Show(text[i].ToString());///////////////
                        if (text[i].Equals('s'))
                        {
                            i += 4;
                        }
                    }
                    else if (text[i].Equals(')'))
                    {
                        while (!s.Peek().Equals('(') && !s.Peek().Equals('s'))
                        {
                            double n1, n2;
                            char s1;
                            n2 = m.Pop();
                            n1 = m.Pop();
                            s1 = s.Pop();
                            double sum = Operat(n1, n2, s1);
                            m.Push(sum);
                           /// MessageBox.Show(sum.ToString());////////////////
                        }

                        if (s.Peek().Equals('s'))
                        {
                            double use = m.Pop();
                            use = Math.Pow(use, 0.5);
                            m.Push(use);
                            ///MessageBox.Show(use.ToString());////////////////
                            s.Pop();
                        }
                        else
                        {
                            s.Pop();
                        }
                    }
                }
            }
        }

        /// <summary>数量
        /// 判断括号
        /// </summary>
        /// <returns></returns>
        private bool testBrackets()
        {
            int num = 0;
            for (int i = 0; i < textDisplay.Text.Length; i++)
            {
                if (textDisplay.Text[i] == '(')
                {
                    num++;
                }

                if (textDisplay.Text[i] == ')')
                {
                    num--;
                }
            }

            if (num != 0)
            {
                MessageBox.Show("亲，括号数量不对吧？");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 判断等号前面的数
        /// </summary>
        /// <returns></returns>
        private bool testPre()
        {
            if (string.IsNullOrEmpty(textDisplay.Text))
            {
                MessageBox.Show("亲，你是不是忘记输入了？");
                return false;
            }

            if ((textDisplay.Text[textDisplay.Text.Length - 1] >= '0' &&
                 textDisplay.Text[textDisplay.Text.Length - 1] <= '9') ||
                textDisplay.Text[textDisplay.Text.Length - 1] == ')')
            {
                return true;
            }

            MessageBox.Show("亲，你是不是还没输完？");
            return false;
        }
    }
}