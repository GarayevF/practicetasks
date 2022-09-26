using System;
namespace Task3
{
    public class Company
    {
        private string _name;
        public string Name {
            get => _name;
            set
            {
                while (!NameChecker(value))
                {
                    Console.WriteLine("Company adi boyuk herfle baslamalidir ve " +
                        "icerisinde herf, reqem ve bosluqdan basqa hec ne(simvol) ola bilmez. Yeniden daxil edin");
                    value = Console.ReadLine();
                }
                _name = value;
            }
        }

        public int Limit { get; set; }

        public Employee[] Employees = { };


        public Company()
        {
            
        }


        bool NameChecker(string name)
        {
            if (char.IsLower(name[0])) return false;

            foreach (char item in name)
            {
                if (!(char.IsLetter(item) || char.IsDigit(item) || char.IsWhiteSpace(item))) return false;
            }

            return true;
        }


        public void AddEmoployee(Employee employee)
        {
            if (Employee.No < Limit)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employee;
            }
        }

        public Employee[] GetEmployees()
        {
            return Employees;
        }

    }
}
