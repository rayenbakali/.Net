using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {

        public DateOnly BirthDate { get; set; }
        public int PassportNumber { get; set; }

        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "Firstname="+this.FirstName+"LastName="+this.LastName;
        }
        //public bool CheckProfile(string FirstName,string LastName)
        //    {
        //        return FirstName==this.FirstName && LastName==this.LastName
        //     ;
        //    }

        //public bool CheckProfile(string FirstName, string LastName, string email)
        //{
        //    return FirstName == this.FirstName && LastName == this.LastName
        //    && email == this.EmailAdress;
        //}
        public bool CheckProfile(string FirstName, string LastName, string email=null)
        {

            if (email == null) {
                return FirstName == this.FirstName && LastName == this.LastName;
                    }
            else { 
                return FirstName == this.FirstName && LastName == this.LastName
            && email == this.EmailAdress;
            }
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }

    }
}
