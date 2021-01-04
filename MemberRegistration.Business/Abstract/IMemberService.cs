using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemeberRegistration.Entities.Concrete;

/*
 Created by OlcerTuğba 2021
 */
namespace MemberRegistration.Business.Abstract
{
    public interface IMemberService
    {
        void Add(Member member);
    }
}
