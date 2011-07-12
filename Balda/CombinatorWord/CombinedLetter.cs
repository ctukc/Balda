using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CombinatorWord
{
    public class CombinedLetter
    {
        private int _coordX;
        private int _coordY;
        private char _letter;


        public int CoordX
        {
            get { return _coordX; }
            set { _coordX = value; }
        }

        public int CoordY
        {
            get { return _coordY; }
            set { _coordY = value; }
        }

        public char Letter
        {
            get { return _letter; }
            set { _letter = value; }
        }
    }

    
}
