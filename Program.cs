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



        }
    }
}
