using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120171010_152120211071_19
{
    public class PictureClass
    {
        private static readonly string[] symbols = new[] { "*", "o", "_" };

        private static Bitmap _lastBitmap;

        // Çizilen Bitmap'i get yöntemi ile erişilebilir hale getirin
        public static Bitmap LastBitmap => _lastBitmap;

        public static Dictionary<string, int> DrawSymbols(PictureBox pictureBox)
        {
            // PictureBox'un boyutları
            int width = pictureBox.Width;
            int height = pictureBox.Height;

            // Rastgele sayı üretici
            Random random = new Random();

            // Her sembolün sayısını tutan sözlük
            Dictionary<string, int> symbolCounts = new Dictionary<string, int>
        {
            { "*", 0 },
            { "o", 0 },
            { "_", 0 }
        };

            // Toplam sembol sayısı 10 olacak şekilde dağıt
            int totalSymbols = 10;
            int remainingSymbols = totalSymbols;

            for (int i = 0; i < symbols.Length - 1; i++)
            {
                int count = random.Next(1, totalSymbols - (symbols.Length - 1 - i));
                symbolCounts[symbols[i]] = count;
                totalSymbols -= count;
            }
            // Son sembole geriye kalan sembol sayısını ekle
            symbolCounts[symbols[symbols.Length - 1]] = totalSymbols;

            // Kullanılan konumları takip eden liste
            List<Point> usedLocations = new List<Point>();

            // Bitmap oluştur ve Graphics nesnesi ile ilişkilendir
            _lastBitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(_lastBitmap))
            {
                // Arka planı beyaz olarak ayarla
                g.Clear(Color.White);

                // Font ayarları
                Font font = new Font("Arial", 12);
                Brush brush = Brushes.Black;

                // Her sembol için belirlenen sayıda rastgele konumda çizim yap
                foreach (var symbol in symbols)
                {
                    for (int i = 0; i < symbolCounts[symbol]; i++)
                    {
                        Point location;
                        SizeF symbolSize = g.MeasureString(symbol, font);

                        // Benzersiz ve PictureBox'tan taşmayan bir konum bulana kadar döngü
                        do
                        {
                            int x = random.Next(width - (int)symbolSize.Width);
                            int y = random.Next(height - (int)symbolSize.Height);
                            location = new Point(x, y);
                        }
                        while (usedLocations.Exists(p => IsOverlap(p, location, symbolSize)));

                        // Sembolü çiz
                        g.DrawString(symbol, font, brush, location);

                        // Konumu kullanılanlar listesine ekle
                        usedLocations.Add(location);
                    }
                }
            }

            // Çizilen Bitmap'i PictureBox'un Image özelliğine ata
            pictureBox.Image = _lastBitmap;

            return symbolCounts;
        }

        private static bool IsOverlap(Point p1, Point p2, SizeF size)
        {
            // İki noktanın sembol boyutlarına göre çakışıp çakışmadığını kontrol et
            return Math.Abs(p1.X - p2.X) < size.Width && Math.Abs(p1.Y - p2.Y) < size.Height;
        }

        
    }
}
