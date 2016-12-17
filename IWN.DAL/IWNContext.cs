using IWN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWN.DAL
{
    internal class IWNContext : DbContext
    {
        public   DbSet<Member> Members { get; set; }

        public DbSet<Payment> Payments { get; set; }
    }
}
