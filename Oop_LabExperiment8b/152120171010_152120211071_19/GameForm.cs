using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120171010_152120211071_19
{
    public partial class GameForm : Form
    {
        private labeluser1 startForm;
        public GameForm(labeluser1 startForm)
        {
            InitializeComponent();
            this.startForm=startForm;
            //InitializeTimer();

        }
        private int countdown;
        User1 user1game = new User1();
        User2 user2game = new User2();
        PictureBox myPictureBox1;
        PictureBox myPictureBox2;
        public int[] actualValues;
        public int[] estimatedValuesUser1;
        public int[] estimatedValuesUser2;
        private void OpenFormInPanel(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            countdown = 5;
            timer1.Start();
            OpenFormInPanel(user1game, panel1);
            OpenFormInPanel(user2game, panel2);
            Form myForm1 = null;

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Form)
                {
                    myForm1 = ctrl as Form;
                    break;
                }
            }

            Form myForm2 = null;
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl is Form)
                {
                    myForm2 = ctrl as Form;
                    break;
                }
            }

            if (myForm1 != null)
            {
                // Form içindeki PictureBox kontrolüne erişmek
                myPictureBox1 = myForm1.Controls["pictureBox1"] as PictureBox;
                myPictureBox2 = myForm2.Controls["pictureBox1"] as PictureBox;
                if (myPictureBox1 != null && myPictureBox2 != null)
                {
                    // PictureBox'ın özelliklerini değiştirebilirsiniz
                    var symbolCounts1 = PictureClass.DrawSymbols(myPictureBox1);
                    myPictureBox2.Image = PictureClass.LastBitmap;
                    //Sembollerin sayısını label'a yazdır
                    label1.Text = $"* : {symbolCounts1["*"]}, o : {symbolCounts1["o"]}, _ : {symbolCounts1["_"]}";
                    label2.Text = $"* : {symbolCounts1["*"]}, o : {symbolCounts1["o"]}, _ : {symbolCounts1["_"]}";
                    actualValues = new int[] { symbolCounts1["*"], symbolCounts1["o"], symbolCounts1["_"] };

                    // You can initialize estimated values for users here
                    estimatedValuesUser1 = new int[] { 0, 0, 0 }; // Replace with actual logic to get these values
                    estimatedValuesUser2 = new int[] { 0, 0, 0 }; // Replace with actual logic to get these values
                }
                else
                {
                    MessageBox.Show("PictureBox bulunamadı!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            estimatedValuesUser1 = user1game.user1guess;
            estimatedValuesUser2 = user2game.user2guess;

            int errorUser1 = ScoreCalculator.CalculateError(actualValues, estimatedValuesUser1);
            int errorUser2 = ScoreCalculator.CalculateError(actualValues, estimatedValuesUser2);

            // Determine winner
            string winner = ScoreCalculator.DetermineWinner(errorUser1, errorUser2);

            // Display winner
            MessageBox.Show(winner);
            this.Close();
            startForm.label2.Text = winner;
            startForm.label2.Visible = true;
            startForm.user1lastpoint.Text = errorUser1.ToString();
            startForm.user2lastpoint.Text = errorUser2.ToString();

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                countdown--;
                label3.Text = $"Time left: {countdown} seconds";
            }

            if(countdown == 0)
            {
                myPictureBox1.Visible = false;
                myPictureBox2.Visible = false;
            }


        }
    }

    public class ScoreCalculator
    {
        public static int CalculateError(int[] actual, int[] estimated)
        {
            int error = 0;
            for (int i = 0; i < actual.Length; i++)
            {
                error += Math.Abs(actual[i] - estimated[i]);
            }
            return error;
        }

        public static string DetermineWinner(int error1, int error2)
        {
            if (error1 < error2) return "User 1 Wins!";
            if (error2 < error1) return "User 2 Wins!";
            return "It's a Tie!";
        }

        
    }

}
