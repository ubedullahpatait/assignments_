using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATACar
{
    class TataCar
    {
        Engine _engine;
        public TataCar(Engine engine)
        {

            this._engine = engine;
           
        }

        public void Drive()
        {

            _engine.Start();
        }
        public void Halt()
        {

            _engine.Stop();
        }
    }
}
