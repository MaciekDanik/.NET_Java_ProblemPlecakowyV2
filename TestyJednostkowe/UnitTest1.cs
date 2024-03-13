using ProblemPlecakowyV2;

namespace TestyJednostkowe
{
    [TestClass]
    public class UnitTest1
    {
        private int Seed = 5;

        [TestMethod]
        public void TestMethodCountElements() // czy zgadza siê iloœæ elementów
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };

            foreach (int n in sizes)
            {
                Problem problem = new Problem(n, Seed);

                Assert.AreEqual(n, problem.items.Count);
            }
        }

        [TestMethod]
        public void ZeroCapacity() //Czy przy 0 pojemnoœci wynik bêdzie 0
        {
            Problem problem = new Problem(25, Seed);
            Result result = problem.Solve(0);
            int val = result.getFinalItems().Count;

            Assert.AreEqual(0, val);
        }

        [TestMethod]
        public void ZeroItems() // Czy prz 0 item bêdzie 0 items
        {
            Problem problem = new Problem(0, Seed);
            int val = problem.items.Count;

            Assert.AreEqual(0, val);
        }

        [TestMethod]
        public void TestSpecificInstance() //Sprawdzenie poprawnoœci wyniku dla konkretnej instancji.
        {
            List<int> Weight = new List<int>() { 4, 3, 5, 2, 6, 9, 1, 5, 9, 8 };
            List<int> Values = new List<int>() { 29, 62, 92, 95, 12, 37, 8, 16, 10, 25 };

            List<Item> items = new List<Item>();
            List<Item> result = new List<Item>();

            for (int i = 0; i < 10; i++)
            {
                Item item = new Item(i, Weight[i], Values[i]);
                items.Add(item);

                if (i == 0 || i == 1 || i == 2 || i == 3 || i == 6 || i == 7)
                {
                    result.Add(item);
                }
            }

            result = result.OrderByDescending(item => item.getRatio()).ToList();

            Problem problem = new Problem(10, Seed);
            Result wynik = problem.Solve(20);
            List<Item> listaItemow = wynik.getFinalItems();

            //Console.WriteLine(result.ToString());
            bool areEqual = true;
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].Id != listaItemow[i].Id)
                {
                    areEqual = false;
                }
            }

            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void TestNotMetConditions() //y jeœli ¿aden przedmiot nie spe³nia ograniczeñ, to zwrócono puste rozwi¹zanie
        {
            List<int> Weight = new List<int>() { 4, 3, 5, 4, 6, 9, 6, 5, 9, 8 };
            List<int> Values = new List<int>() { 29, 62, 92, 95, 12, 37, 8, 16, 10, 25 };

            List<Item> items = new List<Item>();

            for (int i = 0; i < 10; i++)
            {
                Item item = new Item(i, Weight[i], Values[i]);
                items.Add(item);
            }

            Problem problem = new Problem(10, Seed);
            problem.items = items;
            Result result = problem.Solve(2);

            Assert.AreEqual(0, result.getFinalItems().Count);
        }

        [TestMethod]
        public void JakisNowyTest() //y jeœli ¿aden przedmiot nie spe³nia ograniczeñ, to zwrócono puste rozwi¹zanie
        {
            //JESZCZE NIE WIEM CO BÊDZIE ROBI£
        }
    }
}