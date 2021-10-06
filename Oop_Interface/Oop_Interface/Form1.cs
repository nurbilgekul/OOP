using Oop_Interface.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            WomanPolitician womanPolitician = new WomanPolitician();

            womanPolitician.FirstName = "Sarah";
            womanPolitician.LastName = "Bright";
            womanPolitician.Age = 43;
            womanPolitician.Alias = "Iron Lady";
            womanPolitician.IsRetired = false;
            womanPolitician.PoliticalParty = "SCP";
            womanPolitician.Lie();
            womanPolitician.beMomy();
         


        }
    }
}
