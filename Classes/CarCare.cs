namespace BiluthrningExercise.Classes
{
    public class Maintance
    {
        public string MaintanceNeed;
        public string MaintacnceHistory;


        public void NextMaintance()
        {
            Console.WriteLine("The next maintance of this vehicle is in 7 months");
        }


        public void LastMaintance()
        {
            Console.WriteLine("The last maintance of this vehicle was 3 months ago");
        }
    }
}
