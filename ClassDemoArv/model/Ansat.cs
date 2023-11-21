using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassDemoArv.model
{
    public abstract class Ansat
    {
        // instans felter 
        protected int _id;
        protected string _name;
        protected string _email;


        // properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        // constructors
        public Ansat()
        {
            _id = -1;
            _name = "";
            _email = "";

        }

        public Ansat(int id, string name, string email)
        {
            _id = id;
            _name = name;
            _email = email;
        }




        // methods

        //public virtual int Salary()
        //{
        //    return 0;
        //}

        public abstract int Salary();






        // toString

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Email)}={Email}}}";
        }

    }
}
