using System;

namespace Task2
{
    class Program
    {

        /*

            Task - 2
            Student class-i yaradin:

            Fullname
            GroupNo
            Age
            GroupNo memberi ardicil olaraq bir boyuk verf ve 3 reqemli bir natural ededed
            ibaret olmalidir (misalcun: P216) Fullname memberi ad ve soyadi ifade edir,ona
            gore de fullname value-u ad ve soyaddan ibaret olmalidir.Formati ad +bosluq+soyad
            seklinde olmalidir (misalcu: "Abbas Quliyev")

            static CheckGroupNo() - parametr olaraq gonderilen groupNo value-nun dogru olub olmamasini
            yoxlayir ve true/false qaytrir static CheckFullname() - parametr olaraq gonderilen fullname
            value-nun dogru olub olmamasini yoxlayir ve true/false qaytrir

            ps:Student yaradilarken butun deyerlerin verilmesi mecburidir.Main hissesinde Student
            yaratmaq ucun console-dan deyer qebul edin ve gonderilmis deyerler duzgun olanadek yeniden
            daxil edilmesini temin edin.

        */

        static void Main(string[] args)
        {
            Console.WriteLine("Ad ve Soyad daxil edin");
            string Fullname = Console.ReadLine();
            while (!Student.CheckFullname(Fullname))
            {
                Console.WriteLine("Ad ve Soyad duzgun qeyd olunmayib. Yeniden daxil edin.");
                Fullname = Console.ReadLine();
            }


            Console.WriteLine("Qrup nomresi daxil edin daxil edin");
            string GroupNo = Console.ReadLine();
            while (!Student.CheckGroupNo(GroupNo))
            {
                Console.WriteLine("GroupNo memberi ardicil olaraq bir boyuk verf ve 3 reqemli bir natural " +
                    "ededed ibaret olmalidir. Yeniden daxil edin.");
                GroupNo = Console.ReadLine();
            }

            Console.WriteLine("Yas daxil edin");
            byte.TryParse(Console.ReadLine(), out byte Age);

            Student stu1 = new Student(Fullname, GroupNo, Age);

        }
    }
}
