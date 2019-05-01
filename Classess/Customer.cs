using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestGladeApp.Classess
{
    public class Customer
    {
        #region Properties
        public int Id;
        public string Name;
        public string Surname;
        public string Mail;
        public string Phone;
        #endregion

        #region Contructor
        public Customer()
        {

        }
        public Customer(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Customer(string name, string surname, string mail) : this(name, surname)
        {
            this.Mail = mail;
        }

        public Customer(string name, string surname, string mail, string phone) : this(name, surname, mail)
        {
            this.Phone = phone;
        }
        #endregion
    }
}
