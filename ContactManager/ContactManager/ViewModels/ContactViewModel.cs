using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactManager.Models;

namespace ContactManager
{
    internal class ContactViewModel:ViewModel
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        private string contactName = "John Doe";
        public string Label { get => contactName; }
    }
}
