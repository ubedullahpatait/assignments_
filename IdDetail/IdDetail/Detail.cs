using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdDetail
{
    class Detail
    {
        private String _name, _address , _dob;
        private long _phoneNumber;

        
        public Detail(String name)
        {
            this._name = name;
        }

        public Detail(String name, String address, string dob) : this(name)
        {

            this._address = address;
            this._dob = dob;

        }
        public Detail(String name, String address, string dob , long phoneNumber) : this(name , address ,dob)
        {

            this._phoneNumber = phoneNumber;

        }



    }
}
