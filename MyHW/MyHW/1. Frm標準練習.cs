
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHomeWork : Form
    {
        public FrmHomeWork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = 66;
            int c = 77;
            int max = c;

            if (a > max)
            { max = a; }

            if (b > max)
            { max = b; }

            lblResult.Text = max.ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] nums = { 33, 4, 5, 11, 222, 34 };
            int a=0,b=0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                { a++; }
                if (nums[i] % 2 == 1)
                { b++; }
            }
            lblResult.Text = "奇數" + b + "個," + "  偶數" + a + "個";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] name = { "JasonCHEN", "HAPPYLI", "WOMEN", "appleaday", "happytimehaapyday" };
            string i = name[0];
            string S = "";

            foreach (string item in name)   
            {
                S += item+",";
                i = i.Length > item.Length ? i : item;
            }
            lblResult.Text = "name陣列{" + S + "}\n最長的名子是" + i;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a;
            bool ismp = int.TryParse(textBox4.Text, out a);
            if (ismp)
            { if (a %2== 0)
                { lblResult.Text = "偶數"; }
                if (a %2== 1)
                { lblResult.Text = "奇數"; }
            }
            else
            { MessageBox.Show("請輸入數值"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100,150, 33,55};

            int max =  scores.Max();
            MessageBox.Show("Max = " + max);

            int min = scores.Min();
            MessageBox.Show("Min = " + min);

            //Array.Sort(scores);
            //MessageBox.Show("Max =" + scores[scores.Length - 1]);

            //================================

            //Point[] points = new Point[3];
            //points[0].X = 3;
            //points[0].Y = 4;
            ////System.InvalidOperationException: '無法比較陣列中的兩個元素。'

            //Array.Sort(points);

            //=================================


        }

        int MyMinScore(int[] nums)
        {
            return 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ANS1=AAA("國文", 60,30,20,50,70);
            lblResult.Text = ANS1+"\n";
            string ANS2 = AAA("英文", 30, 20, 50);
            lblResult.Text += ANS2;
        }

        string AAA(string A,params int[] BBB)
        {
            int MAX = BBB[0];
            string resulft = "";
            for (int i = 0; i < BBB.Length; i++)
            {
                if (BBB[i] > MAX)
                { MAX = BBB[i]; }
            }
            resulft = A + "最高分: " + MAX.ToString();
            return resulft;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            int[] A = new int[] {R.Next(42),R.Next(42), R.Next(42), R.Next(42), R.Next(42), R.Next(42) };
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] == 0)
                    { A[i] = R.Next(42); i = -1; break; }
                    else if (i == j)
                    {
                        if (j == A.Length - 1)
                        { break; }
                        else if (A[i] == A[j + 1])
                        { A[i] = R.Next(42); i = -1; break; }
                    }
                    else if (A[i] == A[j])
                    { A[i] = R.Next(42); i = -1; break; }
                }
            }
            lblResult.Text = "樂透號碼六碼不重複: \n";
            for (int i = 0; i < A.Length; i++)
            {
                lblResult.Text += A[i].ToString();
                lblResult.Text += ", ";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] aaaa = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" ,"cat"};
            int bbbb = 0;
            for (int i = 0; i < aaaa.Length; i++)
            {
                if (aaaa[i].Contains("C") || aaaa[i].Contains("c"))
                {
                    bbbb++;
                }
            }
            lblResult.Text= "aaaa陣列:{ mother張, emma, 迪克蕭, J40, Candy, \nCindy, Coconut, Motherfacker ,cat\n}"
                + "有C 及 c 的名子共有" + bbbb + "個";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblResult.Text = "結果";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int a = 99;
            List<int> b = new List<int>();
            for(int i=0;a!=1;i++)
            {
                if (a % 2 == 0)
                { b.Add (0); }
                else
                { b.Add(1); }
                a=a / 2;

                if (a == 1)
                { b.Add(1); }
            }
            lblResult.Text = "";
            for (int i = b.Count; i != 0; i--)
            { lblResult.Text += b[i - 1]; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[,] A = new int[9, 9];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = (i + 1) * (j + 1);
                }
            }

            lblResult.Text = "";

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    lblResult.Text += (i+1) + "*" + (j+1) + "=" + A[i, j] + "  |";
                }
                lblResult.Text += "\n";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            

            bool ismp1 = int.TryParse(textBox1.Text, out a);
            if (ismp1)
            {
                bool ismp2 = int.TryParse(textBox2.Text, out b);
                if (ismp2)
                {
                    bool ismp3 = int.TryParse(textBox3.Text, out c);
                    if (ismp3)
                    {
                        int sum = a;
                        int temp = a + c;

                        for (; temp <= b;)
                        {
                            sum = sum + temp;
                            temp = temp + c;
                        }
                        lblResult.Text = sum.ToString();

                    }
                    else { MessageBox.Show("請輸入數值"); }
                }
                else { MessageBox.Show("請輸入數值"); }
            }
            else { MessageBox.Show("請輸入數值"); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;


            bool ismp1 = int.TryParse(textBox1.Text, out a);
            if (ismp1)
            {
                bool ismp2 = int.TryParse(textBox2.Text, out b);
                if (ismp2)
                {
                    bool ismp3 = int.TryParse(textBox3.Text, out c);
                    if (ismp3)
                    {
                        int sum = a;
                        int temp = a + c;

                        while (temp <= b)
                        {
                            sum = sum + temp;
                            temp = temp + c;
                        }
                        lblResult.Text = sum.ToString();

                    }
                    else { MessageBox.Show("請輸入數值"); }
                }
                else { MessageBox.Show("請輸入數值"); }
            }
            else { MessageBox.Show("請輸入數值"); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;


            bool ismp1 = int.TryParse(textBox1.Text, out a);
            if (ismp1)
            {
                bool ismp2 = int.TryParse(textBox2.Text, out b);
                if (ismp2)
                {
                    bool ismp3 = int.TryParse(textBox3.Text, out c);
                    if (ismp3)
                    {
                        int sum = a;
                        int temp = a + c;

                        do
                        {
                            sum = sum + temp;
                            temp = temp + c;
                        } while (temp <= b);

                        lblResult.Text = sum.ToString();

                    }
                    else { MessageBox.Show("請輸入數值"); }
                }
                else { MessageBox.Show("請輸入數值"); }
            }
            else { MessageBox.Show("請輸入數值"); }
        }
    }
}
    

        

