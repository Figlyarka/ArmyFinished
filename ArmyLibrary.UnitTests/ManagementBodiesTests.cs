using NUnit.Framework;
using static Army.Serviceman;

namespace Army
{
    [TestFixture]
    public class ManagementBodiesTests
    {
        private ManagementBodies _managementBodies;

        [SetUp]
        public void Setup()
        {
            _managementBodies = new ManagementBodies("Pavel", "Pavlov", 532, "South", "Сaptain");
            _managementBodies.Rank = "Genial";
            _managementBodies.NumMillitaryUnit = 923;
            _managementBodies.DateOfEntryIntoService = new DateTime(2021, 6, 19);
            _managementBodies.TypeOfService = TypeOfService.Contract;
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(_managementBodies.Name, Is.EqualTo("Pavel"));
            Assert.That(_managementBodies.Surname, Is.EqualTo("Pavlov"));
            Assert.That(_managementBodies.NumMillitaryTicket, Is.EqualTo(532));
            Assert.That(_managementBodies.CountyName, Is.EqualTo("South"));
            Assert.That(_managementBodies.Post, Is.EqualTo("Сaptain"));
            Assert.That(_managementBodies.Rank, Is.EqualTo("Genial"));
            Assert.That(_managementBodies.NumMillitaryUnit, Is.EqualTo(923));
            Assert.That(_managementBodies.DateOfEntryIntoService, Is.EqualTo(new DateTime(2021, 6, 19)));
            Assert.That(_managementBodies.TypeOfService, Is.EqualTo(TypeOfService.Contract));
        }

        [Test]
        public void GetInfoTest()
        {
            var expectedInfo = "Pavel Pavlov. ";
            expectedInfo += "Номер билета: 532. ";
            expectedInfo += "Номер военной части: 923. ";
            expectedInfo += "Звание: Genial. ";
            expectedInfo += "Дата поступления на службу: 19.06.2021 0:00:00. ";
            expectedInfo += "Cрок службы: 733. ";
            expectedInfo += "Тип службы: контракт. ";
            expectedInfo += "Название округа: South. ";
            expectedInfo += "Должность: Сaptain.";
            Assert.That(_managementBodies.GetInfo(), Is.EqualTo(expectedInfo));

        }
    }
}

