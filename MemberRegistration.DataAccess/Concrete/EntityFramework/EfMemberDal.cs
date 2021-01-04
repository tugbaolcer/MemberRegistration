using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess.EntityFramework;
using MemberRegistration.DataAccess.Abstract;
using MemeberRegistration.Entities.Concrete;
/*
 Created by OlcerTuğba 2021
 */
namespace MemberRegistration.DataAccess.Concrete.EntityFramework
{
    public class EfMemberDal:EfEntityRepositoryBase<Member, MembershipContext>, IMemberDal
    {
    }
}
