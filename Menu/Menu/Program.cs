using System;
using System.Collections;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("==============MENU==============");
            Console.WriteLine("1: Coca Cola 150 ml (€ 2.50)");
            Console.WriteLine("2: Insalata di pollo (€ 5.20)");
            Console.WriteLine("3: Pizza Margherita (€ 10.00)");
            Console.WriteLine("4: Pizza 4 Formaggi (€ 12.50)");
            Console.WriteLine("5: Pz patatine fritte (€ 3.50)");
            Console.WriteLine("6: Insalata di riso (€ 8.00)");
            Console.WriteLine("7: Frutta di stagione (€ 5.00)");
            Console.WriteLine("8: Pizza fritta (€ 5.00)");
            Console.WriteLine("9: Piadina vegetariana (€ 6.00)");
            Console.WriteLine("10: Panino Hamburger (€ 7.90)");
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============");

            Hashtable order = new Hashtable()
            {
                {"Coca Cola", 0 },
                {"Insalata di pollo", 0 },
                {"Pizza Margherita", 0 },
                {"Pizza 4 Formaggi", 0 },
                {"Pz patatine fritte", 0 },
                {"Insalata di riso", 0 },
                {"Frutta di stagione", 0 },
                {"Pizza fritta", 0 },
                {"Piadina vegetariana", 0 },
                {"Panino Hamburger", 0 },
            };
            string scelta;
            do
            {
                scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        order["Coca Cola"] = (int)order["Coca Cola"] + 1;
                        total += 2.50;
                        break;
                    case "2":
                        order["Insalata di pollo"] = (int)order["Insalata di pollo"] + 1;
                        total += 5.20;
                        break;
                    case "3":
                        order["Pizza Margherita"] = (int)order["Pizza Margherita"] + 1;
                        total += 10.00;
                        break;
                    case "4":
                        order["Pizza 4 Formaggi"] = (int)order["Pizza 4 Formaggi"] + 1;
                        total += 12.50;
                        break;
                    case "5":
                        order["Pz patatine fritte"] = (int)order["Pz patatine fritte"] + 1;
                        total += 3.50;
                        break;
                    case "6":
                        order["Insalata di riso"] = (int)order["Insalata di riso"] + 1;
                        total += 8.00;
                        break;
                    case "7":
                        order["Frutta di stagione"] = (int)order["Frutta di stagione"] + 1;
                        total += 5.00;
                        break;
                    case "8":
                        order["Pizza fritta"] = (int)order["Pizza fritta"] + 1;
                        total += 5.00;
                        break;
                    case "9":
                        order["Piadina vegetariana"] = (int)order["Piadina vegetariana"] + 1;
                        total += 6.00;
                        break;
                    case "10":
                        order["Panino Hamburger"] = (int)order["Panino Hamburger"] + 1;
                        total += 7.90;
                        break;
                    default:
                        break;
                }
            } while (scelta != "11");

            Console.WriteLine("\n");
            Console.WriteLine("Ordine:");

            foreach (string key in order.Keys)
            {
                if ((int)order[key] > 0)
                    Console.WriteLine(String.Format($"-{key}: x{order[key]}"));
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Totale ordine: {total} euro");
            Console.ReadLine();
        }
    }
}
