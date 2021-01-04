using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.DataAccess.Concrete.EntityFramework.Mappings;
using MemeberRegistration.Entities.Concrete;
/*
 Created by OlcerTuğba 2021
 */
namespace MemberRegistration.DataAccess.Concrete.EntityFramework
{
    public class MembershipContext : DbContext
    {

        public MembershipContext()
        {
            Database.SetInitializer<MembershipContext>(null);
        }

        public DbSet<Member> Members { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
        }

    }
}
