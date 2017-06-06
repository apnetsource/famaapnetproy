using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMA.AP.Model
{
    public class Mechanism
    {
        public int idMechanism { get; set; }

        public int idMechanismParent { get; set; }

        public int idTags { get; set; }

        public int idActions { get; set; }

        public int idEvent { get; set; }

        public int idProcessType { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public bool active { get; set; }

        public bool cycleActivationOne { get; set; }

        public bool cycleActivationTwo { get; set; }

        public bool cycleActivationThree { get; set; }

        public bool cycleActivationFour { get; set; }

        public int idCeis { get; set; }

        public int machineType { get; set; }

        public DateTime createDate { get; set; }


    }
}
