using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObjectofYourAffection
{
    class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[] { };
        }

        public string ViewProfile()
        {

            string bioHobbies = "";
            foreach (string hobby in hobbies)
            {
                bioHobbies += hobby + ", ";
            }
            string bio = $"Name: {name}, Age: {age}, City: {city}, Country: {country}, Pronouns: {pronouns}, Hobbies: {bioHobbies}";
            return bio;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
    /*
     * Your friend is super impressed with the Profile class you’ve created!
     Here are a few suggestions to make the Profile class even better:

If you call ViewProfile() before calling SetHobbies(), you’ll get an error because the hobbies field isn’t set to any value. Fix the class so that you can call ViewProfile() without adding hobbies.
Convert the fields into private properties and add validation. For example, users must be at least 18 years of age.
Some users may create a profile with just a name and age. Use optional parameters or create a constructor overload to handle those issues.
     */
}
