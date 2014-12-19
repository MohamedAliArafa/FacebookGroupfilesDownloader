using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using System.Windows.Forms;
namespace GroupSolution
{
    class FBclass
    {
        public static string GetUserID(string access)
        {        
            FacebookClient fb = new FacebookClient(access);

            dynamic MyData = fb.Get("/me");

            return MyData.id;

        }
        public static string GetUserName(string access)
        {
            FacebookClient fb = new FacebookClient(access);
            dynamic MyData = fb.Get("/me");
            return MyData.name;
        }

    }
}
