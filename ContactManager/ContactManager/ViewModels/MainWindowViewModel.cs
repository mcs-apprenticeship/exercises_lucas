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
        private List<Contact> contacts = new()
        {
            new(1,"kljhdflkshd","John", "Doe", Gender.m, true, 100.2 ),
            new(2,"kljhdflkshd","John1", "Doe", Gender.m, false, 100.2 ),
            new(3,"kljhdflkshd","John2", "Doe", Gender.m, true, 100.2 ),
        };

        public List<Contact> Contacts
        {
            get => contacts;
            set
            {
                if (contacts != value)
                {
                    Contacts = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int selectedContact = 1;
        public int SelectedContact 
        { 
            get => selectedContact;
            set
            {
                if(selectedContact != value)
                {
                    selectedContact = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(Contact));

                }
            }
        }

        public bool isMale = false;
        public bool IsMale 
        {
            get => isMale;
            set
            {
                if (isMale != value)
                {
                    isMale = value;
                    NotifyPropertyChanged();
                    Contact.Gender = Gender.m;
                }
            }
        }

        public bool isFemale = false;
        public bool IsFemale
        {
            get => isFemale;
            set
            {
                if (isFemale != value)
                {
                    isFemale = value;
                    Contact.Gender = Gender.f;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool isOther = true;
        public bool IsOther
        {
            get => isOther;
            set
            {
                if (isOther != value)
                {
                    isOther = value;
                    Contact.Gender = Gender.x;
                    NotifyPropertyChanged();
                }
            }
        }

        public Contact Contact 
        { 
            get => contacts[SelectedContact];
            set
            {
                if (contacts[SelectedContact] != value)
                {
                    NotifyPropertyChanged();
                    contacts[SelectedContact] = value;
                }
            } 
        }


    }
}
