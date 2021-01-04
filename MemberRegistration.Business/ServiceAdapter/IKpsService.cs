using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemeberRegistration.Entities.Concrete;

/*
 Created by OlcerTuğba 2021
 */
namespace MemberRegistration.Business.ServiceAdapter
{
    public interface IKpsService
    {
        bool ValidateUser(Member member);
    }
}
