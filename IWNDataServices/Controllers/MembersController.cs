using IWN.BL;
using IWN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace IWNDataServices.Controllers
{
    [EnableCors("*", "*", "*")]
  
    public class MembersController : ApiController
    {
        [AllowAnonymous]
        [Route("api/Members"), HttpGet]
        public async Task< List<Models.ModelMember>> GetAllMembers()
        {
            var members = await  new MembersBL().GetAllMembers();
            return ProcessResult(members);
        }

        private List<Models.ModelMember> ProcessResult(List<IWN.Entities.Member> members)
        {
            List<Models.ModelMember> result = new List<Models.ModelMember>();
            members.ForEach(member => result.Add( Models.ModelMember.BuildModelMember(member)));
            return result;
        }

        [Route("api/Members"), HttpPost]
       
        public Member AddMember(Member member)
        {
           return  new MembersBL().AddMember(member);
        }

        [Route("api/Members"), HttpPut]

        public void UpdateMember(Member member)
        {
            new MembersBL().UpdateMember(member);
        }

        [Route("api/Members/{memberId:int}"), HttpDelete]
        public void DeleteMember(int memberId)
        {
            new MembersBL().DeleteMember(memberId);
        }




    }
}
