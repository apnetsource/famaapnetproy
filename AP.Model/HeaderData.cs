using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMA.AP.Model
{
    public class HeaderData
    {

        public string strBPM { get; set; }
        public string strMold { get; set; }
        public string strVReal { get; set; }
        public string strVTeorico { get; set; }
        public string strVSeccion { get; set; }
        public string strCicloReal { get; set; }
        public string strCicloTeo { get; set; } 
        public string strSecOper { get; set; }
        public string strTime { get; set; }
        public string strDate { get; set; }

        public string _strBPM;
        public string _strMold;
        public string _strVReal;
        public string _strVTeorico;
        public string _strVSeccion;
        public string _strCicloReal;
        public string _strCicloTeo;
        public string _strSecOper;
        public string _strTime;
        public string _strDate;
        public string _strFullName;


        public string BPM
        {
            get { return _strBPM = "19"; }
        }
        public string Mold
        {
            get { return _strMold = "2246086"; }
        }

        public string VReal
        {
            get { return _strVReal = "0"; }
        }

        public string VTeorico
        {
            get { return _strVTeorico = "160.5"; }
        }

        public string VSeccion
        {
            get { return _strVSeccion = "15.90"; }
        }

        public string VCicloReal
        {
            get { return _strCicloReal = "0"; }
        }

        public string CicloTeo
        {
            get { return _strCicloTeo = "450.80"; }
        }


        public string SecOper
        {
            get { return _strSecOper = "8 de 10"; }
        }

        public string Time
        {
            get { return _strTime = DateTime.Now.ToShortTimeString(); }
        }
        public string Date
        {
            get { return _strDate = DateTime.Now.ToString("dd-MMM-yyyy"); }
        }


        public string FullName
        {
            get { return _strFullName = "Raul Perez"; }
        }

    }

}

