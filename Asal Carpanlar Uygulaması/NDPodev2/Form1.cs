/********************************************************************************************************************************************************
**                                                                                                                                                     **
**                                                                                                                                                     **
**                                                                          SAKARYA ÜNİVERSİTESİ                                                       **                                                      
**                                                                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                                            ** 
**                                                                      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                                                 ** 
**                                                                     NESNEYE DAYALI PROGRAMLAMA DERSİ                                                **
**                                                                          2019-2020 BAHAR DÖNEMİ                                                     **
**                                                                                                                                                     ** 
**                                                                ÖDEV NUMARASI...........:2                                                           ** 
**                                                                ÖĞRENCİ ADI.............:SEVDET IŞIK                                                 **                 
**                                                                ÖĞRENCİ NUMARASI........:G191210082                                                  **
**                                                                DERSİN ALINDIĞI GRUP....:2.ÖĞRETİM B GRUBU                                           **
**                                                                                                                                                     **
**                                                                                                                                                     **   
**                                                                                                                                                     **
********************************************************************************************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPodev2
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

        //Textbox'a girilen girdinin sayi olup olmadığını kontrol edecek olan method.
        static bool digitControl(string giris)
        {
            bool donus = true;
            //Girilen girdinin her bir karakteri tek tek kontrol ediliyor.
            for(int i = 0; i < giris.Length; i++)
            {
                //Eğer girilen girdinin ilgili karakteri sayı değilse donus değişkeni false olarak atanıyor.
                if (!char.IsDigit(giris[i]))
                {
                    donus = false;
                }
            }
            return donus;
        }
       
                   
        private void lblY_Click(object sender, EventArgs e)
        {

        }

        
        //Son butonuna tıklanınca form uygulaması kapatılıyor.
        private void btnSon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int btnSayac = 0;

        //Arkadas mı butonunun yaptığı kontroller.
        private void btnArk_Click(object sender, EventArgs e)
        { 
            //Eğer methodun dışında tanımlanan btnSayac değeri 0'sa kontrole giriliyor.      
            if (btnSayac == 0)
            {   
                //Sayı değeri girilene kadar kullanıcıdan girdi alınıyor.
                while (true)
                {
                    int x;
                    int y;
                    //Eğer girilen girdiler sayıysa ilgili değişkenlere atanıyor.
                    if (digitControl(txtX.Text) && digitControl(txtY.Text))
                    {
                         x = Convert.ToInt32(txtX.Text);
                         y = Convert.ToInt32(txtY.Text);
                    }
                    //Eğer girilen girdilerden herhangi biri sayı değilse tekrar girilmesine dair mesaj gösteriliyor.
                    else
                    {
                        MessageBox.Show("Lütfen boşluğa sayı giriniz.");
                        break;
                    }
                    
                    
                    int xToplam = 0;
                    int yToplam = 0;
                    int[] xCarpan = new int[100];
                    int[] yCarpan = new int[100];
                    int xSayac = 0;
                    int ySayac = 0;

                    //Girilen değerlerden x'in çarpanları bulunuyor.
                    for (int i = 1; i < x; i++)
                    {
                        //eğer sayı x'in çarpanıysa ilgili diziye eklenip,toplam değere ekleniyor.
                        if (x % i == 0)
                        {
                            xCarpan[xSayac] = i;
                            xSayac++;
                            xToplam += i;

                        }
                    }

                    //Girilen değerlerden y'nin çarpanları bulunuyor.
                    for (int i = 1; i < y; i++)
                    {
                        //eğer sayı y'nin çarpanıysa ilgili diziye eklenip,toplam değere ekleniyor.
                        if (y % i == 0)
                        {
                            yCarpan[ySayac] = i;
                            ySayac++;
                            yToplam += i;
                        }
                    }
                    this.Size = new Size(800, 450);

                    Label lblYeniX = new Label();
                    lblYeniX.BackColor = System.Drawing.Color.LightSlateGray;
                    lblYeniX.Size = new Size(14, 13);
                    lblYeniX.Location = new Point(400, 30);
                    lblYeniX.Text = "X";
                    Controls.Add(lblYeniX);

                    ListBox lbX = new ListBox();
                    lbX.Size = new Size(100, 300);

                    lbX.Location = new Point(355, 50);

                    //x'in çarpanları ilgili listboxa değer olarak ekleniyor.
                    for (int i = 0; i < xSayac; i++)
                    {
                        lbX.Items.Add(xCarpan[i]);
                    }

                    Controls.Add(lbX);

                    Label lblYeniY = new Label();
                    lblYeniY.Size = new Size(14, 13);
                    lblYeniY.BackColor = System.Drawing.Color.LightSlateGray;
                    lblYeniY.Location = new Point(600, 30);
                    lblYeniY.Text = "Y";
                    Controls.Add(lblYeniY);

                    ListBox lbY = new ListBox();
                    lbY.Size = new Size(100, 300);
                    lbY.Location = new Point(555, 50);
                    //y'nin çarpanları ilgili listboxa değer olarak ekleniyor.
                    for (int i = 0; i < ySayac; i++)
                    {
                        lbY.Items.Add(yCarpan[i]);
                    }
                    Controls.Add(lbY);

                    Label lblYeniToplam = new Label();
                    lblYeniToplam.Text = "TOPLAMLAR";
                    lblYeniToplam.Location = new Point(250, 350);
                    lblYeniToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lblYeniToplam.Size = new Size(80, 15);

                    lblYeniToplam.BackColor = System.Drawing.Color.LightSlateGray;
                    Controls.Add(lblYeniToplam);

                    TextBox txtXToplam = new TextBox();
                    TextBox txtYToplam = new TextBox();

                    txtXToplam.Location = new Point(355, 347);
                    txtXToplam.Text = Convert.ToString(xToplam);
                    txtXToplam.BackColor = System.Drawing.Color.LightSlateGray;
                    txtXToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    txtXToplam.TextAlign = HorizontalAlignment.Center;

                    Controls.Add(txtXToplam);

                    txtYToplam.Location = new Point(555, 347);
                    txtYToplam.Text = Convert.ToString(yToplam);
                    txtYToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    txtYToplam.BackColor = System.Drawing.Color.LightSlateGray;
                    txtYToplam.TextAlign = HorizontalAlignment.Center;
                    Controls.Add(txtYToplam);
                    break;
                }                                                                                        
            }      
            
            //Eğer btnSayac değeri 0'dan farklıysa aşağıdaki işlemler uygulanıyor.
            else
            {   
                //Kullanıcı sayı girene kadar girdi girilmesi isteniyor.
                while (true)
                {
                    //Uygulamanın birden fazla kez çalıştırılabilir olması için form ekranı temizleniyor ve kontrol elemanları tekrar ekleniyor.
                    this.Controls.Clear();
                    this.Controls.Add(txtX);
                    this.Controls.Add(txtY);
                    this.Controls.Add(lblX);
                    this.Controls.Add(lblY);
                    this.Controls.Add(btnArk);
                    this.Controls.Add(btnSon);
                    int x;
                    int y;
                    //Eğer girilen girdiler sayıysa ilgili değişkenlere atanıyor.
                    if (digitControl(txtX.Text) && digitControl(txtY.Text))
                    {
                        x = Convert.ToInt32(txtX.Text);
                        y = Convert.ToInt32(txtY.Text);
                    }
                    //Eğer girdilerden herhangi biri sayı değilse tekrar girilmesine dair mesaj gösteriliyor.
                    else
                    {
                        MessageBox.Show("Lütfen boşluğa sayı giriniz.");
                        break;
                    }


                    int xToplam = 0;
                    int yToplam = 0;
                    int[] xCarpan = new int[100];
                    int[] yCarpan = new int[100];
                    int xSayac = 0;
                    int ySayac = 0;

                    //Tekrar girilen x değerinin çarpanları bulunuyor.
                    for (int i = 1; i < x; i++)
                    {
                        //Eğer sayı x'in çarpanıysa diziye eklenip,toplam değere ekleniyor.
                        if (x % i == 0)
                        {
                            xCarpan[xSayac] = i;
                            xSayac++;
                            xToplam += i;

                        }
                    }

                    //Tekrar girilen y değerinin çarpanları bulunuyor.
                    for (int i = 1; i < y; i++)
                    {
                        //Eğer sayı y'nin çarpanıysa diziye eklenip,toplam değere ekleniyor.
                        if (y % i == 0)
                        {
                            yCarpan[ySayac] = i;
                            ySayac++;
                            yToplam += i;
                        }
                    }
                    this.Size = new Size(800, 450);

                    Label lblYeniX = new Label();
                    lblYeniX.BackColor = System.Drawing.Color.LightSlateGray;
                    lblYeniX.Size = new Size(14, 13);
                    lblYeniX.Location = new Point(400, 30);
                    lblYeniX.Text = "X";
                    Controls.Add(lblYeniX);

                    ListBox lbX = new ListBox();
                    lbX.Size = new Size(100, 300);

                    lbX.Location = new Point(355, 50);
                    //Yeni girilen x'in çarpanları ilgili listboxa değer olarak ekleniyor.
                    for (int i = 0; i < xSayac; i++)
                    {
                        lbX.Items.Add(xCarpan[i]);
                    }

                    Controls.Add(lbX);

                    Label lblYeniY = new Label();
                    lblYeniY.Size = new Size(14, 13);
                    lblYeniY.BackColor = System.Drawing.Color.LightSlateGray;
                    lblYeniY.Location = new Point(600, 30);
                    lblYeniY.Text = "Y";
                    Controls.Add(lblYeniY);

                    ListBox lbY = new ListBox();
                    lbY.Size = new Size(100, 300);
                    lbY.Location = new Point(555, 50);
                    //Yeni girilen y'nin çarpanları ilgili listboxa değer olarak ekleniyor.
                    for (int i = 0; i < ySayac; i++)
                    {
                        lbY.Items.Add(yCarpan[i]);
                    }
                    Controls.Add(lbY);

                    Label lblYeniToplam = new Label();
                    lblYeniToplam.Text = "TOPLAMLAR";
                    lblYeniToplam.Location = new Point(250, 350);
                    lblYeniToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lblYeniToplam.Size = new Size(80, 15);

                    lblYeniToplam.BackColor = System.Drawing.Color.LightSlateGray;
                    Controls.Add(lblYeniToplam);

                    TextBox txtXToplam = new TextBox();
                    TextBox txtYToplam = new TextBox();

                    txtXToplam.Location = new Point(355, 347);
                    txtXToplam.Text = Convert.ToString(xToplam);
                    txtXToplam.BackColor = System.Drawing.Color.LightSlateGray;
                    txtXToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    txtXToplam.TextAlign = HorizontalAlignment.Center;

                    Controls.Add(txtXToplam);

                    txtYToplam.Location = new Point(555, 347);
                    txtYToplam.Text = Convert.ToString(yToplam);
                    txtYToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    txtYToplam.BackColor = System.Drawing.Color.LightSlateGray;
                    txtYToplam.TextAlign = HorizontalAlignment.Center;
                    Controls.Add(txtYToplam);
                    break;
                }

            }

            btnSayac++;                   
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {

        }
    }
}
