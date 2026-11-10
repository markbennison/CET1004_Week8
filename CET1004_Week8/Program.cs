using static CET1004_Week8.Ticket;

namespace CET1004_Week8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticketing();
            /*ask 2 — Read input with validation loop
1. In Main(): ask the user for the ticket type.
2. If input is not "Adult" or "Child", print an error message and re-prompt (loop).
3. Ask the user whether the ticket is for a weekday (Y/N), and validate in the same way (loop)
Task 3 — Create the Object
1. Create a Ticket object using the input provided by the user
Task 4 — Call the Method
1. Call the CalculatePrice() method on the object
2. Store the returned value in a variable
Task 5 — Display the Result
1. Display the total ticket price to the user in a clear format, e.g. “Ticket*/


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
