using System;
using NUnit.Framework;
using NUnit;

namespace OTPCipherLibTest
{
    public class OTPCipherLibTest
    {
        CipherLib.OTPCipher otp = null;

        [SetUp]
        public void SetUpCipherLib()
        {

        }
    

        [TestCase("abc", Result = "abc")]
        [TestCase("a bc", Result = "abc")]
        [TestCase("we98", Result = "we")]
        [TestCase("w$;98", Result = "w")]
        [TestCase("w$;98", Result = "w")]
        [TestCase("!@#$%^&*()[]:<>/", Result = "")]
        public string ReplaceNonAlpha(string textToCipher)
        {
            otp = new CipherLib.OTPCipher(textToCipher);
            textToCipher = otp.ReplaceAllNonAlphaChars(textToCipher);
            //Assert.AreEqual(expectedVal, retVal);
            return (textToCipher);
        }

        [TestCase('A', Result = 0)]
        [TestCase('F', Result = 5)]
        [TestCase('I', Result = 8)]
        [TestCase('O', Result = 14)]
        [TestCase('T', Result = 19)]
        [TestCase('Z', Result = 25)]
        public short GetLetterNumber(char letter)
        {
            otp = new CipherLib.OTPCipher("");
            return otp.GetLetterNumber(letter);
        }

        [TestCase(0, Result = 'A')]
        [TestCase(5, Result = 'F')]
        [TestCase(8, Result = 'I')]
        [TestCase(14, Result = 'O')]
        [TestCase(19, Result = 'T')]
        [TestCase(25, Result = 'Z')]
        public char GetLetterByNumber(short number)
        {
            otp = new CipherLib.OTPCipher("");
            return otp.GetLetterByNumber(number);
        }


    }
}
