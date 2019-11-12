using System;

namespace ObjectClass
{
    class Item {
                public string name;
                public int price;
                public bool onSale;

                
            }
            
    class Program
    {
        static void Main(string[] args)
        {
            // Make this code works by create new class, method, and property.
            Item item = new Item();
            item.name = "Indomie Goreng";
            item.price = 3500;
            item.onSale = true; // If true the price will drop 20%

            if (item.onSale == true)
            {
                double diskon = item.price*0.2;
                Console.WriteLine(diskon);
            }

            string print(){
                Console.WriteLine(item.name);
            }

            item.print(); // Output: "Indomie Goreng (Rp2800)"
        }
    }
}
