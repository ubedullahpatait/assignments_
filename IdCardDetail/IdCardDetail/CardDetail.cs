using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdCardDetail
{
   public class CardDetail
    {
        private String _name, _address, _dob;
        private long _phoneNumber;


        public CardDetail(String name)
        {
            this._name = name;
        }

        public CardDetail(String name, String address, string dob) : this(name)
        {

            this._address = address;
            this._dob = dob;

        }
        public CardDetail(String name, String address, string dob, long phoneNumber) : this(name, address, dob)
        {

            this._phoneNumber = phoneNumber;

        }





    }
}
