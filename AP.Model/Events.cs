using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMA.AP.Model
{
    public class Events
    {
        public int idEvent { get; set; }

        public int idProcess { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public DateTime createDate { get; set; }

        public bool active { get; set; }
    }
}
