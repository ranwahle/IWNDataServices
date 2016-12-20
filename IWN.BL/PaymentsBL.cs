using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWN.Entities;
using IWN.DAL;

namespace IWN.BL
{
    public class PaymentsBL
    {
        public List<Payment> GetPayemntsByMemberId(int memberId)
        {
            return new PaymentsDAL().GetPaymentsBymemberId(memberId);
        }

        public void SavePayment(Payment payment)
        {
            new PaymentsDAL().SavePayment(payment);
        }
    }
}
