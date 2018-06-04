using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string sum1;
        public string sum2;
        
        public string temp="0";

        public int countHistory=0;

        public int countDigit=0;
        public long flagSide = 0;
        public bool IsFloat=false;

        public double memory = 0;

        public bool IsAdd = false;
        public bool IsSub = false;
        public bool IsMul = false;
        public bool IsDiv = false;
        public List<string> history = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonOne_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            countHistory = history.Count - 1;
            countDigit++;
            if (countDigit > 9)
            {
            }
            else if(countDigit<=9 && flagSide==0)
            {
                sum1 = sum1+"1";
                monitor.Text = sum1;
            }
            else if (countDigit <= 9 && flagSide == 1) 
            {
                sum2 = sum2 + "1";
                monitor.Text = sum2;
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            countHistory = history.Count - 1;
            countDigit++;
            if (countDigit > 9)
            {
            }
            else if (countDigit <= 9 && flagSide == 0)
            {
                sum1 = sum1 + "2";
                monitor.Text = sum1;
            }
            else if (countDigit <= 9 && flagSide == 1)
            {
                sum2 = sum2 + "2";
                monitor.Text = sum2;
            }
        }
        private void buttonThree_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            countHistory = history.Count - 1;
            countDigit++;
            if (countDigit > 9)
            {
            }
            else if (countDigit <= 9 && flagSide == 0)
            {
                sum1 = sum1 + "3";
                monitor.Text = sum1;
            }
            else if (countDigit <= 9 && flagSide == 1)
            {
                sum2 = sum2 + "3";
                monitor.Text = sum2;
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            countHistory = history.Count - 1;
            countDigit++;
            if (countDigit > 9)
            {
            }
            else if (countDigit <= 9 && flagSide == 0)
            {
                sum1 = sum1 + "4";
                monitor.Text = sum1;
            }
            else if (countDigit <= 9 && flagSide == 1)
            {
                sum2 = sum2 + "4";
                monitor.Text = sum2;
            }
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            countHistory = history.Count - 1;
            countDigit++;
            if (countDigit > 9)
            {
            }
            else if (countDigit <= 9 && flagSide == 0)
            {
                sum1 = sum1 + "5";
                monitor.Text = sum1;
            }
            else if (countDigit <= 9 && flagSide == 1)
            {
                sum2 = sum2 + "5";
                monitor.Text = sum2;
            }
        }
        private void buttonSix_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            countHistory = history.Count - 1;
            countDigit++;
            if (countDigit > 9)
            {
            }
            else if (countDigit <= 9 && flagSide == 0)
            {
                sum1 = sum1 + "6";
                monitor.Text = sum1;
            }
            else if (countDigit <= 9 && flagSide == 1)
            {
                sum2 = sum2 + "6";
                monitor.Text = sum2;
            }
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            countHistory = history.Count - 1;
            countDigit++;
            if (countDigit > 9)
            {
            }
            else if (countDigit <= 9 && flagSide == 0)
            {
                sum1 = sum1 + "7";
                monitor.Text = sum1;
            }
            else if (countDigit <= 9 && flagSide == 1)
            {
                sum2 = sum2 + "7";
                monitor.Text = sum2;
            }
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            countHistory = history.Count - 1;
            countDigit++;
            if (countDigit > 9)
            {
            }
            else if (countDigit <= 9 && flagSide == 0)
            {
                sum1 = sum1 + "8";
                monitor.Text = sum1;
            }
            else if (countDigit <= 9 && flagSide == 1)
            {
                sum2 = sum2 + "8";
                monitor.Text = sum2;
            }
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            countHistory = history.Count - 1;
            countDigit++;
            if (countDigit > 9)
            {
            }
            else if (countDigit <= 9 && flagSide == 0)
            {
                sum1 = sum1 + "9";
                monitor.Text = sum1;
            }
            else if (countDigit <= 9 && flagSide == 1)
            {
                sum2 = sum2 + "9";
                monitor.Text = sum2;
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            countHistory = history.Count - 1;
            countDigit++;
            if (countDigit > 9)
            {
            }
            else if (countDigit <= 9 && flagSide == 0)
            {
                sum1 = sum1 + "0";
                monitor.Text = sum1;
            }
            else if (countDigit <= 9 && flagSide == 1)
            {
                sum2 = sum2 + "0";
                monitor.Text = sum2;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            countHistory = history.Count - 1;
            if (flagSide == 0) 
            {
                try
                {
                    if (sum1[sum1.Length - 1] == '.')
                    {
                        IsFloat = false;
                    }
                }
                catch 
                {

                }
                try
                {
                    sum1 = sum1.Remove(sum1.Length - 1, 1);
                }
                catch 
                {

                }
                monitor.Text = sum1;
                try { countDigit = sum1.Length; }
                catch { }
            }
            else if (flagSide == 1)
            {
                if (sum2[sum2.Length - 1] == '.') 
                {
                    IsFloat = false;
                }
                try
                {
                    sum2 = sum2.Remove(sum2.Length - 1, 1);
                }
                catch 
                {

                }
                monitor.Text = sum2;
                countDigit = sum2.Length;
            }
            if (monitor.Text == "") 
            {
                monitor.Text = "0";
            }
        }


        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            try
            {
                if (sum1 == "")
                {
                    sum1 = "0";
                }
                if (IsAdd == true)
                {
                    bool flag = false;
                    temp = sum1;
                    double result = Double.Parse(sum1) + Double.Parse(sum2);
                    sum1 = Convert.ToString(result);
                    if (sum1.Length > 9)
                    {
                        if (sum1.IndexOf(".") >= 8)
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                            flag = true;
                        }
                        else if (sum1.IndexOf(".") < 8 && sum1.IndexOf(".") >= 0 && !sum1.Contains("E"))
                        {
                            monitor.Text = sum1.Substring(0, 9);
                            sum1 = sum1.Substring(0, 9);
                            flag = true;
                            history.Add(temp + "+" + sum2 + " = " + "" + result + "");
                            countHistory = history.Count - 1;
                        }
                        else if (sum1.Contains("E"))
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                            flag = true;
                        }
                        else
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                            flag = true;
                        }
                    }
                    if (sum1.Length <= 9 && flag == false)
                    {
                        if (!sum1.Contains("E"))
                        {
                            monitor.Text = sum1;
                            history.Add(temp + "+" + sum2 + " = " + "" + result + "");
                            countHistory = history.Count - 1;
                        }
                        else if (sum1.Contains("E"))
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                        }
                    }
                }
                if (IsSub == true)
                {
                    bool flag = false;
                    temp = sum1;
                    double result = Double.Parse(sum1) - Double.Parse(sum2);
                    sum1 = Convert.ToString(result);
                    if (sum1.Length > 9)
                    {
                        if (sum1.IndexOf(".") >= 8)
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                            flag = true;
                        }
                        else if (sum1.IndexOf(".") < 8 && sum1.IndexOf(".") >= 0 && !sum1.Contains("E"))
                        {
                            monitor.Text = sum1.Substring(0, 9);
                            sum1 = sum1.Substring(0, 9);
                            flag = true;
                            history.Add(temp + "-" + sum2 + " = " + "" + result + "");
                            countHistory = history.Count - 1;
                        }
                        else if (sum1.Contains("E"))
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                            flag = true;
                        }
                        else
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                            flag = true;
                        }
                    }
                    if (sum1.Length <= 9 && flag == false)
                    {
                        if (!sum1.Contains("E"))
                        {
                            monitor.Text = sum1;
                            history.Add(temp + "-" + sum2 + " = " + "" + result + "");
                            countHistory = history.Count - 1;
                        }
                        else if (sum1.Contains("E"))
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                        }
                    }
                }
                if (IsMul == true)
                {
                    bool flag = false;
                    temp = sum1;
                    double result = Double.Parse(sum1) * Double.Parse(sum2);
                    sum1 = Convert.ToString(result);
                    if (sum1.Length > 9)
                    {
                        if (sum1.IndexOf(".") >= 8)
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                            flag = true;
                        }
                        else if (sum1.IndexOf(".") < 8 && sum1.IndexOf(".") >= 0 && !sum1.Contains("E"))
                        {
                            monitor.Text = sum1.Substring(0, 9);
                            sum1 = sum1.Substring(0, 9);
                            flag = true;
                            history.Add(temp + "*" + sum2 + " = " + "" + result + "");
                            countHistory = history.Count - 1;
                        }
                        else if (sum1.Contains("E"))
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                            flag = true;
                        }
                        else
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                            flag = true;
                        }
                    }
                    if (sum1.Length <= 9 && flag == false)
                    {
                        if (!sum1.Contains("E"))
                        {
                            monitor.Text = sum1;
                            history.Add(temp + "*" + sum2 + " = " + "" + result + "");
                            countHistory = history.Count - 1;
                        }
                        else if (sum1.Contains("E"))
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                        }
                    }
                }
                if (IsDiv == true)
                {
                    bool flag = false;
                    temp = sum1;
                    double result = Double.Parse(sum1) / Double.Parse(sum2);
                    sum1 = Convert.ToString(result);
                    if (sum1.Length > 9)
                    {
                        if (sum1.IndexOf(".") >= 8)
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                            flag = true;
                        }
                        else if (sum1.IndexOf(".") < 8 && sum1.IndexOf(".") >= 0 && !sum1.Contains("E"))
                        {
                            monitor.Text = sum1.Substring(0, 9);
                            sum1 = sum1.Substring(0, 9);
                            flag = true;
                            history.Add(temp + "/" + sum2 + " = " + "" + result + "");
                            countHistory = history.Count - 1;
                        }
                        else if (sum1.Contains("E"))
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                            flag = true;
                        }
                        else
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                            flag = true;
                        }
                    }
                    if (sum1.Length <= 9 && flag == false)
                    {
                        if (!sum1.Contains("E"))
                        {
                            monitor.Text = sum1;
                            history.Add(temp + "/" + sum2 + " = " + "" + result + "");
                            countHistory = history.Count - 1;
                        }
                        else if (sum1.Contains("E"))
                        {
                            monitor.Text = "Out of Bounds";
                            sum1 = "";
                        }
                    }
                }
                flagSide = 0;
                sum2 = "";
                if (sum1.Contains("."))
                {
                    IsFloat = true;
                }
                else if (!sum1.Contains("."))
                {
                    IsFloat = false;
                }
                countDigit = sum1.Length;
                IsAdd = false;
                IsSub = false;
                IsMul = false;
                IsDiv = false;
            }
            catch { }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            if(IsFloat == false)
            {
                if (flagSide == 0) 
                {
                    if (monitor.Text == "0")
                    {
                        sum1 = "0.";
                    }
                    else
                    {
                        sum1 = sum1 + ".";
                    }
                    monitor.Text = sum1;
                }
                else if (flagSide == 1) 
                {
                    if (sum2 == "")
                    {
                        sum2 = "0.";
                    }
                    else
                    {
                        sum2 = sum2 + ".";
                    }
                    monitor.Text = sum2;
                }
            }
            IsFloat = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            flagSide = 1;
            countDigit = 0;
            IsFloat = false;
            IsAdd = true;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            flagSide = 1;
            countDigit = 0;
            IsFloat = false;
            IsSub = true;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            flagSide = 1;
            countDigit = 0;
            IsFloat = false;
            IsMul = true;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            flagSide = 1;
            countDigit = 0;
            IsFloat = false;
            IsDiv = true;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            countHistory = history.Count - 1;
            monitor.Text = "0";
            sum1 = "";
            sum2 = "";
            IsAdd = false;
            IsSub = false;
            IsDiv = false;
            IsMul = false;
            flagSide = 0;
            countDigit = 0;
            IsFloat = false;
        }

        private void buttonCE_MouseHover(object sender, EventArgs e)
        {
            buttonCE.BackColor = Color.LightBlue;
        }

        private void buttonCE_MouseLeave(object sender, EventArgs e)
        {
            buttonCE.BackColor = Color.LightSeaGreen;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            Console.Beep(500,200);
            if (countHistory >= 0) 
            {
                try
                {
                    monitor.Text = history[countHistory];
                }
                catch { }
            }
            if (countHistory >= 1)
            {
                countHistory--;
            }
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            Console.Beep(500,200);
            try
            {
                memory = memory + Convert.ToDouble(monitor.Text);
            }
            catch 
            {

            }
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            Console.Beep(500,200);
            monitor.Text = "" + memory;
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            try
            {
                memory = memory - Convert.ToDouble(monitor.Text);
            }
            catch
            {

            }
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            memory = 0;
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 200);
            try
            {
                string temp=monitor.Text;
                string sr =""+Math.Sqrt(Convert.ToDouble(monitor.Text))+"";
                if (sr.Contains("E"))
                {
                    monitor.Text = "Out of Bounds";
                }
                else if (sr.Length > 9)
                {
                    monitor.Text = sr.Substring(0, 9);
                    sum1 = monitor.Text;
                    history.Add("√" + temp + " = " + sum1);
                    countHistory = history.Count - 1;
                }
                else 
                {
                    monitor.Text = sr;
                    sum1 = monitor.Text;
                    history.Add("√" + temp + " = " + sum1);
                    countHistory = history.Count - 1;
                }
            }
            catch { }
        }

    }
}
