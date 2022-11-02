using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Validation
    {
        customsupportloggerdbEntities user = null;
        public Validation()
        {
            user = new customsupportloggerdbEntities();
        }

        public bool UserValidation(int userid,string password)
        {
            bool result=false;
            var ans = user.UserInfoes.ToList().Find(a => a.UserId == userid);
            if(ans!=null)
            {
                if(ans.Password==password)
                {
                    result=true;
                }
            }
            return result;
        }
    }
}
