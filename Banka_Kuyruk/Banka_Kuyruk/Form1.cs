using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Kuyruk
{
    public partial class Form1 : Form
    {
        public int[] sayilar;
        Random rndm2 = new Random();
       public float toplam2 = 0;
        

    public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayilar = new int[20];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rndm2.Next(60, 601);
                toplam2 += sayilar[i];
            }
        }

        private void btnDairesel_Click(object sender, EventArgs e)
        {
            lblDaireselBaslık.Visible = true;
            lstBoxDaireselSure.Items.Clear();
           
            float toplam = 0;
            
            DaireselKuyruk dk = new DaireselKuyruk(20);
            Random rndm = new Random();
            

            for (int i = 0; i < 20; i++)
            {
                 sayilar[i] = rndm.Next(60, 601);
                toplam +=Convert.ToInt32( sayilar[i]);
             
                dk.Insert(new Musteri { MusteriNo = (1000+(i+1)),IslemSuresi=Convert.ToInt32(toplam) });
  
            }
            for (int i = 0; i < 20; i++)
            {
              
                lstBoxDaireselSure.Items.Add(((Musteri)dk.Peek()).MusteriNo + " ---> " + ((Musteri)dk.Remove()).IslemSuresi + "  sn");


            }


            decimal tplm =Convert.ToDecimal((toplam / 20));
            lblOrtSonuc.Text = tplm.ToString() + "  sn";

        }

        private void btnOncelik_Click(object sender, EventArgs e)
        {
            lblBaslık.Visible = true;
            float top = 0;
            LstBoxSure.Items.Clear();

            Oncelik_Kuyruk ok = new Oncelik_Kuyruk(20);
            Oncelik_Kuyruk2 okyruk = new Oncelik_Kuyruk2(20);

            for (int i = 0; i < sayilar.Length; i++)
            {
               
                ok.Insert(new Musteri { MusteriNo = (1000 + (i + 1)), IslemSuresi = sayilar[i]});
                okyruk.Insert(new Musteri { MusteriNo = (1000 + (i + 1)), IslemSuresi = sayilar[i] });


            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                for (int j = i+1; j <sayilar.Length ; j++)
                {
                    if(sayilar[i]>sayilar[j])
                    {
                        int gecici = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = gecici;
                    }
                     
                }
                top += sayilar[i];
               
                LstBoxSure.Items.Add(((Musteri)ok.Peek()).MusteriNo + "    ---  " + top + "   ---" + "  sn" +"   ---  "+ ((Musteri)ok.Remove()).IslemSuresi + "  sn");

            }


            decimal tplm = Convert.ToDecimal((top / 20));
            (lblOrtSonuc.Text) = tplm.ToString()+"  sn";


            lblBuyükten.Visible = true;
            float top2 = 0;
            lstBoxSure2.Items.Clear();
            

           

            for (int i = 0; i < sayilar.Length; i++)
            {
                for (int j = i + 1; j < sayilar.Length; j++)
                {
                    if (sayilar[i] > sayilar[j])
                    {
                        int gecici = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = gecici;
                    }

                }
                top2 += sayilar[i];


            }
            float temp = top2;
            for (int i = 0; i < sayilar.Length; i++)
            {
                for (int t = 0; t < sayilar.Length; t++)
                {
                    if (sayilar[t] < sayilar[i])
                    {

                        int gecici = sayilar[i];

                        sayilar[i] = sayilar[t];

                        sayilar[t] = gecici;

                    }
                }
                lstBoxSure2.Items.Add(((Musteri)okyruk.Peek()).MusteriNo + "    ---  " + temp + "   ---" + "  sn" + "   ---  " + ((Musteri)okyruk.Remove()).IslemSuresi + "  sn");
                temp -= sayilar[i];
            }

            decimal tplm2 = Convert.ToDecimal((top2 / 20));
            (lblOrtSonuc.Text) = tplm2.ToString() + "  sn";




        }

       

        private void btnKazanc_Click(object sender, EventArgs e)
        {
            lblKazanc.Visible = true;
        }
    }
}
