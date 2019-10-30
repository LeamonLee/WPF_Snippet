using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Pattern.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using MVVM_Pattern.Command;

namespace MVVM_Pattern.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public PersonViewModel()
        {
            this.OPerson = new Person();
            this.LstPersons = new ObservableCollection<Person>();
        }

        private Person _oPerson;

        public Person OPerson
        {
            get { return _oPerson; }
            set {
                _oPerson = value;
                NotifyPropertyChanged("OPerson");
            }
        }

        private ObservableCollection<Person> _lstPerons;

        public ObservableCollection<Person> LstPersons
        {
            get { return _lstPerons; }
            set {
                _lstPerons = value;
                NotifyPropertyChanged("LstPersons");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string strPropertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(strPropertyName));
            }
        }

        private ICommand _submitCmd;

        public ICommand SubmitCmd
        {
            get {
                if(_submitCmd == null)
                {
                    _submitCmd = new RelayCommand(submitExecute, canSubmitExecute, false);
                }
                return _submitCmd;
            }
            
        }

        private bool canSubmitExecute(object parameter)
        {
            if (string.IsNullOrEmpty(OPerson.StrFirstName) ||
               string.IsNullOrEmpty(OPerson.StrLastName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void submitExecute(object parameter)
        {
            LstPersons.Add(OPerson);
        }
    }
}
