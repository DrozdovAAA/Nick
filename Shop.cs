using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class Shop
    {
        private string Name;
        private int RegistrationNumber;
        private string RegistrationDate;
        private string Adress;
        private string Phone;
        public static string a1 = "Shop.txt";
        
        public Shop(string Name, int RegistrationNumber, string RegistrationDate, string Adress, string Phone)
        {
            this.Name = Name;
            this.RegistrationNumber = RegistrationNumber;
            this.RegistrationDate = RegistrationDate;
            this.Adress = Adress;
            this.Phone = Phone;       
        }

        public Shop(string Name, int RegistrationNumber, string RegistrationDate, string Adress, string Phone, ref List<Shop> shop)
        {
            this.Name = Name;
            this.RegistrationNumber = RegistrationNumber;
            this.RegistrationDate = RegistrationDate;
            this.Adress = Adress;
            this.Phone = Phone;

        }


        public  string getName() { return Name; }
        public int getRegistrationNumber() { return RegistrationNumber; }
        public string getRegistrationDate() { return RegistrationDate; }
        public string getAdress() { return Adress; }
        public string getPhone() { return Phone; }
       

        public static void InputShop(ref List<Shop> shop)
        {
           
            
            do
            {
                Console.WriteLine("Просмотреть список недвижимости - 1, добавить новый объект - 2, удалить-3, Закончить - 4, 5 - отладка");
                int a = Convert.ToInt32(Console.ReadLine());
  
                if (a == 1)
                {
                    Files.OpenFile1(a1);
                }
                if (a == 2)
                {
                    Console.WriteLine("Введите название магазина:");
                    string a1 = Console.ReadLine();
                    Console.WriteLine("Введите номер регистрации:");
                    string a2 = Console.ReadLine();
                    Console.WriteLine("Введите дау регистрации:");
                    string a3 = Console.ReadLine();
                    Console.WriteLine("Введите адресс магазина:");
                    string a4 = Console.ReadLine();
                    Console.WriteLine("Введите телефон магазина:");
                    string a5 = Console.ReadLine();
                    shop.Add(new Shop(a1,Convert.ToInt16( a2), a3, a4, a5,ref shop) { });

                    Console.WriteLine("Готово");
                }
                if (a == 3)
                {
                    FileStream file1 = new FileStream("Supplier.txt", FileMode.Create);
                }
                if (a == 4) break;
                if (a == 5) {  }
            } while (true);
        }

        public static void InputDop(ref List<Shop> shop) {
            Console.WriteLine("Введите название объекта:");
            string a1 = Console.ReadLine();
            Console.WriteLine("Введите номер регистрации:");
            string a2 = Console.ReadLine();
            Console.WriteLine("Введите дау регистрации:");
            string a3 = Console.ReadLine();
            Console.WriteLine("Введите адресс магазина:");
            string a4 = Console.ReadLine();
            Console.WriteLine("Введите телефон магазина:");
            string a5 = Console.ReadLine();

            shop.Add(new Shop(a1, Convert.ToInt32( a2), a3, a4, a5, ref shop) { });

            Console.WriteLine("Готово");
        }

       

       /* public static void dop(ref List<Owner> owner, ref List<Object1> object1,string dop2) {
             
            Console.WriteLine(dop2 + " владеет объектами:");
            foreach (Object1 p in object1) {
                foreach (Owner p2 in owner) {
                    
                    if (dop2 == p2.getFIO()) {
                        if (p2.getFIO() == p.getOwner()) {
                          Console.WriteLine(p.getTypeOfProperty());
                            doop = p2.getAgenccy();
                        }

                    }
                }
            }
            Console.WriteLine("Пользуется услугами агенства по недвижимости: " + doop);
            Console.WriteLine("Хотите добавить объект? 1-да, 2-нет");
            int dop4 = Convert.ToInt32(Console.ReadLine());
            if (dop4 == 1) { InputDop(ref object1); }
            
        }*/
    }
}


