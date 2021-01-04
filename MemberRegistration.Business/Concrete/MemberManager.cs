using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.KpsServiceReference;
using MemberRegistration.Business.ServiceAdapter;
using MemberRegistration.Business.ValidationRoles.FluentValidation;
using MemberRegistration.DataAccess.Abstract;
using MemeberRegistration.Entities.Concrete;
/*
 Created by OlcerTuğba 2021
 */
namespace MemberRegistration.Business.Concrete
{
    public class MemberManager:IMemberService
    {
        private IMemberDal _memberDal;
        private IKpsService _kpsService;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            CheckIfMemberExists(member);
            CheckIfUserValidFromKps(member);
            _memberDal.Add(member);
        }

        private void CheckIfUserValidFromKps(Member member)
        {
            //MicroService Mimarisini kontrol ediyoruz.
            if (_kpsService.ValidateUser(member) == false)
            {
                throw new Exception("User Not Found !");
            }
        }

        private void CheckIfMemberExists(Member member)
        {
            //Kullanıcı daha önce kayıt var mı yok mu ona bakar.
            if (_memberDal.Get(m => m.TcNo == member.TcNo) != null)
            {
                throw new Exception("User Available !");
            }
        }
    }
}
