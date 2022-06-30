using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactManager.Models;

namespace ContactManager
{
    internal class MainWindowViewModel : ViewModel
    {
        public List<Contact> Contacts = new
        {
            new(){ Id = 12, AvatarPath = "kljhdflkshd", Name = "John", LastName = "Doe", Gender = Gender.m, Married = false, Weight = 100.2 };
        }
        Contact contact1 = new(12, "kljhdflkshd", "John", "Doe", Gender.m, false, 100.2);



        public List<string> Name
        {
            get => contact1.Name;
            set
            {
                if (contact1.Name != value)
                {
                    contact1.Name = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
