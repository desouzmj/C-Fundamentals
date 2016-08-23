using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    struct Item
    {
        public int Number;
        public string Description;
        public float Price;
        public int Quantity;
        public float Cost;
        public float Value;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Item[] Inventory = new Item[50];
            bool noquit = true;
            int numitems = 0;
            while (noquit)
            {
                Console.WriteLine("1. Add an item");
                Console.WriteLine("2. Change an item(by giving its item number)");
                Console.WriteLine("3. Delete an item(by giving its item number)");
                Console.WriteLine("4. List all items in the database");
                Console.WriteLine("5. Quit");

                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1": //Add item
                        {
                            Inventory[numitems].Number = numitems+1;

                            Console.WriteLine("Enter description: ");
                            Inventory[numitems].Description = Console.ReadLine();

                            Console.WriteLine("Enter price: ");
                            string strprice = Console.ReadLine();
                            Inventory[numitems].Price = float.Parse(strprice);

                            Console.WriteLine("Enter quantity: ");
                            string strqty = Console.ReadLine();
                            Inventory[numitems].Quantity = int.Parse(strqty);

                            Console.WriteLine("Enter cost: ");
                            string strcost = Console.ReadLine();
                            Inventory[numitems].Cost = float.Parse(strcost);

                            Inventory[numitems].Value = Inventory[numitems].Quantity * Inventory[numitems].Cost;

                            numitems++;
                            break;
                        }
                    case "2":
                        {
                            //Change an item
                            foreach (Item i in Inventory)
                            {
                                if (i.Number != 0)
                                {
                                    Console.WriteLine("{0,6}   {1,-15}     {2,-9:C}   {3,10:d}    {4,-8:C}    {5,-13:C}", i.Number, i.Description, i.Price, i.Quantity, i.Cost, i.Value);
                                }
                            }

                            Console.WriteLine("Choose an item number to change:");
                            string chgchoice = Console.ReadLine();
                            int changechoice = int.Parse(chgchoice);

                            Console.WriteLine("Enter description: ");
                            Inventory[changechoice-1].Description = Console.ReadLine();

                            Console.WriteLine("Enter price: ");
                            string strprice = Console.ReadLine();
                            Inventory[changechoice-1].Price = float.Parse(strprice);

                            Console.WriteLine("Enter quantity: ");
                            string strqty = Console.ReadLine();
                            Inventory[changechoice-1].Quantity = int.Parse(strqty);

                            Console.WriteLine("Enter cost: ");
                            string strcost = Console.ReadLine();
                            Inventory[changechoice-1].Cost = float.Parse(strcost);

                            Inventory[changechoice-1].Value = Inventory[changechoice-1].Quantity * Inventory[changechoice-1].Cost;

                            break;
                        }
                    case "3":
                        {
                            //Delete an item
                            foreach (Item i in Inventory)
                            {
                                if (i.Number != 0)
                                {
                                    Console.WriteLine("{0,6}   {1,-15}     {2,-9:C}   {3,10:d}    {4,-8:C}    {5,-13:C}", i.Number, i.Description, i.Price, i.Quantity, i.Cost, i.Value);
                                }
                            }
                            Console.WriteLine("Choose an item number to delete:");
                            string delchoice = Console.ReadLine();
                            int deletechoice = int.Parse(delchoice);

                            for (int i = deletechoice - 1; i < numitems; i++)
                            {
                                Inventory[i] = Inventory[i + 1];
                                Inventory[i].Number = i+1;
                            }

                            Inventory[numitems-1].Number = 0;
                            numitems--;

                            break;
                        }
                    case "4": //List all items
                        {
                            Console.WriteLine("Item #   Description         Price       Quantity      Cost        Value");
                            Console.WriteLine("------   ---------------     ---------   ----------    --------    -------------");
                            foreach (Item i in Inventory)
                            {
                                if (i.Number != 0)
                                {
                                    Console.WriteLine("{0,6}   {1,-15}     {2,-9:C}   {3,10:d}    {4,-8:C}    {5,-13:C}", i.Number, i.Description, i.Price, i.Quantity, i.Cost, i.Value);
                                }
                            }
                            break;
                        }
                    case "5":
                        {
                            noquit = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid selection!");
                            break;
                        }
                }
            }
        }
    }
}
