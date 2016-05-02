using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class User
    {
        //- Instance variables
        private string email = "N/A";
        private string password = "N/A";

        //- Properties
        public string Email
        {
            get { return this.email; }
            set
            {
                //- Check that the email is valid
                if (!this.validateEmail(value))
                {
                    throw new Exception("Invalid Email, must be a valid email address");
                }

                //- Set the email
                this.email = value; // Skal ændres så den henter fra databasen??
            }
        }
        private bool validateEmail(string emailAddress)
        {
            string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            System.Text.RegularExpressions.Match matches = System.Text.RegularExpressions.Regex.Match(emailAddress, regexPattern);
            return matches.Success;
        }

        public string Password
        {
            get
            {
                throw new Exception("You can't be readin' somebodies password you crazy fool!!!");
            }
            set
            {
                //- Check that the password is at least 4 characters long
                if (value.Length < 4)
                {
                    throw new Exception("Ugyldig adgangskode. Adgangskoden skal være på minimum 4 karakterer");
                }
                //- Check that the password contains 3 classes of symbols (number, lower, UPPER)
                bool containsNumber = false;
                bool containsLower = false;
                bool containsUpper = false;

                foreach (char c in value)
                {
                    if (char.IsDigit(c)) containsNumber = true;
                    if (char.IsLower(c)) containsLower = true;
                    if (char.IsUpper(c)) containsUpper = true;
                }

                if (!(containsNumber && containsLower && containsUpper))
                {
                    throw new Exception("Ugyldig adgangskode. Adgangskoden skal indeholde tal, og både store og små bogstaver");
                }

                //- Set password
                this.password = value;
            }
        }
        public bool CheckPassword(string passwordToCheck)
        {
            if (passwordToCheck == this.password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}