using System;
using System.Collections.Generic;
using System.Linq;
using AddressbookApp.Droid;
using AddressbookApp.Interface;
using Android.App;
using Xamarin.Contacts;
using Contact = AddressbookApp.Interface.Contact;

[assembly: Xamarin.Forms.Dependency(typeof(Contacts))]
namespace AddressbookApp.Droid
{
    class Contacts : IContacts
    {
        public IEnumerable<Contact> Working()
        {
            var addressbook = new AddressBook(Application.Context);
            foreach (var p in addressbook)
            {
                var contact = new Contact
                {
                    Name = p.DisplayName,
                    PhoneNumber = string.Join(", ", p.Phones)
                };
                yield return contact;
            }
        }

        public IEnumerable<Contact> Exception()
        {
            var addressbook = new AddressBook(Application.Context);
            return addressbook.Select(p => new Contact
            {
                Name = p.DisplayName,
                PhoneNumber = string.Join(", ", p.Phones)
            });
        }
    }
}