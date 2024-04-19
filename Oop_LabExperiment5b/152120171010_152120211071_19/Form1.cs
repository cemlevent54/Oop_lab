using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120171010_152120211071_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        DateTime now = DateTime.Now;
        string siparisStr = "";
        Dictionary<string, List<string>> cityDistricts = new Dictionary<string, List<string>>()
        {
            {"Eskişehir", new List<string> {"Tepebaşı", "Odunpazarı"}},
            {"Bursa", new List<string> {"İnegöl", "Kestel"}}
        };


        


        private void btnSiparis_Click(object sender, EventArgs e)
        {
            string adsoyad = textBox1.Text;
            string telno = textBox2.Text;
            string menu = "";
            string quantity = numericUpDown1.Value.ToString();
            
            foreach (var selectedItem in listBoxMenu.SelectedItems)
            {
                menu += selectedItem.ToString() + " ";
            }

            string city = listBoxCity.SelectedItem.ToString();
            string district = listBoxDistrict.SelectedItem.ToString();

            siparisStr = $"{now} tarihli siparisiniz olusturuldu:,{Environment.NewLine}" +
                      $"{adsoyad},{Environment.NewLine}" +
                      $"{telno},{Environment.NewLine}" +
                      $"{menu},{Environment.NewLine}" +
                      $"{quantity},{Environment.NewLine}" +
                      $"{city},{Environment.NewLine}" +
                      $"{district},{Environment.NewLine}";
                     
            listBoxSiparisler.Items.Add(siparisStr);
            // custom adaptor
            textBox1.Text = "";
            textBox2.Text = "";
            if (listBoxMenu.SelectedIndex != -1)
            {
                listBoxMenu.ClearSelected();
            }
        }

        private void listBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDistrict.Items.Clear();

            string secilenIl = listBoxCity.SelectedItem.ToString();
            List<string> ilceler = cityDistricts[secilenIl];
            foreach (var ilce in ilceler)
            {
                listBoxDistrict.Items.Add(ilce);
            }
        }

        private void listBoxSiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxSiparisler.SelectedIndex != -1) 
            {
                SiparisLabel.Text = listBoxSiparisler.SelectedItem.ToString();
                SiparisLabel.Visible = true;
            }
            
        }

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                
                MessageBox.Show("Lütfen ad alanına sayı girmeyin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                e.Handled = true;
            }

            else
            {
                e.Handled = false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                
                MessageBox.Show("Lütfen sadece rakam girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                e.Handled = true;
            }
        
            else
            {
                e.Handled = false;
            }
        }
        
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.TextLength != 11)
            {
                MessageBox.Show("Telefon numarası 11 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
        }
    }
}
