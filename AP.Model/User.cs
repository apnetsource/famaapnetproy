using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FAMA.AP.Model 
{
    public class User 
        //: System.ComponentModel.IDataErrorInfo
    {
//        private string _Password;

        public Guid IdUser { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        //public string Password
        //{
        //    get { return _Password; }
        //    set
        //    {
        //        if (value.Equals(""))
        //            throw new ArgumentException("Debe proporcionar password");
        //        _Password = value;
        //    }
        //}

        public string EmailAddress { get; set; }
        public int IdProfile { get; set; }
        public string ProfileName { get; set; }
        public int idClient { get; set; }
        public string ClientDescription { get; set; }

        public string _fullName;
        public string FullName
        {
            get
            {
                return _fullName = Name + " " + LastName;
            }
        }

        //string IDataErrorInfo.Error
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //string IDataErrorInfo.this[string columnName]
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }

}
