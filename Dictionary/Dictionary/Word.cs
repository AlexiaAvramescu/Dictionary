using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Word
    {
        private string _wordVal;

        public string WordVal
        {
            get { return _wordVal; }
            set
            {
                _wordVal = value;
            }
        }

        private string _definition;

        public string Definition
        {
            get { return _definition; }
            set { _definition = value; }
        }

        private string _category;


    }
}
