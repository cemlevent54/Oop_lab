using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlak_kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=your_database_connection;Initial Catalog=siteler;Integrated Security=True;Encrypt=False");
        
        private bool kullaniciKontrol(TextBox text1Box1, TextBox textBox2)
        {
            bool kullaniciVarMi = false;
            baglanti.Open();
            string username = textBox1.Text;
            string password = textBox2.Text;
            string sqlquery = "SELECT * FROM kullaniciBilgi WHERE adsoyad=@username AND password=@password";
            SqlCommand komut = new SqlCommand(sqlquery, baglanti);
            komut.Parameters.AddWithValue("@username", username);
            komut.Parameters.AddWithValue("@password", password);
            SqlDataReader oku = komut.ExecuteReader();

            kullaniciVarMi = oku.HasRows;

            oku.Close();
            baglanti.Close();

            return kullaniciVarMi;
        }

        private void kullaniciKaydet()
        {
            baglanti.Open();
            string sqlquery = "INSERT into kullaniciBilgi (email,adsoyad,password) VALUES (@email,@adsoyad,@password)";
            SqlCommand komut = new SqlCommand(sqlquery, baglanti);

            komut.Parameters.AddWithValue("@email", textBox3.Text);
            komut.Parameters.AddWithValue("@adsoyad", textBox4.Text);
            komut.Parameters.AddWithValue("@password", textBox5.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            label8.Text = textBox4.Text +" kullanicisi sisteme kaydedildi." + Environment.NewLine + "Sisteme Giriş Yapabilirsiniz";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(kullaniciKontrol(textBox1,textBox2))
            {
                label7.Text = "Hoşgeldiniz";

                Form2 form = new Form2();
                form.ShowDialog();
                this.Hide();
                
            }
            else
            {
                label7.Text = "Kullanici Yok. Kayıt Olmak için kayıt ekranına gidiniz.";
            }
        }

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                MessageBox.Show("Kullanici adi sadece harflerden oluşmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                MessageBox.Show("Kullanici adi sadece harflerden oluşmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        bool condition;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string girilenSifre = textBox5.Text;
            bool uzunlukGecerli = girilenSifre.Length >= 10;
            bool kucukHarfVar = girilenSifre.Any(char.IsLower);
            bool buyukHarfVar = girilenSifre.Any(char.IsUpper);
            bool sayiVar = girilenSifre.Any(char.IsDigit);
            condition = uzunlukGecerli && kucukHarfVar && buyukHarfVar && sayiVar;

            if (!uzunlukGecerli)
            {
                label9.Text = "Uzunluk 10 olmalı.";
                if (!kucukHarfVar && !buyukHarfVar && !sayiVar)
                {
                    label9.Text += "En az bir küçük harf, bir büyük harf ve bir sayı içermelidir.";
                }
                else
                {
                    if (!kucukHarfVar && buyukHarfVar && sayiVar)
                    {
                        label9.Text += "Küçük harf içermeli";
                    }
                    if (kucukHarfVar && !buyukHarfVar && sayiVar)
                    {
                        label9.Text += "Büyük harf içermeli";
                    }
                    if (kucukHarfVar && buyukHarfVar && !sayiVar)
                    {
                        label9.Text += "Sayı içermeli";
                    }
                    if (!kucukHarfVar && buyukHarfVar && !sayiVar)
                    {
                        label9.Text += "Küçük harf ve sayı içermeli";
                    }
                    if (kucukHarfVar && !buyukHarfVar && !sayiVar)
                    {
                        label9.Text += "Büyük harf ve sayı içermeli";
                    }
                    if (!kucukHarfVar && !buyukHarfVar && sayiVar)
                    {
                        label9.Text += "Küçük ve büyük harf içermeli";
                    }
                }
            }
            else
            {
                label9.Text = "";
                if (kucukHarfVar && buyukHarfVar && sayiVar)
                {
                    label9.Text += "Şifre Güvenli" + Environment.NewLine + "Kayıt Olabilirsiniz :)";
                }
                else if (!kucukHarfVar && !buyukHarfVar && !sayiVar)
                {
                    label9.Text += "En az bir küçük harf, bir büyük harf ve bir sayı içermelidir.";
                }
                else
                {
                    if (!kucukHarfVar && buyukHarfVar && sayiVar)
                    {
                        label9.Text += "Küçük harf içermeli";
                    }
                    if (kucukHarfVar && !buyukHarfVar && sayiVar)
                    {
                        label9.Text += "Büyük harf içermeli";
                    }
                    if (kucukHarfVar && buyukHarfVar && !sayiVar)
                    {
                        label9.Text += "Sayı içermeli";
                    }
                    if (!kucukHarfVar && buyukHarfVar && !sayiVar)
                    {
                        label9.Text += "Küçük harf ve sayı içermeli";
                    }
                    if (kucukHarfVar && !buyukHarfVar && !sayiVar)
                    {
                        label9.Text += "Büyük harf ve sayı içermeli";
                    }
                    if (!kucukHarfVar && !buyukHarfVar && sayiVar)
                    {
                        label9.Text += "Küçük ve büyük harf içermeli";
                    }
                }
            }

            button2.Enabled = condition;

        }

        // kullanici kayit
        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciKaydet();
        }


    
    
    }
}
