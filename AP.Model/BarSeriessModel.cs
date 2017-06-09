using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Windows.Input;
using System.Collections.ObjectModel;
using FAMA.AP.Model;
//using System.Windows.Data;


namespace FAMA.AP.Model
{

    public class BarSeriessModel 
    {
        public int idEvento { get; set; }
        public string SenDesc { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
    }
  


}
