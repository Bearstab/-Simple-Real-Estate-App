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
    public partial class EvBul : Form
    {
        public string lblSonuc = null;
        public EvBul()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("İlan Numarası Yazınız");
                return;
            }
            using (var ctx = new EmlakContext())
            {
                var sonuc = from ev in ctx.Evler where ev.IlanNo == long.Parse(textBox1.Text) select ev;
                var gev = sonuc.FirstOrDefault();
                if (gev != null)
                {
                    lblSonuc = $"ilanNumarası:{gev.IlanNo}\n" + $"OdaSayısı:{gev.OdaSayisi}\n" + $"KatNumarası:{gev.KatNo}\n" +
                        $"Alan:{gev.Alan}\n" + $"Semt:{gev.Semt}\n";
                    var frm = new EvGetir(this);
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ev Yok");
                }
            }
        }
    }
}
