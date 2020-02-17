using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Owner
    {
        private string FIO;
        private string phone;
        private string Adress;
        private static string a1= "Owner.txt";
        public Owner(string FIO, string phone,string adress) {
            this.FIO = FIO;
            this.phone = phone;
            this.Adress = adress;
            
        }
       
        public Owner(string FIO, string phone,string adress, ref List<Owner> owner) 
        {
           
          
            
          owner.Add(new Owner(FIO, phone,adress));
                
            
        }
        

        public static void InputOwner(ref List<Owner> owner) {
            do
            {

                Console.WriteLine("Просмотреть список владельцев - 1, добавить нового - 2, удалить-3, Закончить - 4");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Files.OpenFile1(a1);
                 
                }
                if (a == 2)
                {
                    Console.WriteLine("Введите ФИО владельца магазина");
                    string a2 = Console.ReadLine();
                    Console.WriteLine("Введите номер телефона");
                    string a3 = Console.ReadLine();
                    Console.WriteLine("Введите адресс");
                    string a4 = Console.ReadLine();
                    owner.Add(new Owner(a2,a3,a4));
                    Console.WriteLine("Готово");
                }
                if (a == 3)
                {
                    FileStream file1 = new FileStream("Supplier.txt", FileMode.Create);
                }
                if (a == 4) break;
            } while (true);
        }

        public string getFIO() {
            return FIO;
        }
        public string getPhone() {
            return phone;
        }
        public string getAdress()
        {
            return Adress;
        }
       
    }
}
