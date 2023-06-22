using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Army
{
    
    public class Serviceman 
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

        public string GetInfo()
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
    }
}