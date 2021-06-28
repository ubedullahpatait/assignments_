using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATACar
{
    class RevorTron:IEngine
    {
        public void Start()
        {
            Console.WriteLine("start");
        }

        public void Stop()
        {
            Console.WriteLine("stop");
        }



    }
}
