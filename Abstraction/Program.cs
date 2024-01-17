using Abstraction;
using System;

var salariedEmployee = new SalariedEmployee();
salariedEmployee.SetName("Ashraf", "Alagmawy");
salariedEmployee.Email = "ashraf@gmail.com";
salariedEmployee.BasicSalary = 2000;
salariedEmployee.Housing = 1000;
salariedEmployee.Transportation = 500;
Console.WriteLine($"Salary Of Salaried Employee (Without Taxes) Is {salariedEmployee.GetSalary():0.00}");
Console.WriteLine($"Salary Of Salaried Employee (With 10% Taxes) Is {salariedEmployee.GetSalary(10):0.00}");
Console.WriteLine($"Salary Of Salaried Employee (With 10% Taxes And 1200 Bonus) Is {salariedEmployee.GetSalary(10, 1200):0.00}");

Console.WriteLine("-----------------------------------------------------------");

var hourlyEmployee = new HourlyEmployee();
hourlyEmployee.SetName("Ashraf", "Alagmawy");
hourlyEmployee.Email = "ashraf@gmail.com";
hourlyEmployee.HourRate = 100;
hourlyEmployee.TotalWorkingHours = 60;
Console.WriteLine($"Salary Of Hourly Employee Is {hourlyEmployee.GetSalary():0.00}");

Console.WriteLine("-----------------------------------------------------------");

var internEmployee = new InternEmployee();
internEmployee.SetName("Ashraf", "Alagmawy");
internEmployee.Email = "ashraf@gmail.com";
Console.WriteLine($"Salary Of Intern Employee Is {internEmployee.GetSalary():0.00}");

Console.WriteLine("-----------------------------------------------------------");

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("#########################################################");

var notifire = new Notifire("mail@example.com", 22, "noreplay@example.com", "Abc123");
var paySlipGenerator = new PaySlipGenerator(notifire);
paySlipGenerator.Generate(salariedEmployee);
paySlipGenerator.Generate(hourlyEmployee);
paySlipGenerator.Generate(internEmployee);

Console.WriteLine("-----------------------------------------------------------");

Console.ReadKey();
