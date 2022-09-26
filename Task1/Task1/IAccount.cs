using System;
namespace Task1
{
    public interface IAccount
    {
        public bool PasswordChecker(string pass);
        public void ShowInfo();
    }
}
