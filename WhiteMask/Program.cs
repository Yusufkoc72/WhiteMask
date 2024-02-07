using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using Entities.Concrete;


Citizen citizen1 = new Citizen();
citizen1.FirstName = "1";
citizen1.LastName = "2";
citizen1.DateOfBirth = 1;
citizen1.IdentityNumber = 1;

PttManager pttManager = new PttManager(new PersonManager());

pttManager.GetMask(citizen1);
