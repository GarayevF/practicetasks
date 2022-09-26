using System;

namespace Task3
{
    class Program
    {

        /*
            Task-3
            Asagidaki parameterlerden ibret Employee class-i yaradirsini
            No - iscinin nomresi company-e elave edilme sirasina gore olur (company-e birinic elave
            edilen iscinin no deyrei 1, ikincide 2 olsun)
            Fullname
            Salary
            Position - iscinin sirketdeki vezifesi
            Asagidaki parameterlerden ibaret Company class-i yaradirsiniz:
            Name - Company adini ifade edir. Company adi boyuk herfle baslamalidir ve
            icerisinde herf,reqem ve bosluqdan basqa hec ne (simvol) ola bilmez
            Limit - Company-da ola bilecek maximum isci sayini ifade edir
            Employees - Company-in icerisindeki iscilerin siyahisini ifade edir (Employee typda array)
            AddEmoployee() - metod prameter olaraq  Employee  typinda obyekt qebul edir ve onu eger
            Company - da yer varsa  Company -nin  Employees arrayine elave edir
            GetEmployees() - bu metod  Employee-larin siyahisini geriye qaytarir
         */

        static void Main(string[] args)
        {
            Company comp = new Company();
            comp.Limit = 5;
            
            Console.WriteLine("Sirket adi daxil edin");
            comp.Name = Console.ReadLine();

            Employee employee1 = new Employee();
            employee1.Fullname = "Farid1 Garayev";
            employee1.Position = "Junior Full Stack Developer";
            employee1.Salary = 1500;
            comp.AddEmoployee(employee1);

            Employee employee2 = new Employee();
            employee2.Fullname = "Farid2 Garayev";
            employee2.Position = "Middle Full Stack Developer";
            employee2.Salary = 2500;
            comp.AddEmoployee(employee2);

            Employee employee3 = new Employee();
            employee3.Fullname = "Farid3 Garayev";
            employee3.Position = "Senior Full Stack Developer";
            employee3.Salary = 3500;
            comp.AddEmoployee(employee3);

            Employee employee4 = new Employee();
            employee4.Fullname = "Farid4 Garayev";
            employee4.Position = "Senior Full Stack Developer";
            employee4.Salary = 4500;
            comp.AddEmoployee(employee4);


            foreach (Employee item in comp.GetEmployees())
            {
                Console.WriteLine(item.Fullname);
            }
        }
    }
}
