using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMA.AP.Model
{
    public class ProcessValue
    {
        public int idProcessValue { get; set; }

        public int idActiveSections { get; set; }

        public Mechanism idMechanism { get; set; }

        public decimal fTotEv { get; set; }

        public decimal fTotals { get; set; }

        public string tmpName { get; set; }
    }
}
