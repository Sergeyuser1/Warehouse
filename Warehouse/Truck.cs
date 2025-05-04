using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse;

namespace Warehouse
{

    internal class Truck
    {
       public readonly List<Product> Products = new List<Product>();
        public Truck()
        {
            
            //загружаем машину коробками с продукцией
            Products.Add(new Food("Pelmeni","Grandmother",true,DateTime.Now.AddMonths(new Random().Next(2,4)), (byte)new Random().Next(1,200)));
            Products.Add(new Clothes("Jacket", "Nike", (byte)new Random().Next(1, 200)));
            Products.Add(new Shoes("Sneaker", "MadeInChina", (byte)new Random().Next(1, 200)));

        }
       
    }
}
