using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDLS
{
    class CurrentTypeOfUser
    {
        public  string typeUser; 
    }

    class Class1
    {
        static string nm, add, add2;
        public static string name
        {
            get
            {
                return nm;
            }
            set
            {
                nm = value;
            }
        }
        public static string trakerName
        {
            get
            {
                return add;

            }
            set
            {
                add = value;
            }
        }

        public static string trakID
        {
            get
            {
                return add2;

            }
            set
            {
                add2 = value;
            }
        }
    }
}
