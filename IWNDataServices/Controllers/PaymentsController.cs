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
    public class PaymentsController : ApiController
    {
        [Route("api/Payments/{memberId:int}")]
        [HttpGet]
        public List<Payment> GetPayments(int memberId)
        {
            return new PaymentsBL().GetPayemntsByMemberId(memberId);
        }

        public void SavePayment(Payment payment)
        {
            new PaymentsBL().SavePayment(payment);
        }


    }
}
