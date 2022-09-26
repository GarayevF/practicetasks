using System;

namespace Task1
{
    class Program
    {
        /*
            Task-1

            Asagidaki metodlari olan IAccount interface yaradirsiniz :

            PasswordChecker() - parameter oalraq string sifreni qebul edir
            ShowInfo()
            Asagidaki memberlerden ibaret User class-i yaradirsiniz ve IAccount-u implement edirsiniz:

            Fullname

            Email

            Password

            PasswordChecker() - PasswordChecker metodu - gelen string sifre deyerinin sertleri
            odeyib odemediyini yoxlayib true/false deyer qaytarir. Şertler: - sifrede minimum 8 character
            olmalidir - sifrede en az 1 boyuk herf olmaldir - sifrede en az 1 kicik herf olmalidir - sifrede en az 1 reqem olmalidir

            ShowInfo() - bu metod Console-a user-in Fullanem ve email-inin yazdirir

            ps: User classina IAccount interface-i implement edilir.User yarandigi zaman email ve
            sifre teyin edilmesi mecburidir.Usere sifre teyin edilerken sifrenin PasswordChecker
            metodunun sertlerini odemesi lazimdir.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Email daxil edin");
            string email = Console.ReadLine();

            Console.WriteLine("Sifre daxil edin");
            string password = Console.ReadLine();

            User user1 = new User(email, password);

            user1.FullName = "Farid Garayev";
            user1.ShowInfo();
        }
    }
}
