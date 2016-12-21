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
                return context.Members.Where(member => member.State != State.Deleted).ToList();
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

        public void DeleteMembers(int memberId)
        {
            using (var context = new IWNContext())
            {
                var memberToDelete = context.Members.First(member => member.MemberId == memberId);
                if (memberToDelete == null)
                {
                    return;
                }

                memberToDelete.State = State.Deleted;
                context.Entry(memberToDelete).State = System.Data.Entity.EntityState.Modified;

               
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
