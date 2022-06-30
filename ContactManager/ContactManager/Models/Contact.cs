using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public enum Gender
    {
        m,
        f,
        x
    }

    public class Contact
    {
        public int Id { get; set; }
        public string AvatarPath { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public bool Married { get; set; }
        public double Weight { get; set; }

        public string FullName
        {
            get => $"{Name} {LastName}";
        } 

        public Contact(int id, string avatarPath, string name, string lastName, Gender gender, bool married, double weight)
        {
            Id = id;
            AvatarPath = avatarPath;
            Name = name;
            LastName = lastName;
            Gender = gender;
            Married = married;
            Weight = weight;
        }

    }
}
