using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Code
{
    /// <summary>
    /// Person properties class.
    /// </summary>
    public abstract class Person
    {
        #region Properties
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
        public int ID { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Person constructor.
        /// </summary>
        /// <param name="id">Id of the student.</param>
        protected Person (int id)
        {
            this.ID = id;
        }

        #endregion

    }
}
