using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MemeberRegistration.Entities.Concrete;

/*
 Created by OlcerTuğba 2021
 */
namespace MemberRegistration.Business.ValidationRoles.FluentValidation
{
    public class MemberValidator:AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(m => m.FirstName).NotEmpty();
            RuleFor(m => m.LastName).NotEmpty();
            RuleFor(m => m.DateOfBirth).NotEmpty();
            RuleFor(m => m.DateOfBirth).LessThan(DateTime.Now);//Kişinin doğum tarihi şuandan küçük olmalıdır.
            RuleFor(m => m.TcNo).NotEmpty();
            RuleFor(m => m.TcNo).Length(11);
            RuleFor(m => m.Email).NotEmpty();
            RuleFor(m => m.Email).EmailAddress();//Email adres formuna uygun olmalıdır.
        }
    }
}
