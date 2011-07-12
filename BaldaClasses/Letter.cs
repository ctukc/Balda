using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaldaClasses
{
    public interface ILetter
    {
        /// <summary>
        /// Значение в букве
        /// </summary>
        char Value { get; set; }

        /// <summary>
        /// Поставлена в данном ходе
        /// </summary>
        bool IsPasted { get; set; }

        /// <summary>
        /// если помечена в переборе
        /// </summary>
        bool IsMarkedPerebor { get; set; }
    }

    public class Letter : ILetter
    {
        
        private char _value;
        private bool _isPasted;
        private bool _isMarkedPerebor;
      

        /// <summary>
        /// Значение в букве
        /// </summary>
        public char Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// Поставлена в данном ходе
        /// </summary>
        public bool IsPasted
        {
            get { return _isPasted; }
            set { _isPasted = value; }
        }

        /// <summary>
        /// если помечена в переборе
        /// </summary>
        public bool IsMarkedPerebor
        {
            get { return _isMarkedPerebor; }
            set { _isMarkedPerebor = value; }
        }


    }
}
