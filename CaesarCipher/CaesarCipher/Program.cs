using System;
using System.Runtime.Intrinsics.Arm;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main()
        {
            // This is a project made with CodeCademy, and I've adaptet a few things
            // like validating user input and introducing an getting encrypting key from user


            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Please insert your word:");
            string message = Console.ReadLine();  // getting user input - the word he wants to encrypt
            char[] secretMessage = message.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];
            bool validateKey = false;
            int key = 0;
            Console.WriteLine("Please insert an encryption key ( must be a numeric value bigger than 1 ): "); // getting a key from user for encrypting message
            do
            {
                string keyInput = Console.ReadLine();
                if (Int32.TryParse(keyInput, out key) == false) // validating the input, forcing the user to input a valid value
                {
                    Console.WriteLine($"\"{keyInput}\" is not a valid key value!\nPlease insert a numeric value bigger than 1: ");
                }
                else
                {
                    validateKey = true;
                }

            } while (!validateKey);
            
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char character = secretMessage[i];
                int position = Array.IndexOf(alphabet, character);
                int newLetterPosition = (position + key) % alphabet.Length;
                encryptedMessage[i] = alphabet[newLetterPosition];
            }

            Console.WriteLine($"Your encrypted message is: {String.Join("", encryptedMessage)}");
        }
    }
}
