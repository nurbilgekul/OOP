using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop_DescriptionsandApplications
{
    //Object Oriented programming(OOP) is a programming relies on classes and objects.

    //classes are user defined data types.
    //Classes contain fields and methods.

    class Bag
    {
        public string Brand;
        public string Model;
        public int Price;


        //Access Modifiers
        //(Default Internal)
        //Public:no restrictions.
        //private:limited to within the class definition.
        //protected Access: limited to within the class definition and any class that inherits from the class.
        //internal Access: limited exclusively to classes defined within the current project 


        //Constructor is a method of the class which initialized automatically when an instance of the class is created.
        //Constructor shortcut ctor+TabTab

        public Bag()
        {
            //creating object within Bag class without any property
        }

        public Bag(string marka, string model, int ucret)
        {
            //creating object within Bag class with Brand, Model and Price properties.
            this.Brand = marka;
            this.Model = model;
            this.Price = ucret;
            MessageBox.Show($"Brand: {this.Brand}\nModel: {this.Model}\nPrice: {this.Price}");
        }

        //Encapsulation:  containing information in an object, exposing only selected information to outside
        //when use encapsulation can hide important information and provide security

        public Bag(string marka)
        {
        private Guid _id = Guid.NewGuid();
        public Guid Id
        {
            get { return _id; }
        }
        private int _size;
        public int Size
        {
            get => _size;
            set
            {
                if (value > 0)
                {
                    value = _size;
                }
            }


        }
    }
       
}
        








     
 

    
       
        
        

      
           

   

