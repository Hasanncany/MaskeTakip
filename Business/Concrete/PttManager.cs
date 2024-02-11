using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager
    {
        // Class larda field lar _ ile başlar.
        // New ile bağımlılığı kaldır. Class ların Interface'lerini yaz.
        // Constructor kullanabilmek için oluşturuldu.
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantservice) // Constructor -> New yapıldığında çalışır. İLK!
        { 
            _applicantService = applicantservice;
        }

        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " İçin Maske Verildi.");
            }
        }
    }
}
