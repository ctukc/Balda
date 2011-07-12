using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaldaClasses;

namespace CombinatorWord
{
    public class Combinator
    {

        private List<char> _alphabet = new List<char> { 'а',
                                                        'б',
                                                        'в',
                                                        'г',
                                                        'д',
                                                        'е',
                                                        'ж',
                                                        'з',
                                                        'и',
                                                        'к',
                                                        'л',
                                                        'м',
                                                        'н',
                                                        'о',
                                                        'п',
                                                        'р',
                                                        'с',
                                                        'т',
                                                        'у',
                                                        'х',
                                                        'ф',
                                                        'ч',
                                                        'ц',
                                                        'ш',
                                                        'щ',
                                                        'ъ',
                                                        'ы',
                                                        'ь',
                                                        'э',
                                                        'ю',
                                                        'я',
                                                        'ъ',
                                                        'ъ',
                                                        'ъ'};

        public void Combine(Field pField)
        {
            // на каждую клетку пытаемся вставить букву
            for (int i = 0; i < pField.FieldLetter.Count; i++)
            {
                for (int j = 0; j < pField.FieldLetter[i].Count; j++)
                {
                    // проверяем каждую букву
                    foreach (char c in _alphabet)
                    {
                        if (pField.FieldLetter[i][j].Value != 0)
                        {
                            pField.FieldLetter[i][j].Value = c;
                            GetCombinedWords(pField, i, j);
                        }
                    }
                }
            }
        }

        private void GetCombinedWords(Field pField, int i, int j)
        {
            // должна возвращать слово
            // две ситуации
            // 1. в клетке есть буква
            // 2. в клетке нет буквы
        }

    }
}
