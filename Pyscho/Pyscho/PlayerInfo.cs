using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyscho
{
    class PlayerInfo
    {
        public string Name;
        public string LastName;
        public int Month;
        public int Day;
        public int Year;

        public PlayerInfo()
        {
        }

        public void DisplayActOneDescription()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The date is " + DateTime.Now.ToShortDateString() + ", the elevator doors open and walk into you the clinic for your doctors appointment, you notice the place is empty. " +
                "You're not sure what is wrong" +
                " but you keep seeing things that happen to not be there. The last time you were here the doctor said you were ok, but you wanted a second opinion." +
                " You walk up to the front desk to check in, you notice the nurse is already smiling and waiting\n");
            Console.ResetColor();
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
        }

        public void NewPlayerInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("You: What is my first name? ");
            Name = Console.ReadLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n" + Name + ": Last name... ");
            LastName = Console.ReadLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nNarrator: You look over to the birthday section.\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ok, my birthday is...");
            Console.ResetColor();

            Console.Write("Month: ");
            Month = int.Parse(Console.ReadLine());
            Console.Write("Date: ");
            Day = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            Year = int.Parse(Console.ReadLine());
        }

       

        public void PaperTop()
        {
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------");
            Console.WriteLine("| First Name: " + Name +              "Middle Initial: _____            Last Name: " + LastName +"       |");
            Console.WriteLine("| Month of Birth: " + Month + "               Date: " + Day + "   Year: " + Year + "            SSN #: 123 - 45 - 6789  " + "   |");
            Console.WriteLine();
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
        }
    }
}
