using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Code
{
    /// <summary>
    /// Student repository.
    /// </summary>
    public static class StudentRepository
    {
        /// <summary>
        /// Gets students.
        /// </summary>
        /// <returns>IEnumerable of students.</returns>
        public static IEnumerable<Student> GetStudents()
        {
            return StudentList.GetStudents();
        }

        /// <summary>
        /// Adds student.
        /// </summary>
        /// <param name="student">Student.</param>
        public static void AddStudent(Student student)
        {            
            StudentList.AddStudent(student);
        }

        /// <summary>
        /// Sorts list by last name.
        /// </summary>
        /// <returns>List of students.</returns>
        public static List<Student> SortedList()
        {
            return StudentList.SortedList();
        }

        /// <summary>
        /// Creates a new list if it is null.
        /// </summary>
        public static void ListCheck()
        {
            StudentList.ListCheck();
        }

    }
}
