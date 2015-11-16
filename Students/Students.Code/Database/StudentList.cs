﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Students.Code
{
    /// <summary>
    /// Student's list class.
    /// </summary>
    static public class StudentList
    {
        /// <summary>
        /// Students.
        /// </summary>
        static public List<Student> students;

        #region Properties

        /// <summary>
        /// List of students.
        /// </summary>
        static public Student StudentContainer { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds student.
        /// </summary>
        /// <param name="student"></param>
        static public void AddStudent(Student student)
        {
            ListCheck();
            students.Add(student);
            StudentContainer = student;
        }

        /// <summary>
        /// Creates a new list if it is null.
        /// </summary>
        static public void ListCheck()
        {
            if (students == null)
            {
                students = new List<Student>();
            }
        }

        /// <summary>
        /// Sorts list by last name.
        /// </summary>
        /// <returns></returns>
        static public List<Student> SortedList()
        {
            var sortedListByLastName = StudentList.students.OrderBy(student => student.LastName);

            return sortedListByLastName.ToList();
        }

        #endregion



    }
}
