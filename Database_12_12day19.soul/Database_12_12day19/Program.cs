using Database_12_12day19.ApplicationDbcontexet;
using Database_12_12day19.Modeels;

namespace Database_12_12day19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationCompanyDBContact context = new ApplicationCompanyDBContact();
            ApplicationCompanyDBContact _db = new ApplicationCompanyDBContact();
            ApplicationCompanyDBContact _db2 = new ApplicationCompanyDBContact();
            int x = 3;
            while (x-->0) {
                Console.WriteLine("enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine("enter your salary:");
                decimal salary = decimal.Parse(Console.ReadLine());
                Console.WriteLine("enter your age:");
                int age = int.Parse(Console.ReadLine());

                EmployeeInformation employee = new EmployeeInformation { 
                
                Name = name,
                Salary = salary,    
                Age = age
                };
                _db.EmployeeInformations.Add(employee);
                _db.SaveChanges();


           
            }


        }
    }
}