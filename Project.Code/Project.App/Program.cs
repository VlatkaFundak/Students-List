﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = true;

            do
            {
                Console.Write("Operation: ");
                string userInput = Console.ReadLine();
                Validation.OperationInput(userInput);

                isValid = OperationInput(userInput);

            } while (!isValid);

            Console.ReadKey();
        }

        /// <summary>
        /// Input of the user for enlisting.
        /// </summary>
        /// <param name="userInput">User input.</param>
        /// <returns>True if input is correct.</returns>
        static private bool OperationInput(string userInput)
        {
            switch (userInput.ToLower())
            {
                case Operations.enlist:
                    Enlist();
                    return false;
                case Operations.display:
                    Display();
                    Environment.Exit(-1);
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Enlists students.
        /// </summary>
        static private void Enlist()
        {
            Console.WriteLine("Student");

            string firstName = String.Empty;
            string lastName = String.Empty;
            string gpa = String.Empty;

            do
            {
                Console.Write("First name: ");
                firstName = Console.ReadLine();

            } while (!Validation.InputEmptySpaces(firstName));


            do
            {
                Console.Write("Last name: ");
                lastName = Console.ReadLine();
            }while (!Validation.InputEmptySpaces(lastName));

            do
            {
                Console.Write("GPA: ");
                gpa = Console.ReadLine();

            } while (Validation.GPAInput(gpa));

            StudentList.AddStudent(new Student(StudentIdGenerator.GeneratedId(), firstName, lastName, gpa));
        }

        /// <summary>
        /// Displays students.
        /// </summary>
        static private void Display()
        {
            Console.WriteLine("Students in a system:");
            foreach (var item in StudentList.students)
            {
                Console.WriteLine(item.ID + ". " + item.LastName + ", " + item.FirstName);
            }
            Console.ReadLine();
        }
    }
}