using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers - DONE

            var sum = numbers.Sum();
            Console.WriteLine("Sum: ");
            Console.WriteLine(sum);

            Console.WriteLine("----------");
            //TODO: Print the Average of numbers - DONE
            var average = numbers.Average();
            Console.WriteLine("Average: ");
            Console.WriteLine(average);

            Console.WriteLine("----------");
            //TODO: Order numbers in ascending order and print to the console - DONE
            var ascend = from num in numbers
                         where num is >= 0
                         orderby num ascending
                         select num;
            Console.WriteLine("Numbers in ascending order: ");
            foreach (var x in ascend)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------");
            //TODO: Order numbers in descending order and print to the console - DONE
            var decendOrder = numbers.OrderByDescending(x => x);
            Console.WriteLine("Numbers in decending order: ");
            foreach (var x in decendOrder)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------");
            //TODO: Print to the console only the numbers greater than 6 - DONE
            var pastSix = from num in numbers
                          where num is >= 6
                          orderby num ascending
                          select num;
            Console.WriteLine("Numbers greater than six: ");
            foreach (var x in pastSix)
            {
                Console.WriteLine(x);
            }

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!** - DONE
            var decsend = from num in numbers
                         where num is >= 0
                         orderby num descending
                         select num;
            Console.WriteLine("Numbers in decsending order: ");
            foreach (var x in decsend)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------");

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 21;
            var ageDescend = numbers.OrderByDescending(x => x);
            Console.WriteLine("Decending order with age: ");
            foreach (var x in ageDescend)
            {
                Console.WriteLine(x);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var namesFiltered = employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S'));
            namesFiltered.OrderBy(x => x.FirstName);

            Console.WriteLine("Full Names that start with C or S: ");
            foreach( var x in namesFiltered)
            {
                Console.WriteLine(x.FullName);
            }

            Console.WriteLine("----------");
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var ageFiltered = employees.Where(x => x.Age > 26);
            ageFiltered.OrderBy(x => x.FullName);

            Console.WriteLine("People over 26: ");
            foreach(var x in ageFiltered)
            {
                Console.WriteLine($" First Name: {x.FirstName}, Age: {x.Age}"); 
            }

            Console.WriteLine("----------");
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var sumOfEmployees = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            var totalSum = sumOfEmployees.Sum(x => x.YearsOfExperience);
            

            Console.WriteLine("Sum of Employees YOE: ");
            Console.WriteLine(totalSum);

            Console.WriteLine("----------");
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var avgOfEmloyees = employees.Average(x => x.YearsOfExperience);
            
            Console.WriteLine("Average of Employees: ");
            Console.WriteLine(avgOfEmloyees);

            Console.WriteLine("----------");
            //TODO: Add an employee to the end of the list without using employees.Add()

            employees = employees.Append(new Employee("Jacob", "Batista", 21, 1)).ToList();

            Console.WriteLine("All Employees: ");
            foreach ( var x in employees)
            {
                Console.WriteLine(x.FullName);
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
