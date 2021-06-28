using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATACar
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiJetEngine _multijetengine = new MultiJetEngine();
            TataCar _harrier = new TataCar(_multijetengine);
            _harrier.Drive();
            _harrier.Halt();

            VeriCorEngine _vericonengine = new VeriCorEngine();
           TataCar _nexon = new TataCar(_vericonengine);
            _nexon.Drive();
            _nexon.Halt();

            RevorTron _dicoreengine = new RevorTron();
            TataCar _hexa = new TataCar(_dicoreengine);
            _hexa.Drive();
            _hexa.Halt();
            


        }
    }
}
