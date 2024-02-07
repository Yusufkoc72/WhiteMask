using Business.Abstract;
using Entities.Concrete;
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
            return true;
        }

        public List<Citizen> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
