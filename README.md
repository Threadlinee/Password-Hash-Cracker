# 🔓 Password Hash Cracker (Dictionary + Brute Force) 🔑



![image](https://github.com/user-attachments/assets/d70f8761-ec88-408a-bfd2-f3eed9d38123)




![image](https://github.com/user-attachments/assets/a5f41e83-9572-49d4-a13e-06c4f0c0dcff)



# 🚀 Description
The Password Hash Cracker is a versatile and efficient tool designed to crack password hashes using Dictionary and Brute Force methods. It supports common hash algorithms such as MD5, SHA-1, and SHA-256.

Whether you're a security professional 🛡️, an ethical hacker 🕵️‍♂️, or just someone testing your own hashed passwords 🔐, this tool helps you recover plaintext passwords from hashed values. You can use a wordlist (dictionary attack) or try all possible combinations up to a given length (brute force).

# 🛠️ Key Features:

MD5, SHA-1, and SHA-256 hash cracking support 🔑.

Dictionary Attack: Cracks hashes using a wordlist 📜.

Brute Force Attack: Tries every possible combination 🔢.

Custom Wordlist: Input your own wordlist for cracking 📑.

Real-time updates: Progress tracking for brute force attacks 📊.

Simple and easy-to-understand CLI interface 🎮.

# 💻 Installation and Setup
Windows and Linux Instructions:
1. Clone the Repository
To get started, clone the project from GitHub:

git clone https://github.com/dionabazi/Password-Hash-Cracker.git
2. Navigate to the Project Folder
Change to the directory where you cloned the repository:

cd Password-Hash-Cracker
3. Build the Project
Once inside the folder, compile the project using .NET 6.0 or above:

dotnet build
4. Run the Tool
Run the tool using the following command:

dotnet run
Alternatively, if you've already built it, navigate to the bin/debug/net8.0/ folder and run the executable directly:

# Windows:

./PasswordHashCracker.exe
Linux:

./PasswordHashCracker
🔧 Usage
Once the tool is running, you can use Dictionary Attack or Brute Force Attack to crack password hashes.

Dictionary Attack:
To crack a password hash using a wordlist, use this command:

PasswordHashCracker.exe -h [hash_to_crack] -w [path_to_wordlist]
Where:

-h [hash] is the hash you want to crack.

-w [wordlist] is the path to your wordlist.

# Example (Windows):

PasswordHashCracker.exe -h 098f6bcd4621d373cade4e832627b4f6 -w wordlist.txt
Brute Force Attack:
To perform a brute force attack with a custom length (e.g., between 4 and 6 characters):

PasswordHashCracker.exe -h [hash_to_crack] -b [min_length] [max_length]
Where:

-h [hash] is the hash you want to crack.

-b [min_length] [max_length] specifies the range of characters for brute-forcing.

# Example (Windows):

PasswordHashCracker.exe -h fcea920f7412b5da7be0cf42b8c93759 -b 4 6
# 🔨 Example Commands
Cracking an MD5 hash using the default wordlist:

PasswordHashCracker.exe -h 098f6bcd4621d373cade4e832627b4f6 -w wordlist.txt
Cracking a SHA-1 hash with brute-force (min length 4, max length 6):

PasswordHashCracker.exe -h fcea920f7412b5da7be0cf42b8c93759 -b 4 6
# ⚠️ Disclaimer
This tool is intended for ethical hacking 🛡️, password recovery 🔑, and testing purposes only. Use it responsibly and only on systems you have permission to test. Unauthorized use is illegal and unethical 🚫. Always follow legal and ethical guidelines when using this tool.

# 🤝 Contributing
Contributions are welcome! If you find bugs or have ideas for new features, feel free to fork the project and create a pull request. We follow the guidelines below for contributions:

Fork the repository and make your changes.

Create a descriptive pull request with details of what you've done.

Follow the code style and add clear comments to your code.

We appreciate your contributions! 🎉

# 📜 License
This project is open-source and available under the MIT License.

