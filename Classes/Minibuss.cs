namespace BiluthrningExercise.Classes
{
    public class Van : Vehicle
    {
        public void VanInfo()
        {
            Console.WriteLine($"The price of this {Brand} {Model} {Year} is {Price}kr for {PeriodInDays} days ");
        }
    }
}
