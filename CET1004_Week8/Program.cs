using static CET1004_Week8.Ticket;

namespace CET1004_Week8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticketing();
        }

        static void Ticketing()
        {
            TicketType ticketType = TicketType.Adult;
            bool isWeekday = false;

            bool validInput = false;

            do
            {
                Console.WriteLine("Enter ticket type (Adult/Child):");
                string ticketTypeInput = Console.ReadLine();

                if (ticketTypeInput.ToLower() == "adult")
                {
                    validInput = true;
                    ticketType = TicketType.Adult;
                }
                else if (ticketTypeInput.ToLower() == "child")
                {
                    validInput = true;
                    ticketType = TicketType.Child;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'Adult' or 'Child'.");
                }

            } while (!validInput);

            validInput = false;
            do
            {
                Console.WriteLine("Is the ticket for a weekday? (Y/N):");
                string weekdayInput = Console.ReadLine();

                if (weekdayInput.ToLower() == "y")
                {
                    validInput = true;
                    isWeekday = true;
                }
                else if (weekdayInput.ToLower() == "n")
                {
                    validInput = true;
                    isWeekday = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
                }

            } while (!validInput);



            Ticket ticket = new Ticket(ticketType, isWeekday);

            string printedTicket = ticket.CalculatePrice();

            Console.WriteLine(printedTicket);

            Console.ReadKey();
        }
    }
}
