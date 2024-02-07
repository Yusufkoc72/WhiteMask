using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        public IApplicantService _applicantService;
        PttManager(IApplicantService applicantService) {
            _applicantService = applicantService;
        }
        public void GetMask(Citizen citizen)
        {
            if (_applicantService.CheckCitizen(citizen))
            {
                Console.WriteLine(citizen.FirstName + " " + citizen.LastName + " kişisine maske verilebilir");
            }
            else
            {
                Console.WriteLine(citizen.FirstName + " " + citizen.LastName + "kişine maske verilemiyor");
            }
        }
    }
}
