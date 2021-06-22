using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    class TDSdata
    {
        private string id;
        private string currentdata;
        private string counterpartyid;

        public string getid()
        {
            return this.id;
        }
        public string getcurrentdata()
        {
            return this.currentdata;
        }

        public string getcounterpartyid()
        {
            return this.counterpartyid;
        }

        public void setid(string value)
        {
            this.id = value;
        }
        public void setcurrentdata(string value)
        {
            this.currentdata = value;
        }

        public void setcounterpartyid(string value)
        {
            this.counterpartyid = value;
        }


    }

    class RDSDataModel
    {
        private string CounterPartyId;
        private string Name;

    }



    class RiskCalculator
    {
        public void Calculate()
        {
            Console.WriteLine("calculating");
        }
    }

    class RiskInputDataMerger
    {
        public void Merge()

        {
            Console.WriteLine("merge data");
        }
    }

}
