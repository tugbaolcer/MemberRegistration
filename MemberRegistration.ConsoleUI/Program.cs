using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.Concrete;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemeberRegistration.Entities.Concrete;
/*
 Created by OlcerTugba 2021
 */
namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member{FirstName = "Tuğba", LastName = "ÖLÇER", DateOfBirth = new DateTime(1989,9,9), TcNo = "TcNoGirilir", Email = "tugbaolcer@hotmail.com"});
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
