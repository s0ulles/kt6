
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var s = Console.ReadLine();
            int countPen = Convert.ToInt32(Console.ReadLine());
            Factory factory = new Factory();
            factory.CreatePen(countPen);
            factory.CreatePencil(countPen);
            factory.ShowCost();
            Console.ReadLine();
        }
    }




    class Factory
    {

        public void CreatePen(int count)
        {
            for (var i = 0; i < count; i++)
            {
                Pen pen = new Pen();
                products.Add(pen);
                wood -= 2;
            }
        }

        public void CreatePencil(int count)
        {
            for (var i = 0; i < count; i++)
            {
                Pencil pencil = new Pencil();
                products.Add(pencil);
                plastic -= 2;
            }
        }

        int wood = 1000;
        int plastic = 1000;

        void ShowResources()
        {
            Console.WriteLine($"Остаток пластика на складе{plastic}, остаток дерева на складе{wood}");
        }

        public void ShowCost()
        {
            int cost = 0;
            foreach (var product in products)
            {
                cost += product.Sale();
            }
            Console.WriteLine(cost);
        }

        List<IForSale> products = new List<IForSale>();


    }

    interface IForSale
    {
        int Sale();

    }

    class Pen : IForSale
    {
        public int Sale()
        {
            return 5;
        }
    }

    class Pencil : IForSale
    {

        public int Sale()
        {
            Random r = new Random();
            int number = r.Next(3, 5);
            return number;
        }
    }
}