using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class WordCollection
    {
        public WordCollection()
        {
            Words = new ObservableCollection<Word>();
        }

        ObservableCollection<Word> Words { get; set; }
    }
}
