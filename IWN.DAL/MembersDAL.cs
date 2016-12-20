using IWN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWN.DAL
{
    public class MembersDAL
    {
        public List<Member> GetAllMembers()
        {
            using(var context = new IWNContext())
            {
                return context.Members.ToList();
            } 
        }

        public void AddMember(Member member)
        {
            if (member.MemberId != 0)
            {
                UpdateMember(member);
            }
            else
            {
                using (var context = new IWNContext())
                {
                    context.Members.Add(member);
                    context.SaveChanges();
                }
            }
        }

        public void DeleteMembers(Member member)
        {
            using (var context = new IWNContext())
            {
                context.Members.Attach(member);
                var payments = context.Payments.Where(payment => payment.MemberId == member.MemberId);
                foreach (var payment in payments)
                {
                    context.Entry(payment).State = System.Data.Entity.EntityState.Deleted;
                }

                context.Entry(member).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void UpdateMember(Member member)
        {
            using (var context = new IWNContext())
            {
                context.Members.Attach(member);
                context.Entry(member).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
