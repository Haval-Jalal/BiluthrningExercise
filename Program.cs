using BiluthrningExercise.Classes;

namespace BiluthrningExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Jag har brainstormat, samlat data och fått information av ett scenario.
           //Jag ska skriva kod om ett biluthyrningsföretag med flera classer.


           CarRent company = new CarRent();
            company.Name = "HB Luxury";
            company.Adress = "Göteborg";
            company.OpenHours = "09:00 - 17:00";
            company.Contact = 123456789;

            company.DisplayInfo();


            // Jag har skapat ett objekt av klassen Car som ärver från klassen Vehicle.
            //Objektet har 5 attributer och en metod.

            Car car1 = new Car();
            car1.Brand = "Bmw";
            car1.Model = "5 Series";
            car1.Year = 2025;
            car1.Price = 1500;
            car1.PeriodInDays = 2;


            car1.CarInfo();



        }
    }
}
