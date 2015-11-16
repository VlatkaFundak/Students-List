using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Code
{
    /// <summary>
    /// Student's ID generator class.
    /// </summary>
    public class StudentIdGenerator
    {
        /// <summary>
        /// Initialization.
        /// </summary>
        private static StudentIdGenerator instance = null;

        /// <summary>
        /// Constructor of the class.
        /// </summary>
        private StudentIdGenerator()
        { }

        /// <summary>
        /// Instance of the class.
        /// </summary>
        public static StudentIdGenerator Instance
        {
            get
            {
                if (StudentIdGenerator.instance == null)
                    StudentIdGenerator.instance = new StudentIdGenerator();
                return StudentIdGenerator.instance;
            }
        }

        /// <summary>
        /// Generates id.
        /// </summary>
        /// <returns></returns>
        public int GeneratedId()
        {
            StudentList.ListCheck();

            int i = StudentList.students.Count();
            i++;

            return i;
        }
    }
}
