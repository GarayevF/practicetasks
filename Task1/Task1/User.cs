using System;
namespace Task1
{
    public class User : IAccount
    {

        public string FullName { get; set; }
        public string Email { get; set; }

        private string _password;

        public string Password {
            get => _password;
            set
            {
                while (!PasswordChecker(value))
                {
                    Console.WriteLine("sifrede minimum 8 character " +
                        "olmalidir - sifrede en az 1 boyuk herf olmaldir - sifrede en az 1 " +
                        "kicik herf olmalidir - sifrede en az 1 reqem olmalidir");
                    value = Console.ReadLine();
                }
                _password = value;
            }
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public bool PasswordChecker(string pass)
        {
            if (pass.Length < 8) return false;

            bool isUpper = false;
            bool isLower = false;
            bool isDigit = false;

            foreach (char item in pass)
            {
                if (char.IsDigit(item)) isDigit = true;
                else if (char.IsUpper(item)) isUpper = true;
                else if (char.IsLower(item)) isLower = true;
            }

            if (isDigit && isUpper && isLower) return true;
            else return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nFullname : {FullName}\nEmail : {Email}");
        }
    }
}
