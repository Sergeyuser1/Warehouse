namespace Warehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck();
            Worker worker = new Worker("Ivan");

            using (ApplicationContext db = new ApplicationContext())
            {
              
                
               db.Products.AddRange(truck.Products[0]);
                db.SaveChanges();

               
            }

            



            Console.WriteLine("Hello, World!");
        }
    }
}
