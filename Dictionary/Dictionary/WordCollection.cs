﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class WordCollection
    {
        public WordCollection()
        {
            Words = new ObservableCollection<Word>();
            Categories = new ObservableCollection<String>();
            SearchedWords = new ObservableCollection<Word>();
        }

        public ObservableCollection<Word> Words { get; set; }
        public ObservableCollection<String> Categories
        {
            get;
            set;
        }
        public ObservableCollection<Word> SearchedWords { get; set; }
        public Word SelectedWord { get; set; }


        private bool ValidateInput(string word)
        {
            return string.IsNullOrEmpty(word) ? false : true;
        }
        public bool AddWord(string word, string description, string category, string imgPath)
        {
            if (ValidateInput(word) && ValidateInput(description) && ValidateInput(category) && Words.FirstOrDefault(item => item.Equals(word)) == null)
            {
                if (Categories.FirstOrDefault(item => item.Equals(category)) == null)
                {
                    AddCategory(category);
                }
                Word newWord = new Word() { Value = word, Category = category, Description = description, ImagePath = imgPath };
                Words.Add(newWord);
                return true;
            }
            return false;
        }

        public void AddCategory(string category)
        {
            if (ValidateInput(category))
            {
                Categories.Add(category);
            }
        }

        public bool RemoveWord()
        {
            return Words.Remove(SelectedWord);
        }

        public void SeatchFor(string word)
        {
            if (!ValidateInput(word)) return;
            SearchedWords.Clear();
            var foundWords = Words.Where(item => item.Value.StartsWith(word, StringComparison.OrdinalIgnoreCase));
            foreach (var item in foundWords)
            {
                SearchedWords.Add(item);
            }
        }
    }
}
