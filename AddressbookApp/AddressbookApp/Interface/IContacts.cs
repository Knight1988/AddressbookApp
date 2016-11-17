using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookApp.Interface
{
    public interface IContacts
    {
        IEnumerable<Contact> Working();
        IEnumerable<Contact> Exception();
    }

    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
