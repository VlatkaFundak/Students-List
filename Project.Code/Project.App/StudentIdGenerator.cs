using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.App
{
    public class StudentIdGenerator
    {
        /// <summary>
        /// Generates id.
        /// </summary>
        /// <returns></returns>
        static public int GeneratedId()
        {
            StudentList.ListCheck();
            int i = 1;

            foreach (var item in StudentList.students)
            {
                i++;
            }
            return i;
        }

    }
}
