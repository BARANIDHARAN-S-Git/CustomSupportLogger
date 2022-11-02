using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using NUnit.Framework;


namespace DALTest
{
    [TestFixture]
    public class CustomSupportLoggerTest
    {
        Validation v = null;
        AddCustomerComplaints a = null;
        public CustomSupportLoggerTest()
        {
            v= new Validation();
            a = new AddCustomerComplaints();
        }

        [TestCase(101,"admin@123",ExpectedResult =true)]
        [TestCase(201, "admin@123", ExpectedResult =false)]
      
        public bool UserInfoTest(int userid,string password)
        {
            return v.UserValidation(userid,password);
        }

       
        [TestCase(101,ExpectedResult =true)]
        [TestCase(201,ExpectedResult = false)]
        public bool CustLogInfoTest(int userid)
        {
            CustLogInfo l = new CustLogInfo();
            l.UserId=userid;
            return a.Add(l);


        }
       
    }
}
