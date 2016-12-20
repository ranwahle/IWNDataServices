using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWN.Entities;

namespace IWN.DAL
{
    public class PaymentsDAL
    {
        public List<Payment> GetPaymentsBymemberId(int memberId)
        {
            using (IWNContext context = new IWNContext())
            {
                return context.Payments.Where(payment => payment.MemberId == memberId).ToList();
            }
        }

        public void SavePayment(Payment payment)
        {
            if (payment.TransactionId == 0)
            {
                AddPayment(payment);
            }
            using (IWNContext context = new IWNContext())
            {
                context.Payments.Attach(payment);
                context.Entry(payment).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        private void AddPayment(Payment payment)
        {
            using (IWNContext context = new IWNContext())
            {
                context.Payments.Add(payment);
                context.SaveChanges();
            }
        }
    }
}
