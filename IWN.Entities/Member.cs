using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWN.Entities
{
    public class Member
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public List<Payment> Payments { get; set; }

        public string IdNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        [Key]
        public int MemberId { get; set; }

        public State State { get; set; }

    }
}
