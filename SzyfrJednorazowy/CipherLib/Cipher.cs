using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("OTPCipherLibTest")]
namespace CipherLib
{
    public class OTPCipher
    {
        private string _textToCipher;
        private string _privateKey;
        private string _cipheredText;

        public string TextToCipher { get => _textToCipher; }

        public string PrivateKey { get => _privateKey; }
        public string CipheredText { get => _cipheredText; }


        readonly Dictionary<short, char> Alphabet = new Dictionary<short, char>()
            {
                {0, 'A' },
                {1, 'B' },
                {2, 'C' },
                {3, 'D' },
                {4, 'E' },
                {5, 'F' },
                {6, 'G' },
                {7, 'H' },
                {8, 'I' },
                {9, 'J' },
                {10, 'K' },
                {11, 'L' },
                {12, 'M' },
                {13, 'N' },
                {14, 'O' },
                {15, 'P' },
                {16, 'Q' },
                {17, 'R' },
                {18, 'S' },
                {19, 'T' },
                {20, 'U' },
                {21, 'V' },
                {22, 'W' },
                {23, 'X' },
                {24, 'Y' },
                {25, 'Z' },
            };


        public OTPCipher(string TextToCipher)
        {
            _textToCipher = TextToCipher;
        }

        public string GeneratePrivateKey()
        {
            _privateKey = string.Empty;
            StringBuilder sb = new StringBuilder(_textToCipher.Length);

            for (int i = 0; i < _textToCipher.Length; i++)
            {
                if (_textToCipher[i] == (char)32)
                {
                    sb.Append((char)32);
                }
                else
                {
                    sb.Append(GetRandomLetter());
                }
            }
            _privateKey = sb.ToString();
            return _privateKey;
        }

        public string CipherMessage()
        {
            _cipheredText = string.Empty;
            StringBuilder sb = new StringBuilder(_textToCipher.Length);

            for (int i = 0; i < _textToCipher.Length; i++)
            {
                if (_textToCipher[i] == (char)32)
                {
                    sb.Append((char)32);
                }
                else
                {
                    char textLetter = _textToCipher[i];
                    char privateKeyLetter = _privateKey[i];

                    short textLetterNumber = GetLetterNumber(_textToCipher[i]);
                    short privateKeyNumber = GetLetterNumber(_privateKey[i]);
                    int numberForCaluculation = (short)textLetterNumber + (short)privateKeyNumber;

                    if (numberForCaluculation>26)
                    {
                        System.Diagnostics.Debug.WriteLine($"{textLetter} + {privateKeyLetter} =  {numberForCaluculation} /26 = {numberForCaluculation% 26}");
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"{textLetter} + {privateKeyLetter} =  {numberForCaluculation} = {numberForCaluculation}");
                    }
                }
            }
            _cipheredText = sb.ToString();
            return _cipheredText;
        }


        internal char GetRandomLetter()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            short randomNumber = Convert.ToSByte(rand.Next(0, 25));

            return Alphabet[randomNumber];
        }

        internal short GetLetterNumber(char letter)
        {
            return Alphabet.Where(w => w.Value == letter).Select(s => s.Key).First();
        }

        internal char GetLetterByNumber(short number)
        {
            return Alphabet.Where(w => w.Key == number).Select(s => s.Value).First();
        }

        internal string ReplaceAllNonAlphaChars(string textString)
        {
            Regex rgx = new Regex("[^a-zA-Z]");
            return textString = rgx.Replace(textString, "");
        }
    }
}
