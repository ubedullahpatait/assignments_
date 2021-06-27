using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdDetail
{
    class GuestId:CardDetail
    {
        String _purpose;
       public  GuestId(String name, String address,String dob ,long phoneNumber,String purpose):base(name, address,dob, phoneNumber)
        {
            this._purpose = purpose;
        }

    }
}
