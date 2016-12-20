using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IWN.Entities
{
    public class Payment
    {

        public DateTime PaymentDate { get; set; }

        public decimal Sum { get; set; }

        public bool Accepted { get; set; }

        public int MemberId { get; set; }

        [ForeignKey("MemberId")]
        public Member Member { get; set; }

        [Key]
        public int TransactionId { get; set; }
    }
}