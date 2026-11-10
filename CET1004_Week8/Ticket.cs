using System;
using System.Collections.Generic;
using System.Text;

namespace CET1004_Week8
{
    internal class Ticket
    {
        public enum TicketType
        {
            Adult,
            Child
        }

        TicketType ticketType;
        bool isWeekday;

        public Ticket(TicketType ticketType, bool isWeekday)
        {
            this.ticketType = ticketType;
            this.isWeekday = isWeekday;
        }

        public string CalculatePrice()
        {
            int price = 0;
            string priceString = "";
            string freebie = "";

            if (ticketType == TicketType.Adult)
            {
                price = 10;
            }
            else if (ticketType == TicketType.Child)
            {
                price = 6;
            }

            if (isWeekday)
            {
                price -= 2;
                if (ticketType == TicketType.Child)
                {
                    freebie = "\nFree small popcorn voucher!";
                }
            }

            priceString = $"Price: £{price.ToString("0.00")}";
            return priceString + freebie;
        }
    }
}
