using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project.App
{
    /// <summary>
    /// Students properties class.
    /// </summary>
    class Student : Person
    {
        /// <summary>
        /// Gpa of student.
        /// </summary>
        public string Gpa { get; set; }

        /// <summary>
        /// Student constant.
        /// </summary>
        public string student = "Student";

        /// <summary>
        /// Student constructor.
        /// </summary>
        /// <param name="id">ID of the student.</param>
        /// <param name="firstName">First name of the student.</param>
        /// <param name="lastName">Last name of the student.</param>
        /// <param name="gpa">Gpa of the student.</param>
        public Student(int id, string firstName, string lastName, string gpa)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gpa = gpa;
        }
    }
}

