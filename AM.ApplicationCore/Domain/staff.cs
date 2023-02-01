using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class staff:Passenger
    {
        public DateOnly EmployementDate { get; set; }

        public string Function { get; set; }

        public double Salary { get; set; }


        public override string ToString()
        {
            return "EmployementDate"+this.EmployementDate+"Salary" + this.Salary;
        }

        public virtual void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am a staff member");
        }
    }

}
