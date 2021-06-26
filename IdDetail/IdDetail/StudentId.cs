using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdDetail 
{
    class StudentId : Detail
    {
        String _usn, _course, _section;
        public StudentId(String name, String address, string dob,long phoneNumber ,String usn, String course , String section):base(name,address,dob,phoneNumber)
        {
            this._usn = usn;
            this._course = course;
            this._section = section;



        }
    }
}
