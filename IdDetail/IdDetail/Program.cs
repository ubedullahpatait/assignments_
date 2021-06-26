using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdDetail
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentId _student = new StudentId("ubed","shankar nagar","01/09/1996",8754692154,"1GI21MCA01","MCA","A");

            TeacherId _teacher = new TeacherId("kiran","vaibhav nagar","09/07/1985",986542158,"mechanical","Assistance Professor" ,"MECH987");

            GuestId _guest = new GuestId("anand", "shanti nagar", "05/04/1980", 865321547, "Enquiry");
        }
    }
}
