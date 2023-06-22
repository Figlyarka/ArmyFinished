using ArmyLibrary;
using System;
using Army;
using NUnit.Framework;

namespace ArmyLibrary.UnitTests
{
    [TestFixture]
    public class ServicemanTests
    {
        static Serviceman serviceman;

        [SetUp]
        public void Setup()
        {
            serviceman = new Serviceman("John", "Smith", 122);
            serviceman.Rank = "Major";
            serviceman.NumMillitaryUnit = 512;
            serviceman.DateOfEntryIntoService = new DateTime(2021, 6, 19);
            serviceman.TypeOfService = TypeOfService.Contract;
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(serviceman.Name, Is.EqualTo("John"));
            Assert.That(serviceman.Surname, Is.EqualTo("Smith"));
            Assert.That(serviceman.NumMillitaryTicket, Is.EqualTo(122));
            Assert.That(serviceman.Rank, Is.EqualTo("Major"));
            Assert.That(serviceman.NumMillitaryUnit, Is.EqualTo(512));
            Assert.That(serviceman.DateOfEntryIntoService, Is.EqualTo(new DateTime(2021, 6, 19)));
            Assert.That(serviceman.TypeOfService, Is.EqualTo(TypeOfService.Contract));
        }

        [Test]
        public void ServiceLifeGetter_Serviceman_CurrentLife()
        {
            Assert.That(serviceman.ServiceLife, Is.EqualTo((DateTime.Now - serviceman.DateOfEntryIntoService).Days));
        }



        [Test]
        public void GetInfo_Person_ValuesString()
        {
            var expectedInfo = "John Smith. ";
            expectedInfo += "����� ������: 122. ";

            expectedInfo += "����� ������� �����: 512. ";
            expectedInfo += "������: Major. ";
            expectedInfo += "���� ����������� �� ������: 19.06.2021 0:00:00. ";
            expectedInfo += "C��� ������: 733. ";
            expectedInfo += "��� ������: ��������.";

            Assert.That(serviceman.GetInfo(), Is.EqualTo(expectedInfo));
        }

        [Test]
        public void CompareToTest()
        {
            var john = new Serviceman("John", "Fogerty", 122) { NumMillitaryUnit = 223 };
            var alex = new Serviceman("Alex", "Smith", 235) { NumMillitaryUnit = 706 };
            var peter = new Serviceman("Peter", "Gabriel", 233) { NumMillitaryUnit = 915 };
            var tom = new Serviceman("Tom", "Fogerty", 532) { NumMillitaryUnit = 308 };

            Assert.That(john.CompareTo(tom), Is.LessThan(0));
            Assert.That(peter.CompareTo(alex), Is.GreaterThan(0));
            Assert.That(tom.CompareTo(tom), Is.EqualTo(0));
            Assert.That(alex.CompareTo(peter), Is.LessThan(0));

        }
    }
}