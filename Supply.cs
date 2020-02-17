using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Supply
    {
        private string Date;
        private int Quantity;
        private static string a1 = "Supply.txt";
        private string price;

        public Supply(string Date, int Quantity, string price)
        {
            this.Date = Date;
            this.Quantity = Quantity;
            this.price = price;
            
        }

        public static void InputLodger(ref List<Supply> supplies)
        {
            do
            {
                Console.WriteLine("Просмотреть список квартиросъемщиков - 1, добавить нового - 2, очистить-3, Закончить - 4");
               int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Files.OpenFile1(a1);
                   
                }
                if (a == 2)
                {
                    Console.WriteLine("Введите Дату поставки");
                    string a1 = Console.ReadLine();
                    Console.WriteLine("Введите количество товара");
                    string a2 = Console.ReadLine();
                    Console.WriteLine("Введите стоимость поставки");
                    string a3 = Console.ReadLine();
                    supplies.Add(new Supply(a1,Convert.ToInt32(a2),a3) { });
                    Console.WriteLine("Готово");
                }
                if (a == 3)
                {
                    
                    FileStream file1 = new FileStream("Supply.txt", FileMode.Create); 
                   
                }
                if (a == 4) break;
            } while (true);
        }

        public string getDate()
        {
            return Date;
        }

        public int getQuantity()
        {
            return Quantity;
        }

        public string getPrice() {
            return price;
        }
    }
}
