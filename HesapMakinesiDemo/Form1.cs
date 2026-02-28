using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiDemo
{
    public partial class Form1 : Form
    {
        public List<string> ozet = new List<string>();
        double ilkSayi = 0;
        string islem = "";

        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(750, 600);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox display = new TextBox();
            display.Location = new System.Drawing.Point(140, 20);
            display.Size = new System.Drawing.Size(400, 60);
            display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20, System.Drawing.FontStyle.Bold);
            display.ReadOnly = true;
            display.TextAlign = HorizontalAlignment.Right;
            display.BackColor = System.Drawing.Color.LightBlue;
            display.ForeColor = System.Drawing.Color.White;
            this.Controls.Add(display);

            Button button1 = new Button();
            button1.Text = "1";
            button1.Location = new System.Drawing.Point(10, 150);
            button1.ForeColor = System.Drawing.Color.White;
            button1.BackColor = System.Drawing.Color.LightBlue;
            button1.Size = new System.Drawing.Size(70, 70);
            button1.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            button1.Click += (s, args) =>
            {
                display.Text += "1";
            };
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Text = "2";
            button2.Location = new System.Drawing.Point(85, 150);
            button2.ForeColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.LightBlue;
            button2.Size = new System.Drawing.Size(70, 70);
            button2.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            button2.Click += (s, args) =>
            {
                display.Text += "2";
            };
            this.Controls.Add(button2);

            Button button3 = new Button();
            button3.Text = "3";
            button3.Location = new System.Drawing.Point(160, 150);
            button3.ForeColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.LightBlue;
            button3.Size = new System.Drawing.Size(70, 70);
            button3.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            button3.Click += (s, args) =>
            {
                display.Text += "3";
            };
            this.Controls.Add(button3);

            Button button4 = new Button();
            button4.Text = "4";
            button4.Location = new System.Drawing.Point(10, 235);
            button4.ForeColor = System.Drawing.Color.White;
            button4.BackColor = System.Drawing.Color.LightBlue;
            button4.Size = new System.Drawing.Size(70, 70);
            button4.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            button4.Click += (s, args) =>
            {
                display.Text += "4";
            };
            this.Controls.Add(button4);

            Button button5 = new Button();
            button5.Text = "5";
            button5.Location = new System.Drawing.Point(85, 235);
            button5.ForeColor = System.Drawing.Color.White;
            button5.BackColor = System.Drawing.Color.LightBlue;
            button5.Size = new System.Drawing.Size(70, 70);
            button5.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            button5.Click += (s, args) =>
            {
                display.Text += "5";
            };
            this.Controls.Add(button5);

            Button button6 = new Button();
            button6.Text = "6";
            button6.Location = new System.Drawing.Point(160, 235);
            button6.ForeColor = System.Drawing.Color.White;
            button6.BackColor = System.Drawing.Color.LightBlue;
            button6.Size = new System.Drawing.Size(70, 70);
            button6.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            button6.Click += (s, args) =>
            {
                display.Text += "6";
            };
            this.Controls.Add(button6);

            Button button7 = new Button();
            button7.Text = "7";
            button7.Location = new System.Drawing.Point(10, 320);
            button7.ForeColor = System.Drawing.Color.White;
            button7.BackColor = System.Drawing.Color.LightBlue;
            button7.Size = new System.Drawing.Size(70, 70);
            button7.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            button7.Click += (s, args) =>
            {
                display.Text += "7";
            };
            this.Controls.Add(button7);

            Button button8 = new Button();
            button8.Text = "8";
            button8.Location = new System.Drawing.Point(85, 320);
            button8.ForeColor = System.Drawing.Color.White;
            button8.BackColor = System.Drawing.Color.LightBlue;
            button8.Size = new System.Drawing.Size(70, 70);
            button8.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            button8.Click += (s, args) =>
            {
                display.Text += "8";
            };
            this.Controls.Add(button8);

            Button button9 = new Button();
            button9.Text = "9";
            button9.Location = new System.Drawing.Point(160, 320);
            button9.ForeColor = System.Drawing.Color.White;
            button9.BackColor = System.Drawing.Color.LightBlue;
            button9.Size = new System.Drawing.Size(70, 70);
            button9.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            button9.Click += (s, args) =>
            {
                display.Text += "9";
            };
            this.Controls.Add(button9);

            Button button0 = new Button();
            button0.Text = "0";
            button0.Location = new System.Drawing.Point(85, 405);
            button0.ForeColor = System.Drawing.Color.White;
            button0.BackColor = System.Drawing.Color.LightBlue;
            button0.Size = new System.Drawing.Size(70, 70);
            button0.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            button0.Click += (s, args) =>
            {
                display.Text += "0";
            };
            this.Controls.Add(button0);

            Button buttonFaktoriyel = new Button();
            buttonFaktoriyel.Text = "Faktöriyel";
            buttonFaktoriyel.Location = new System.Drawing.Point(10, 90);
            buttonFaktoriyel.ForeColor = System.Drawing.Color.White;
            buttonFaktoriyel.BackColor = System.Drawing.Color.LightBlue;
            buttonFaktoriyel.Size = new System.Drawing.Size(105, 50);
            buttonFaktoriyel.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            this.Controls.Add(buttonFaktoriyel);

            buttonFaktoriyel.Click += (s, args) =>
            {
                try
                {
                    int sayi = Convert.ToInt32(display.Text);
                    if (sayi < 0)
                    {
                        MessageBox.Show("Negatif sayıların faktöriyeli hesaplanamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    long faktoriyel = 1;
                    for (int i = 1; i <= sayi; i++)
                    {
                        faktoriyel *= i;
                    }
                    ozet.Add($"Faktöriyel: ({sayi}) = {faktoriyel}");

                    display.Text = faktoriyel.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Geçerli bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            Button buttonUs = new Button();
            buttonUs.Text = "Üs";
            buttonUs.Location = new System.Drawing.Point(120, 90);
            buttonUs.ForeColor = System.Drawing.Color.White;
            buttonUs.BackColor = System.Drawing.Color.LightBlue;
            buttonUs.Size = new System.Drawing.Size(110, 50);
            buttonUs.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            this.Controls.Add(buttonUs);

            buttonUs.Click += (s, args) =>
            {
                try
                {
                    string[] sayilar = display.Text.Split('.');
                    if (sayilar.Length != 2)
                    {
                        MessageBox.Show("Lütfen üs alma işlemi için 'taban.üs' formatında giriş yapınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    double taban = Convert.ToDouble(sayilar[0]);
                    double us = Convert.ToDouble(sayilar[1]);
                    double sonuc = Math.Pow(taban, us);
                    ozet.Add($"{taban}^{us} = {sonuc}");
                    display.Text = sonuc.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Geçerli bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            Button buttonAsal = new Button();
            buttonAsal.Text = "Asal";
            buttonAsal.Location = new System.Drawing.Point(235, 90);
            buttonAsal.ForeColor = System.Drawing.Color.White;
            buttonAsal.BackColor = System.Drawing.Color.LightBlue;
            buttonAsal.Size = new System.Drawing.Size(110, 50);
            buttonAsal.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            this.Controls.Add(buttonAsal);

            buttonAsal.Click += (s, args) =>
            {
                string girilensayi = display.Text;
                int kontrolsayi = Convert.ToInt32(girilensayi);

                if (kontrolsayi < 2)
                {
                    display.Text = kontrolsayi + " asal değildir";
                    ozet.Add($"{kontrolsayi} asal değildir");
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(kontrolsayi); i++)
                    {
                        if (kontrolsayi % i == 0)
                        {
                            display.Text = kontrolsayi + " asal değildir";
                            ozet.Add($"{kontrolsayi} asal değildir");
                            return;
                        }
                    }
                    display.Text = kontrolsayi + " asaldır";
                    ozet.Add($"{kontrolsayi} asaldır");
                }
            };

            Button buttonLog = new Button();
            buttonLog.Text = "Log";
            buttonLog.Location = new System.Drawing.Point(350, 90);
            buttonLog.ForeColor = System.Drawing.Color.White;
            buttonLog.BackColor = System.Drawing.Color.LightBlue;
            buttonLog.Size = new System.Drawing.Size(110, 50);
            buttonLog.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            this.Controls.Add(buttonLog);

            buttonLog.Click += (s, args) =>
            {
                try
                {
                    string[] girdiler = display.Text.Split('.');
                    if (girdiler.Length != 2)
                    {
                        MessageBox.Show("Lütfen 'taban.sayi' formatında giriş yapınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    double taban = Convert.ToDouble(girdiler[0]);
                    double sayi = Convert.ToDouble(girdiler[1]);

                    if (taban <= 0 || taban == 1)
                    {
                        MessageBox.Show("Logaritma tabanı 0'dan büyük ve 1'den farklı olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (sayi <= 0)
                    {
                        MessageBox.Show("Logaritması alınacak sayı pozitif olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    double logSonuc = Math.Log(sayi) / Math.Log(taban);
                    ozet.Add($"Log{taban}({sayi}) = {logSonuc}");
                    display.Text = logSonuc.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Geçerli bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            Button buttonKok = new Button();
            buttonKok.Text = "√";
            buttonKok.Location = new System.Drawing.Point(465, 90);
            buttonKok.ForeColor = System.Drawing.Color.White;
            buttonKok.BackColor = System.Drawing.Color.LightBlue;
            buttonKok.Size = new System.Drawing.Size(110, 50);
            buttonKok.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            this.Controls.Add(buttonKok);

            buttonKok.Click += (s, args) =>
            {
                try
                {
                    double sayi = Convert.ToDouble(display.Text);

                    if (sayi < 0)
                    {
                        MessageBox.Show("Negatif sayıların karekökü alınamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    double sonuc = Math.Sqrt(sayi);
                    ozet.Add($"√({sayi}) = {sonuc}");
                    display.Text = sonuc.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Geçerli bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            Button buttonNokta = new Button();
            buttonNokta.Text = ".";
            buttonNokta.Location = new System.Drawing.Point(10, 405);
            buttonNokta.ForeColor = System.Drawing.Color.White;
            buttonNokta.BackColor = System.Drawing.Color.LightBlue;
            buttonNokta.Size = new System.Drawing.Size(70, 70);
            buttonNokta.Font = new Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold);
            buttonNokta.Click += (s, args) =>
            {
                display.Text += ".";
            };
            this.Controls.Add(buttonNokta);

            Button buttonArti = new Button();
            buttonArti.Text = "+";
            buttonArti.Location = new System.Drawing.Point(285, 220);
            buttonArti.ForeColor = System.Drawing.Color.White;
            buttonArti.BackColor = System.Drawing.Color.LightBlue;
            buttonArti.Size = new System.Drawing.Size(100, 70);
            buttonArti.Font = new Font("Microsoft Sans Serif", 16, System.Drawing.FontStyle.Bold);
            this.Controls.Add(buttonArti);

            buttonArti.Click += (s, args) =>
            {
                ilkSayi = Convert.ToDouble(display.Text);
                islem = "+";
                display.Text = "";
            };

            Button buttonCikarma = new Button();
            buttonCikarma.Text = "-";
            buttonCikarma.Location = new System.Drawing.Point(400, 220);
            buttonCikarma.ForeColor = System.Drawing.Color.White;
            buttonCikarma.BackColor = System.Drawing.Color.LightBlue;
            buttonCikarma.Size = new System.Drawing.Size(100, 70);
            buttonCikarma.Font = new Font("Microsoft Sans Serif", 16, System.Drawing.FontStyle.Bold);
            this.Controls.Add(buttonCikarma);

            buttonCikarma.Click += (s, args) =>
            {
                ilkSayi = Convert.ToDouble(display.Text);
                islem = "-";
                display.Text = "";
            };

            Button buttonCarpim = new Button();
            buttonCarpim.Text = "*";
            buttonCarpim.Location = new System.Drawing.Point(285, 325);
            buttonCarpim.ForeColor = System.Drawing.Color.White;
            buttonCarpim.BackColor = System.Drawing.Color.LightBlue;
            buttonCarpim.Size = new System.Drawing.Size(100, 70);
            buttonCarpim.Font = new Font("Microsoft Sans Serif", 16, System.Drawing.FontStyle.Bold);
            this.Controls.Add(buttonCarpim);

            buttonCarpim.Click += (s, args) =>
            {
                ilkSayi = Convert.ToDouble(display.Text);
                islem = "*";
                display.Text = "";
            };

            Button buttonBolum = new Button();
            buttonBolum.Text = "/";
            buttonBolum.Location = new System.Drawing.Point(400, 325);
            buttonBolum.ForeColor = System.Drawing.Color.White;
            buttonBolum.BackColor = System.Drawing.Color.LightBlue;
            buttonBolum.Size = new System.Drawing.Size(100, 70);
            buttonBolum.Font = new Font("Microsoft Sans Serif", 16, System.Drawing.FontStyle.Bold);
            this.Controls.Add(buttonBolum);

            buttonBolum.Click += (s, args) =>
            {
                ilkSayi = Convert.ToDouble(display.Text);
                islem = "/";
                display.Text = "";
            };

            Button buttonOzet = new Button();
            buttonOzet.Text = "Özet";
            buttonOzet.Location = new System.Drawing.Point(580, 90);
            buttonOzet.ForeColor = System.Drawing.Color.White;
            buttonOzet.BackColor = System.Drawing.Color.LightBlue;
            buttonOzet.Size = new System.Drawing.Size(110, 50);
            buttonOzet.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            this.Controls.Add(buttonOzet);

            buttonOzet.Click += (butonSender, olayE) =>
            {
                if (ozet.Count == 0)
                {
                    MessageBox.Show("Henüz bir işlem yapılmadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string ozetMetni = string.Join("\n", ozet);
                MessageBox.Show("Yapılan İşlemler:\n" + ozetMetni, "İşlem Özeti");
            };

            Button buttonEsittir = new Button();
            buttonEsittir.Text = "=";
            buttonEsittir.Location = new System.Drawing.Point(160, 405);
            buttonEsittir.ForeColor = System.Drawing.Color.White;
            buttonEsittir.BackColor = System.Drawing.Color.LightBlue;
            buttonEsittir.Size = new System.Drawing.Size(70, 70);
            buttonEsittir.Font = new Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold);
            this.Controls.Add(buttonEsittir);

            buttonEsittir.Click += (s, args) =>
            {
                double ikinciSayi = Convert.ToDouble(display.Text);
                double sonuc = 0;

                switch (islem)
                {
                    case "+":
                        sonuc = ilkSayi + ikinciSayi;
                        ozet.Add($"{ilkSayi} + {ikinciSayi} = {sonuc}");
                        break;
                    case "-":
                        sonuc = ilkSayi - ikinciSayi;
                        ozet.Add($"{ilkSayi} - {ikinciSayi} = {sonuc}");
                        break;
                    case "*":
                        sonuc = ilkSayi * ikinciSayi;
                        ozet.Add($"{ilkSayi} * {ikinciSayi} = {sonuc}");
                        break;
                    case "/":
                        sonuc = ilkSayi / ikinciSayi;
                        ozet.Add($"{ilkSayi} / {ikinciSayi} = {sonuc}");
                        break;
                }
                display.Text = sonuc.ToString();
            };

            Button buttonTemizle = new Button();
            buttonTemizle.Text = "TEMİZLE";
            buttonTemizle.Location = new System.Drawing.Point(525, 150);
            buttonTemizle.ForeColor = System.Drawing.Color.White;
            buttonTemizle.BackColor = System.Drawing.Color.LightBlue;
            buttonTemizle.Size = new System.Drawing.Size(165, 327);
            buttonTemizle.Font = new Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold);
            this.Controls.Add(buttonTemizle);

            buttonTemizle.Click += (s, args) =>
            {
                display.Text = "";
                ilkSayi = 0;
                islem = "";
            };
        }

        // Aşağıdaki metodlar fotoğrafların sonunda yer alan ve muhtemelen 
        // daha önce yazdığın ancak Form1_Load içerisinde kullanmadığın metodlar.
        // Kodun hata vermemesi için bunları da ekledim.
        private Label sonucEkrani;

        private void BilesenleriOlustur()
        {
        }

        private void ButonEkle(string metin, int x, int y, EventHandler tiklamaIsleyici = null)
        {
            Button buton = new Button();
            buton.Text = metin;
            buton.Location = new Point(x, y);
            buton.Size = new Size(100, 100);
            buton.Click += tiklamaIsleyici ?? new EventHandler(ButonTikla);
            this.Controls.Add(buton);
        }

        private void ButonTikla(object sender, EventArgs e)
        {
            Button tiklananButon = sender as Button;
            sonucEkrani.Text += tiklananButon.Text;
        }

        private void SonucButonu_Click(object sender, EventArgs e)
        {
            sonucEkrani.Text = "Sonuç Hesaplandı";
        }

        private void TemizleButonu_Click(object sender, EventArgs e)
        {
            sonucEkrani.Text = string.Empty;
        }

        private double FaktoriyelHesapla(int sayi)
        {
            if (sayi == 0 || sayi == 1)
                return 1;

            double faktoriyel = 1;
            for (int i = 2; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            return faktoriyel;
        }

        private double EvaluateExpression(string expression)
        {
            DataTable dt = new DataTable();
            var sonuc = dt.Compute(expression, null);
            return Convert.ToDouble(sonuc);
        }
    }
}