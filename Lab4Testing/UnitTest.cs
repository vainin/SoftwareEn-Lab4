using Lab3;

namespace Lab4Testing
{
    public class Tests
    {
        private BusinessLogic bl = new BusinessLogic();
        private string clue;
        private string answer;
        private int difficulty;
        private string date;
        private int id;

        [SetUp]
        public void Setup()
        {
            bl.GetEntries();
            clue = "";
            answer = "";
            difficulty = 1;
            date = "";
            id = bl.latestId;
        }

        [Test]
        public void TestAddNormal()
        {
            bl.AddEntry(clue, answer, difficulty, date);
            id++;
            Assert.Equals(id, bl.latestId);
        }
    }
}