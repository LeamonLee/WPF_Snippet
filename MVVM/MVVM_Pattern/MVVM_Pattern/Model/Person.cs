using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Pattern.Model
{
    public class Person : INotifyPropertyChanged, IDataErrorInfo
    {
        private string _strFirstName;

        public string StrFirstName
        {
            get { return _strFirstName; }
            set {
                if (_strFirstName != value)
                {
                    _strFirstName = value;
                    OnPropertychanged("StrFirstName");
                    OnPropertychanged("StrFullName");
                }
                
            }
        }

        private string _strLastName;

        public string StrLastName
        {
            get { return _strLastName; }
            set {
                if (_strLastName != value)
                {
                    _strLastName = value;
                    OnPropertychanged("StrLastName");
                    OnPropertychanged("StrFullName");
                }
            }
        }

        private string _strFullname;

        public string StrFullName
        {
            get {
                return _strFullname = StrFirstName + " " + StrLastName;
            }
            set {
                if(_strFullname != value)
                    _strFullname = value;
            }
        }

        public DateTime DteToday { get; set; }

        // IDataErrorInfo
        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string strPropertyName]
        {
            get
            {
                string strResult = string.Empty;
                switch(strPropertyName)
                {
                    case "StrFirstName":
                        if (string.IsNullOrEmpty(StrFirstName))
                            strResult = "FirstName is required";
                        break;
                    case "StrLastName":
                        if (string.IsNullOrEmpty(StrLastName))
                            strResult = "LastName is required";
                        break;
                    default:
                        break;
                }
                return strResult;
            }
        }
        // IDataErrorInfo

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertychanged(string strProperty)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(strProperty));

            }
        }

    }
}
