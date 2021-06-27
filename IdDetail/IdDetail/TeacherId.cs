using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdCardDetail
{
   public class TeacherIdCard:CardDetail
    {
        String  _dept, _designation, _IdNumber;
       public TeacherIdCard(String name, String address, String dob, long phoneNumber,String dept, String designation ,String IdNumber):base(name, address, dob, phoneNumber)
        {
            this._dept = dept;
            this._designation = designation;
            this._IdNumber = IdNumber;
        }
    }
}
