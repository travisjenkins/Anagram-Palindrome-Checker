using System;
namespace Anagram_Palindrome
{
    public class HelperMethods
    {
        private List<char> _firstWordOrPhrase = new();
        private List<char> _secondWordOrPhrase = new();

        private List<char> _sanitizeWordOrPhrase(string wordOrPhrase)
        {
            List<char> result = new();
            if (!string.IsNullOrWhiteSpace(wordOrPhrase))
            {
                result = wordOrPhrase.ToLower().ToList();
                result = _removeSpaces(result);
                result = _justTheLetters(result);
            }
            return result;
        }

        private List<char> _removeSpaces(List<char> wordOrPhrase)
        {
            List<char> result = new();
            foreach (var character in wordOrPhrase)
            {
                if (!char.IsWhiteSpace(character))
                {
                    result.Add(character);
                }
            }
            return result;
        }

        private List<char> _justTheLetters(List<char> wordOrPhrase)
        {
            List<char> result = new();
            foreach (var character in wordOrPhrase)
            {
                if (char.IsLetter(character))
                {
                    result.Add(character);
                }
            }
            return result;
        }

        private int _partition(List<char> chars, int left, int right)
        {
            int i = left;
            int pivot = chars[right];
            char temp;

            for (int j = left; j <= right; j++)
            {
                if (chars[j] < pivot)
                {
                    temp = chars[i];
                    chars[i] = chars[j];
                    chars[j] = temp;
                    i++;
                }
            }

            temp = chars[right];
            chars[right] = chars[i];
            chars[i] = temp;
            return i;
        }

        /*
         * REFERENCES:
         * 
         * https://alphacodingskills.com/cs/pages/cs-program-for-quick-sort.php#:~:text=C%23%20Program%20-%20Quick%20Sort%20Quick%20sort%20is,pivot%20containing%20all%20elements%20greater%20than%20the%20pivot.
         * 
         * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char
         * 
         * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/comparison-operators
         */

        private void _quickSort(List<char> chars, int left, int right)
        {
            if (left < right)
            {
                int pivot = _partition(chars, left, right);
                _quickSort(chars, left, pivot - 1);
                _quickSort(chars, pivot + 1, right);
            }
        }

        private bool _lettersAreTheSame()
        {
            bool result = false;
            if (_firstWordOrPhrase.Count == _secondWordOrPhrase.Count)
            {
                bool allMatch = true;

                // Perform Sort
                _quickSort(_firstWordOrPhrase, 0, _firstWordOrPhrase.Count - 1);
                _quickSort(_secondWordOrPhrase, 0, _secondWordOrPhrase.Count - 1);

                // Compare Letters
                if (_firstWordOrPhrase.Count > 0 && _secondWordOrPhrase.Count > 0)
                {
                    for (int i = 0; i < _firstWordOrPhrase.Count; i++)
                    {
                        if (_firstWordOrPhrase[i] != _secondWordOrPhrase[i])
                        {
                            allMatch = false;
                            break;
                        }
                    }
                    result = allMatch;
                }
            }
            return result;
        }

        private bool _reversedWordOrPhraseIsTheSame()
        {
            if (_firstWordOrPhrase.Count == _secondWordOrPhrase.Count)
            {
                // Reverse One Word or Phrase (doesn't matter which one)
                List<char> secondWordOrPhraseReversed = new();
                for (int i = _secondWordOrPhrase.Count - 1; i >= 0; i--)
                {
                    secondWordOrPhraseReversed.Add(_secondWordOrPhrase[i]);
                }
                // Compare Word or Phrase
                if (secondWordOrPhraseReversed.Count > 0)
                {
                    string firstWordOrPhrase = string.Join("", _firstWordOrPhrase);
                    string secondWordOrPhrase = string.Join("", secondWordOrPhraseReversed);
                    if (firstWordOrPhrase == secondWordOrPhrase)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool _runChecks(string name, string wordOrPhrase1, string wordOrPhrase2)
        {
            bool result = false;
            string first = wordOrPhrase1;
            string second = wordOrPhrase2;

            // Sanitize input
            _firstWordOrPhrase = _sanitizeWordOrPhrase(first);
            _secondWordOrPhrase = _sanitizeWordOrPhrase(second);

            // Perform Appropriate Check
            if (_firstWordOrPhrase.Count > 0 && _secondWordOrPhrase.Count > 0)
            {
                if (name == nameof(IsAnagram))
                {
                    result = _lettersAreTheSame();
                }
                else if (name == nameof(IsPalindrome))
                {
                    result = _reversedWordOrPhraseIsTheSame();
                }
            }

            // Reset Lists
            _firstWordOrPhrase = new();
            _secondWordOrPhrase = new();

            return result;
        }

        public bool IsAnagram(string wordOrPhrase1, string wordOrPhrase2)
        {
            return _runChecks(nameof(IsAnagram), wordOrPhrase1, wordOrPhrase2);
        }

        public bool IsPalindrome(string wordOrPhrase1, string wordOrPhrase2)
        {
            return _runChecks(nameof(IsPalindrome), wordOrPhrase1, wordOrPhrase2);
        }
    }
}

