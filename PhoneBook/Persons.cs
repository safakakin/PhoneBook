using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Persons
    {
        private string _name;
        private string _surname;
        private string _phoneNumber;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public Persons(string _name, string _surname, string _phoneNumber)
        {
            Name = _name;
            Surname = _surname;
            PhoneNumber = _phoneNumber;

        }
        public Persons() { }

    }
}
