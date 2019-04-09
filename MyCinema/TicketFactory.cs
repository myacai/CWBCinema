using System;
using System.Collections.Generic;
using System.Text;

namespace MyCinema
{
    public class TicketFactory
    {
        public static Ticket CreateTicket(ScheduleItem scheduleItems, Seat seat, string customerName, int discount, string type)
        {
            Ticket ticket = null;
            switch (type)
            {
                case "∆’Õ®∆±":
                    ticket = new Ticket(scheduleItems, seat);
                    break;
                case "‘˘∆±":
                    ticket = new FreeTicket(scheduleItems, seat, customerName);
                    break;
                case "—ß…˙∆±":
                    ticket = new StudentTicket(scheduleItems, seat, discount);
                    break;
            }
            return ticket;
        }
    }
}
