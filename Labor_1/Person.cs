using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    internal class Person
    {
        private string _name;
        private string _surname;
        private Date _dob;

        public void setName(string name)
        { 
            _name = name; 
        }
        public string name()
        {
            return _name;
        }
         public void setSurname(string surname)
        { 
            _surname = surname; 
        }
        public string surname() 
        {
            return _surname;
        }
        public int setDob(uint day, MONTH month, int year)
        {
            // Array mit der Anzahl der Tage in jedem Monat
            // (Index 0 bleibt leer, da Monate bei 1 beginnen)
            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Schaltjahrüberprüfung für den Februar
            if (month == MONTH.FEB && (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)))
            {
                daysInMonth[(int)MONTH.FEB] = 29;  // Februar hat im Schaltjahr 29 Tage
            }

            // Überprüfen, ob der Tag für den angegebenen Monat gültig ist
            if (day < 1 || day > daysInMonth[(int)month])
            {
                return 1;  // ERROR zurückgeben, wenn der Tag ungültig ist
            }

            // Wenn das Datum gültig ist, wird es in der Struktur _dob gespeichert
            _dob.day = (int)day;
            _dob.month = month;
            _dob.year = year;

            return 0;  // OK zurückgeben, wenn alles in Ordnung ist
        }
        public Date dob()
        {
            return _dob;
        }
       
    }


}
