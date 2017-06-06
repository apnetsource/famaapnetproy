using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMA.AP.Model
{
    public class Client
    {
        public int IdClient { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Locality { get; set; }
        public int IdLineConfiguration { get; set; }
        public string NameClient { get; set; }
        public string ShortName { get; set; }
        public int line { get; set; }
        public int oven { get; set; }
        public DateTime createDate { get; set; }
        public DateTime updDate { get; set; }
    }
}
