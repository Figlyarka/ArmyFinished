using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Army
{
    public class Serviceman : IComparable<Serviceman>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly int NumMillitaryTicket;
        public string Rank;
        public int NumMillitaryUnit { get; set; }
        public DateTime DateOfEntryIntoService;
        public double ServiceLife
        {
            get => (DateTime.Now - DateOfEntryIntoService).Days;
        }

        public TypeOfService TypeOfService;

        public Serviceman(string name, string surname, int numMillitaryTicket)
        {
            Name = name;
            Surname = surname;
            NumMillitaryTicket = numMillitaryTicket;
        }
        public virtual string GetInfo()
        {
            var typeofservice = "";
            if (TypeOfService == TypeOfService.Contract)
                typeofservice = "контракт";
            if (TypeOfService == TypeOfService.Urgent)
                typeofservice = "срочное";
            return $"{Name} {Surname}. Номер билета: {NumMillitaryTicket}. Номер военной части: {NumMillitaryUnit}. " +
                   $"Звание: {Rank}. Дата поступления на службу: {DateOfEntryIntoService}. Cрок службы: {ServiceLife}. " +
                   $"Тип службы: {typeofservice}.";
        }

        public int CompareTo(Serviceman other)
        {
            if (NumMillitaryUnit != other.NumMillitaryUnit)
                return NumMillitaryUnit.CompareTo(other.NumMillitaryUnit);
            if (Surname != other.Surname)
                return Surname.CompareTo(other.Surname);
            return Name.CompareTo(other.Name);
        }

        public class CommandStaff : Serviceman
        {
            public string DivisionName { get; set; }
            public string Post { get; set; }

            public CommandStaff(string name, string surname, int numMillitaryTicket, string divisionName, string post) : base(name, surname, numMillitaryTicket)
            {
                DivisionName = divisionName;
                Post = post;
            }

            public override string GetInfo()
            {
                return base.GetInfo() + $" Название подразделения: {DivisionName}. Должность: {Post}.";
            }
        }

        public class ManagementBodies : Serviceman
        {
            public string CountyName { get; set; }
            public string Post { get; set; }

            public ManagementBodies(string name, string surname, int numMillitaryTicket, string countyName, string post) : base(name, surname, numMillitaryTicket)
            {
                CountyName = countyName;
                Post = post;
            }

            public override string GetInfo()
            {
                return base.GetInfo() + $" Название округа: {CountyName}. Должность: {Post}.";
            }
        }

        public class Veteran : Serviceman
        {
            public int LengthOfService { get; set; }
            public int PensionAmount { get; set; }

            public Veteran(string name, string surname, int numMillitaryTicket, int lengthOfService, int pensionAmount) : base(name, surname, numMillitaryTicket)
            {
                LengthOfService = lengthOfService;
                PensionAmount = pensionAmount;
            }

            public override string GetInfo()
            {
                return base.GetInfo() + $" Выслуга лет: {LengthOfService} лет. Размер пенсии: {PensionAmount} руб.";
            }
        }

    }
}