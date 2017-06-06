using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMA.AP.Model
{
    public class Sections
    {
        public int idActiveSections { get; set; }
        public int idProcessType { get; set; }
        public int idMoldingChange { get; set; }
        public int idProcess { get; set; }
        public bool active { get; set; }
        public string name { get; set; }
    }
}
