using System;
namespace Task2
{
    public class Student
    {
        private string _fullname;
        public string Fullname {
            get => _fullname;
            set
            {
                while (!CheckFullname(value))
                {
                    Console.WriteLine("Ad ve Soyad duzgun qeyd olunmayib. Yeniden daxil edin.");
                    value = Console.ReadLine();
                }
                _fullname = value;
            }
        }

        private string _groupNo;
        public string GroupNo {
            get => _groupNo;
            set
            {
                while (!CheckGroupNo(value))
                {
                    Console.WriteLine("GroupNo memberi ardicil olaraq bir boyuk verf ve 3 reqemli bir natural " +
                        "ededed ibaret olmalidir. Yeniden daxil edin.");
                    value = Console.ReadLine();
                }
                _groupNo = value;
                Console.WriteLine("done");
            }
        }

        public byte Age { get; set; }


        public Student(string fullname, string groupno, byte age)
        {
            Fullname = fullname;
            GroupNo = groupno;
            Age = age;
        }

        public static bool CheckGroupNo(string str)
        {
            if (str.Length != 4) return false;

            bool NoChecker = int.TryParse($"{str[1]}{str[2]}{str[3]}", out int a);
            
            if (char.IsUpper(str[0]) && NoChecker) return true;
            else return false;  
        }

        public static bool CheckFullname(string str)
        {
            string[] StrSplit = str.Split();

            if (StrSplit.Length != 2) return false;

            if (StrSplit[0].Length > 2 && StrSplit[1].Length > 2) return true;
            else return false;

        }
    }
}
