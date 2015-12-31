using System;
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
        #region Fields

        /// <summary>
        /// List of students.
        /// </summary>
        private static List<Student> studentContainer { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        /// Gets students.
        /// </summary>
        /// <returns>IEnumerable of students.</returns>
        public static IEnumerable<Student> GetStudents()
        {
            IEnumerable<Student> studentList = (IEnumerable<Student>)studentContainer;
            return studentList;
        }

        /// <summary>
        /// Adds student.
        /// </summary>
        /// <param name="student">Student.</param>
        public static void AddStudent(Student student)
        {
            if  (student == null)
            {
                Console.WriteLine("Null value.");
            }
            ListCheck();
            studentContainer.Add(student);
        }

        /// <summary>
        /// Creates a new list if it is null.
        /// </summary>
        public static void ListCheck()
        {
            if (studentContainer == null)
            {
                studentContainer = new List<Student>();
            }
        }

        /// <summary>
        /// Sorts list by last name.
        /// </summary>
        /// <returns>List of students.</returns>
        public static List<Student> SortedList()
        {
            var sortedListByLastName = studentContainer.OrderBy(student => student.LastName);

            return sortedListByLastName.ToList();
        }

        #endregion



    }
}
