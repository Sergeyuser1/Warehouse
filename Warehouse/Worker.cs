using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronQr;
using IronSoftware.Drawing;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using AutoMapper;


namespace Warehouse
{
    internal class Worker
    {
        static int chQR = 0;
        static string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        static string projRoot = Path.GetFullPath(Path.Combine(baseDir, @"..\..\..\"));
        static string picPath = Path.Combine(projRoot, "PictureQR");
        private List<Product> fastPerishableList = new List<Product>();
        public Worker(string name)
        { Name = name; }
        public string Name { get; }
        //метод проверки срока годности продуктов на складе (предполагаем что просрочку не привезут)
        public void CheckExpirationDate()
        {
            for (int i = 0; i < fastPerishableList.Count; i++)
            {
                if (fastPerishableList[i].ExpirationDate > DateTime.Now)
                {
                    Console.WriteLine($"найден просроченный товар, пора бы списать {fastPerishableList[i].Id} {fastPerishableList[i].Name} {fastPerishableList[i].Manufacturer}");
                }
            }
            Console.WriteLine("Ну вот, теперь на складе нет просрочки");
        }
        public void ProductAcceptance(Truck truck)
        {
            for (int i = 0; i < truck.Products.Count; i++)
            {
                CreateQRStiker(truck.Products[i]);
                if (truck.Products[i].IsPerishable)
                {
                    fastPerishableList.Add(truck.Products[i]);
                }
                try
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        db.Products.AddRange(new Product()
                        {
                            Name = truck.Products[i].Name,
                            Manufacturer = truck.Products[i].Manufacturer,
                            IsPerishable = truck.Products[i].IsPerishable,
                            ExpirationDate = truck.Products[i].ExpirationDate,
                            SizeProduct = truck.Products[i].SizeProduct
                        });
                        db.SaveChanges();
                    }

                }
                catch (Exception)
                {


                }
            }
        }
        private void CreateQRStiker(Product product)
        {
            if (!Directory.Exists(picPath))
            {
                Directory.CreateDirectory(picPath);
            }
            string jsonQR = JsonSerializer.Serialize(product);
            QrCode productQr = QrWriter.Write(jsonQR);
            AnyBitmap qrBitmap = productQr.Save();
            qrBitmap.SaveAs($"{picPath}/qr{chQR++}.png");

        }
    }
}
