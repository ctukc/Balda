using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Words
{
    public class Words
    {
        private List<string> _words = new List<string>();

        public bool CheckWord(string pWord)
        {
            return _words.Contains(pWord);
        }

        public void LoadWords(string pFile)
        {
            if (!File.Exists(pFile))
                return;
            TextReader tr = new StreamReader(pFile, Encoding.Default);
            string word = tr.ReadLine();
            while (word != null)
            {
                word = tr.ReadLine();
                _words.Add(word);
            }

        }
    }
}
