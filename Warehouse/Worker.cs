using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    internal class Worker
    {
        public Worker(string name)
        { Name = name; }
        public string Name { get; }
        //метод проверки срока годности продуктов на складе (предполагаем что просрочку не привезут)
        public void CheckExpirationDate()
        {

        }
        public void ProductAcceptance(Truck truck)
        {

        }
    }
}
