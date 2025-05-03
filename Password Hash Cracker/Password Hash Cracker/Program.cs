using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class PasswordHashCracker
{
    // Method to generate the hash of a string using MD5 (you can swap it for SHA1, SHA256)
    static string GenerateHash(string input, string algorithm = "MD5")
    {
        using (var hashAlgorithm = HashAlgorithm.Create(algorithm))
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = hashAlgorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }

    static string DictionaryAttack(string hash, string wordlistPath)
    {
        if (!File.Exists(wordlistPath))
        {
            Console.WriteLine("Wordlist file not found.");
            return null;
        }

        Console.WriteLine("Starting dictionary attack...");

        foreach (var line in File.ReadLines(wordlistPath))
        {
            string hashedLine = GenerateHash(line);
            if (hashedLine == hash)
            {
                return line; 
            }
        }
        return null;
    }

    static string BruteForceAttack(string hash, int maxLength = 6)
    {
        string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return BruteForceRecursive(hash, characters, "", maxLength);
    }

    static string BruteForceRecursive(string hash, string characters, string current, int maxLength)
    {
        if (current.Length == maxLength)
        {
            string hashedCurrent = GenerateHash(current);
            if (hashedCurrent == hash)
                return current;
            return null;
        }

        foreach (var c in characters)
        {
            string result = BruteForceRecursive(hash, characters, current + c, maxLength);
            if (result != null)
                return result;
        }
        return null;
    }

    static void DisplayBanner()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"
  _____                                    _                
 |  __ \                                  | |               
 | |__) |_ _ ___ _____      _____  _ __ __| |               
 |  ___/ _` / __/ __\ \ /\ / / _ \| '__/ _` |               
 | |  | (_| \__ \__ \\ V  V / (_) | | | (_| |               
 |_|   \__,_|___/___/ \_/\_/ \___/|_|  \__,_| _             
 | |             | |                         | |            
 | |__   __ _ ___| |__     ___ _ __ __ _  ___| | _____ _ __ 
 | '_ \ / _` / __| '_ \   / __| '__/ _` |/ __| |/ / _ \ '__|
 | | | | (_| \__ \ | | | | (__| | | (_| | (__|   <  __/ |   
 |_| |_|\__,_|___/_| |_|  \___|_|  \__,_|\___|_|\_\___|_|   
                                                            
                                                                          
               Password Hash Cracker  - Add discord: threadline_
");
    }
    static void Main()
    {
        while (true)
        {
            DisplayBanner();
            Console.Write("Enter the hash (MD5, SHA1, SHA256): ");
            string hash = Console.ReadLine().ToLower().Trim();

            if (string.IsNullOrEmpty(hash))
            {
                Console.WriteLine("Hash cannot be empty. Try again.");
                continue;
            }

            Console.WriteLine("Choose attack method:");
            Console.WriteLine("1. Dictionary Attack");
            Console.WriteLine("2. Brute-force Attack");
            Console.Write("Enter choice (1 or 2, or 'exit' to quit): ");
            string choice = Console.ReadLine().Trim().ToLower();

            if (choice == "exit")
                break;

            string result = null;
            if (choice == "1")
            {
                string wordlistPath = "";
                while (string.IsNullOrEmpty(wordlistPath))
                {
                    Console.Write("Enter path to wordlist file (or 'exit' to quit): ");
                    wordlistPath = Console.ReadLine().Trim();

                    if (wordlistPath == "exit")
                        break;

                    if (!File.Exists(wordlistPath))
                    {
                        Console.WriteLine("Invalid file path. Please provide a valid wordlist file.");
                        wordlistPath = ""; 
                    }
                }

                if (wordlistPath == "exit")
                    break;

                result = DictionaryAttack(hash, wordlistPath);
            }
            else if (choice == "2")
            {
                result = BruteForceAttack(hash);
            }

            if (result != null)
            {
                Console.WriteLine($"Password found: {result}");
            }
            else
            {
                Console.WriteLine("Password not found.");
            }

            Console.WriteLine("Press any key to continue or 'exit' to quit.");
            string continueChoice = Console.ReadLine().Trim().ToLower();
            if (continueChoice == "exit")
                break;
        }

        Console.WriteLine("Exiting the tool. Goodbye!");
    }
}
