using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Supplier
    {
        private string Name;
        private string Phone;
        private string Adress;
        private string FIO;
        private static string a1 = "Supplier.txt";
        public Supplier(string Name, string Phone, string Adress, string Fio)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Adress = Adress;
            this.FIO = Fio;
           
        }

        public string getName()
        {
            return Name;
        }
        public string getPhone()
        {
            return Phone;
        }
        public string getAdress()
        {
            return Adress;
        }
        public string getFio()
        {
            return FIO;
        }

        public static void InputSupplier(ref List<Supplier> supplier)
        {
            do
            {
                Console.WriteLine("Просмотреть список агенств - 1, добавить новое - 2, удалить-3, Закончить - 4");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                   Files.OpenFile1(a1);
                  
                }
                if (a == 2)
                {

                    Console.WriteLine("Введите название поставщика");
                    string a1 = Console.ReadLine();
                    Console.WriteLine("Введите адресс поставщика");
                    string a2 = Console.ReadLine();
                    Console.WriteLine("Введите телефон поставщика");
                    string a3 = Console.ReadLine();
                    Console.WriteLine("Введите ФИО контактного лица");
                    string a4 = Console.ReadLine();
                    supplier.Add(new Supplier(a1, a2, a3,a4));
                    Console.WriteLine("Готово");
                    
                }
                if (a == 3)
                { 
                    FileStream file1 = new FileStream("Supplier.txt", FileMode.Create); 
                   
                   
                }
                if (a == 4) break;
            } while (true);
        }

  
    }
}
