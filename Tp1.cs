using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Tp1
    {
        public void Run()
        {
            ShowWelcomeMsg();
            Logic();
        }

        public void ShowWelcomeMsg()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------  WELCOME TO MY FIRST TP C# APP --------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        }

        public bool TestHour(int hour)
        {
            /*
             * This method  return true if hour between 9a.m - 6p.m and false if between 6p.m and 9a.m
             * 
             */
            bool result;
            if(hour>=9 && hour < 18)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public bool TestAllWeek(string today)
        {
            /*
             * This method  return true if the day of today is between L, M, M,J and V
             * 
             */
            switch (today)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    return true;
            }
            return false;
        }

        public bool TestContractWeek(string today)
        {
            /*
             * This method  return true if the day of today is between L, M, M,J
             * 
             */
            switch (today)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                    return true;
            }
            return false;
        }

        public void Logic()
        {
           // string username = Environment.UserName;
           // int hour = DateTime.Now.Hour;
           // string today = DateTime.Now.DayOfWeek.ToString();
           // string msg = "";
            string username = "Sorel";
            int hour = 12;
            string today = "Friday";
            string msg = "";

            if (TestHour(hour))
            {
                if (TestAllWeek(today))
                {
                    msg = "-----     Bonjour "+ username +"        ------";
                }
                else
                {
                    msg = "-----     Bon Weekend " + username + "   ------";
                }
            }
            else
            {
                if (TestContractWeek(today))
                {
                    msg = "-----     Bonsoir " + username + "        ------";
                }
                else
                {
                    msg = "-----     Bon Weekend " + username + "   ------";
                }
            }
            Console.WriteLine(msg);
        }
    }
}
