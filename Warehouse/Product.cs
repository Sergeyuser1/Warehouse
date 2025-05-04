using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    internal class Product
    {
        [Key]
        public Guid Id { get;  } = Guid.NewGuid();
        public virtual string Name { get; set; } 
        public virtual string Manufacturer { get; set; }
        public virtual bool IsPerishable { get; set; }
        public virtual DateTime ExpirationDate { get; set; }
        public virtual byte SizeProduct { get; set; }
      
    }

    class Food : Product
    {
        public override string Name { get; set; }
        public override string Manufacturer { get; set; }
        public override bool IsPerishable { get; set; }
        public override DateTime ExpirationDate { get; set; }
        public override byte SizeProduct { get; set; }
        public Food(string name, string manufacturer, bool isPerishable, DateTime expirationDate, byte sizeProduct)
        {
            Name = name;
            Manufacturer = manufacturer;
            IsPerishable = isPerishable;
            ExpirationDate = expirationDate;
            SizeProduct = sizeProduct;
        }

    }
    class Clothes : Product
    {
        public override string Name { get; set; }
        public override string Manufacturer { get; set; }
        public override bool IsPerishable { get; set; } = false;
        public override DateTime ExpirationDate { get; set; } = new DateTime(2999, 12, 31);
        public override byte SizeProduct { get; set; }
        public Clothes (string name,string manufacturer, byte sizeProduct)
        {
            Name=name;
            Manufacturer = manufacturer;
            SizeProduct = sizeProduct;
        }

    }
    class Shoes: Product
    {
        public override string Name { get; set; }
        public override string Manufacturer { get; set; }
        public override bool IsPerishable { get; set; } = false;
        public override DateTime ExpirationDate { get; set; } = new DateTime(2999, 12, 31);
        public override byte SizeProduct { get;set; }
        public Shoes(string name, string manufacturer, byte sizeProduct)
        {
            Name = name;
            Manufacturer = manufacturer;
            SizeProduct = sizeProduct;
        }
    }

}
