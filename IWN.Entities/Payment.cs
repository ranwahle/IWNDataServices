using System;
using System.ComponentModel.DataAnnotations;

namespace IWN.Entities
{
    public class Payment
    {

        public DateTime PaymentDate { get; set; }

        public decimal Sum { get; set; }

        public bool Accepted { get; set; }

        [Key]
        public int TransactionId { get; set; }
    }
}