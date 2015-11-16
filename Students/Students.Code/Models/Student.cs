using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Students.Code
{
    /// <summary>
    /// Students properties class.
    /// </summary>
    public class Student : Person
    {
        #region Public properties

        /// <summary>
        /// Gpa of student.
        /// </summary>
        public string Gpa { get; set; }

        #endregion

        #region Constructor

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

        #endregion
    }
}

