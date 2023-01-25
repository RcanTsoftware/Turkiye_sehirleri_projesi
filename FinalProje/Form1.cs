using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using LiveCharts.WinForms;
using System.Windows.Media;

namespace FinalProje
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        // GENEL RENKLENDİRME KOLEKSİYONU OLUŞTURULDU.
        public GradientStopCollection collection = new GradientStopCollection();
        



        //LiveCharts nesnesi oluşturma.
        public LiveCharts.WinForms.GeoMap geo = new LiveCharts.WinForms.GeoMap();

        // ADANA LİVECHARTS NESNESİ OLUŞTURULDU.
        public LiveCharts.WinForms.GeoMap geo01 = new LiveCharts.WinForms.GeoMap();
        
        // ADIYAMAN LİVECHARTS NESNESİ OLUŞTURULDU.
        public LiveCharts.WinForms.GeoMap geo02 = new LiveCharts.WinForms.GeoMap();

        // AFYONKARAHİSAR LİVECHARTS NESNESİ OLUŞTURULDU.
        public LiveCharts.WinForms.GeoMap geo03 = new LiveCharts.WinForms.GeoMap();

        // AĞRI LİVECHARTS NESNESİ OLUŞTURULDU.
        public LiveCharts.WinForms.GeoMap geo04 = new LiveCharts.WinForms.GeoMap();

        // AMASYA LİVECHARTS NESNESİ OLUŞTURULDU.
        public LiveCharts.WinForms.GeoMap geo05 = new LiveCharts.WinForms.GeoMap();

        // ANKARA LİVECHARTS NESNESİ OLUŞTURULDU.
        public LiveCharts.WinForms.GeoMap geo06 = new LiveCharts.WinForms.GeoMap();










        // AKSARAY LİVECHARTS NESNESİ OLUŞTURULDU.
        public LiveCharts.WinForms.GeoMap geo68 = new LiveCharts.WinForms.GeoMap();

        




        // GENEL SÖZLÜK ATANDI.
        public Dictionary<string, double> d = new Dictionary<string, double>();
       
        
        // İL VE İLÇE KONTROLÜ İÇİN ATAMA YAPILDI.
        public int sayac;

        // RENKLENDİRME KONTROLÜ İÇİN ATAMA YAPILDI.
        public int sayac2;
        public int sayac3;
        public int sayac4;
        public int sayac5;
        public int sayac6;
        public int sayac7;
        public int sayac8;
        public int sayac9;
        public int sayac10;

        // DOLGUN RGB DEĞERLERİ ATANDI.
        byte r3;
        byte g3;
        byte b3;

        // ORTA RGB DEĞERLERİ ATANDI.
        byte r2;
        byte g2;
        byte b2;

        // SOLGUN RGB DEĞERLERİ ATANDI.
        byte r;
        byte g;
        byte b;

        // FORM LOAD DURUMUNDA VE GERİ BUTONUNDA ÇALIŞMASI GEREKEN KOMUTLAR EKLENDİ.
        public void Baslangic()
        {
            labelR.Visible = false;
            labelR2.Visible = false;
            labelR3.Visible = false;
            labelG.Visible = false;
            labelG2.Visible = false;
            labelG3.Visible = false;
            labelB.Visible = false;
            labelB2.Visible = false;
            labelB3.Visible = false;
            labelS.Visible = false;
            labelO.Visible = false;
            labelD.Visible = false;
            textBoxR.Visible = false;
            textBoxR2.Visible = false;
            textBoxR3.Visible = false;
            textBoxG.Visible = false;
            textBoxG2.Visible = false;
            textBoxG3.Visible = false;
            textBoxB.Visible = false;
            textBoxB2.Visible = false;
            textBoxB3.Visible = false;
            buttonRenk.Visible = false;
            button2.Visible = true;
            button1.Visible = true;
            buttonRP.Visible = false;
            label2.Visible = false;
            geo.Visible = true;
            geo01.Visible = false;
            geo02.Visible = false;
            geo03.Visible = false;
            geo04.Visible = false;
            geo05.Visible = false;
            geo06.Visible = false;

            geo68.Visible = false;
            linkLabelSHR.Visible = false;
            buttonNS.Visible = false;
            


            label1.Text = "TÜRKİYE HARİTASI";

            geo.Hoverable = true;
            // dosya yolu gösterildi ve bu forma eklenildi.
            geo.Source = "Turkiye.xml";
            this.Controls.Add(geo);
            geo.Dock = DockStyle.Fill;
            //Click eventi oluşturma
            geo.LandClick += GeoMap_TRClick;
        }

        // PLAKAYA GÖRE RENKLENDİRME İŞLEMİ YAPILDI.
        public void Plaka_Siralama()
        {
            
            d["01"] = 81;
            d["02"] = 80;
            d["03"] = 79;
            d["04"] = 78;
            d["05"] = 77;
            d["06"] = 76;
            d["07"] = 75;
            d["08"] = 74;
            d["09"] = 73;
            d["10"] = 72;
            d["11"] = 71;
            d["12"] = 70;
            d["13"] = 69;
            d["14"] = 68;
            d["15"] = 67;
            d["16"] = 66;
            d["17"] = 65;
            d["18"] = 64;
            d["19"] = 63;
            d["20"] = 62;
            d["21"] = 61;
            d["22"] = 60;
            d["23"] = 59;
            d["24"] = 58;
            d["25"] = 57;
            d["26"] = 56;
            d["27"] = 55;
            d["28"] = 54;
            d["29"] = 53;
            d["30"] = 52;
            d["31"] = 51;
            d["32"] = 50;
            d["33"] = 49;
            d["34"] = 48;
            d["35"] = 47;
            d["36"] = 46;
            d["37"] = 45;
            d["38"] = 44;
            d["39"] = 43;
            d["40"] = 42;
            d["41"] = 41;
            d["42"] = 40;
            d["43"] = 39;
            d["44"] = 38;
            d["45"] = 37;
            d["46"] = 36;
            d["47"] = 35;
            d["48"] = 34;
            d["49"] = 33;
            d["50"] = 32;
            d["51"] = 31;
            d["52"] = 30;
            d["53"] = 29;
            d["54"] = 28;
            d["55"] = 27;
            d["56"] = 26;
            d["57"] = 25;
            d["58"] = 24;
            d["59"] = 23;
            d["60"] = 22;
            d["61"] = 21;
            d["62"] = 20;
            d["63"] = 19;
            d["64"] = 18;
            d["65"] = 17;
            d["66"] = 16;
            d["67"] = 15;
            d["68"] = 14;
            d["69"] = 13;
            d["70"] = 12;
            d["71"] = 11;
            d["72"] = 10;
            d["73"] = 9;
            d["74"] = 8;
            d["75"] = 7;
            d["76"] = 6;
            d["77"] = 5;
            d["78"] = 4;
            d["79"] = 3;
            d["80"] = 2;
            d["81"] = 1;
            

            GradientStopCollection collection = new GradientStopCollection();
            collection.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, 86, 255, 255), Offset = 0 });
            collection.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, 0, 127, 255), Offset = 0.5 });
            collection.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, 0, 0, 191), Offset = 1 });
            geo.GradientStopCollection = collection;

            geo.HeatMap = d;

        }

        // NÜFUSA GÖRE RENKLENDİRME İŞLEMİ YAPILDI.
        public void Nüfus_Siralama()
        {
            Dictionary<string, double> d = new Dictionary<string, double>();
            d["01"] = 75;
            d["02"] = 49;
            d["03"] = 51;
            d["04"] = 39;
            d["05"] = 25;
            d["06"] = 80;
            d["07"] = 77;
            d["08"] = 6;
            d["09"] = 62;
            d["10"] = 65;
            d["11"] = 11;
            d["12"] = 20;
            d["13"] = 27;
            d["14"] = 23;
            d["15"] = 16;
            d["16"] = 78;
            d["17"] = 43;
            d["18"] = 7;
            d["19"] = 40;
            d["20"] = 59;
            d["21"] = 70;
            d["22"] = 34;
            d["23"] = 45;
            d["24"] = 12;
            d["25"] = 52;
            d["26"] = 57;
            d["27"] = 73;
            d["28"] = 38;
            d["29"] = 5;
            d["30"] = 18;
            d["31"] = 69;
            d["32"] = 37;
            d["33"] = 71;
            d["34"] = 81;
            d["35"] = 79;
            d["36"] = 19;
            d["37"] = 31;
            d["38"] = 67;
            d["39"] = 29;
            d["40"] = 13;
            d["41"] = 72;
            d["42"] = 76;
            d["43"] = 44;
            d["44"] = 54;
            d["45"] = 68;
            d["46"] = 64;
            d["47"] = 56;
            d["48"] = 58;
            d["49"] = 33;
            d["50"] = 22;
            d["51"] = 28;
            d["52"] = 53;
            d["53"] = 26;
            d["54"] = 60;
            d["55"] = 66;
            d["56"] = 24;
            d["57"] = 10;
            d["58"] = 50;
            d["59"] = 61;
            d["60"] = 47;
            d["61"] = 55;
            d["62"] = 1;
            d["63"] = 74;
            d["64"] = 30;
            d["65"] = 63;
            d["66"] = 35;
            d["67"] = 46;
            d["68"] = 36;
            d["69"] = 2;
            d["70"] = 15;
            d["71"] = 17;
            d["72"] = 48;
            d["73"] = 41;
            d["74"] = 8;
            d["75"] = 3;
            d["76"] = 9;
            d["77"] = 21;
            d["78"] = 14;
            d["79"] = 4;
            d["80"] = 42;
            d["81"] = 32;



            GradientStopCollection collection = new GradientStopCollection();
            collection.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, 153, 255, 153), Offset = 0 });
            collection.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, 0, 255, 0), Offset = 0.5 });
            collection.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, 0, 102, 0), Offset = 1 });

            geo.GradientStopCollection = collection;
            
            geo.HeatMap = d;
        }

        // TOOLLAR AKTİFLEŞTİRİRDİ.
        public void Tool_Aktif()
        {
            labelS.Visible = true;
            labelO.Visible = true;
            labelD.Visible = true;
            labelR.Visible = true;
            labelR2.Visible = true;
            labelR3.Visible = true;
            labelG.Visible = true;
            labelG2.Visible = true;
            labelG3.Visible = true;
            labelB.Visible = true;
            labelB2.Visible = true;
            labelB3.Visible = true;
            label2.Visible = true;
            textBoxR.Visible = true;
            textBoxR2.Visible = true;
            textBoxR3.Visible = true;
            textBoxG.Visible = true;
            textBoxG2.Visible = true;
            textBoxG3.Visible = true;
            textBoxB.Visible = true;
            textBoxB2.Visible = true;
            textBoxB3.Visible = true;
            buttonRenk.Visible = true;
            

        }

        // TOOLLAR PASİFLEŞTİRİLDİ.
        public void Tool_Daktif()
        {
            labelS.Visible = false;
            labelO.Visible = false;
            labelD.Visible = false;
            labelR.Visible = false;
            labelR2.Visible = false;
            labelR3.Visible = false;
            labelG.Visible = false;
            labelG2.Visible = false;
            labelG3.Visible = false;
            labelB.Visible = false;
            labelB2.Visible = false;
            labelB3.Visible = false;
            label2.Visible = false;
            textBoxR.Visible = false;
            textBoxR2.Visible = false;
            textBoxR3.Visible = false;
            textBoxG.Visible = false;
            textBoxG2.Visible = false;
            textBoxG3.Visible = false;
            textBoxB.Visible = false;
            textBoxB2.Visible = false;
            textBoxB3.Visible = false;
            buttonRenk.Visible = false;
           

        }

        // HARİTA RENKLENDİRME DEĞERLERİNİN ALINMA İŞLENMİ YAPILDI
        public void Renk_Al()
        {
            if (textBoxR3.Text.Length > 0)
            {
                if (Convert.ToInt32(textBoxR3.Text) <= 255)
                {
                    r3 = Convert.ToByte(textBoxR3.Text);
                    sayac2 = 001;
                }
                else
                {
                    MessageBox.Show("LÜTFEN 255 VEYA DAHA KÜÇÜK BİR DOLGUN R DEĞERİ GİRİNİZ ! ! !");
                }
            }
                        
            if (textBoxG3.Text.Length > 0)
            {
                if (Convert.ToInt32(textBoxG3.Text) <= 255)
                {
                    g3 = Convert.ToByte(textBoxG3.Text);
                    sayac3 = 002;
                }
                else
                {
                    MessageBox.Show("LÜTFEN 255 VEYA DAHA KÜÇÜK BİR DOLGUN G DEĞERİ GİRİNİZ ! ! !");
                }
            }
            

            if (textBoxB3.Text.Length > 0)
            {
                if (Convert.ToInt32(textBoxB3.Text) <= 255)
                {
                    b3 = Convert.ToByte(textBoxB3.Text);
                    sayac4 = 003;
                }
                else
                {
                    MessageBox.Show("LÜTFEN 255 VEYA DAHA KÜÇÜK BİR DOLGUN B DEĞERİ GİRİNİZ ! ! !");
                }
            }
            

            if (textBoxR2.Text.Length > 0)
            {
                if (Convert.ToInt32(textBoxR2.Text) <= 255)
                {
                    r2 = Convert.ToByte(textBoxR2.Text);
                    sayac5 = 004;
                }
                else
                {
                    MessageBox.Show("LÜTFEN 255 VEYA DAHA KÜÇÜK BİR ORTA R DEĞERİ GİRİNİZ ! ! !");
                }
            }
           

            if (textBoxG2.Text.Length > 0)
            {
                if (Convert.ToInt32(textBoxG2.Text) <= 255)
                {
                    g2 = Convert.ToByte(textBoxG2.Text);
                    sayac6 = 005;
                }
                else
                {
                    MessageBox.Show("LÜTFEN 255 VEYA DAHA KÜÇÜK BİR ORTA G DEĞERİ GİRİNİZ ! ! !");
                }
            }
           

            if (textBoxB2.Text.Length > 0)
            {
                if (Convert.ToInt32(textBoxB2.Text) <= 255)
                {
                    b2 = Convert.ToByte(textBoxB2.Text);
                    sayac7 = 006;
                }
                else
                {
                    MessageBox.Show("LÜTFEN 255 VEYA DAHA KÜÇÜK BİR ORTA B DEĞERİ GİRİNİZ ! ! !");
                }
            }

            if (textBoxR.Text.Length > 0)
            {
                if (Convert.ToInt32(textBoxR.Text) <= 255)
                {
                    r = Convert.ToByte(textBoxR.Text);
                    sayac8 = 007;
                }
                else
                {
                    MessageBox.Show("LÜTFEN 255 VEYA DAHA KÜÇÜK BİR SOLGUN R DEĞERİ GİRİNİZ ! ! !");
                }

            }
            if (textBoxG.Text.Length > 0)
            {
                if (Convert.ToInt32(textBoxG.Text) <= 255)
                {
                    g = Convert.ToByte(textBoxG.Text);
                    sayac9 = 008;
                }
                else
                {
                    MessageBox.Show("LÜTFEN 255 VEYA DAHA KÜÇÜK BİR SOLGUN G DEĞERİ GİRİNİZ ! ! !");
                }

            }
            if (textBoxB.Text.Length > 0)
            {
                if (Convert.ToInt32(textBoxB.Text) <= 255)
                {
                    b = Convert.ToByte(textBoxB.Text);
                    sayac10 = 009;
                }
                else
                {
                    MessageBox.Show("LÜTFEN 255 VEYA DAHA KÜÇÜK BİR SOLGUN B DEĞERİ GİRİNİZ ! ! !");
                }

            }



            if (sayac2 == 001 && sayac3 == 002 && sayac4 == 003 && sayac5 == 004 && sayac6 == 005 && sayac7 == 006 && sayac8 == 007 && sayac9 == 008 && sayac10 == 009)
            {
                // ADANANIN RENKLENDİRME İŞLEMİ YAPILDI.
                if (sayac == 01)
                {
                    GradientStopCollection collection01 = new GradientStopCollection();

                    collection01.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r3, g3, b3), Offset = 0 });
                    collection01.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r2, g2, b2), Offset = 0.5 });
                    collection01.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r, g, b), Offset = 1 });

                    geo01.GradientStopCollection = collection01;

                    textBoxR.Clear();
                    textBoxR2.Clear();
                    textBoxR3.Clear();
                    textBoxG.Clear();
                    textBoxG2.Clear();
                    textBoxG3.Clear();
                    textBoxB.Clear();
                    textBoxB2.Clear();
                    textBoxB3.Clear();

                    sayac2 = 010;
                }
                //----------------------------------------------------------------------------------------------------------------------------


                // ADIYAMAN RENKLENDİRME İŞLEMİ YAPILDI.
                if (sayac == 02)
                {
                    GradientStopCollection collection02 = new GradientStopCollection();

                    collection02.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r3, g3, b3), Offset = 0 });
                    collection02.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r2, g2, b2), Offset = 0.5 });
                    collection02.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r, g, b), Offset = 1 });

                    geo02.GradientStopCollection = collection02;

                    textBoxR.Clear();
                    textBoxR2.Clear();
                    textBoxR3.Clear();
                    textBoxG.Clear();
                    textBoxG2.Clear();
                    textBoxG3.Clear();
                    textBoxB.Clear();
                    textBoxB2.Clear();
                    textBoxB3.Clear();

                    sayac2 = 010;
                }
                //----------------------------------------------------------------------------------------------------


                // AFYONKARAHİSAR RENKLENDİRME İŞLEMİ YAPILDI.
                if (sayac == 03)
                {
                    GradientStopCollection collection03 = new GradientStopCollection();

                    collection03.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r3, g3, b3), Offset = 0 });
                    collection03.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r2, g2, b2), Offset = 0.5 });
                    collection03.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r, g, b), Offset = 1 });

                    geo03.GradientStopCollection = collection03;

                    textBoxR.Clear();
                    textBoxR2.Clear();
                    textBoxR3.Clear();
                    textBoxG.Clear();
                    textBoxG2.Clear();
                    textBoxG3.Clear();
                    textBoxB.Clear();
                    textBoxB2.Clear();
                    textBoxB3.Clear();

                    sayac2 = 010;
                }
                //----------------------------------------------------------------------------------------------------


                // AĞRI RENKLENDİRME İŞLEMİ YAPILDI.
                if (sayac == 04)
                {
                    GradientStopCollection collection04 = new GradientStopCollection();

                    collection04.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r3, g3, b3), Offset = 0 });
                    collection04.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r2, g2, b2), Offset = 0.5 });
                    collection04.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r, g, b), Offset = 1 });

                    geo04.GradientStopCollection = collection04;

                    textBoxR.Clear();
                    textBoxR2.Clear();
                    textBoxR3.Clear();
                    textBoxG.Clear();
                    textBoxG2.Clear();
                    textBoxG3.Clear();
                    textBoxB.Clear();
                    textBoxB2.Clear();
                    textBoxB3.Clear();

                    sayac2 = 010;
                }
                //----------------------------------------------------------------------------------------------------


                // AMASYA RENKLENDİRME İŞLEMİ YAPILDI.
                if (sayac == 05)
                {
                    GradientStopCollection collection05 = new GradientStopCollection();

                    collection05.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r3, g3, b3), Offset = 0 });
                    collection05.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r2, g2, b2), Offset = 0.5 });
                    collection05.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r, g, b), Offset = 1 });

                    geo05.GradientStopCollection = collection05;

                    textBoxR.Clear();
                    textBoxR2.Clear();
                    textBoxR3.Clear();
                    textBoxG.Clear();
                    textBoxG2.Clear();
                    textBoxG3.Clear();
                    textBoxB.Clear();
                    textBoxB2.Clear();
                    textBoxB3.Clear();

                    sayac2 = 010;
                }
                //----------------------------------------------------------------------------------------------------


                // ANKARA RENKLENDİRME İŞLEMİ YAPILDI.
                if (sayac == 06)
                {
                    GradientStopCollection collection06 = new GradientStopCollection();

                    collection06.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r3, g3, b3), Offset = 0 });
                    collection06.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r2, g2, b2), Offset = 0.5 });
                    collection06.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r, g, b), Offset = 1 });

                    geo06.GradientStopCollection = collection06;

                    textBoxR.Clear();
                    textBoxR2.Clear();
                    textBoxR3.Clear();
                    textBoxG.Clear();
                    textBoxG2.Clear();
                    textBoxG3.Clear();
                    textBoxB.Clear();
                    textBoxB2.Clear();
                    textBoxB3.Clear();

                    sayac2 = 010;
                }
                //----------------------------------------------------------------------------------------------------















                // AKSARAY RENKLENDİRME İŞLEMİ YAPILDI.
                if (sayac == 68)
                {
                    GradientStopCollection collection68 = new GradientStopCollection();

                    collection68.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r3, g3, b3), Offset = 0 });
                    collection68.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r2, g2, b2), Offset = 0.5 });
                    collection68.Add(new GradientStop() { Color = System.Windows.Media.Color.FromArgb(120, r, g, b), Offset = 1 });

                    geo68.GradientStopCollection = collection68;

                    textBoxR.Clear();
                    textBoxR2.Clear();
                    textBoxR3.Clear();
                    textBoxG.Clear();
                    textBoxG2.Clear();
                    textBoxG3.Clear();
                    textBoxB.Clear();
                    textBoxB2.Clear();
                    textBoxB3.Clear();

                    sayac2 = 010;
                }
                //----------------------------------------------------------------------------------------------------


               











            }
            else
            {
                MessageBox.Show("LÜTFEN GEÇERLİ RGB DEĞERLERİNİ GİRİNİZ ! ! !");
            }
        }


        


    

        private void Form1_Load(object sender, EventArgs e)
        {
            Baslangic();
        }

        public void GeoMap_TRClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            // ADANA İLİNİN HARİTASININ EKLENMESİ VE İLÇELERİNİN DETAYLARININ EKLENME İŞLEMLERİ YAPILDI.
            if (arg2.Name == "Adana")
            {
                buttonRP.Visible = true;
                geo.Visible = false;
                geo01.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                label1.Text = arg2.Name;
                geo01.Source = "Adana.xml";
                this.Controls.Add(geo01);
                geo01.Dock = DockStyle.None;
                geo01.Width = 1920;
                geo01.Height = 1050;
                geo01.Hoverable = true;
                geo01.LandClick += Geo_01Click;

                sayac = 01;
                


                // İLÇELERİN DETAYLARI EKLENDİ.
                void Geo_01Click(object arg11, LiveCharts.Maps.MapData arg22)
                {
                    // ADANA İLÇELERİNİN DETAYLARI EKLENDİ.
                    if (arg22.Name == "Kozan")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "KOZAN TARİHİ YERLERİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 101;

                        Tool_Daktif();
                        
                    }

                    if (arg22.Name == "Aladağ")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ALADAĞ TARİHÇESİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 102;

                        Tool_Daktif();

                    }

                    if (arg22.Name == "Karaisalı")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "KARAİSALI TARİHÇESİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 103;

                        Tool_Daktif();

                    }

                    if (arg22.Name == "Feke")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "FEKE TARİHÇESİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 104;

                        Tool_Daktif();

                    }

                    if (arg22.Name == "Ceyhan")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "KENTE BAKIŞ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 105;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Pozantı")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "POZANTI TARİHÇESİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 106;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Tufanbeyli")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "TUFANBEYLİ TARİHÇESİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 107;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Saimbeyli")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "SAİMBEYLİ TARİHİ YERLERİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 108;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Seyhan")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "SEYHAN TARİHÇESİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 109;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Karataş")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "KARATAŞ TARİHÇESİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 110;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Yumurtalık")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "YUMURTALIK TARİHÇESİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 111;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "İmamoğlu")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "İMAMOĞLU TARİHÇESİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 112;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Yüreğir")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "YÜREĞİR TARİHÇESİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 113;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Çukurova")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ÇUKUROVA TARİHÇESİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 114;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Sarıçam")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "SARIÇAM TARİHÇESİ";
                        geo01.Source = "Adana.xml";
                        this.Controls.Add(geo01);
                        label1.Text = arg22.Name;
                        geo01.Dock = DockStyle.None;
                        geo01.Width = 1000;
                        geo01.Height = 1050;

                        sayac = 115;

                        Tool_Daktif();
                    }

                }
            }
            //--------------------------------------------------------------------------------------------------------


            // ADIYAMAN İLİNİN HARİTASININ EKLENMESİ VE İLÇELERİNİN DETAYLARININ EKLENME İŞLEMLERİ YAPILDI.
            if (arg2.Name == "Adıyaman")
            {
                buttonRP.Visible = true;
                geo.Visible = false;
                geo02.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                label1.Text = arg2.Name;
                geo02.Source = "Adıyaman.xml";
                this.Controls.Add(geo02);
                geo02.Dock = DockStyle.None;
                geo02.Width = 2200;
                geo02.Height = 2000;
                geo02.Hoverable = true;
                geo02.LandClick += Geo_02Click;

                sayac = 02;



                // İLÇELERİN DETAYLARI EKLENDİ.
                void Geo_02Click(object arg11, LiveCharts.Maps.MapData arg22)
                {
                    // ADIYAMAN İLÇELERİNİN DETAYLARI EKLENDİ.
                    if (arg22.Name == "Merkez")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ADIYAMAN TARİHÇESİ";
                        geo02.Source = "Adıyaman.xml";
                        this.Controls.Add(geo02);
                        label1.Text = arg22.Name;
                        geo02.Dock = DockStyle.None;
                        geo02.Width = 1000;
                        geo02.Height = 1500;

                        sayac = 201;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Kahta")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "KAHTA TARİHÇESİ";
                        geo02.Source = "Adıyaman.xml";
                        this.Controls.Add(geo02);
                        label1.Text = arg22.Name;
                        geo02.Dock = DockStyle.None;
                        geo02.Width = 1000;
                        geo02.Height = 1500;

                        sayac = 202;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Besni")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "BESNİ TARİHÇESİ";
                        geo02.Source = "Adıyaman.xml";
                        this.Controls.Add(geo02);
                        label1.Text = arg22.Name;
                        geo02.Dock = DockStyle.None;
                        geo02.Width = 1000;
                        geo02.Height = 1500;

                        sayac = 203;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Gölbaşı")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "GÖLBAŞI TARİHÇESİ";
                        geo02.Source = "Adıyaman.xml";
                        this.Controls.Add(geo02);
                        label1.Text = arg22.Name;
                        geo02.Dock = DockStyle.None;
                        geo02.Width = 1000;
                        geo02.Height = 1500;

                        sayac = 204;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Gerger")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "GERGER TARİHÇESİ";
                        geo02.Source = "Adıyaman.xml";
                        this.Controls.Add(geo02);
                        label1.Text = arg22.Name;
                        geo02.Dock = DockStyle.None;
                        geo02.Width = 1000;
                        geo02.Height = 1500;

                        sayac = 205;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Sincik")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "SİNCİK TARİHÇESİ";
                        geo02.Source = "Adıyaman.xml";
                        this.Controls.Add(geo02);
                        label1.Text = arg22.Name;
                        geo02.Dock = DockStyle.None;
                        geo02.Width = 1000;
                        geo02.Height = 1500;

                        sayac = 206;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Çelikhan")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ÇELİKHAN TARİHÇESİ";
                        geo02.Source = "Adıyaman.xml";
                        this.Controls.Add(geo02);
                        label1.Text = arg22.Name;
                        geo02.Dock = DockStyle.None;
                        geo02.Width = 1000;
                        geo02.Height = 1500;

                        sayac = 207;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Tut")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "TUT TARİHÇESİ";
                        geo02.Source = "Adıyaman.xml";
                        this.Controls.Add(geo02);
                        label1.Text = arg22.Name;
                        geo02.Dock = DockStyle.None;
                        geo02.Width = 1000;
                        geo02.Height = 1500;

                        sayac = 208;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Samsat")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "SAMSAT TARİHÇESİ";
                        geo02.Source = "Adıyaman.xml";
                        this.Controls.Add(geo02);
                        label1.Text = arg22.Name;
                        geo02.Dock = DockStyle.None;
                        geo02.Width = 1000;
                        geo02.Height = 1500;

                        sayac = 209;

                        Tool_Daktif();
                    }
































                }
            }
            //------------------------------------------------------------------------------------------------------


            // AFYONKARAHİSAR İLİNİN HARİTASININ EKLENMESİ VE İLÇELERİNİN DETAYLARININ EKLENME İŞLEMLERİ YAPILDI.
            if (arg2.Name == "Afyonkarahisar")
            {
                buttonRP.Visible = true;
                geo.Visible = false;
                geo03.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                label1.Text = arg2.Name;
                geo03.Source = "Afyonkarahisar.xml";
                this.Controls.Add(geo03);
                geo03.Dock = DockStyle.Fill;
                geo03.Hoverable = true;
                geo03.LandClick += Geo_03Click;

                sayac = 03;



                // İLÇELERİN DETAYLARI EKLENDİ.
                void Geo_03Click(object arg11, LiveCharts.Maps.MapData arg22)
                {
                    // AFYONKARAHİSAR İLÇELERİNİN DETAYLARI EKLENDİ.
                    if (arg22.Name == "Merkez")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "AFYONKARAHİSARI TANIYALIM";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 301;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Sandıklı")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "SANDIKLI TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 302;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Dinar")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "DİNAR TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 303;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Bolvadin")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "BOLVADİN TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 304;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Emirdağ")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "EMİRDAĞ TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 305;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Sinanpaşa")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "SİNANPAŞA TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 306;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Şuhut")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ŞUHUT TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 307;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Çay")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ÇAY TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 308;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "İhsaniye")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "İHSANİYE TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 309;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "İscehisar")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "İSCEHİSAR TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 310;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Sultandağı")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "SULTANDAĞI TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 311;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Çobanlar")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ÇOBANLAR TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 312;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Dazkırı")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "DAZKIRI TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 313;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Başmakçı")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "BAŞMAKÇI TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 314;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Hocalar")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "HOCALAR TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 315;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Bayat")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "BAYAT TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 316;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Evciler")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "EVCİLER TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 317;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Kızılören")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "KIZILÖREN TARİHÇESİ";
                        geo03.Source = "Afyonkarahisar.xml";
                        this.Controls.Add(geo03);
                        label1.Text = arg22.Name;
                        geo03.Dock = DockStyle.None;
                        geo03.Width = 1000;
                        geo03.Height = 1100;

                        sayac = 318;

                        Tool_Daktif();
                    }


































                }
            }
            //------------------------------------------------------------------------------------------------------


            // AĞRI İLİNİN HARİTASININ EKLENMESİ VE İLÇELERİNİN DETAYLARININ EKLENME İŞLEMLERİ YAPILDI.
            if (arg2.Name == "Ağrı")
            {
                buttonRP.Visible = true;
                geo.Visible = false;
                geo04.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                label1.Text = arg2.Name;
                geo04.Source = "Ağrı.xml";
                this.Controls.Add(geo04);
                geo04.Dock = DockStyle.Fill;
                geo04.Hoverable = true;
                geo04.LandClick += Geo_04Click;

                sayac = 04;



                // İLÇELERİN DETAYLARI EKLENDİ.
                void Geo_04Click(object arg11, LiveCharts.Maps.MapData arg22)
                {
                    // Ağrı İLÇELERİNİN DETAYLARI EKLENDİ.
                    if (arg22.Name == "Merkez")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "AĞRI TARİHÇESİ";
                        geo04.Source = "Ağrı.xml";
                        this.Controls.Add(geo04);
                        label1.Text = arg22.Name;
                        geo04.Dock = DockStyle.None;
                        geo04.Width = 1000;
                        geo04.Height = 1100;

                        sayac = 401;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Doğubayazıt")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "DOĞUBAYAZIT TARİHÇESİ";
                        geo04.Source = "Ağrı.xml";
                        this.Controls.Add(geo04);
                        label1.Text = arg22.Name;
                        geo04.Dock = DockStyle.None;
                        geo04.Width = 1000;
                        geo04.Height = 1100;

                        sayac = 402;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Patnos")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "PATNOS TARİHÇESİ";
                        geo04.Source = "Ağrı.xml";
                        this.Controls.Add(geo04);
                        label1.Text = arg22.Name;
                        geo04.Dock = DockStyle.None;
                        geo04.Width = 1000;
                        geo04.Height = 1100;

                        sayac = 403;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Diyadin")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "DİYADİN TARİHÇESİ";
                        geo04.Source = "Ağrı.xml";
                        this.Controls.Add(geo04);
                        label1.Text = arg22.Name;
                        geo04.Dock = DockStyle.None;
                        geo04.Width = 1000;
                        geo04.Height = 1100;

                        sayac = 404;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Eleşkirt")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ELEŞKİRT TARİHÇESİ";
                        geo04.Source = "Ağrı.xml";
                        this.Controls.Add(geo04);
                        label1.Text = arg22.Name;
                        geo04.Dock = DockStyle.None;
                        geo04.Width = 1000;
                        geo04.Height = 1100;

                        sayac = 405;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Tutak")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "TUTAK TARİHÇESİ";
                        geo04.Source = "Ağrı.xml";
                        this.Controls.Add(geo04);
                        label1.Text = arg22.Name;
                        geo04.Dock = DockStyle.None;
                        geo04.Width = 1000;
                        geo04.Height = 1100;

                        sayac = 406;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Taşlıçay")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "TAŞLIÇAY TARİHÇESİ";
                        geo04.Source = "Ağrı.xml";
                        this.Controls.Add(geo04);
                        label1.Text = arg22.Name;
                        geo04.Dock = DockStyle.None;
                        geo04.Width = 1000;
                        geo04.Height = 1100;

                        sayac = 407;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Hamur")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "HAMUR TARİHÇESİ";
                        geo04.Source = "Ağrı.xml";
                        this.Controls.Add(geo04);
                        label1.Text = arg22.Name;
                        geo04.Dock = DockStyle.None;
                        geo04.Width = 1000;
                        geo04.Height = 1100;

                        sayac = 408;

                        Tool_Daktif();
                    }

                    


































                }
            }
            //------------------------------------------------------------------------------------------------------


            // AMASYA İLİNİN HARİTASININ EKLENMESİ VE İLÇELERİNİN DETAYLARININ EKLENME İŞLEMLERİ YAPILDI.
            if (arg2.Name == "Amasya")
            {
                buttonRP.Visible = true;
                geo.Visible = false;
                geo05.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                label1.Text = arg2.Name;
                geo05.Source = "Amasya.xml";
                this.Controls.Add(geo05);
                geo05.Dock = DockStyle.Fill;
                geo05.Hoverable = true;
                geo05.LandClick += Geo_05Click;

                sayac = 05;



                // İLÇELERİN DETAYLARI EKLENDİ.
                void Geo_05Click(object arg11, LiveCharts.Maps.MapData arg22)
                {
                    // AMASYA İLÇELERİNİN DETAYLARI EKLENDİ.
                    if (arg22.Name == "Merkez")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "AMASYA TARİHÇESİ";
                        geo05.Source = "Amasya.xml";
                        this.Controls.Add(geo05);
                        label1.Text = arg22.Name;
                        geo05.Dock = DockStyle.None;
                        geo05.Width = 1000;
                        geo05.Height = 1100;

                        sayac = 501;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Merzifon")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "MERZİFON TARİHÇESİ";
                        geo05.Source = "Amasya.xml";
                        this.Controls.Add(geo05);
                        label1.Text = arg22.Name;
                        geo05.Dock = DockStyle.None;
                        geo05.Width = 1000;
                        geo05.Height = 1100;

                        sayac = 502;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Suluova")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "SULUOVA TARİHÇESİ";
                        geo05.Source = "Amasya.xml";
                        this.Controls.Add(geo05);
                        label1.Text = arg22.Name;
                        geo05.Dock = DockStyle.None;
                        geo05.Width = 1000;
                        geo05.Height = 1100;

                        sayac = 503;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Taşova")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "TAŞOVA TARİHÇESİ";
                        geo05.Source = "Amasya.xml";
                        this.Controls.Add(geo05);
                        label1.Text = arg22.Name;
                        geo05.Dock = DockStyle.None;
                        geo05.Width = 1000;
                        geo05.Height = 1100;

                        sayac = 504;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Gümüşhacıköy")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "GÜMÜŞHACIKÖY TARİHÇESİ";
                        geo05.Source = "Amasya.xml";
                        this.Controls.Add(geo05);
                        label1.Text = arg22.Name;
                        geo05.Dock = DockStyle.None;
                        geo05.Width = 1000;
                        geo05.Height = 1100;

                        sayac = 505;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Göynücek")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "GÖYNÜCEK TARİHÇESİ";
                        geo05.Source = "Amasya.xml";
                        this.Controls.Add(geo05);
                        label1.Text = arg22.Name;
                        geo05.Dock = DockStyle.None;
                        geo05.Width = 1000;
                        geo05.Height = 1100;

                        sayac = 506;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Hamamözü")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "HAMAMÖZÜ TARİHÇESİ";
                        geo05.Source = "Amasya.xml";
                        this.Controls.Add(geo05);
                        label1.Text = arg22.Name;
                        geo05.Dock = DockStyle.None;
                        geo05.Width = 1000;
                        geo05.Height = 1100;

                        sayac = 507;

                        Tool_Daktif();
                    }

                    

                    


































                }
            }
            //------------------------------------------------------------------------------------------------------


            // ANKARA İLİNİN HARİTASININ EKLENMESİ VE İLÇELERİNİN DETAYLARININ EKLENME İŞLEMLERİ YAPILDI.
            if (arg2.Name == "Ankara")
            {
                buttonRP.Visible = true;
                geo.Visible = false;
                geo06.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                label1.Text = arg2.Name;
                geo06.Source = "Ankara.xml";
                this.Controls.Add(geo06);
                geo06.Dock = DockStyle.Fill;
                geo06.Hoverable = true;
                geo06.LandClick += Geo_06Click;

                sayac = 06;



                // İLÇELERİN DETAYLARI EKLENDİ.
                void Geo_06Click(object arg11, LiveCharts.Maps.MapData arg22)
                {
                    // ANKARA İLÇELERİNİN DETAYLARI EKLENDİ.
                    if (arg22.Name == "Çankaya")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ÇANKAYA TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 601;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Keçiören")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "KEÇİÖREN TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 602;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Yenimahalle")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "YENİMAHALLE TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 603;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Mamak")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "MAMAK TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 604;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Etimesgut")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ETİMESGUT TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 605;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Sincan")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "SİNCAN TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 606;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Altındağ")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ALTINDAĞ TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 607;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Pursaklar")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "PURSAKLAR TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 608;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Gölbaşı")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "GÖLBAŞI TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 609;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Polatlı")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "POLATLI TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 610;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Çubuk")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ÇUBUK TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 611;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Kahramankazan")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "KAHRAMANKAZAN TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 612;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Beypazarı")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "BEYPAZARI TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 613;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Elmadağ")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ELMADAĞ TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 614;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Akyurt")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "AKYURT TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 615;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Şereflikoçhisar")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ŞEREFLİKOÇHİSAR TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 616;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Haymana")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "HAYMANA TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 617;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Kızılcahamam")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "KIZILCAHAMAM TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 618;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Nallıhan")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "NALLIHAN TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 619;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Bala")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "BALA TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 620;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Ayaş")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "AYAŞ TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 621;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Kalecik")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "KALECİK TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 622;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Çamlıdere")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ÇAMLIDERE TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 623;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Güdül")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "GÜDÜL TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 624;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Evren")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "EVREN TARİHÇESİ";
                        geo06.Source = "Ankara.xml";
                        this.Controls.Add(geo06);
                        label1.Text = arg22.Name;
                        geo06.Dock = DockStyle.None;
                        geo06.Width = 1000;
                        geo06.Height = 1100;

                        sayac = 625;

                        Tool_Daktif();
                    }

                    

                    

                    


































                }
            }
            //------------------------------------------------------------------------------------------------------














            // AKSARAY İLİNİN HARİTASININ EKLENMESİ VE İLÇELERİNİN DETAYLARININ EKLENME İŞLEMLERİ YAPILDI.
            if (arg2.Name == "Aksaray")
            {
                buttonRP.Visible = true;
                geo.Visible = false;
                geo68.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                label1.Text = arg2.Name;
                geo68.Source = "Aksaray.xml";
                this.Controls.Add(geo68);
                geo68.Dock = DockStyle.Fill;
                geo68.Hoverable = true;
                geo68.LandClick += Geo_68Click;

                sayac = 68;



                // İLÇELERİN DETAYLARI EKLENDİ.
                void Geo_68Click(object arg11, LiveCharts.Maps.MapData arg22)
                {
                    // Ağrı İLÇELERİNİN DETAYLARI EKLENDİ.
                    if (arg22.Name == "Merkez")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "AKSARAY TARİHÇESİ";
                        geo68.Source = "Aksaray.xml";
                        this.Controls.Add(geo68);
                        label1.Text = arg22.Name;
                        geo68.Dock = DockStyle.None;
                        geo68.Width = 1000;
                        geo68.Height = 1100;

                        sayac = 6801;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Ortaköy")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ORTAKÖY TARİHÇESİ";
                        geo68.Source = "Aksaray.xml";
                        this.Controls.Add(geo68);
                        label1.Text = arg22.Name;
                        geo68.Dock = DockStyle.None;
                        geo68.Width = 1000;
                        geo68.Height = 1100;

                        sayac = 6802;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Eskil")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "ESKİL TARİHÇESİ";
                        geo68.Source = "Aksaray.xml";
                        this.Controls.Add(geo68);
                        label1.Text = arg22.Name;
                        geo68.Dock = DockStyle.None;
                        geo68.Width = 1000;
                        geo68.Height = 1100;

                        sayac = 6803;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Gülağaç")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "GÜLAĞAÇ TARİHÇESİ";
                        geo68.Source = "Aksaray.xml";
                        this.Controls.Add(geo68);
                        label1.Text = arg22.Name;
                        geo68.Dock = DockStyle.None;
                        geo68.Width = 1000;
                        geo68.Height = 1100;

                        sayac = 6804;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Sultanhanı")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "SULTANHANI TARİHÇESİ";
                        geo68.Source = "Aksaray.xml";
                        this.Controls.Add(geo68);
                        label1.Text = arg22.Name;
                        geo68.Dock = DockStyle.None;
                        geo68.Width = 1000;
                        geo68.Height = 1100;

                        sayac = 6805;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Güzelyurt")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "GÜZELYURT TARİHÇESİ";
                        geo68.Source = "Aksaray.xml";
                        this.Controls.Add(geo68);
                        label1.Text = arg22.Name;
                        geo68.Dock = DockStyle.None;
                        geo68.Width = 1000;
                        geo68.Height = 1100;

                        sayac = 6806;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Ağaçören")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "AĞAÇÖREN TARİHÇESİ";
                        geo68.Source = "Aksaray.xml";
                        this.Controls.Add(geo68);
                        label1.Text = arg22.Name;
                        geo68.Dock = DockStyle.None;
                        geo68.Width = 1000;
                        geo68.Height = 1100;

                        sayac = 6807;

                        Tool_Daktif();
                    }

                    if (arg22.Name == "Sarıyahşi")
                    {
                        linkLabelSHR.Visible = true;
                        buttonNS.Visible = true;
                        linkLabelSHR.Text = "SARIYAHŞİ TARİHÇESİ";
                        geo68.Source = "Aksaray.xml";
                        this.Controls.Add(geo68);
                        label1.Text = arg22.Name;
                        geo68.Dock = DockStyle.None;
                        geo68.Width = 1000;
                        geo68.Height = 1100;

                        sayac = 6808;

                        Tool_Daktif();
                    }

                    

                    


































                }
            }
            //------------------------------------------------------------------------------------------------------



















        }

        // NÜFUSA GÖRE SIRALAMA DEĞERLERİ ATANDI VE RENKLENDİRME İŞLEMİ YAPILDI.
        public void buttonRenk_Click(object sender, EventArgs e)
        {
            // ADANA NÜFUSA GÖRE SIRALAMA DEĞERLERİ ATANDI VE RENKLENDİRME İŞLEMİ YAPILDI.
            if (sayac == 01)
            {
                Dictionary<string, double> d01 = new Dictionary<string, double>();

                d01["101"] = 6 ;
                d01["102"] = 14 ;
                d01["103"] = 9 ;
                d01["104"] = 13 ;
                d01["105"] = 5 ;
                d01["106"] = 10 ;
                d01["107"] = 12 ;
                d01["108"] = 15 ;
                d01["109"] = 1 ;
                d01["110"] = 8 ;
                d01["111"] = 11 ;
                d01["112"] = 7 ;
                d01["113"] = 2 ;
                d01["114"] = 3 ;
                d01["115"] = 4;


                Renk_Al();
                

                if (sayac2 == 010 )
                {
                    geo01.HeatMap = d01;
                }
            }  
            //--------------------------------------------------------------------------------------------------

             // ADIYAMAN NÜFUSA GÖRE SIRALAMA DEĞERLERİ ATANDI VE RENKLENDİRME İŞLEMİ YAPILDI.
            if (sayac == 02)
            {
                Dictionary<string, double> d02 = new Dictionary<string, double>();

                d02["201"] = 1 ;
                d02["202"] = 2 ;
                d02["203"] = 3 ;
                d02["204"] = 4 ;
                d02["205"] = 5 ;
                d02["206"] = 6 ;
                d02["207"] = 7 ;
                d02["208"] = 8 ;
                d02["209"] = 9 ;
                


                Renk_Al();
                

                if (sayac2 == 010 )
                {
                    geo02.HeatMap = d02;
                }
            }  
            //--------------------------------------------------------------------------------------------------

            // ADIYAMAN NÜFUSA GÖRE SIRALAMA DEĞERLERİ ATANDI VE RENKLENDİRME İŞLEMİ YAPILDI.
            if (sayac == 03)
            {
                Dictionary<string, double> d03 = new Dictionary<string, double>();

                d03["301"] = 1 ;
                d03["302"] = 2 ;
                d03["303"] = 3 ;
                d03["304"] = 4 ;
                d03["305"] = 5 ;
                d03["306"] = 6 ;
                d03["307"] = 7 ;
                d03["308"] = 8 ;
                d03["309"] = 9 ;
                d03["310"] = 10 ;
                d03["311"] = 11 ;
                d03["312"] = 12 ;
                d03["313"] = 13 ;
                d03["314"] = 14 ;
                d03["315"] = 15 ;
                d03["316"] = 16 ;
                d03["317"] = 17 ;
                d03["318"] = 18 ;
                


                Renk_Al();
                

                if (sayac2 == 010 )
                {
                    geo03.HeatMap = d03;
                }
            }
            //--------------------------------------------------------------------------------------------------

            // AĞRI NÜFUSA GÖRE SIRALAMA DEĞERLERİ ATANDI VE RENKLENDİRME İŞLEMİ YAPILDI.
            if (sayac == 04)
            {
                Dictionary<string, double> d04 = new Dictionary<string, double>();

                d04["401"] = 1;
                d04["402"] = 2;
                d04["403"] = 3;
                d04["404"] = 4;
                d04["405"] = 5;
                d04["406"] = 6;
                d04["407"] = 7;
                d04["408"] = 8;
                



                Renk_Al();


                if (sayac2 == 010)
                {
                    geo04.HeatMap = d04;
                }
            }
            //--------------------------------------------------------------------------------------------------

            // AMASYA NÜFUSA GÖRE SIRALAMA DEĞERLERİ ATANDI VE RENKLENDİRME İŞLEMİ YAPILDI.
            if (sayac == 05)
            {
                Dictionary<string, double> d05 = new Dictionary<string, double>();

                d05["501"] = 1;
                d05["502"] = 2;
                d05["503"] = 3;
                d05["504"] = 4;
                d05["505"] = 5;
                d05["506"] = 6;
                d05["507"] = 7;
                
                



                Renk_Al();


                if (sayac2 == 010)
                {
                    geo05.HeatMap = d05;
                }
            }
            //--------------------------------------------------------------------------------------------------

            // ANKARA NÜFUSA GÖRE SIRALAMA DEĞERLERİ ATANDI VE RENKLENDİRME İŞLEMİ YAPILDI.
            if (sayac == 06)
            {
                Dictionary<string, double> d06 = new Dictionary<string, double>();

                d06["601"] = 1;
                d06["602"] = 2;
                d06["603"] = 3;
                d06["604"] = 4;
                d06["605"] = 5;
                d06["606"] = 6;
                d06["607"] = 7;
                d06["608"] = 8;
                d06["609"] = 9;
                d06["610"] = 10;
                d06["611"] = 11;
                d06["612"] = 12;
                d06["613"] = 13;
                d06["614"] = 14;
                d06["615"] = 15;
                d06["616"] = 16;
                d06["617"] = 17;
                d06["618"] = 18;
                d06["619"] = 19;
                d06["620"] = 20;
                d06["621"] = 21;
                d06["622"] = 22;
                d06["623"] = 23;
                d06["624"] = 24;
                d06["625"] = 25;
                
                



                Renk_Al();


                if (sayac2 == 010)
                {
                    geo06.HeatMap = d06;
                }
            }
            //--------------------------------------------------------------------------------------------------













            // AKSARAY NÜFUSA GÖRE SIRALAMA DEĞERLERİ ATANDI VE RENKLENDİRME İŞLEMİ YAPILDI.
            if (sayac == 68)
            {
                Dictionary<string, double> d68 = new Dictionary<string, double>();

                d68["6801"] = 1;
                d68["6802"] = 2;
                d68["6803"] = 3;
                d68["6804"] = 4;
                d68["6805"] = 5;
                d68["6806"] = 6;
                d68["6807"] = 7;
                d68["6808"] = 8;
                



                Renk_Al();


                if (sayac2 == 010)
                {
                    geo68.HeatMap = d68;
                }
            }
            //--------------------------------------------------------------------------------------------------

















        }



        // GERİ BUTONU YAPILDI.
        void Geri_buton_Click(object sender, EventArgs e)
        {

            Baslangic();
            
        }

        // BAŞLIĞA BÜYÜK HARF YAZMA İŞLEMİ YAPILDI.
        private void label1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = label1.Text.ToUpper();
         
        }

        // PLAKAYA GÖRE SIRALAMA RENKLENDİRMESİ YAPILDI.
        private void button1_Click(object sender, EventArgs e)
        {
            Plaka_Siralama();
        }

        // NÜFUSA GÖRE SIRALAMA RENKLENDİRMESİ YAPILDI.
        private void button2_Click(object sender, EventArgs e)
        {
            Nüfus_Siralama();
        }

        private void textBoxG_TextChanged(object sender, EventArgs e)
        {

        }

        // KARAKTER SINIRLAMA
        private void textBoxR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonKydt_Click(object sender, EventArgs e)
        {
            geo01.HeatMap = d;
            geo01.HeatMap = d;
        }

        private void textBaskin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        // RENK PANELİ BUTONUNA TIKLAMA OLAYLARI YAPILDI.
        private void buttonRP_Click(object sender, EventArgs e)
        {
            

            // ADANA RENK PANELİ BUTONUNA TIKLAMA OLAYLARI YAPILDI.
            if (sayac == 01 || sayac == 101 || sayac == 102 || sayac == 103 || sayac == 104 || sayac == 105 || sayac == 106 || sayac == 107 || sayac == 108 || sayac == 109 || sayac == 110 || sayac == 111 || sayac == 112 || sayac == 113 || sayac == 114 || sayac == 115)
            {
                linkLabelSHR.Visible = false;
                buttonNS.Visible = false;

                geo01.Source = "Adana.xml";
                this.Controls.Add(geo01);
                label1.Text = "ADANA - NÜFUS SIRALAMASI";
                geo01.Dock = DockStyle.None;
                geo01.Width = 1000;
                geo01.Height = 1050;

                Tool_Aktif();

                sayac = 01;         
            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            // ADIYAMAN RENK PANELİ BUTONUNA TIKLAMA OLAYLARI YAPILDI.
            if (sayac == 02 || sayac == 201 || sayac == 202 || sayac == 203 || sayac == 204 || sayac == 205 || sayac == 206 || sayac == 207 || sayac == 208 || sayac == 209) 
            {
                linkLabelSHR.Visible = false;
                buttonNS.Visible = false;

                geo02.Source = "Adıyaman.xml";
                this.Controls.Add(geo02);
                label1.Text = "ADIYAMAN - NÜFUS SIRALAMASI";
                geo02.Dock = DockStyle.None;
                geo02.Width = 1000;
                geo02.Height = 1500;

                Tool_Aktif();

                sayac = 02;
            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            // AFYONKARAHİSAR RENK PANELİ BUTONUNA TIKLAMA OLAYLARI YAPILDI.
            if (sayac == 03 || sayac == 301 || sayac == 302 || sayac == 303 || sayac == 304 || sayac == 305 || sayac == 306 || sayac == 307 || sayac == 308 || sayac == 309 || sayac == 310 || sayac == 311 || sayac == 312 || sayac == 313 || sayac == 314 || sayac == 315 || sayac == 316 || sayac == 317 || sayac == 318) 
            {
                linkLabelSHR.Visible = false;
                buttonNS.Visible = false;

                geo03.Source = "Afyonkarahisar.xml";
                this.Controls.Add(geo03);
                label1.Text = "AFYONKARAHİSAR - NÜFUS SIRALAMASI";
                geo03.Dock = DockStyle.None;
                geo03.Width = 1000;
                geo03.Height = 1100;

                Tool_Aktif();

                sayac = 03;
            }
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            // AĞRI RENK PANELİ BUTONUNA TIKLAMA OLAYLARI YAPILDI.
            if (sayac == 04 || sayac == 401 || sayac == 402 || sayac == 403 || sayac == 404 || sayac == 405 || sayac == 406 || sayac == 407 || sayac == 408)
            {
                linkLabelSHR.Visible = false;
                buttonNS.Visible = false;

                geo04.Source = "Ağrı.xml";
                this.Controls.Add(geo04);
                label1.Text = "AĞRI - NÜFUS SIRALAMASI";
                geo04.Dock = DockStyle.None;
                geo04.Width = 1000;
                geo04.Height = 1100; 

                Tool_Aktif();

                sayac = 04;
            }
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            // AMASYA RENK PANELİ BUTONUNA TIKLAMA OLAYLARI YAPILDI.
            if (sayac == 05 || sayac == 501 || sayac == 502 || sayac == 503 || sayac == 504 || sayac == 505 || sayac == 506 || sayac == 507)
            {
                linkLabelSHR.Visible = false;
                buttonNS.Visible = false;

                geo05.Source = "Amasya.xml";
                this.Controls.Add(geo05);
                label1.Text = "AMASYA - NÜFUS SIRALAMASI";
                geo05.Dock = DockStyle.None;
                geo05.Width = 1000;
                geo05.Height = 1100; 

                Tool_Aktif();

                sayac = 05;
            }
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            // ANKARA RENK PANELİ BUTONUNA TIKLAMA OLAYLARI YAPILDI.
            if (sayac == 06 || sayac == 601 || sayac == 602 || sayac == 603 || sayac == 604 || sayac == 605 || sayac == 606 || sayac == 607 || sayac == 608 || sayac == 609 || sayac == 610 || sayac == 611 || sayac == 612 || sayac == 613 || sayac == 614 || sayac == 615 || sayac == 616 || sayac == 617 || sayac == 618 || sayac == 619 || sayac == 620 || sayac == 621 || sayac == 622 || sayac == 623 || sayac == 624 || sayac == 625)
            {
                linkLabelSHR.Visible = false;
                buttonNS.Visible = false;

                geo06.Source = "Ankara.xml";
                this.Controls.Add(geo06);
                label1.Text = "ANKARA - NÜFUS SIRALAMASI";
                geo06.Dock = DockStyle.None;
                geo06.Width = 1000;
                geo06.Height = 1100; 

                Tool_Aktif();

                sayac = 06;
            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------













            // AKSARAY RENK PANELİ BUTONUNA TIKLAMA OLAYLARI YAPILDI.
            if (sayac == 68 || sayac == 6801 || sayac == 6802 || sayac == 6803 || sayac == 6804 || sayac == 6805 || sayac == 6806 || sayac == 6807 || sayac == 6808) 
            {
                linkLabelSHR.Visible = false;
                buttonNS.Visible = false;

                geo68.Source = "Aksaray.xml";
                this.Controls.Add(geo68);
                label1.Text = "AKSARAY - NÜFUS SIRALAMASI";
                geo68.Dock = DockStyle.None;
                geo68.Width = 1000;
                geo68.Height = 1100; 

                Tool_Aktif();

                sayac = 68;
            }
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

















        }

        // LİNK AÇMA İŞLEMİ YAPILDI.
        private void linkLabelSHR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // ADANA İLÇELERİNİN LİNK AÇMA İŞLEMİ YAPILDI.
            if (sayac == 101)
            {              
                System.Diagnostics.Process.Start("https://www.kozan.bel.tr/tarihi-degerler.html");
            }

            if (sayac == 102)
            {
                System.Diagnostics.Process.Start("https://www.aladag.bel.tr/belediye-tarihcesi");
            }

            if (sayac == 103)
            {
                System.Diagnostics.Process.Start("https://www.karaisali.bel.tr/?page_id=238");
            }

            if (sayac == 104)
            {
                System.Diagnostics.Process.Start("https://www.feke.bel.tr/icerik/tarihce");
            }

            if (sayac == 105)
            {
                System.Diagnostics.Process.Start("https://ceyhan.bel.tr/wp/kente-bakis/#sec-0dad");
            }

            if (sayac == 106)
            {
                System.Diagnostics.Process.Start("https://www.pozanti.bel.tr/pozanti.html");
            }

            if (sayac == 107)
            {
                System.Diagnostics.Process.Start("https://www.tufanbeyli.bel.tr/tarihce.html");
            }

            if (sayac == 108)
            {
                System.Diagnostics.Process.Start("https://www.saimbeyli.bel.tr/index.php/saimbeyli/turizm-rehberi/86-saimbeyli/241-tescilli-kultur-miraslari.html");
            }

            if (sayac == 109)
            {
                System.Diagnostics.Process.Start("https://seyhan.bel.tr/sayfa.php?id=47");
            }

            if (sayac == 110)
            {
                System.Diagnostics.Process.Start("https://karatas.bel.tr/karatas-hakkinda/tarihce/");
            }
            
            if (sayac == 111)
            {
                System.Diagnostics.Process.Start("https://www.yumurtalik.bel.tr/sayfa/tarihce/");
            }

            if (sayac == 112)
            {
                System.Diagnostics.Process.Start("http://imamoglubelediyesi.bel.tr/benim-sehrim");
            }

            if (sayac == 113)
            {
                System.Diagnostics.Process.Start("https://www.yuregir.bel.tr/Sayfa/2/YUREgIR_HAKKINDA");
            }

            if (sayac == 114)
            {
                System.Diagnostics.Process.Start("http://www.cukurova.gov.tr/tarihce");
            }

            if (sayac == 115)
            {
                System.Diagnostics.Process.Start("http://www.saricam.bel.tr/kurumsal/ilcemizin-tarihi");
            }
            //-----------------------------------------------------------------------------------------------------


            // ADIYAMAN İLÇELERİNİN LİNK AÇMA İŞLEMİ YAPILDI.
            if (sayac == 201)
            {
                System.Diagnostics.Process.Start("http://www.adiyaman.gov.tr/adiyaman-tarihi");
            }

            if (sayac == 202)
            {
                System.Diagnostics.Process.Start("https://www.kahta.bel.tr/sayfa/kahta-ilcesi.html");
            }

            if (sayac == 203)
            {
                System.Diagnostics.Process.Start("http://www.besni.gov.tr/besni-tarihi");
            }

            if (sayac == 204)
            {
                System.Diagnostics.Process.Start("http://www.golbasi.bel.tr/sehir/golbasi-tarihce/72/");
            }

            if (sayac == 205)
            {
                System.Diagnostics.Process.Start("http://www.gerger.gov.tr/gerger-tarihi#:~:text=1859%20yılında%20Malatya%20Sancak%20olunca,kişiliğine%20sahip%20Güngörmüş%20köyünde%20bulunuyorken.");
            }

            if (sayac == 206)
            {
                System.Diagnostics.Process.Start("http://www.sincik.gov.tr/ilcemizin-tarihcesi");
            }

            if (sayac == 207)
            {
                System.Diagnostics.Process.Start("https://www.celikhan.bel.tr/tarihce");
            }

            if (sayac == 208)
            {
                System.Diagnostics.Process.Start("https://www.tut.bel.tr/bilgi/gecmisten-gunumuze-tut-20.html");
            }

            if (sayac == 209)
            {
                System.Diagnostics.Process.Start("https://www.samsat.bel.tr/ilcemiz/");
            }
            //------------------------------------------------------------------------------------------------------


            // AFYONKARAHİSAR İLÇELERİNİN LİNK AÇMA İŞLEMİ YAPILDI.
            if (sayac == 301)
            {
                System.Diagnostics.Process.Start("https://www.afyon.bel.tr/icerikkategori/2/58/ilimizi-taniyalim.aspx");
            }

            if (sayac == 302)
            {
                System.Diagnostics.Process.Start("https://sandikli.bel.tr/tarihi/");
            }

            if (sayac == 303)
            {
                System.Diagnostics.Process.Start("https://www.dinar.bel.tr/icerik/tarihce.html");
            }

            if (sayac == 304)
            {
                System.Diagnostics.Process.Start("https://www.bolvadinbelediyesi.com/icerik/tarihce");
            }

            if (sayac == 305)
            {
                System.Diagnostics.Process.Start("http://emirdag.bel.tr/kurumsal/emirdag-tarihi-1/");
            }

            if (sayac == 306)
            {
                System.Diagnostics.Process.Start("http://www.sinanpasa.bel.tr/sayfa/tarihcemiz.html");
            }

            if (sayac == 307)
            {
                System.Diagnostics.Process.Start("https://suhut.bel.tr/sayfa-352-tarihce.html");
            }

            if (sayac == 308)
            {
                System.Diagnostics.Process.Start("https://www.cay.bel.tr/sayfa-354-tarihce.html");
            }

            if (sayac == 309)
            {
                System.Diagnostics.Process.Start("https://www.ihsaniye.bel.tr/tarihi.html");
            }

            if (sayac == 310)
            {
                System.Diagnostics.Process.Start("https://www.iscehisar.bel.tr/sayfa-1-tarihce.html");
            }

            if (sayac == 311)
            {
                System.Diagnostics.Process.Start("https://www.sultandagi.bel.tr/icerik/tarihce");
            }

            if (sayac == 312)
            {
                System.Diagnostics.Process.Start("https://www.cobanlar.bel.tr/sayfa/ilcemiz-hakkinda/2");
            }

            if (sayac == 313)
            {
                System.Diagnostics.Process.Start("https://dazkiri.bel.tr/Dazkiritarihce.aspx");
            }

            if (sayac == 314)
            {
                System.Diagnostics.Process.Start("https://www.basmakci.bel.tr/tarihce/");
            }

            if (sayac == 315)
            {
                System.Diagnostics.Process.Start("http://hocalar.gov.tr/tarihcemiz");
            }

            if (sayac == 316)
            {
                System.Diagnostics.Process.Start("https://www.bayat.bel.tr/tarihce");
            }

            if (sayac == 317)
            {
                System.Diagnostics.Process.Start("https://www.evciler.bel.tr/sayfa/tarihcemiz.html");
            }

            if (sayac == 318)
            {
                System.Diagnostics.Process.Start("http://www.afyonkarahisar.gov.tr/kiziloren");
            }
            //--------------------------------------------------------------------------------------------------------


            // AĞRI İLÇELERİNİN LİNK AÇMA İŞLEMİ YAPILDI.
            if (sayac == 401)
            {
                System.Diagnostics.Process.Start("https://www.agri.bel.tr/sayfa/tarihce/");
            }

            if (sayac == 402)
            {
                System.Diagnostics.Process.Start("http://www.dogubayazit.gov.tr/dogubayazit-tarihcesi");
            }

            if (sayac == 403)
            {
                System.Diagnostics.Process.Start("http://www.patnos.gov.tr/tarihce");
            }

            if (sayac == 404)
            {
                System.Diagnostics.Process.Start("http://www.diyadin.bel.tr/ilcemiz-tarihi");
            }

            if (sayac == 405)
            {
                System.Diagnostics.Process.Start("https://www.eleskirt.bel.tr/ilcemiz.php");
            }

            if (sayac == 406)
            {
                System.Diagnostics.Process.Start("https://www.tutak.bel.tr/sayfa/tutak/");
            }

            if (sayac == 407)
            {
                System.Diagnostics.Process.Start("http://www.taslicay.gov.tr/ilcenin-genel-durumu");
            }

            if (sayac == 408)
            {
                System.Diagnostics.Process.Start("https://hamur.bel.tr/icerik/tarihce");
            }
            //--------------------------------------------------------------------------------------------


            // AMASYA İLÇELERİNİN LİNK AÇMA İŞLEMİ YAPILDI.
            if (sayac == 501)
            {
                System.Diagnostics.Process.Start("https://amasya.bel.tr/amasyanın-tarihi");
            }

            if (sayac == 502)
            {
                System.Diagnostics.Process.Start("https://merzifon.bel.tr/merzifonu-kesfedin");
            }

            if (sayac == 503)
            {
                System.Diagnostics.Process.Start("https://suluova.bel.tr/kategori/suluova/");
            }

            if (sayac == 504)
            {
                System.Diagnostics.Process.Start("https://tasova.bel.tr/tasova-tarihi/");
            }

            if (sayac == 505)
            {
                System.Diagnostics.Process.Start("https://gumushacikoy.bel.tr/tarihi-24.html");
            }

            if (sayac == 506)
            {
                System.Diagnostics.Process.Start("https://www.goynucek.bel.tr/goynucek");
            }

            if (sayac == 507)
            {
                System.Diagnostics.Process.Start("https://amasya.ktb.gov.tr/TR-59479/hamamozu.html");
            }
            //--------------------------------------------------------------------------------------------


            // ANKARA İLÇELERİNİN LİNK AÇMA İŞLEMİ YAPILDI.
            if (sayac == 601)
            {
                System.Diagnostics.Process.Start("https://www.cankaya.bel.tr/pages/17/ANKARANIN-TARIHI/");
            }

            if (sayac == 602)
            {
                System.Diagnostics.Process.Start("https://www.kecioren.bel.tr/kecioren.html");
            }

            if (sayac == 603)
            {
                System.Diagnostics.Process.Start("https://www.yenimahalle.bel.tr/Icerik/yenimahalle-hakkinda/3");
            }

            if (sayac == 604)
            {
                System.Diagnostics.Process.Start("https://www.mamak.bel.tr/mamak/ataturk-ve-mamak/");
            }

            if (sayac == 605)
            {
                System.Diagnostics.Process.Start("https://www.etimesgut.bel.tr/icerik/tarihte-etimesgut-1619.aspx#:~:text=Mayıs%201928%27de%20Atatürk%27ün,tarihinde%20de%20Etimesgut%20Belediyesi%20kurulmuştur.");
            }

            if (sayac == 606)
            {
                System.Diagnostics.Process.Start("https://www.sincan.bel.tr/hakkimizda");
            }

            if (sayac == 607)
            {
                System.Diagnostics.Process.Start("https://www.altindag.bel.tr/#!tarihce");
            }

            if (sayac == 608)
            {
                System.Diagnostics.Process.Start("https://www.pursaklar.bel.tr/pursaklar/tarihce");
            }

            if (sayac == 609)
            {
                System.Diagnostics.Process.Start("http://www.ankaragolbasi.gov.tr/tarih#:~:text=Gölbaşı%27nın%20ilçe%20olması%20ise,bağlandı.%201955%20yılında%20E-5");
            }

            if (sayac == 610)
            {
                System.Diagnostics.Process.Start("https://www.polatli.bel.tr/sayfa/tarihce");
            }

            if (sayac == 611)
            {
                System.Diagnostics.Process.Start("https://www.cubuk.bel.tr/kent-rehberi/tarihce/");
            }

            if (sayac == 612)
            {
                System.Diagnostics.Process.Start("https://www.kahramankazan.bel.tr/sayfa/kahramankazan-tarihi");
            }

            if (sayac == 613)
            {
                System.Diagnostics.Process.Start("http://www.beypazari.gov.tr/beypazari-tarihi");
            }

            if (sayac == 614)
            {
                System.Diagnostics.Process.Start("http://www.elmadag.bel.tr/tarihce");
            }

            if (sayac == 615)
            {
                System.Diagnostics.Process.Start("https://www.akyurt.bel.tr/akyurt-hakkinda");
            }

            if (sayac == 616)
            {
                System.Diagnostics.Process.Start("https://www.sereflikochisar.bel.tr/icerik/tarihce");
            }

            if (sayac == 617)
            {
                System.Diagnostics.Process.Start("https://haymana.bel.tr/sayfa/tarihce");
            }

            if (sayac == 618)
            {
                System.Diagnostics.Process.Start("https://www.kizilcahamam.bel.tr/Tarihce");
            }

            if (sayac == 619)
            {
                System.Diagnostics.Process.Start("https://ankara.ktb.gov.tr/TR-152779/nallihan.html");
            }

            if (sayac == 620)
            {
                System.Diagnostics.Process.Start("https://www.bala.bel.tr/tarihce#");
            }

            if (sayac == 621)
            {
                System.Diagnostics.Process.Start("http://www.ayas.gov.tr/ayas-tarihcesi");
            }

            if (sayac == 622)
            {
                System.Diagnostics.Process.Start("http://kalecik.gov.tr/ilcemizin-tarihcesi");
            }

            if (sayac == 623)
            {
                System.Diagnostics.Process.Start("https://camlidere.bel.tr/sayfa/tarihi");
            }

            if (sayac == 624)
            {
                System.Diagnostics.Process.Start("http://www.gudul.gov.tr/tarihcee#");
            }

            if (sayac == 625)
            {
                System.Diagnostics.Process.Start("http://www.evren.bel.tr/sayfalar.asp?line=sayfalar/tarihce.htm");
            }
            //--------------------------------------------------------------------------------------------














            // AKSARAY İLÇELERİNİN LİNK AÇMA İŞLEMİ YAPILDI.
            if (sayac == 6801)
            {
                System.Diagnostics.Process.Start("http://www.aksaray.gov.tr/aksaray-tanitim#:~:text=Cumhuriyet%20dönemine%20kadar%20Konya%27ya,Nenessa%20(Nenossos)%20olduğu%20sanılmaktadır.");
            }

            if (sayac == 6802)
            {
                System.Diagnostics.Process.Start("https://ortakoy.bel.tr/ortakoy-ortakoy-hakkinda_5");
            }

            if (sayac == 6803)
            {
                System.Diagnostics.Process.Start("http://www.eskil.bel.tr/sehirTanitim");
            }

            if (sayac == 6804)
            {
                System.Diagnostics.Process.Start("https://gulagac.bel.tr/belediyemiz/");
            }

            if (sayac == 6805)
            {
                System.Diagnostics.Process.Start("https://www.sultanhani.bel.tr/sayfa/tarihce/");
            }

            if (sayac == 6806)
            {
                System.Diagnostics.Process.Start("https://www.guzelyurt.bel.tr/icerik/tarihce");
            }

            if (sayac == 6807)
            {
                System.Diagnostics.Process.Start("https://www.agacoren.bel.tr/sayfa/3_belediyemizin-tarihi#:~:text=İlçenin%20adı%201961%20yılında%20Ağaçören,itibariyle%20ilçede%208%20mahalle%20bulunmaktadır.");
            }

            if (sayac == 6808)
            {
                System.Diagnostics.Process.Start("https://sariyahsi.bel.tr/ilcemiz/");
            }
            //--------------------------------------------------------------------------------------------
















        }


        // NÜFUS SAYISI ÖĞRENME İŞLEMİ YAPILDI
        private void buttonNS_Click(object sender, EventArgs e)
        {
            // ADANA İLÇELERİNİN NÜFUS SAYISI ÖĞRENME İŞLEMİ YAPILDI.
            if (sayac == 101)
            {
                MessageBox.Show("132.320 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 102)
            {
                MessageBox.Show("15.855 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 103)
            {
                MessageBox.Show("21.967 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 104)
            {
                MessageBox.Show("16.072 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 105)
            {
                MessageBox.Show("159.955 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 106)
            {
                MessageBox.Show("20.005 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 107)
            {
                MessageBox.Show("16.660 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 108)
            {
                MessageBox.Show("14.030 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 109)
            {
                MessageBox.Show("792.536 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 110)
            {
                MessageBox.Show("23.321 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 111)
            {
                MessageBox.Show("18.653 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 112)
            {
                MessageBox.Show("27.399 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 113)
            {
                MessageBox.Show("407.054 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 114)
            {
                MessageBox.Show("386.634 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 115)
            {
                MessageBox.Show("208.227 KİŞİ YAŞAMAKTADIR.");
            }
            //--------------------------------------------------------------------------------------------------


            // ADIYAMAN İLÇELERİNİN NÜFUS SAYISI ÖĞRENME İŞLEMİ YAPILDI.
            if (sayac == 201)
            {
                MessageBox.Show("312.207 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 202)
            {
                MessageBox.Show("127.534 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 203)
            {
                MessageBox.Show("77.207 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 204)
            {
                MessageBox.Show("50.150 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 205)
            {
                MessageBox.Show("16.416 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 206)
            {
                MessageBox.Show("16.341 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 207)
            {
                MessageBox.Show("15.294 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 208)
            {
                MessageBox.Show("9.686 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 209)
            {
                MessageBox.Show("7.313 KİŞİ YAŞAMAKTADIR.");
            }
            //------------------------------------------------------------------------------------------------------


            // AFYONKARAHİSAR İLÇELERİNİN NÜFUS SAYISI ÖĞRENME İŞLEMİ YAPILDI.
            if (sayac == 301)
            {
                MessageBox.Show("319.574 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 302)
            {
                MessageBox.Show("55.210 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 303)
            {
                MessageBox.Show("47.378 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 304)
            {
                MessageBox.Show("45.944 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 305)
            {
                MessageBox.Show("42.327 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 306)
            {
                MessageBox.Show("38.830 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 307)
            {
                MessageBox.Show("36.309 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 308)
            {
                MessageBox.Show("30.777 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 309)
            {
                MessageBox.Show("27.455 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 310)
            {
                MessageBox.Show("24.999 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 311)
            {
                MessageBox.Show("14.279 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 312)
            {
                MessageBox.Show("14.131 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 313)
            {
                MessageBox.Show("11.364 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 314)
            {
                MessageBox.Show("9.536 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 315)
            {
                MessageBox.Show("9.035 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 316)
            {
                MessageBox.Show("7.687 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 317)
            {
                MessageBox.Show("7.183 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 318)
            {
                MessageBox.Show("2.161 KİŞİ YAŞAMAKTADIR.");
            }
            //--------------------------------------------------------------------------------------------------------


            // AĞRI İLÇELERİNİN NÜFUS SAYISI ÖĞRENME İŞLEMİ YAPILDI.
            if (sayac == 401)
            {
                MessageBox.Show("150.335 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 402)
            {
                MessageBox.Show("118.643 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 403)
            {
                MessageBox.Show("118.481 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 404)
            {
                MessageBox.Show("40.286 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 405)
            {
                MessageBox.Show("31.545 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 406)
            {
                MessageBox.Show("28.927 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 407)
            {
                MessageBox.Show("19.321 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 408)
            {
                MessageBox.Show("17.106 KİŞİ YAŞAMAKTADIR.");
            }
            //--------------------------------------------------------------------------------------------


            // AMASYA İLÇELERİNİN NÜFUS SAYISI ÖĞRENME İŞLEMİ YAPILDI.
            if (sayac == 501)
            {
                MessageBox.Show("147.380 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 502)
            {
                MessageBox.Show("74.727 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 503)
            {
                MessageBox.Show("47.066 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 504)
            {
                MessageBox.Show("30.123 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 505)
            {
                MessageBox.Show("22.179 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 506)
            {
                MessageBox.Show("10.291 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 507)
            {
                MessageBox.Show("3.565 KİŞİ YAŞAMAKTADIR.");
            }
            //--------------------------------------------------------------------------------------------


            // ANKARA İLÇELERİNİN NÜFUS SAYISI ÖĞRENME İŞLEMİ YAPILDI.
            if (sayac == 601)
            {
                MessageBox.Show("949.265 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 602)
            {
                MessageBox.Show("942.884 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 603)
            {
                MessageBox.Show("703.809 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 604)
            {
                MessageBox.Show("682.420 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 605)
            {
                MessageBox.Show("606.472 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 606)
            {
                MessageBox.Show("561.411 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 607)
            {
                MessageBox.Show("407.675 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 608)
            {
                MessageBox.Show("159.676 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 609)
            {
                MessageBox.Show("142.961 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 610)
            {
                MessageBox.Show("127.526 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 611)
            {
                MessageBox.Show("91.363 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 612)
            {
                MessageBox.Show("57.913 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 613)
            {
                MessageBox.Show("48.393 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 614)
            {
                MessageBox.Show("44.236 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 615)
            {
                MessageBox.Show("38.588 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 616)
            {
                MessageBox.Show("33.475 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 617)
            {
                MessageBox.Show("27.298 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 618)
            {
                MessageBox.Show("26.968 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 619)
            {
                MessageBox.Show("26.961 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 620)
            {
                MessageBox.Show("22.966 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 621)
            {
                MessageBox.Show("13.093 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 622)
            {
                MessageBox.Show("12.502 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 623)
            {
                MessageBox.Show("8.350 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 624)
            {
                MessageBox.Show("8.155 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 625)
            {
                MessageBox.Show("2.965 KİŞİ YAŞAMAKTADIR.");
            }
            //--------------------------------------------------------------------------------------------













            // AKSARAY İLÇELERİNİN NÜFUS SAYISI ÖĞRENME İŞLEMİ YAPILDI.
            if (sayac == 6801)
            {
                MessageBox.Show("315.222 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 6802)
            {
                MessageBox.Show("32.130 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 6803)
            {
                MessageBox.Show("27.151 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 6804)
            {
                MessageBox.Show("19.443 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 6805)
            {
                MessageBox.Show("11.630 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 6806)
            {
                MessageBox.Show("10.677 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 6807)
            {
                MessageBox.Show("7.633 KİŞİ YAŞAMAKTADIR.");
            }

            if (sayac == 6808)
            {
                MessageBox.Show("5.183 KİŞİ YAŞAMAKTADIR.");
            }
            //--------------------------------------------------------------------------------------------



        }
    }
}
