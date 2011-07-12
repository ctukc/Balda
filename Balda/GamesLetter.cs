using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using BaldaClasses;

namespace Balda
{
    class GamesLetter:TextBox,ILetter
    {
        public char Value
        {
            get { return this.Text[0]; }
            set { Text = value.ToString(); }
        }

        public bool IsPasted
        {
            get; set; 
        }

        public bool IsMarkedPerebor
        {
            get; set; 
        }
    }
}
