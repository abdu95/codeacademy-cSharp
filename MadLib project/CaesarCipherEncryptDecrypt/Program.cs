using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherEncryptDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            /* version 1*/
            /**/
            //char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //Console.WriteLine("Enter a secret message");
            //string input = Console.ReadLine();
            //char[] secretMessage = input.ToCharArray();
            //char[] encryptedMessage = new char[secretMessage.Length];

            //for (int i = 0; i < secretMessage.Length; i++)
            //{
            //    char item = secretMessage[i];
            //    int position = Array.IndexOf(alphabet, item);
            //    int newPosition = (position + 3) % alphabet.Length;
            //    char character = alphabet[newPosition];
            //    encryptedMessage[i] = character;
            //}
            //string encryptedString = String.Join("", encryptedMessage);
            //Console.WriteLine(encryptedString);
            /**/
            /* version 2*/
            /**/
            Console.WriteLine("Enter a secret message");
            string userInput = Console.ReadLine();
            string input = userInput.ToLower();
            char[] secretMessage = input.ToCharArray();
            char[] encrypted = Decrypt(secretMessage, 3);
            string encryptedString = String.Join("", encrypted);
            Console.WriteLine(encryptedString);
            Console.ReadLine();
        }

        public static char[] Encrypt(char[] charArray, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] encryptedMessage = new char[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                char item = charArray[i];
                int position = Array.IndexOf(alphabet, item);
                int newPosition = (position + key) % alphabet.Length;
                char character = alphabet[newPosition];
                encryptedMessage[i] = character;
            }
            return encryptedMessage;
        }

        public static char[] Decrypt(char[] charArray, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] encryptedMessage = new char[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                char item = charArray[i];
                if (!Char.IsLetter(item))
                    continue;
                int position = Array.IndexOf(alphabet, item);
                int newPosition = (position - key) % alphabet.Length;
                char character = alphabet[newPosition];
                encryptedMessage[i] = character;
            }
            return encryptedMessage;
        }

    }
}
