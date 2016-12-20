using IWN.BL;
using IWN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace IWNDataServices.Controllers
{
    [EnableCors("*", "*", "*")]
  
    public class MembersController : ApiController
    {
        [AllowAnonymous]
        [Route("api/Members"), HttpGet]
        public List<Member> GetAllMembers()
        {
            return new MembersBL().GetAllMembers();
        }

      
        [Route("api/Members"), HttpPost]
       
        public void AddMember(Member member)
        {
            new MembersBL().AddMember(member);
        }

        [Route("api/Members"), HttpPut]

        public void UpdateMember(Member member)
        {
            new MembersBL().UpdateMember(member);
        }

        [Route("api/Members"), HttpDelete]
        public void DeleteMember(Member member)
        {
            new MembersBL().DeleteMember(member);
        }




    }
}
