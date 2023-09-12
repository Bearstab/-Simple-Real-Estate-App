using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.model;

namespace WinFormsApp1
{
    public partial class EvKayitFormu : Form
    {
        public EvKayitFormu()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox && item.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Boş Yer Var");
                    return;
                }

            }
            using (var ctx = new EmlakContext())
            {
                var ev = new Ev
                {
                    IlanNo = long.Parse(textBox1.Text),
                    OdaSayisi = byte.Parse(textBox2.Text),
                    KatNo = sbyte.Parse(textBox3.Text),
                    Alan = float.Parse(textBox4.Text),
                    Semt = textBox5.Text
                };
                ctx.Evler.Add(ev);
                int sonuc = ctx.SaveChanges();
                if (sonuc > 0) MessageBox.Show("Kayıt Başarılı");
                else MessageBox.Show("Kayıt Başarısız");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new EvBul();
            frm.ShowDialog();
        }
        public void Clean()
        {
            foreach(Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = String.Empty;
                }
            }
        }
    }
}
