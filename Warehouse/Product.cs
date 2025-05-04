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
        public Guid Id { get; set; }
        public string Name { get; }
        public string Manufacturer { get; }
        public bool IsPerishable { get; }
        public DateTime ExpirationDate { get; }
        public byte SizeProduct { get; }
    }

    class Food : Product
    {
        public string Name { get; }
        public string Manufacturer { get; }
        public bool IsPerishable { get; }
        public DateTime ExpirationDate { get; }
        public byte SizeProduct { get; }
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
        public string Name { get; }
        public string Manufacturer { get; }
        public bool IsPerishable { get; } = false;
        public DateTime ExpirationDate { get; } = new DateTime(2999, 12, 31);
        public byte SizeProduct { get; }
        public Clothes (string name,string manufacturer, byte sizeProduct)
        {
            Name=name;
            Manufacturer = manufacturer;
            SizeProduct = sizeProduct;
        }

    }
    class Shoes: Product
    {
        public string Name { get; }
        public string Manufacturer { get; }
        public bool IsPerishable { get; } = false;
        public DateTime ExpirationDate { get; } = new DateTime(2999, 12, 31);
        public byte SizeProduct { get; }
        public Shoes(string name, string manufacturer, byte sizeProduct)
        {
            Name = name;
            Manufacturer = manufacturer;
            SizeProduct = sizeProduct;
        }
    }

}
