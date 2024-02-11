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
        // Class larda field lar _ ile başlar.
        // New ile bağımlılığı kaldır. Class ların Interface'lerini yaz.
        // Constructor kullanabilmek için oluşturuldu.
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantservice) // Constructor -> New yapıldığında ilk burası çalışır.
        { 
            _applicantService = applicantservice;
        }

        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " İçin Maske Verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " İÇİN MASKE VERİLEMEDİ!!!");
            }
        }
    }
}
