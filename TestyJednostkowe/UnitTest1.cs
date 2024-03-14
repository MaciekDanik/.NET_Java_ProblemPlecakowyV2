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
        public void AtLeastOne()//jeœli co najmniej jeden pasuje- zwraca jeden element
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
            Result result = problem.Solve(3);

            Assert.AreEqual(1, result.getFinalItems().Count);
        }

        [TestMethod]
        public void doesOrderMatter()
        {
            List<int> Weight1 = new List<int>() { 4, 3, 5, 4, 6, 9, 6, 5, 9, 8 };
            List<int> Values1 = new List<int>() { 29, 62, 92, 95, 12, 37, 8, 16, 10, 25 };

            List<int> Weight2 = new List<int>() { 6, 9, 6, 5, 9, 8, 4, 3, 5, 4 };
            List<int> Values2 = new List<int>() { 12, 37, 8, 16, 10, 25, 29, 62, 92, 95 };

            List<Item> items1 = new List<Item>();
            List<Item> items2 = new List<Item>();

            for (int i = 0; i < 10; i++)
            {
                Item item1 = new Item(i, Weight1[i], Values1[i]);
                Item item2 = new Item(i, Weight2[i], Values2[i]);
                items1.Add(item1);
                items2.Add(item2);
            }

            Problem problem1 = new Problem(10, Seed);
            Problem problem2 = new Problem(10, Seed);
            problem1.items = items1;
            problem2.items = items2;
            Result result1 = problem1.Solve(20);
            Result result2 = problem2.Solve(20);
            List<Item> wynik1 = result1.getFinalItems();
            List<Item> wynik2 = result2.getFinalItems();

            bool areSame = true;
            for (int i = 0; i < wynik1.Count; i++)
            {
                if (wynik1[i].getRatio() != wynik2[i].getRatio())
                {
                    areSame = false;
                }
            }

            Assert.IsTrue(areSame);
        }

        [TestMethod]
        public void RatioTest()//jeœli co najmniej jeden pasuje- zwraca jeden element
        {
            List<int> Weight = new List<int>() { 4, 3, 5, 4, 6, 9, 6, 5, 9, 8 };
            List<int> Values = new List<int>() { 29, 62, 92, 95, 12, 37, 8, 16, 10, 25 };

            List<Item> items = new List<Item>();
            List<double> ratios = new List<double>();

            for (int i = 0; i < 10; i++)
            {
                Item item = new Item(i, Weight[i], Values[i]);
                double r = Values[i] / Weight[i];
                items.Add(item);
                ratios.Add(r);
            }

            bool same = true;
            for (int i = 0; i < Weight.Count; i++)
            {
                if (items[i].getRatio() != ratios[i])
                {
                    same = false;
                }
            }

            Assert.IsTrue(same);
        }
    }
}