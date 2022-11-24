using MoodAnalyzer_Problem1;
namespace MoodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HappyOrSad()
        {
            Mood mood = new Mood();
            string result = mood.AnalyzeString("Happy");
            Assert.AreEqual("Happy".ToUpper(),result);
        }
        public void Sad()
        {
            Mood mood = new Mood();
            string result = mood.AnalyzeString("I am in Sad Mood");
            Assert.AreEqual("Sad".ToUpper(), result);
        }
    }
}