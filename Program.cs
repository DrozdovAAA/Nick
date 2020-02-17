using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.IO;


namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Owner> owner = new List<Owner>();
            List<Supplier> supplier = new List<Supplier>();
            List<Shop> shop = new List<Shop>();
            List<Supply> supply = new List<Supply>();

            
            Shop.InputShop(ref shop);
            Owner.InputOwner(ref owner);
            Supplier.InputSupplier( ref supplier);
            Supply.InputLodger(ref supply);
            Files.InFile(ref shop, "Shop.txt");
            Files.InFile(ref owner, "Owner.txt");
            Files.InFile(ref supplier, "Supplier.txt");
            Files.InFile(ref supply, "Supply.txt");
            Console.ReadKey();
            
            
        }
    }
}
