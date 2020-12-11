using Interfaces_demo.Entities;
using Interfaces_demo.Services;
using System;
using System.Globalization;

namespace Interfaces_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A Brazilian car rental company charges an hourly rate for rentals of up to 12 hours. However, if the duration of the rental exceeds 12 hours,
             *the rental will be charged on a daily basis.In addition to the value of the lease, the value of the tax is added to the price according to the
             *rules of the country which, in the case of Brazil, is 20% for values up to 100.00, or 15% for values above 100.00.Make a program that reads the
             *rental data (car model, initial and final instant of the rental), as well as the value per hour and the daily rental value.The program must
             *then generate the payment slip (containing rental value, tax amount and total payment amount) and inform the data on the screen.*/

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
