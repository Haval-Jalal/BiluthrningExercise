namespace BiluthrningExercise.Classes
{
    public class Truck : Vehicle
    {
        public void TruckInfo()
        {
            Console.WriteLine($"The price of this {Brand} {Model} {Year} is {Price}kr for {PeriodInDays} days ");
        }
    }
}
