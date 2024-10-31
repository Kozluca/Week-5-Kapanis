using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Kapanis
{
    public class Car
    {
        DateTime ProductionDate;
        public string SerialNumber;
        public string Brand;
        public string Model;
        public string Color;
        public int DoorNumber;

        public Car(DateTime productionDate, string serialNumber, string brand, string model, string color, int doorNumber)
        {
            ProductionDate = productionDate;
            SerialNumber = serialNumber;
            Brand = brand;
            Model = model;
            Color = color;
            DoorNumber = doorNumber;
        }
        public static void CarList(List<Car> Carliste)
        {

            foreach (var Car in Carliste)
            {
                Console.WriteLine($"Arabanın Markası : {Car.Brand}");
                Console.WriteLine($"Arabanın Modeli : {Car.Model}");
                Console.WriteLine($"Arabanın Rengi: {Car.Color}");
                Console.WriteLine($"Arabanın Kapısayısı : {Car.DoorNumber}");
                Console.WriteLine($"Arabanın SeriNumarası: {Car.SerialNumber}");
                Console.WriteLine($"Arabanın Üretim Tarihi : {DateTime.Now}");
                Console.WriteLine("*****************************");

            }
        }
    }
}
