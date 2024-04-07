using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Threading;


namespace emlak_kayit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=your_database_connection;Initial Catalog=siteler;Integrated Security=True;Encrypt=False");

        private void clearDatas()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            comboBox5.SelectedItem = null;

        }

        private void verileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT *FROM sitebilgi",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["id"].ToString());
                item.SubItems.Add(oku["site"].ToString());
                item.SubItems.Add(oku["durum"].ToString());
                item.SubItems.Add(oku["oda"].ToString());
                item.SubItems.Add(oku["metre"].ToString());
                item.SubItems.Add(oku["fiyat"].ToString());
                item.SubItems.Add(oku["blok"].ToString());
                item.SubItems.Add(oku["no"].ToString());
                item.SubItems.Add(oku["adsoyad"].ToString());
                item.SubItems.Add(oku["telefon"].ToString());
                item.SubItems.Add(oku["notlar"].ToString());
                listView1.Items.Add(item);
            }

            baglanti.Close();
        }

        private void verileriKaydet()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("INSERT into sitebilgi (id,site,durum,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar) Values " +
                "(@id,@site,@durum,@oda,@metre,@fiyat,@blok,@no,@adsoyad,@telefon,@notlar)",baglanti);

            komut.Parameters.AddWithValue("@id", textBox3.Text);
            komut.Parameters.AddWithValue("@site", comboBox1.Text.ToString());
            komut.Parameters.AddWithValue("@durum",comboBox2.Text.ToString());
            komut.Parameters.AddWithValue("@oda",comboBox3.Text.ToString());
            komut.Parameters.AddWithValue("@metre", textBox1.Text);
            komut.Parameters.AddWithValue("@fiyat", textBox2.Text);
            komut.Parameters.AddWithValue("@blok",comboBox5.Text.ToString());
            komut.Parameters.AddWithValue("@no", textBox7.Text);
            komut.Parameters.AddWithValue("@adsoyad", textBox6.Text);
            komut.Parameters.AddWithValue("@telefon", textBox5.Text);
            komut.Parameters.AddWithValue("@notlar", textBox4.Text);
            komut.ExecuteNonQuery();
            
            baglanti.Close();
        }

        private void veriSil()
        {
            baglanti.Open();
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            SqlCommand komut = new SqlCommand("Delete from sitebilgi where id=@id",baglanti);
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void veriGuncelle()
        {
            baglanti.Open();
            string query = "Update sitebilgi set id=@id, site=@site, durum=@durum, oda=@oda, metre=@metre, fiyat=@fiyat, blok=@blok, no=@no, adsoyad=@adsoyad, telefon=@telefon, notlar=@notlar where id=@id";
            
            SqlCommand komut = new SqlCommand(query,baglanti);
            komut.Parameters.AddWithValue("@id",int.Parse(textBox3.Text));
            komut.Parameters.AddWithValue("@site",comboBox1.Text);
            komut.Parameters.AddWithValue("@durum", comboBox2.Text);
            komut.Parameters.AddWithValue("@oda", comboBox3.Text);
            komut.Parameters.AddWithValue("@metre",textBox1.Text);
            komut.Parameters.AddWithValue("@fiyat", textBox2.Text);
            komut.Parameters.AddWithValue("@blok", comboBox5.Text);
            komut.Parameters.AddWithValue("@no",textBox7.Text);
            komut.Parameters.AddWithValue("@adsoyad", textBox6.Text);
            komut.Parameters.AddWithValue("@telefon", textBox5.Text);
            komut.Parameters.AddWithValue("@notlar", textBox4.Text);


            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (listView1.Items.Count != 0)
            {
                listView1.Items.Clear();
            }
            else
            {
                if (count == 0)
                {
                    verileriGoster();
                    count++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            if(listView1.Items.Count != 0)
            {
                listView1.Items.Clear();
            }
            else
            {
                if(count == 0)
                {
                    verileriKaydet();
                    verileriGoster();
                    count++;
                }
            }

            //verileriKaydet();
            //verileriGoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            veriSil();
            verileriGoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            veriGuncelle();
            verileriGoster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text); // id
            textBox3.Text = id.ToString();
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text; // site
            comboBox2.Text = listView1.SelectedItems[0].SubItems[2].Text; // durum
            comboBox3.Text = listView1.SelectedItems[0].SubItems[3].Text; // oda
            textBox1.Text = listView1.SelectedItems[0].SubItems[4].Text; // metre
            textBox2.Text = listView1.SelectedItems[0].SubItems[5].Text; // fiyat
            comboBox5.Text = listView1.SelectedItems[0].SubItems[6].Text; // blok
            textBox7.Text = listView1.SelectedItems[0].SubItems[7].Text; // no
            textBox6.Text = listView1.SelectedItems[0].SubItems[8].Text; // ad soyad
            textBox5.Text = listView1.SelectedItems[0].SubItems[9].Text; // telefon
            textBox4.Text = listView1.SelectedItems[0].SubItems[10].Text; // notlar
        }

        
    }
}
