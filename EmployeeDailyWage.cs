﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3EmployeeWage
{
    internal class EmployeeDailyWage
    {
        public static void EmployeeWage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int empCheck = random.Next(2);

            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}
