using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MemberRegistration.Business.ValidationRoles.FluentValidation;
using MemeberRegistration.Entities.Concrete;
using Ninject.Modules;
/*
 Created by OlcerTugba 2021
 */
namespace MemberRegistration.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Member>>().To<MemberValidator>().InSingletonScope();
        }
    }
}
