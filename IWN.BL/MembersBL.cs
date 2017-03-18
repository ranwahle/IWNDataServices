using IWN.DAL;
using IWN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWN.BL
{
    public class MembersBL
    {
        private static DateTime MinSQLDate = new DateTime(1900,  1, 1);
        public async  Task< List<Member>> GetAllMembers()
        {
            var members = await new MembersDAL().GetAllMembers();

            members.ForEach(member =>
            {
                if (member.FromDate == MinSQLDate )
                {
                    member.FromDate = null;
                }
            });

            return members;
        }

        public Member AddMember(Member member)
        {
           return new MembersDAL().AddMember(member);
        }

        public void UpdateMember(Member member)
        {
            new MembersDAL().UpdateMember(member);
        }

        public void DeleteMember(int memberId)
        {
            new MembersDAL().DeleteMembers(memberId);
        }
    }
}
