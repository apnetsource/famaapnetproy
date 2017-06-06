using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMA.AP.Model
{
    public class ProcessType
    {
        public int IdProcessType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public DateTime createDate { get; set;  }
        //public DateTime updDate { get; set; }
        public bool active { get; set; }

    }



}
