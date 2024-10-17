using System;
using System.Diagnostics;
using System.Linq;
using Models;
namespace EFCoreApplication
{
    class Data
    {
        public static void Main()
        {
            using var db = new EemployeessContext();
            Console.WriteLine($"Database path : {db.Dbpath}");
            Console.WriteLine("Inserting a new employee");
            Eemployeess employeess0 = new Eemployeess { EID = 1, Name = "Kumar Yadav", DID = 10 };
            Eemployeess employeess1 = new Eemployeess { EID = 2, Name = "Anish Karki", DID = 10 };
            Eemployeess employeess2 = new Eemployeess { EID = 3, Name = "Bimal Lama", DID = 10 };
            db.Add(employeess0);
            db.Add(employeess1);
            db.Add(employeess2);
            db.SaveChanges();
            Console.WriteLine("Querying for all Emploooyee Ordered by Name alphabetically");

            List<Eemployeess> allEemployeess = db.Eemployeess
               .OrderBy(E => E.Name)
               .ToList();
            foreach (var Eemployeess in allEemployeess)
            {
                Console.WriteLine($"EmployyId : {Eemployeess.EID},EmployyName : {Eemployeess.Name},DID : {Eemployeess.DID}");
            }
            EemployeessLeave employeeLeave = new EemployeessLeave { LeaveID = 1, EemployeID = employeess0.EID, NumOfDays = 2 };
            EemployeessLeave employeeLeave1 = new EemployeessLeave { LeaveID = 2, EemployeID = employeess1.EID, NumOfDays = 3 };
            EemployeessLeave employeeLeave2 = new EemployeessLeave { LeaveID = 3, EemployeID = employeess2.EID, NumOfDays = 1 };
            db.Add(employeeLeave);
            db.Add(employeeLeave1);
            db.Add(employeeLeave2);
            db.SaveChanges();
            Console.WriteLine($"Leave applied by {employeess0.Name} for {employeeLeave.NumOfDays} days");
            Console.WriteLine($"Leave applied by {employeess1.Name} for {employeeLeave1.NumOfDays} days");
            Console.WriteLine($"Leave applied by {employeess2.Name} for {employeeLeave2.NumOfDays} days");
            db.Remove(employeess0);
            db.Remove(employeess1);
            db.Remove(employeess2);
            db.RemoveRange(employeeLeave, employeeLeave1, employeeLeave2);
            db.SaveChanges();
        }
    }
}


