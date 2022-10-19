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

        [Test]
        public void TestAddHigh()
        {
            bl.AddEntry(clue, answer, difficulty, date);
            id++;
            Assert.Equals(id, bl.latestId);
        }

        [Test]
        public void TestAddLow()
        {
            bl.AddEntry(clue, answer, difficulty, date);
            id++;
            Assert.Equals(id, bl.latestId);
        }

        [Test]
        public void TestDeleteNormal()
        {
            bl.DeleteEntry(id);
            id--;
            Assert.Equals(id, bl.latestId);
        }

        [Test]
        public void TestDeleteHigh()
        {
            bl.DeleteEntry(id+1);
            
            Assert.Equals(id, bl.latestId);
        }

        [Test]
        public void TestDeleteLow()
        {
            bl.DeleteEntry(-1);
            
            Assert.Equals(id, bl.latestId);
        }

        [Test]
        public void TestUpdateNormal()
        {
            bl.EditEntry(clue, answer, difficulty, date, id);
            
            Assert.Equals(id, bl.latestId);
        }


        [Test]
        public void TestUpdateHigh()
        {
            bl.EditEntry(clue, answer, difficulty, date, id);
            
            Assert.Equals(id, bl.latestId);
        }

        [Test]
        public void TestUpdateLow()
        {
            bl.EditEntry(clue, answer, difficulty, date, id);

            Assert.Equals(id, bl.latestId);
        }


    }
}