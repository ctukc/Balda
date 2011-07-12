using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaldaClasses
{
    public class Field
    {
        private List<List<ILetter>> _fieldLetter;


        public List<List<ILetter>> FieldLetter
        {
            get { return _fieldLetter; }
            set { _fieldLetter = value; }
        }
    }
}
