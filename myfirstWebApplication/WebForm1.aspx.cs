using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace myfirstWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            bigint a = new bigint(TextBox1.Text.ToString());
            bigint b= new bigint(TextBox2.Text.ToString());
            if (globalvalue.sign == "+")
            {
                globalvalue.MAXSIZE = TextBox1.Text.ToString().Length > TextBox2.Text.ToString().Length ? (TextBox1.Text.ToString().Length + 1) : (TextBox2.Text.ToString().Length + 1);
                bigint c = a + b;
                char[] temp_outcome = c.x.TrimEnd('0').ToCharArray();
                Array.Reverse(temp_outcome);
                string outcome = new string(temp_outcome);
                if (c.sign == 0 && outcome.Length != 0) TextBox_outcome.Text = outcome;
                else if (outcome.Length == 0) TextBox_outcome.Text = "0";
                else if (c.sign == 1 && outcome.Length != 0) { TextBox_outcome.Text = ("-" + outcome).ToString(); }
            }
            else if(globalvalue.sign == "-")
            {
                globalvalue.MAXSIZE = TextBox1.Text.ToString().Length > TextBox2.Text.ToString().Length ? (TextBox1.Text.ToString().Length + 1) : (TextBox2.Text.ToString().Length + 1);
                bigint c = a - b;
                char[] temp_outcome = c.x.TrimEnd('0').ToCharArray();
                Array.Reverse(temp_outcome);
                string outcome = new string(temp_outcome);
                if (c.sign == 0 && outcome.Length != 0) TextBox_outcome.Text = outcome;
                else if (outcome.Length == 0) TextBox_outcome.Text = "0";
                else if (c.sign == 1 && outcome.Length != 0) { TextBox_outcome.Text = ("-" + outcome).ToString(); }
            }
            else if(globalvalue.sign == "*")
            {
                int temp_zero = 0;


                if (a.length < b.length) 
                {
                    temp_zero = b.length - a.length;
                    a = bigint.power10(a, b.length - a.length);

                }
                else
                {
                    temp_zero = a.length - b.length;
                    b = bigint.power10(b, a.length - b.length);

                }
                globalvalue.MAXSIZE = a.length * b.length + 10;
                bigint c = a * b;
                string c_x = c.x.Substring(temp_zero);
                char[] temp_outcome = c_x.TrimEnd('0').ToCharArray();
                Array.Reverse(temp_outcome);
                string outcome = new string(temp_outcome);
                if (c.sign == 0 && outcome.Length != 0) TextBox_outcome.Text = outcome;
                else if (outcome.Length == 0) TextBox_outcome.Text = "0";
                else if (c.sign == 1 && outcome.Length != 0) { TextBox_outcome.Text = ("-" + outcome).ToString(); }
            }
            else if(globalvalue.sign == "/")
            {
                globalvalue.MAXSIZE = TextBox1.Text.ToString().Length > TextBox2.Text.ToString().Length ? (TextBox1.Text.ToString().Length + 1) : (TextBox2.Text.ToString().Length + 1);
                if (b.length == 0) TextBox_outcome.Text = "Math Error";
                else
                {
                    bigint c = a / b;
                    char[] temp_outcome = c.x.TrimEnd('0').ToCharArray();
                    Array.Reverse(temp_outcome);
                    string outcome = new string(temp_outcome);
                    if (c.sign == 0 && outcome.Length != 0) TextBox_outcome.Text = outcome;
                    else if (outcome.Length == 0) TextBox_outcome.Text = "0";
                    else if (c.sign == 1 && outcome.Length != 0) { TextBox_outcome.Text = ("-" + outcome).ToString(); }
                }

            }
            else if (globalvalue.sign == "%")
            {
                globalvalue.MAXSIZE = TextBox1.Text.ToString().Length > TextBox2.Text.ToString().Length ? (TextBox1.Text.ToString().Length + 1) : (TextBox2.Text.ToString().Length + 1);
                if (b.length == 0) TextBox_outcome.Text = "Math Error";
                else
                {
                    bigint c = a % b;
                    char[] temp_outcome = c.x.TrimEnd('0').ToCharArray();
                    Array.Reverse(temp_outcome);
                    string outcome = new string(temp_outcome);
                    if (c.sign == 0 && outcome.Length != 0) TextBox_outcome.Text = outcome;
                    else if (outcome.Length == 0) TextBox_outcome.Text = "0";
                    else if (c.sign == 1 && outcome.Length != 0) { TextBox_outcome.Text = ("-" + outcome).ToString(); }
                }
            }

        }

        protected void Button_add_Click(object sender, EventArgs e)
        {
            globalvalue.sign = "+";
            Button_add.BackColor = System.Drawing.Color.Aqua;
            Button_sub.BackColor = System.Drawing.Color.White;
            Button_multi.BackColor = System.Drawing.Color.White;
            Button_div.BackColor = System.Drawing.Color.White;
            Button_mod.BackColor = System.Drawing.Color.White;
        }

        protected void Button_sub_Click(object sender, EventArgs e)
        {
            globalvalue.sign = "-";
            Button_sub.BackColor = System.Drawing.Color.Aqua;
            Button_add.BackColor = System.Drawing.Color.White;
            Button_multi.BackColor = System.Drawing.Color.White;
            Button_div.BackColor = System.Drawing.Color.White;
            Button_mod.BackColor = System.Drawing.Color.White;
        }

        protected void Button_multi_Click(object sender, EventArgs e)
        {
            globalvalue.sign = "*";
            Button_multi.BackColor = System.Drawing.Color.Aqua;
            Button_sub.BackColor = System.Drawing.Color.White;
            Button_add.BackColor = System.Drawing.Color.White;
            Button_div.BackColor = System.Drawing.Color.White;
            Button_mod.BackColor = System.Drawing.Color.White;
        }

        protected void Button_div_Click(object sender, EventArgs e)
        {
            globalvalue.sign = "/";
            Button_div.BackColor = System.Drawing.Color.Aqua;
            Button_sub.BackColor = System.Drawing.Color.White;
            Button_multi.BackColor = System.Drawing.Color.White;
            Button_add.BackColor = System.Drawing.Color.White;
            Button_mod.BackColor = System.Drawing.Color.White;
        }

        protected void Button_mod_Click1(object sender, EventArgs e)
        {
            globalvalue.sign = "%";
            Button_div.BackColor = System.Drawing.Color.White;
            Button_sub.BackColor = System.Drawing.Color.White;
            Button_multi.BackColor = System.Drawing.Color.White;
            Button_add.BackColor = System.Drawing.Color.White;
            Button_mod.BackColor = System.Drawing.Color.Aqua;
        }

        protected void TextBox_outcome_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public partial class globalvalue
    {
        public static string sign;
        public static int MAXSIZE = 20;
    }

    public class bigint
    {
        public bigint(string a)
        {
            
            if (a[0] == '-')
            {
                sign = 1;
                a = a.TrimStart('-');
                length = a.TrimStart('0').Length;
            }
            else
            {
                sign = 0;
                length = a.TrimStart('0').Length;
            }
            char[] temp = a.ToCharArray();
            Array.Reverse(temp);
            x = new string(temp);
            x = x.PadRight(globalvalue.MAXSIZE, '0');

        }
        public string x;
        public int sign;          //符号位 0正1负
        public int length;

        //比较运算符>重载
        public static bool operator >(bigint x1, bigint x2)
        {
            bool status = false;
            if (x1.sign == 1 && x2.sign == 1)
            {
                if (x1.length < x2.length)
                {
                    status = true;
                }
                else if (x1.length == x2.length)
                {
                    int i = 0;
                    for (i = x1.length; i >= 0; i--)
                    {
                        if (x1.x[i] == x2.x[i]) continue;
                        else if (Convert.ToInt32(x1.x[i]) > Convert.ToInt32(x2.x[i])) { status = false; break; }
                        else if (Convert.ToInt32(x1.x[i]) < Convert.ToInt32(x2.x[i])) { status = true; break; }
                    }
                }
                else if (x1.length > x2.length)
                {
                    status = false;
                }
            }
            else if (x1.sign == 0 && x2.sign == 1)
            {
                status = true;
            }
            else if (x1.sign == 1 && x2.sign == 0)
            {
                status = false;
            }
            else if (x1.sign == 0 && x2.sign == 0)
            {
                if (x1.length < x2.length)
                {
                    status = false;
                }
                else if (x1.length == x2.length)
                {
                    int i = 0;
                    for (i = x1.length; i >= 0; i--)
                    {
                        if (x1.x[i] == x2.x[i]) continue;
                        else if (Convert.ToInt32(x1.x[i]) > Convert.ToInt32(x2.x[i])) { status = true; break; }
                        else if (Convert.ToInt32(x1.x[i]) < Convert.ToInt32(x2.x[i])) { status = false; break; }
                    }
                }
                else if (x1.length > x2.length)
                {
                    status = true;
                }
            }
            return status;
        }

        //比较运算符<重载
        public static bool operator <(bigint x1, bigint x2)
        {
            bool status = false;
            if (x1.sign == 1 && x2.sign == 1)
            {
                if (x1.length < x2.length)
                {
                    status = false;
                }
                else if (x1.length == x2.length)
                {
                    int i = 0;
                    for (i = x1.length; i >= 0; i--)
                    {
                        if (x1.x[i] == x2.x[i]) continue;
                        else if (Convert.ToInt32(x1.x[i]) > Convert.ToInt32(x2.x[i])) { status = false; break; }
                        else if (Convert.ToInt32(x1.x[i]) < Convert.ToInt32(x2.x[i])) { status = true; break; }
                    }
                }
                else if (x1.length > x2.length)
                {
                    status = true;
                }
            }
            else if (x1.sign == 0 && x2.sign == 1)
            {
                status = false;
            }
            else if (x1.sign == 1 && x2.sign == 0)
            {
                status = true;
            }
            else if (x1.sign == 0 && x2.sign == 0)
            {
                if (x1.length < x2.length)
                {
                    status = true;
                }
                else if (x1.length == x2.length)
                {
                    int i = 0;
                    for (i = x1.length; i >= 0; i--)
                    {
                        if (x1.x[i] == x2.x[i]) continue;
                        else if (Convert.ToInt32(x1.x[i]) > Convert.ToInt32(x2.x[i])) { status = false; break; }
                        else if (Convert.ToInt32(x1.x[i]) < Convert.ToInt32(x2.x[i])) { status = true; break; }
                    }
                }
                else if (x1.length > x2.length)
                {
                    status = false;
                }
            }
            return status;
        }



        //运算符+重载（加法）
        public static bigint operator +(bigint x1, bigint x2)
        {
            bigint y = new bigint("0");
            string string_y = "";
            if(x1.length == 0 && x2.length == 0)
            {
                bigint zero = new bigint("0");
                return zero;
            }
            else if (x1.sign == 0 && x2.sign == 0)
            {

                int i = 0;
                int a = 0;
                int b = 0;
                int c = 0;
                int dec = 0;
                int length = x1.length > x2.length ? x1.length : x2.length;

                while (i <= length)
                {
                    a = Convert.ToInt32(x1.x[i].ToString());
                    b = Convert.ToInt32(x2.x[i].ToString());
                    dec = (a + b + c) % 10;
                    c = (a + b + c) / 10;
                    string_y = string_y.Insert(i, dec.ToString());
 //                   y.x = y.x.Insert(i, dec.ToString());
                    i++;
                }
                char[] temp = string_y.ToCharArray();
                Array.Reverse(temp);
                string string_y_temp = new string(temp);
                bigint temp_y = new bigint(string_y_temp);
                y.sign = 0;
                y.length = temp_y.length;
                y.x = temp_y.x;
            }
            else if (x1.sign == 0 && x2.sign == 1)
            {
                x2.sign = 0;
                y = x1 - x2;
                x2.sign = 1;
            }
            else if (x1.sign == 1 && x2.sign == 0)
            {
                x1.sign = 0;
                y = x2 - x1;
                x1.sign = 1;
            }
            else if (x1.sign == 1 && x2.sign == 1)
            {
                x1.sign = 0;
                x2.sign = 0;
                y = x1 + x2;
                x1.sign = 1;
                x2.sign = 1;
                y.sign = 1;
            }


            return y;

        }

        //运算符-重载（减法）
        public static bigint operator -(bigint x1, bigint x2)
        {
            bigint y = new bigint("0");
            string string_y = "";
            if (x1.length == 0 && x2.length == 0)
            {
                bigint zero = new bigint("0");
                return zero;
            }
            else if (x1.sign == 0 && x2.sign == 0)
            {
                if (x1 < x2)
                {
                    y = x2 - x1;
                    y.sign = 1;
                }
                else
                {
                    int a;
                    int b;
                    int c = 0;
                    int length = x1.length;
                    int i = 0;
                    int sub;
                    while (i < length)
                    {
                        a = Convert.ToInt32(x1.x[i].ToString());
                        b = Convert.ToInt32(x2.x[i].ToString());
                        sub = (a + 10 - b - c) % 10;
                        c = (a - b - c) >= 0 ? 0 : 1;
                        string_y = string_y.Insert(i, sub.ToString());
//                        y.x = y.x.Insert(i, sub.ToString());
                        i++;
                    }
                    char[] temp = string_y.ToCharArray();
                    Array.Reverse(temp);
                    string string_y_temp = new string(temp);
                    bigint temp_y = new bigint(string_y_temp);
                    y.sign = 0;
                    y.length = temp_y.length;
                    y.x = temp_y.x;
                }
            }
            else if (x1.sign == 0 && x2.sign == 1)
            {
                x2.sign = 0;
                y = x1 + x2;
                y.sign = 0;
                x2.sign = 1;
            }
            else if (x1.sign == 1 && x2.sign == 0)
            {
                x1.sign = 0;
                y = x1 + x2;
                y.sign = 1;
                x1.sign = 1;
            }
            else if (x1.sign == 1 && x2.sign == 1)
            {
                x1.sign = 0;
                x2.sign = 0;
                y = x1 - x2;
                y.sign = y.sign == 1 ? 0 : 1;
            }

            return y;
        }

        //小数值乘法
        public static bigint multiply(bigint x1,bigint x2)
        {
            if (x1.length == 0 || x2.length == 0)
            {
                bigint zero = new bigint("0");
                return zero;
            }
            else
            {
                int a, b, product;
                char[] tempx1_x = x1.x.Remove(x1.length).ToCharArray();
                char[] tempx2_x = x2.x.Remove(x2.length).ToCharArray();
                Array.Reverse(tempx1_x);
                Array.Reverse(tempx2_x);
                string string_a = new string(tempx1_x);
                string string_b = new string(tempx2_x);
                a = Convert.ToInt32(string_a);
                b = Convert.ToInt32(string_b);
                product = a * b;
                bigint y = new bigint(product.ToString());
                if (a == 0 || b == 0) y.sign = 0;
                else if (x1.sign == x2.sign) y.sign = 0;
                else if (x1.sign != x2.sign) y.sign = 1;
                return y;
            }

        }

        //模拟移位
        public static bigint power10(bigint x1, int n)
        {
            int length = x1.length;
            char[]  tempy_x = x1.x.TrimEnd('0').ToCharArray();
            x1.x = x1.x.PadRight(globalvalue.MAXSIZE,'0');
            Array.Reverse(tempy_x);
            string y_x = new string(tempy_x);
            y_x = y_x.PadRight(n+length, '0');
            bigint y = new bigint(y_x);

            if (x1.sign == 0) y.sign = 0;
            else if (x1.sign == 1) y.sign = 1;

            return y;
        }

        //运算符*重载（分治乘法）
        public static bigint operator *(bigint x1, bigint x2)
        {
            //bigint y = new bigint("0");
            int length1 = x1.length;
            int length2 = x2.length;

            if(length1 == 0 || length2 == 0)
            {
                bigint zero = new bigint("0");
                return zero;
            }
            else if (length1 <= 3 && length2 <= 3)
            {
                bigint y = multiply(x1, x2);
                char[] tempy = y.x.TrimEnd('0').ToCharArray();
                y.x = y.x.PadRight(globalvalue.MAXSIZE, '0');
                Array.Reverse(tempy);
                string string_y = new string(tempy);
                bigint product = new bigint(string_y);
 
                if (x1.length == 0 || x2.length == 0) product.sign = 0;
                else if (x1.sign == x2.sign) product.sign = 0;
                else if (x1.sign != x2.sign) product.sign = 1;

                return product;
            }
            else
            {
                int half1 = length1 / 2;
                int half2 = length2 / 2;
                char[] temp1 = x1.x.TrimEnd('0').ToCharArray();
                char[] temp2 = x2.x.TrimEnd('0').ToCharArray();
                x1.x = x1.x.PadRight(globalvalue.MAXSIZE, '0');
                x2.x = x2.x.PadRight(globalvalue.MAXSIZE, '0');
                Array.Reverse(temp1);
                Array.Reverse(temp2);
                string string_x1 = new string(temp1);
                string string_x2 = new string(temp2);
                string x1_low = "";
                string x1_high = "";
                string x2_low = "";
                string x2_high = "";
                if (length1 % 2 == 0)
                {
                    x1_low = string_x1.Substring(half1);
                    x1_high = string_x1.Remove(half1);
                }
                else
                {
                    x1_low = string_x1.Substring(half1 + 1);
                    x1_high = string_x1.Remove(half1 + 1);
                }
                if (length2 % 2 == 0)
                {
                    x2_low = string_x2.Substring(half2);
                    x2_high = string_x2.Remove(half2);
                }
                else
                {
                    x2_low = string_x2.Substring(half2 + 1);
                    x2_high = string_x2.Remove(half2 + 1);
                }

                bigint A = new bigint(x1_high);
                bigint B = new bigint(x1_low);
                bigint C = new bigint(x2_high);
                bigint D = new bigint(x2_low);

                bigint AC = A * C;
                bigint BC = B * C;
                bigint AD = A * D;
                bigint BD = B * D;
                bigint AC_POWER = power10(AC, (half1 + half2));
                bigint BC_POWER = power10(BC, half2);
                bigint AD_POWER = power10(AD, half1);
                bigint ADD1 = AC_POWER + BC_POWER;
                bigint ADD2 = ADD1 + AD_POWER;
                bigint ADD3 = ADD2 + BD;
                char[] tempy = ADD3.x.TrimEnd('0').ToCharArray();
                Array.Reverse(tempy);
                string string_y = new string(tempy);
                bigint y = new bigint(string_y);

                if (x1.length == 0 || x2.length == 0) y.sign = 0;
                else if (x1.sign == x2.sign) y.sign = 0;
                else if (x1.sign != x2.sign) y.sign = 1;

                return y;
            }
        }




        public static bigint operator%(bigint x1, bigint x2)
        {

            int temp_x1_sign = x1.sign;
            int temp_x2_sign = x2.sign;
            x1.sign = 0;
            x2.sign = 0;

            

            if(x1<x2)
            {
                x1.sign = temp_x1_sign;
                x2.sign = temp_x2_sign;
                return x1;
            }
            else
            {
                char[] temp_x1_r = x1.x.TrimEnd('0').ToCharArray();
                char[] temp_x2_r = x2.x.TrimEnd('0').ToCharArray();
                Array.Reverse(temp_x1_r);
                Array.Reverse(temp_x2_r);
                string string_x1 = new string(temp_x1_r);
                string string_x2 = new string(temp_x2_r);

                int length1 = string_x1.Length;
                int length2 = string_x2.Length;
                int i = 0;
                int t = 0;
                string string_quotient = "";
                string string_dividend_initial = length1 == length2 ? string_x1 : string_x1.Remove(length2);
                bigint dividend = new bigint(string_dividend_initial);
                for(t=0,i=0;t<=(length1-length2);t++,i=0)
                {


                    while (dividend.sign == 0)
                    {
                        dividend = dividend - x2;
                        i++;
                    }
                    string_quotient = string_quotient.Insert(t, (i - 1).ToString());

                    if (t != length1 - length2)
                    {
                        bigint next = new bigint(string_x1[(t + length2)].ToString());
                        dividend = power10(dividend + x2, 1) + next;
                    } 
                    else break;
                }

                dividend = dividend + x2;
                x1.sign = temp_x1_sign;
                x2.sign = temp_x2_sign;
                dividend.sign = x1.sign;

                return dividend;
            }

        }

        public static bigint operator /(bigint x1, bigint x2)
        {

            int temp_x1_sign = x1.sign;
            int temp_x2_sign = x2.sign;
            x1.sign = 0;
            x2.sign = 0;



            if (x1 < x2)
            {
                bigint quotient = new bigint("0");
                x1.sign = temp_x1_sign;
                x2.sign = temp_x2_sign;
                if (x1.sign == x2.sign) quotient.sign = 0;
                else quotient.sign = 1;

                return quotient;

            }
            else
            {
                char[] temp_x1_r = x1.x.TrimEnd('0').ToCharArray();
                char[] temp_x2_r = x2.x.TrimEnd('0').ToCharArray();
                Array.Reverse(temp_x1_r);
                Array.Reverse(temp_x2_r);
                string string_x1 = new string(temp_x1_r);
                string string_x2 = new string(temp_x2_r);

                int length1 = string_x1.Length;
                int length2 = string_x2.Length;
                int i = 0;
                int t = 0;
                string string_quotient = "";
                string string_dividend_initial = length1 == length2 ? string_x1 : string_x1.Remove(length2);
                bigint dividend = new bigint(string_dividend_initial);
                for (t = 0, i = 0; t <= (length1 - length2); t++, i = 0)
                {


                    while (dividend.sign == 0)
                    {
                        dividend = dividend - x2;
                        i++;
                    }
                    string_quotient = string_quotient.Insert(t, (i - 1).ToString());

                    if (t != length1 - length2)
                    {
                        bigint next = new bigint(string_x1[(t + length2)].ToString());
                        dividend = power10(dividend + x2, 1) + next;
                    }
                    else break;
                }

                bigint quotient = new bigint(string_quotient);
                x1.sign = temp_x1_sign;
                x2.sign = temp_x2_sign;
                if (x1.sign == x2.sign) quotient.sign = 0;
                else quotient.sign = 1;

                return quotient;
            }

        }


    }
}