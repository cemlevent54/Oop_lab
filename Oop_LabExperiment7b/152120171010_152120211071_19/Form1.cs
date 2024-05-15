using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NCalc;

namespace _152120171010_152120211071_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Stack<string> history = new Stack<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBox_islem.Text = string.Empty;
            
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += btn_7.Text;
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += btn_8.Text;
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += btn_9.Text;
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += btn_4.Text;
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += btn_5.Text;
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += btn_6.Text;
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += btn_1.Text;
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += btn_2.Text;
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += btn_3.Text;
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += btn_0.Text;
        }
        
        private void btn_div_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "/";
        }
        private void btn_openParentheses_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "(";
        }
        private void btn_closeParentheses_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += ")";
        }
        private void btn_mult_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "*";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "-";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "+";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                // TextBox'taki ifadeyi al ve ^ işaretini Pow fonksiyonuna çevir
                string expressionText = txtBox_islem.Text.Replace("^", ",");
                //expressionText = txtBox_islem.Text.Replace("π", Math.PI.ToString());
                string[] parts = expressionText.Split(',');
                if (expressionText.Contains("/0"))
                {
                    MessageBox.Show("Division by zero is not allowed.");
                    txtBox_islem.Text = "";
                    return;
                }

                if (parts.Length == 2)
                {
                    expressionText = $"Pow({parts[0]},{parts[1]})";
                }

                // Parantez kapatma işlemi
                int openParens = expressionText.Count(c => c == '(');
                int closeParens = expressionText.Count(c => c == ')');
                for (int i = 0; i < (openParens - closeParens); i++)
                {
                    expressionText += ")";
                }

                Expression expression = new Expression(expressionText);

                // Özel işlev tanımlama: Pow ve log10 fonksiyonları
                expression.EvaluateFunction += delegate (string name, FunctionArgs args)
                {
                    if (name == "Pow")
                    {
                        var baseVal = Convert.ToDouble(args.Parameters[0].Evaluate());
                        var expVal = Convert.ToDouble(args.Parameters[1].Evaluate());
                        args.Result = Math.Pow(baseVal, expVal);
                    }
                    else if (name == "log10")
                    {
                        var value = Convert.ToDouble(args.Parameters[0].Evaluate());
                        args.Result = Math.Log10(value);
                    }
                    else if (name == "In")
                    {
                        var value = Convert.ToDouble(args.Parameters[0].Evaluate());
                        args.Result = Math.Log(value);
                    }
                    else if (name == "fact")
                    {
                        var value = Convert.ToInt32(args.Parameters[0].Evaluate());
                        args.Result = Factorial(value);
                    }
                    else if (name == "E")
                    {
                        var value = Convert.ToDouble(args.Parameters[0].Evaluate());
                        args.Result = Math.Exp(value);
                    }
                    else if (name == "Pi")
                    {
                        args.Result = Math.PI;
                    }
                    else if (name == "e")
                    {
                        args.Result = Math.E;
                    }
                };

                var result = expression.Evaluate();
                txtBox_islem.Text = result.ToString();
                history.Push(expressionText + " = " + result);
                List<string> list = history.ToList();
                listBox1.DataSource = null;
                listBox1.DataSource = list;
            }
            catch (Exception ex)
            {
                txtBox_islem.Text = $"Error: {ex.Message}";
            }






        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "Sqrt(";
        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "Sin(";
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "Cos(";
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "Tan(";
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "Log10(";
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "In(";
        }

        private double Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        private void btn_factorial_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "fact(";
        }

        private void btn_pow10_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "10^";
        }

        private void btn_xpowery_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "^";
        }

        private void btn_Exp_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "E";
        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "Pi()";
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text = "";
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += " % ";
        }

        private void btn_elen_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += "e()";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            txtBox_islem.Text += ".";
        }
    }
}
