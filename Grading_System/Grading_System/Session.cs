using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grading_System
{
    class Session
    {
        private static string uname;
        public static string UNAME
        {
            get 
            {
                return uname;
            }
            set
            {
                uname = value;
            }
        }
    }
}
