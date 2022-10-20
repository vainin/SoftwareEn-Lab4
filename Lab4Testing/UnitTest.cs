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
            clue = "";
            answer = "";
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
            Assert.Equals(InvalidFieldError.NoError, bl.AddEntry(clue, answer, difficulty, date));
            id++;
            Assert.Equals(id, bl.latestId);
        }

        [Test]
        public void TestAddHigh()
        {

            Assert.Equals(InvalidFieldError.InvalidClueLength, bl.AddEntry(clueh, answer, difficulty, date));
            Assert.Equals(InvalidFieldError.InvalidAnswerLength, bl.AddEntry(clue, answerh, difficulty, date));
            Assert.Equals(InvalidFieldError.InvalidDifficulty, bl.AddEntry(clue, answer, difficultyh, date));

        }

        [Test]
        public void TestAddLow()
        {
            Assert.Equals(InvalidFieldError.InvalidClueLength, bl.AddEntry(cluel, answerl, difficultyl, date));
            Assert.Equals(InvalidFieldError.InvalidAnswerLength, bl.AddEntry(clue, answerl, difficulty, date));
            Assert.Equals(InvalidFieldError.InvalidDifficulty, bl.AddEntry(clue, answer, difficultyl, date));

        }

        [Test]
        public void TestDeleteNormal()
        {
            Assert.Equals(EntryDeletionError.NoError, bl.DeleteEntry(id));
            id--;
            Assert.Equals(id, bl.latestId);
        }

        [Test]
        public void TestDeleteHigh()
        {
            Assert.Equals(EntryDeletionError.EntryNotFound, bl.DeleteEntry(id+1));

            Assert.Equals(id, bl.latestId);
        }

        [Test]
        public void TestDeleteLow()
        {
            Assert.Equals(EntryDeletionError.EntryNotFound, bl.DeleteEntry(-1));
            
            Assert.Equals(id, bl.latestId);
        }

        [Test]
        public void TestUpdateNormal()
        {
            bl.EditEntry(clue, answer, difficulty, date, id);
            Entry entry = new Entry(clue, answer, difficulty, date, id);
            Assert.Equals(id, bl.latestId);
            Assert.Equals(entry, bl.FindEntry(id));
        }


        [Test]
        public void TestUpdateHigh()
        {
            bl.EditEntry(clue, answer, difficulty, date, id);
            Entry entry = new Entry(clue, answer, difficulty, date, id);
            Assert.Equals(id, bl.latestId);
            Assert.Equals(entry, bl.FindEntry(id));
        }

        [Test]
        public void TestUpdateLow()
        {
            bl.EditEntry(clue, answer, difficulty, date, id);
            Entry entry = new Entry(clue, answer, difficulty, date, id);
            Assert.Equals(id, bl.latestId);
            Assert.Equals(entry, bl.FindEntry(id));
        }


    }
}