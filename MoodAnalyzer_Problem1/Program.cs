namespace MoodAnalyzer_Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your String to Check the Mood");
            string mood = Console.ReadLine();
            Mood mood1 = new Mood();
            mood1.AnalyzeString(mood);
        }
    }
}