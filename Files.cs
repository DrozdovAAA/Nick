using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Files
    {
        public static void OpenFile1(string a)
        {
            FileStream file = new FileStream(a, FileMode.Open); //открывает файл только на чтение
            StreamReader reader = new StreamReader(file); // создаем «потоковый читатель» и связываем его с файловым потоком 


            Console.WriteLine(reader.ReadToEnd());


            reader.Close();

        }

        public static void DataFile(ref List<Shop> shop, string a1)
        {
            StreamReader sr = new StreamReader(a1); // создаем «потоковый читатель» и связываем его с файловым 
            string line;
            int j = 0;
            string[] mass = new string[12];
            Console.WriteLine("********");

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                mass[j] = line;

                if (line == "*")
                {

                    shop.Add(new Shop(mass[0], Convert.ToInt32(mass[1]), mass[2], mass[3], mass[4]));

                }
            }
            sr.Close();
        }

        public static void InFile(ref List<Shop> shop, string a)
        {
            FileStream file1 = new FileStream(a, FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            foreach (Shop p in shop)
            {
                writer.Write("Название магазина:" + p.getName() + "\nномер:" + p.getRegistrationNumber() + "\nДата регистрации:" + p.getRegistrationDate() + "\nулица:" + p.getAdress() +
                    "\nномер:" + p.getPhone() + "\n*"); //записываем в файл
            }

            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
        }

        public static void InFile(ref List<Owner> owner, string a)
        {
            FileStream file1 = new FileStream(a, FileMode.Append);
            StreamWriter writer = new StreamWriter(file1);
            foreach (Owner p in owner)
            {
                writer.Write("ФИО:" + p.getFIO() + "\nНомер:\n" + p.getPhone() + "\nАдресс:" + p.getAdress()); //записываем в файл
            }

            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
        }

        public static void InFile(ref List<Supply> supply, string a)
        {
            FileStream file1 = new FileStream(a, FileMode.Append);
            StreamWriter writer = new StreamWriter(file1);
            foreach (Supply p in supply)
            {
                writer.Write("Дата:" + p.getDate() + "\nколичество:" + p.getQuantity() + "\nЦена:" + p.getPrice()); //записываем в файл
            }

            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
        }

        public static void InFile(ref List<Supplier> supplier, string a)
        {
            FileStream file1 = new FileStream(a, FileMode.Append);
            StreamWriter writer = new StreamWriter(file1);
            foreach (Supplier p in supplier)
            {
                writer.Write("Имя:" + p.getName() + "\nАдрес" + p.getAdress() + "\nТелефон:" + p.getPhone() + "\nФИО:" + p.getFio()); //записываем в файл
            }

            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
        }



    }
}
