using BillPayment.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillPayment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            MessageBox.Show(StaticMeth.DogalgazHesapla(12,10).ToString());
            MessageBox.Show(StaticMeth.DogalgazHesapla(15, 2).ToString());
            MessageBox.Show(StaticMeth.SuHesapla(34).ToString());
        }
    }
}
