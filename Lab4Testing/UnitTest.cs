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
        private string cluel;
        private string answerl;
        private int difficultyl;
        private string clueh;
        private string answerh;
        private int difficultyh;
        private int id;

        [SetUp]
        public void Setup()
        {
            bl.GetEntries();
            clue = "What is black and white but read all over?";
            answer = "Newspaper";
            difficulty = 1;
            date = "1/12/2022";
            cluel = "";
            answerl = "";
            difficultyl = -1;
            clueh = "I don't know how to make a clue way to long because it needs to be more than 250 characters so I will try and make it so. It still seems to be too short so another sentance will be added. " +
                "250 characters is a lot for a clue and I hope to never see one that long.";
            answerh = "This answer is way too long";
            difficultyh = 4;
            id = bl.latestId;
        }

        [Test]
        public void TestAddNormal()
        {
            Assert.AreEqual(InvalidFieldError.NoError, bl.AddEntry(clue, answer, difficulty, date));
            id++;
            Assert.AreEqual(id, bl.latestId);
        }

        [Test]
        public void TestAddHigh()
        {

            Assert.AreEqual(InvalidFieldError.InvalidClueLength, bl.AddEntry(clueh, answer, difficulty, date));
            Assert.AreEqual(InvalidFieldError.InvalidAnswerLength, bl.AddEntry(clue, answerh, difficulty, date));
            Assert.AreEqual(InvalidFieldError.InvalidDifficulty, bl.AddEntry(clue, answer, difficultyh, date));

        }

        [Test]
        public void TestAddLow()
        {
            Assert.AreEqual(InvalidFieldError.InvalidClueLength, bl.AddEntry(cluel, answerl, difficultyl, date));
            Assert.AreEqual(InvalidFieldError.InvalidAnswerLength, bl.AddEntry(clue, answerl, difficulty, date));
            Assert.AreEqual(InvalidFieldError.InvalidDifficulty, bl.AddEntry(clue, answer, difficultyl, date));

        }


        [Test]
        public void TestUpdateNormal()
        {
            id = 6;
            bl.EditEntry("What is white and black but read all over?", answer, difficulty, date, id);
            Entry entry = new Entry("What is white and black but read all over?", answer, difficulty, date, id);
            Assert.AreEqual(entry, bl.FindEntry(id));
        }


        [Test]
        public void TestUpdateHigh()
        {
            id = bl.latestId-1;

            Assert.AreEqual(EntryEditError.InvalidFieldError, bl.EditEntry(clueh, answerh, difficultyh, date, id));
        
            
        }

        [Test]
        public void TestUpdateLow()
        {
            id = bl.latestId - 1;
            Assert.AreEqual(EntryEditError.InvalidFieldError, bl.EditEntry(cluel, answerl, difficultyl, date, id));
        }

        [Test]
        public void TestDeleteNormal()
        {
            id = bl.latestId - 1;
            Assert.AreEqual(EntryDeletionError.NoError, bl.DeleteEntry(id));
            id--;
            Assert.AreEqual(id, bl.latestId);
        }

        [Test]
        public void TestDeleteHigh()
        {
            id = 99;
            Assert.AreEqual(EntryDeletionError.EntryNotFound, bl.DeleteEntry(id));

        }

        [Test]
        public void TestDeleteLow()
        {
            
            Assert.AreEqual(EntryDeletionError.EntryNotFound, bl.DeleteEntry(0));

            Assert.AreEqual(id, bl.latestId);
        }

    }
}