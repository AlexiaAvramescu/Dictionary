using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Word : INotifyPropertyChanged
    {
        public Word() { }

        private String _value;

        private String Value
        { get { return _value; }
          set { _value = value; }
        }

        private String _description;

        private String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private String _imagePath;

        private String ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
