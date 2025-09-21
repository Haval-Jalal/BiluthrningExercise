namespace BiluthrningExercise.Classes
{
    public class Car : Vehicle
    {
        public void CarInfo() 
            {
                Console.WriteLine($"The price of this {Brand} {Model} {Year} is {Price}kr for {PeriodInDays} days ");
            }
    }
}
