using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    public class PigLatin
    {
        private string initialText;

        public string InitialText
        {
            get { return this.initialText; }
        }


        public PigLatin(string text)
        {
            this.initialText = text;
        }

        public string[] SplitsString()
        {
            char[] caractere = { ' ', ',', '.', '/', '-', '!', '?' };
            string[] splitedText = this.initialText.Split(caractere, System.StringSplitOptions.RemoveEmptyEntries);
            return splitedText;
        }

        public void Modify()
        {
            string[] splitedText = SplitsString();
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Y', 'a', 'e', 'i', 'o', 'u', 'y' };
            StringBuilder lista = new StringBuilder();
            foreach (string word in splitedText)
            {
                string newWord;

                if (word.Length == 1 || Array.BinarySearch(vowels, word[0]) >= 0)
                {
                    newWord = word + "ay ";
                    lista.Append(newWord);
                }
                else
                {
                    newWord = word.Substring(1) + word[0] + "ay ";
                    lista.Append(newWord);
                }
            }

            string pigLatinText = lista.ToString();
            Console.WriteLine(pigLatinText);
        }



    }
}
