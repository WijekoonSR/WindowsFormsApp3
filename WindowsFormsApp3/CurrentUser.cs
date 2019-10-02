using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class CurrentUser
    {
        public static string employeeID;
        public static string userID;

        public static void setID(string eId, string uId) {
            employeeID = eId;
            userID = uId;
        }

        public static string getEId() {
            return employeeID;
        }
        public static string getUId()
        {
            return userID;
        }
    }
}
