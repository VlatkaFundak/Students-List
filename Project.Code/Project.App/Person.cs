using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.App
{
    /// <summary>
    /// Person properties class.
    /// </summary>
    abstract class Person
    {
        /// <summary>
        /// First name of the person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// ID of the student.
        /// </summary>
        public int ID { get; set; }
    }
}
