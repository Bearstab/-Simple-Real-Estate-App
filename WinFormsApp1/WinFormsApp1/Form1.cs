using WinFormsApp1.model;

namespace WinFormsApp1
{
    public enum Login
    {
        Admin,
        User
    }
    public partial class Form1 : Form
    {
        public string lbladmin = null;
        public Login durum = Login.Admin;
        EvKayitFormu EvKayitFormu;
        public Form1(EvKayitFormu evKayitFormu)
        {
            InitializeComponent();
            this.EvKayitFormu = evKayitFormu;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new EmlakContext())
            {
                var bilgiler = from a in ctx.kullanicis where a.Ad == txtAd.Text.Trim() select a;
                EvKayitFormu evKayitFormu = new EvKayitFormu();
                switch (durum)
                {
                    case Login.Admin:

                        lbladmin = "Admin Giriþ Yaptý";
                        evKayitFormu.Show();
                        this.Close();

                        

                        break;
                    case Login.User:
                        
                        evKayitFormu.Show();
                        
                        


                        break;
                    default:
                        break;
                }
                
                var giris = bilgiler.FirstOrDefault();
            }

        }
    }
}