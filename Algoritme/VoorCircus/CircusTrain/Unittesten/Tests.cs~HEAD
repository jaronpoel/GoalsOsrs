using CircusTrain.classes;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        public Train Train;
        public List<Animal> Animals;
        public List<Wagon> wagons;

        [SetUp]
        public void Setup()
        {
            Train = new Train();
            Animals = new List<Animal>();
        }

        #region Carnivore
        [Test]
        public void CarnivoreTest()
        {
            for (int i = 0; i < 15; i++)
            {
                Animals.Add(new Animal(Size.Normal, Diet.Carnivore));
            }

            for (int i = 0; i < 2; i++)
            {
                Animals.Add(new Animal(Size.Small, Diet.Carnivore));
            }

            for (int i = 0; i < 10; i++)
            {
                Animals.Add(new Animal(Size.Big, Diet.Carnivore));
            }

            List<Wagon> wagons = Train.PlaceAnimals(Animals);

            Assert.AreEqual(27, wagons.Count());
        }

        [Test]
        public void BigCarnavoreTwoWagonsTest()
        {

            for (int i = 0; i < 2; i++)
            {
                Animals.Add(new Animal(Size.Big, Diet.Carnivore));
            }
            List<Wagon> wagons = Train.PlaceAnimals(Animals);

            Assert.AreEqual(2, wagons.Count());
        }

        [Test]
        public void NormalCarnavoreMoreWagonsTest()
        {
            for (int i = 0; i < 20; i++)
            {
                Animals.Add(new Animal(Size.Normal, Diet.Carnivore));
            }
            List<Wagon> wagons = Train.PlaceAnimals(Animals);

            Assert.AreEqual(20, wagons.Count());
        }

        [Test]
        public void SmallCarnavoreTwoWagonsTest()
        {
            for (int i = 0; i < 2; i++)
            {
                Animals.Add(new Animal(Size.Small, Diet.Carnivore));
            }
            List<Wagon> wagons = Train.PlaceAnimals(Animals);

            Assert.AreEqual(2, wagons.Count());
        }

        #endregion

        #region Herbivore
        [Test]
        public void HerbivoreTest()
        {
            for (int i = 0; i < 25; i++)
            {
                Animals.Add(new Animal(Size.Small, Diet.Herbivore));
            }

            for (int i = 0; i < 5; i++)
            {
                Animals.Add(new Animal(Size.Big, Diet.Herbivore));
            }

            for (int i = 0; i < 15; i++)
            {
                Animals.Add(new Animal(Size.Normal, Diet.Herbivore));
            }
            List<Wagon> wagons = Train.PlaceAnimals(Animals);

            Assert.AreEqual(10, wagons.Count());
        }

        [Test]
        public void BigHerbivoreOneWagonTest()
        {
            for (int i = 0; i < 2; i++)
            {
                Animals.Add(new Animal(Size.Big, Diet.Herbivore));
            }
            List<Wagon> wagons = Train.PlaceAnimals(Animals);

            Assert.AreEqual(1, wagons.Count());
        }

        [Test]
        public void SmallHerbivorseOneWagonTest()
        {
            for (int i = 0; i < 10; i++)
            {
                Animals.Add(new Animal(Size.Small, Diet.Herbivore));
            }
            List<Wagon> wagons = Train.PlaceAnimals(Animals);

            Assert.AreEqual(1, wagons.Count());
        }

        [Test]
        public void NormalHerbivoreOneWagonTest()
        {
            for (int i = 0; i < 3; i++)
            {
                Animals.Add(new Animal(Size.Normal, Diet.Herbivore));
            }
            List<Wagon> wagons = Train.PlaceAnimals(Animals);

            Assert.AreEqual(1, wagons.Count());
        }
        #endregion

        #region Place Animals

        [Test]
        public void RandomAnimalListTest1()
        {
            Animals.Add(new Animal(Size.Big, Diet.Carnivore));

            Animals.Add(new Animal(Size.Big, Diet.Herbivore));
            Animals.Add(new Animal(Size.Big, Diet.Herbivore));
            Animals.Add(new Animal(Size.Big, Diet.Herbivore));

            Animals.Add(new Animal(Size.Normal, Diet.Carnivore));
            Animals.Add(new Animal(Size.Normal, Diet.Carnivore));
            Animals.Add(new Animal(Size.Normal, Diet.Carnivore));

            Animals.Add(new Animal(Size.Normal, Diet.Herbivore));
            Animals.Add(new Animal(Size.Normal, Diet.Herbivore));
            Animals.Add(new Animal(Size.Normal, Diet.Herbivore));
            Animals.Add(new Animal(Size.Normal, Diet.Herbivore));
            Animals.Add(new Animal(Size.Normal, Diet.Herbivore));
            Animals.Add(new Animal(Size.Normal, Diet.Herbivore));
            Animals.Add(new Animal(Size.Normal, Diet.Herbivore));

            Animals.Add(new Animal(Size.Small, Diet.Herbivore));
            Animals.Add(new Animal(Size.Small, Diet.Herbivore));
            Animals.Add(new Animal(Size.Small, Diet.Herbivore));
            Animals.Add(new Animal(Size.Small, Diet.Herbivore));
            Animals.Add(new Animal(Size.Small, Diet.Herbivore));

            Animals.Add(new Animal(Size.Small, Diet.Carnivore));
            Animals.Add(new Animal(Size.Small, Diet.Carnivore));
            Animals.Add(new Animal(Size.Small, Diet.Carnivore));
            Animals.Add(new Animal(Size.Small, Diet.Carnivore));

            List<Wagon> wagons = Train.PlaceAnimals(Animals);

            Assert.AreEqual(12, wagons.Count());
        }

        [Test]
        public void RandomAnimalListTest2()
        {
            Animals.Add(new Animal(Size.Big, Diet.Carnivore));

            Animals.Add(new Animal(Size.Big, Diet.Herbivore));

            Animals.Add(new Animal(Size.Normal, Diet.Carnivore));

            Animals.Add(new Animal(Size.Small, Diet.Carnivore));

            Animals.Add(new Animal(Size.Normal, Diet.Herbivore));

            Animals.Add(new Animal(Size.Small, Diet.Herbivore));

            List<Wagon> wagons = Train.PlaceAnimals(Animals);

            Assert.AreEqual(4, wagons.Count());
        }

        [Test]
        public void RandomAnimalListTest3()
        {
            Animals.Add(new Animal(Size.Big, Diet.Herbivore));
            Animals.Add(new Animal(Size.Big, Diet.Herbivore));

            Animals.Add(new Animal(Size.Normal, Diet.Herbivore));
            Animals.Add(new Animal(Size.Normal, Diet.Herbivore));
            Animals.Add(new Animal(Size.Normal, Diet.Herbivore));

            Animals.Add(new Animal(Size.Small, Diet.Carnivore));

            List<Wagon> wagons = Train.PlaceAnimals(Animals);

            Assert.AreEqual(2, wagons.Count());
        }

        [Test]
        public void RandomAnimalListTest4()
        {
            Animals.Add(new Animal(Size.Big, Diet.Herbivore));

            Animals.Add(new Animal(Size.Normal, Diet.Carnivore));
            Animals.Add(new Animal(Size.Normal, Diet.Carnivore));
            Animals.Add(new Animal(Size.Normal, Diet.Carnivore));

            Animals.Add(new Animal(Size.Normal, Diet.Herbivore));

            Animals.Add(new Animal(Size.Small, Diet.Carnivore));

            List<Wagon> wagons = Train.PlaceAnimals(Animals);

            Assert.AreEqual(4, wagons.Count());
        }
        #endregion
    }
}