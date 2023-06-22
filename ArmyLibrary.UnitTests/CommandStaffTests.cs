using NUnit.Framework;
using static Army.Serviceman;

namespace Army
{

    [TestFixture]
    public class CommandStaffTests
    {
        private CommandStaff _commandStaff;

        [SetUp]
        public void Setup()
        {
            _commandStaff = new CommandStaff("Pavel", "Pavlov", 532, "Marine corps", "Сaptain");
            _commandStaff.Rank = "Genial";
            _commandStaff.NumMillitaryUnit = 923;
            _commandStaff.DateOfEntryIntoService = new DateTime(2021, 6, 19);
            _commandStaff.TypeOfService = TypeOfService.Contract;
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(_commandStaff.Name, Is.EqualTo("Pavel"));
            Assert.That(_commandStaff.Surname, Is.EqualTo("Pavlov"));
            Assert.That(_commandStaff.NumMillitaryTicket, Is.EqualTo(532));
            Assert.That(_commandStaff.DivisionName, Is.EqualTo("Marine corps"));
            Assert.That(_commandStaff.Post, Is.EqualTo("Сaptain"));
            Assert.That(_commandStaff.Rank, Is.EqualTo("Genial"));
            Assert.That(_commandStaff.NumMillitaryUnit, Is.EqualTo(923));
            Assert.That(_commandStaff.DateOfEntryIntoService, Is.EqualTo(new DateTime(2021, 6, 19)));
            Assert.That(_commandStaff.TypeOfService, Is.EqualTo(TypeOfService.Contract));
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
            expectedInfo += "Название подразделения: Marine corps. ";
            expectedInfo += "Должность: Сaptain.";

            Assert.That(_commandStaff.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}

