using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EvGetir : Form
    {
        public EvGetir(EvBul frm)
        {
            InitializeComponent();
            this.label1.Text = frm.lblSonuc;
        }
    }
}
