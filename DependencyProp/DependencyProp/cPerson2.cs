using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyProp
{
    public class cPerson10:INotifyPropertyChanged
    {


        private string strFirstName;

        public string StrFirstName
        {
            get { return strFirstName; }
            set {
                if (strFirstName != value)
                {
                    strFirstName = value;
                    OnPropertyChanged("StrFirstName");
                    OnPropertyChanged("StrFullName");
                }
            }
        }

        private string strLastName;

        public string StrLastName
        {
            get { return strLastName; }
            set
            {
                if (strLastName != value)
                {
                    strLastName = value;
                    OnPropertyChanged("StrLastName");
                    OnPropertyChanged("StrFullName");
                }
            }
        }

        private string strFullName;

        public string StrFullName
        {
            get { return strFullName = strFirstName + " " + strLastName; }
            set
            {
                if (strFullName != value)
                {
                    strFullName = value;
                    string[] arrStr= strFullName.Split(' ');
                    strFirstName = arrStr[0];
                    strLastName = arrStr[1];
                    OnPropertyChanged("StrFirstName");
                    OnPropertyChanged("StrLastName");
                    OnPropertyChanged("StrFullName");
                }
            }
        }

        private void OnPropertyChanged(string strProperty)
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(strProperty));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
