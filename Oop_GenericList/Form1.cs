using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop_GenericList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<double> kategoriler = new List<double>() { };

            List<TextBox> texts = new List<TextBox>();
        

            List<Category> categories = new List<Category>()
            {
                new Category { Id = 1, Name = "Watch", Description = "8.Generation Watch" },
                new Category { Id = 2, Name = "Phone", Description = "Good Choice" },
                new Category { Id = 3, Name = "Laptop", Description = "Fastest" }
            };
            dataGridView1.DataSource = categories.ToList();



            
        }

       
    }
}
