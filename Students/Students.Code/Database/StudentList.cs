using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Students.Code
{
    static public class StudentList
    {
        /// <summary>
        /// Students.
        /// </summary>
        static public List<Student> students;
                
        /// <summary>
        /// List of students.
        /// </summary>
        static public Student StudentContainer { get; set; }

        /// <summary>
        /// Adds student.
        /// </summary>
        /// <param name="student"></param>
        static public void AddStudent(Student student)
        {
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

    }
}
