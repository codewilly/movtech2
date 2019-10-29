using movtech.Domain.Entities.Abstract;
using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class TrafficTicket : Address
    {
        public int Id { get; set; }

        public Driver Driver { get; set; }

        public Vehicle Vehicle { get; set; }

        public DateTime TrafficTicketDate { get; set; }

        public DateTime BilletExpiration { get; set; }

        public DateTime? PaymentDate { get; set; }
        
        public decimal Cost { get; set; }

        public int Points { get; set; }

        public TrafficTickeLevel Level { get; set; }

        public string Description { get; set; }

        public bool WasPaid { get; set; }


        public string Validate()
        {
            return "ok";
        }

        public void Pay()
        {
            if (WasPaid)
            {
                throw new InvalidOperationException("Esta multa já se encontra paga!");
            }

            PaymentDate = DateTime.Now;
            WasPaid = true;

        }

    }
}
