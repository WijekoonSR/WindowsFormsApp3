using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class CurrentUser
    {
        public static int employeeID;
        public static int userID;

        public static void setID(int eId, int uId) {
            employeeID = eId;
            userID = uId;
        }

        public static int getEId() {
            return employeeID;
        }
        public static int getUId()
        {
            return userID;
        }
    }
}
