﻿using System;

namespace thietkemenu
{
    class Program
    {
        static void taomenu(){
 int choice;

            //Hiển thị thông tin menu
            Console.WriteLine("Menu");
            Console.WriteLine("1. Draw the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());

            //xử lý các tình huống lựa chọn
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Draw the triangle");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                break;
                case 2:
                    Console.WriteLine("Draw the square");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                break;
                case 3:
                    Console.WriteLine("Draw the rectangle");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                break;
                case 0:
                    Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("No choice!");
                break;
            }
            while(choice!= 0) {} 
        }
        static void Main(string[] args)
        {
            taomenu();
           
        }
    }
}