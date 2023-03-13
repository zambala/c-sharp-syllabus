using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _phoneDictionary;

        //private PhoneEntry[] _data;
        //private int _dataCount;

        public PhoneDirectory() {
            _phoneDictionary = new SortedDictionary<string, string>();
        }

        private bool Find(string name) 
        {
            return _phoneDictionary.ContainsKey(name);
        }

        public string GetNumber(string name) 
        {
            return Find(name) ? _phoneDictionary[name] : "Name not found";
        }

        public void PutNumber(string name, string number) 
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(number))
            {
                throw new Exception("name and number cannot be null");
            }

            _phoneDictionary.Add(name, number);
        }
    }
}