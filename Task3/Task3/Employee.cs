using System;
namespace Task3
{
    public class Employee
    {
        private static int _no = 0;

        public static int No { get => _no; }

        public string Fullname { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }



        public Employee()
        {
            _no++;

        }
    }
}
