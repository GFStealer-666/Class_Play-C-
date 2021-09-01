using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            User jame = new User("jame watson" , "jame@gmail.com");
            TShirt tshirt1 = new TShirt("L", "Tshirt1", "Red", 500);
            TShirt tshirt2 = new TShirt("M", "Tshirt2", "Black", 750);
            TShirt tshirt3 = new TShirt("S", "Tshirt3", "Pink", 625);
            Address ja = new Address("131/75 ", "Phutthamonthon Road", "Nakhon Pathom", "10180");
            Address home = new Address("879", "asdsad", "sadasd", "1015");

            jame.ShoppingCart(ja);
            jame.Addlist(tshirt1);
            jame.Addlist(tshirt2);
            jame.Addlist(tshirt3);

            ja.SentAddress();
            tshirt1.SentShirt();
            tshirt2.SentShirt();
            tshirt3.SentShirt();
            jame.Calculate();

            Console.ReadLine();           
        }
    }

    class TShirt
    {
        public string size;

        public string image;

        public string color;

        public float price;

        public TShirt (string ValueSize , string Valueimage , string Valuecolor , float Valueprice)
        {
            size = ValueSize;
            image = Valueimage;
            color = Valuecolor;
            price = Valueprice;
        }       

        public void SentShirt()
        {
            Console.WriteLine("Shirt size : {0} , Shirt color : {1} , Shirt price : {2}",this.size,this.color,this.price);
        }
    }
    class User
    {
        public string name;

        public string email;

        private List<TShirt> OderTShirt;

        public User (string Valuename , string Valueemail)
        {
            name = Valuename;
            email = Valueemail;
            OderTShirt = new List<TShirt>();
        }      

        public void ShoppingCart(Address address)
        {
            OderTShirt = new List<TShirt>();
            Address JameAddress = address;
        }

        public void Addlist(TShirt tshirt)
        {
            OderTShirt.Add(tshirt);
          
        }
        public void Calculate()
        {
            int counter = 1;
            float pricesum =0;
            foreach (TShirt tshirt in OderTShirt)
            {
                pricesum += tshirt.price;
                counter++;

                if (counter == OderTShirt.Capacity)
                {
                    Console.WriteLine("Overall price that Jame need to paid is : {0}",pricesum);
                } 
            }
        }
    }
    
    class Address
    {
        public string homeaddress;

        public string street;

        public string city;

        public string zipCode;

        public Address (string Valuehomeaddress , string Valuestreet , string Valuecity , string Valuezipcode)
        {
            homeaddress = Valuehomeaddress;
            street = Valuestreet;
            city = Valuecity;
            zipCode = Valuezipcode;        
        }

        public void SentAddress()
        {
            Console.WriteLine("Address : {0} {1} {2} Province Zipcode {3}",this.homeaddress,this.street,this.city,this.zipCode);          
        }

    }
    
   /* class ShoppingCart
    {
        private List <TShirt> OderTShirt;

        public ShoppingCart()
        {
            OderTShirt = new List<TShirt>();
        }

        public void Addlist(TShirt tshirt)
        {
            OderTShirt.Add(tshirt);
        }
    } */
}
