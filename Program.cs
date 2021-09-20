using System;

namespace EmployeeWage.cs
{
    class EmployeeWage
    {
        static void Main(string[] args)
        {
            //UC1 Employee
            //Constants

            int IS_FULL_TIME = 1;

            //predefined random class for generating random value
            Random random = new Random();

            //next method() 0-intial value , 2-number of elements from 0
            int empCheck = random.Next(0, 2);

            //selection statement
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }


        }
    }
}