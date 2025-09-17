using System.Security.Cryptography.X509Certificates;

namespace BiluthrningExercise.Classes
{
    public class CarRent
    {
        public string Name;
        public string Adress;
        public string OpenHours;
        public int Contact;
        


        public void DisplayInfo()
        {
            Console.WriteLine($" Welocome to {Name} at {Adress} everyday {OpenHours}, feel free to call us at {Contact} ");
        }
    }
}
