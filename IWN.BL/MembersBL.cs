﻿using IWN.DAL;
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
        public async  Task< List<Member>> GetAllMembers()
        {
            return await new MembersDAL().GetAllMembers();
        }

        public void AddMember(Member member)
        {
            new MembersDAL().AddMember(member);
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
