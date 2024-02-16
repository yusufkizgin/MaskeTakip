using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concerete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _service;

        public PttManager(IApplicantService service)
        {
            _service = service;
        }

        public void GiveMask(Person person)
        {
            if (_service.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " İçin Maske Verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " İçin Maske Verilemedi!");
            }
        }
    }
}
