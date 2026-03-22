using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetPractise
{
    internal class Car
    {
        private int _makeYear;
        private string _name;
        private string _engine;
        private string _type;

        internal int MakeYear {
            get { return _makeYear; }
            set { _makeYear = value;  }
        }
        internal string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        internal string Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }
        internal string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        internal string GetCar() {
            
            return $"I am buying a {_makeYear} model {_name}  {_type} with {_engine} engine.";
        }
    }
}
