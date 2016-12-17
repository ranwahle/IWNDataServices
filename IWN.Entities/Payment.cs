using System;

namespace IWN.Entities
{
    public class Payment
    {

        public DateTime PaymentDate { get; set; }

        public decimal Sum { get; set; }

        public bool Accepted { get; set; }
    }
}