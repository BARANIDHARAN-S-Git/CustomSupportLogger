using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AddCustomerComplaints
    {

        customsupportloggerdbEntities user = null;
        public AddCustomerComplaints()
        {
            user = new customsupportloggerdbEntities();
        }
        public bool Add(CustLogInfo a)
        {
            bool ans =true;
            try
            {
                user.CustLogInfoes.Add(a);
                user.SaveChanges();
               

                return ans;


            }
            catch(Exception)
            {
                ans=false;
                return ans;
            }






        }
    }
}
