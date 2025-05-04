namespace Warehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("На склад прибыла машина с грузом, сейчас подойдет работник и примет товар.");
            Truck truck = new Truck();
            Worker worker = new Worker("Иван");
            Task.Delay(3000).Wait();
            Console.WriteLine($"Работник {worker.Name} начал приемку товаров");
            Task.Delay(3000).Wait();
            worker.ProductAcceptance(truck);
            Console.WriteLine("Товар принят, разложен по полкам и промаркирован QR кодами");
            Task.Delay(3000).Wait();
            Console.WriteLine($"Работник {worker.Name}, по указанию начальника? пошел на складе искать просроченную продукцию, как хорошо что он ведет отдельный списсок скоропортящихся продуктов");
            Console.WriteLine("Hello, World!");
        }
    }
}
