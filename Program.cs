using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            TDSdata d = new TDSdata();
            d.setid("12");
            d.setcurrentdata("65");
            d.setcounterpartyid("75");

            RiskCalculator e = new RiskCalculator();
            e.Calculate();

            RiskInputDataMerger s = new RiskInputDataMerger();
            s.Merge();



        }
}
}
