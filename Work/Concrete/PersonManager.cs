using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask()
        {
            throw new NotImplementedException();
        }

        public bool CheckCitizen(Citizen citizen)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(citizen.IdentityNumber, citizen.FirstName, citizen.LastName, citizen.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Citizen> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
