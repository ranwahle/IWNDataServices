using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IWN.Entities;
using System.Runtime.Serialization;

namespace IWNDataServices.Models
{
   
    public class ModelMember
    {
       
        public ModelMember()
        {

        }

        public static ModelMember BuildModelMember(IWN.Entities.Member member)
        {
            var newMember = new ModelMember();
            newMember.Address = member.Address;
            newMember.City = member.City;
            newMember.EmailAddress = member.EmailAddress;
            newMember.FirstName = member.FirstName;
            newMember.IdNumber = member.IdNumber;
            newMember.LastName = member.LastName;
            newMember.MemberId = member.MemberId;
            newMember.State = member.State;
            newMember.PhoneNumber = member.PhoneNumber;
             if (member.Payments != null && member.Payments.Count != 0)
            {
                newMember.ToDate = member.Payments.Max(p => p.PaymentDate).AddYears(1);
            }

            return newMember;


        }

        public string Address { get;  set; }
        public string City { get;  set; }
        public string EmailAddress { get;  set; }
        public string FirstName { get;  set; }
        public string IdNumber { get;  set; }
        public string LastName { get;  set; }
        public int MemberId { get;  set; }
        public State State { get;  set; }
        public DateTime?  ToDate { get; set; }

        public string PhoneNumber { get; set; }
    }
}