using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMA.AP.Model
{
    public class Ceis
    {
        public int idCeis { get; set; }
        public int CeisType { get; set; }
        public string CeisTypeDesc { get; set; }
        public int CeisSide { get; set; }
        public string CeisSideDesc { get; set; }
        public int Sections { get; set; }
        public string ProcessType { get; set; }

    }
}
