using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoArv.model
{
    public class Employee: Ansat
    {
        // instans felter
        private int _hourPayment;
        private int _amountOfHours;

        // properties
        public int HourPayment
        {
            get { return _hourPayment; }
            set { _hourPayment = value; }
        }

        public int AmountOfHours
        {
            get { return _amountOfHours; }
            set { _amountOfHours = value; }
        }

        // constructors
        public Employee():base()
        {
            _hourPayment = 0;
            _amountOfHours = 0;
        }

        public Employee(int id, string name, string email, int hour, int amount):
            base( id, name,  email)
        {
            _hourPayment = hour;
            _amountOfHours = amount;
        }


        // metode

        public override int Salary()
        {
            string navn = _name;
            return _hourPayment * _amountOfHours;
        }



        // tostring

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Email)}={Email}, {nameof(HourPayment)}={HourPayment.ToString()}, {nameof(AmountOfHours)}={AmountOfHours.ToString()}}}";
        }


    }
}
