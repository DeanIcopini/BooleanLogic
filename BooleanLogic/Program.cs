using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            // Simple program for determining applicant approval status, based on multiple questions.
            // What is your age?

            Console.WriteLine("What is your age?");
            string userAgeInput = Console.ReadLine();
            int userAge = Convert.ToUInt16(userAgeInput);

            // Have you ever had a DUI?

            Console.WriteLine("Have you ever had a DUI? " + "Please enter true or false.");
            string userDuiInput = Console.ReadLine();
            bool userDui = Convert.ToBoolean(userDuiInput);

            // How many speeding tickets do you have?

            Console.WriteLine("How many speeding tickets do you have? ");
            string userTicketInput = Console.ReadLine();
            int userTicket = Convert.ToUInt16(userTicketInput);

            // **QUALIFIERS**
            // Applicants must be over 15 years old.
            // Applicants must not have any DUI's.
            // Applicants must not have more than 3 speeding tickets.

            Console.WriteLine("Look here to see if you have been approved for insurance.");
            Console.WriteLine
                (userAge > 15 && userDui == false && userTicket < 3);

            Console.ReadLine();
        }
    }
}
