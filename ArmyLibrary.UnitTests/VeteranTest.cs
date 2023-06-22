using NUnit.Framework;
using static Army.Serviceman;

namespace Army
{
    [TestFixture]
    public class VeteranTest
    {
        private Veteran _veteran;

        [SetUp]
        public void Setup()
        {
            _veteran = new Veteran("Ivan", "Ivanov", 742, 25, 30000);
            _veteran.Rank = "Major";
            _veteran.NumMillitaryUnit = 512;
            _veteran.DateOfEntryIntoService = new DateTime(2021, 6, 19);
            _veteran.TypeOfService = TypeOfService.Contract;
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(_veteran.Name, Is.EqualTo("Ivan"));
            Assert.That(_veteran.Surname, Is.EqualTo("Ivanov"));
            Assert.That(_veteran.NumMillitaryTicket, Is.EqualTo(742));
            Assert.That(_veteran.LengthOfService, Is.EqualTo(25));
            Assert.That(_veteran.PensionAmount, Is.EqualTo(30000));
            Assert.That(_veteran.Rank, Is.EqualTo("Major"));
            Assert.That(_veteran.NumMillitaryUnit, Is.EqualTo(512));
            Assert.That(_veteran.DateOfEntryIntoService, Is.EqualTo(new DateTime(2021, 6, 19)));
            Assert.That(_veteran.TypeOfService, Is.EqualTo(TypeOfService.Contract));
        }

        [Test]
        public void GetInfoTest()
        {
            var expectedInfo = "Ivan Ivanov. ";
            expectedInfo += "Номер билета: 742. ";

            expectedInfo += "Номер военной части: 512. ";
            expectedInfo += "Звание: Major. ";
            expectedInfo += "Дата поступления на службу: 19.06.2021 0:00:00. ";
            expectedInfo += "Cрок службы: 733. ";
            expectedInfo += "Тип службы: контракт. ";
            expectedInfo += "Выслуга лет: 25 лет. ";
            expectedInfo += "Размер пенсии: 30000 руб.";
            Assert.That(_veteran.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}

