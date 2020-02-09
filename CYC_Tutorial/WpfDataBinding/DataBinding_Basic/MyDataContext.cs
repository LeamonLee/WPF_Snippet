using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding_Basic
{
    public class MyDataContext
    {
        private double _myValue;
        public double MyValue
        {
            get
            {
                return _myValue;
            } 
            set
            {
                _myValue = value;
            }
            
        }
    }
}
