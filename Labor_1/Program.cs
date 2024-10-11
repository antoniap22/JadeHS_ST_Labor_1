using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void print(Person aPerson)
        {
            // Überprüfe, ob das Objekt ein Customer ist
            if (aPerson is Customer aCustomer)
            {
                // Drucke Details des Customers
                Console.WriteLine("Name: " + aCustomer.name() + " " + aCustomer.surname());
                Console.WriteLine("DoB: " + aCustomer.dob().day + "." + aCustomer.dob().month + "." + aCustomer.dob().year);

                // Ausgabe der Address
                Address addr = aCustomer.address();
                Console.WriteLine("Address: " + addr.street + " " + addr.number + ", " + addr.postcode + " " + addr.city + ", " + addr.country);

                // Ausgabe der ID
                Console.WriteLine("ID: " + aCustomer.id());
            }
            else
            {
                // Wenn es nur eine Person ist, Drucke die Details der Person
                Console.WriteLine("Name: " + aPerson.name() + " " + aPerson.surname());
                Console.WriteLine("DoB: " + aPerson.dob().day + "." + aPerson.dob().month + "." + aPerson.dob().year);
            }
        }


        // main function, no need to return anything
        static void Main(string[] args)
        {
            // Customer-Objekt statt Person-Objekt erstellen
            Customer aCustomer = new Customer();
            int error;

            // Setze die Details der Person (vererbt von Person)
            aCustomer.setName("Joe");
            aCustomer.setSurname("Bloggs");
            error = aCustomer.setDob(29, MONTH.JUL, 1988);

            // Setze die Adresse für den Kunden
            aCustomer.setAddress("Hauptstrasse", 21, "45220", "Klein Bollersen", "Deutschland");

            // Setze die ID für den Kunden
            aCustomer.setID(123456);

            // Überprüfe, ob der Tag zum Monat passt
            if (error == ERROR)
            {
                Console.WriteLine("no such day");
            }
            else
            {
                // Alles ist in Ordnung, drucke die Details
                print(aCustomer);
            }

            Console.ReadKey();
        }
    }
}
