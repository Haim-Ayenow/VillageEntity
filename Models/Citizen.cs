using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Village.Models
{
    public class Citizen
    {
        public int Id;
        public string FName;
        public string NameOfDad;
        public string Gender;
        public bool BornInVillage;
        public DateTime BirthDay;

        public Citizen(int id, string fName, string nameOfDad, string gender, bool bornInVillage, DateTime birthDay)
        {
            Id = id;
            FName = fName;
            NameOfDad = nameOfDad;
            Gender = gender;
            BornInVillage = bornInVillage;
            BirthDay = birthDay;
        }
    }
}