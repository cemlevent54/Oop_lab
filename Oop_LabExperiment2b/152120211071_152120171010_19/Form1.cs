namespace _152120211071_152120171010_19
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a value for n.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int n;
            if (!int.TryParse(textBox1.Text, out n) || n < 0)
            {
                MessageBox.Show("Please enter a valid positive integer for n.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double average = 0;

            

            if (n == 0)
            {
                textBox2.Text = "0";
                if (checkBox1.Checked)
                {
                    label1.Text = "Average: " + "0.00";
                }

            }

            else {
                int[] lucasArray = GetLucasArray(n);
                average = GetAverage(lucasArray);
                textBox2.Text = string.Join(Environment.NewLine, lucasArray);
                if (checkBox1.Checked) 
                {
                   average = GetAverage(lucasArray);
                   label1.Text = "Average: " + average.ToString("0.00");
                }
                else
                {
                   label1.Text = "";
                }
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = checkBox1.Checked ? "GENERATE - CALCULATE" : "GENERATE";
            if (!checkBox1.Checked)
            {
                label1.Text = "";
            }
        }

        public static int[] GetLucasArray(int n)
        {
            if(n == 1)
            {
                int[] lucasArray;
                lucasArray = new int[n];
                lucasArray[0] = 2;
                return lucasArray;
            }

            else
            {
                int[] lucasArray;
                lucasArray = new int[n];
                lucasArray[0] = 2;
                lucasArray[1] = 1;

                if (n == 2)
                {
                    return lucasArray;
                }

                else
                {
                    for (int i = 2; i < n; i++)
                    {
                        lucasArray[i] = lucasArray[i - 1] + lucasArray[i - 2];
                    }

                    return lucasArray;
                }
            }            
        }

        public double GetAverage(int[] arr)
        {
            int sum = 0;
            foreach (int term in arr)
            {
                sum += term;
            }
            double average = (double)sum / arr.Length;

            return average;
        }
    }
}
