using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  {



async static Task Main(string[] args)
{
  Console.WriteLine("Please enter yes, if you would like to enter data manually: ");
  string manual = Console.ReadLine() ?? "";
  if (manual == "yes")
  {
    List<Employee>  manualEmp = PeopleFetcher.GetEmployees();
     Util.PrintEmployees(manualEmp);
    Util.MakeCSV(manualEmp);
    await Util.MakeBadges(manualEmp);
  }
    List<Employee>  employees = await PeopleFetcher.GetFromApi();
    Util.PrintEmployees(employees);
    Util.MakeCSV(employees);
    await Util.MakeBadges(employees);
}

  }
}