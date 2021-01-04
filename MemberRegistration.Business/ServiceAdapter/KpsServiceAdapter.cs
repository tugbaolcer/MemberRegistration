using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.KpsServiceReference;
using MemeberRegistration.Entities.Concrete;

/*
 Created by OlcerTuğba 2021
 */
namespace MemberRegistration.Business.ServiceAdapter
{
    //MicroService Mimari
    public class KpsServiceAdapter:IKpsService
    {
        public bool ValidateUser(Member member)
        {
            KpsServiceReference.KPSPublicSoapClient client=new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(member.TcNo),
                member.FirstName.ToUpper(), member.LastName.ToUpper(), member.DateOfBirth.Year);
        }
    }
}
