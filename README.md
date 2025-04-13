🔓 Password Hash Cracker (Dictionary + Brute Force) 🔑
🚀 Description
Password Hash Cracker is a powerful tool designed to crack hashed passwords using both dictionary and brute force techniques. This tool allows you to recover plaintext passwords from commonly used hash algorithms like MD5, SHA-1, and SHA-256. With the flexibility of using custom wordlists or relying on brute force, this tool provides a comprehensive approach to password recovery.

It is designed for security professionals 🛡️, ethical hackers 🕵️‍♂️, and individuals looking to test the strength of their own password hashes 🔐.

The tool is simple to use, yet powerful enough to tackle real-world password cracking scenarios 🔨.

✨ Features
Supports MD5, SHA-1, and SHA-256 password hashes 🔐.

Two cracking methods:

Dictionary Attack: Uses a predefined list of possible passwords 📜.

Brute Force Attack: Tries all possible combinations up to a specified length 🔢.

Customizable wordlist input or default wordlist options 🔄.

Simple and clear output to track cracking progress 📊.

Real-time status updates for brute-force attempts ⏱️.

🔧 Prerequisites
Before running the tool, ensure you have:

.NET 6.0 or higher installed (if not, download it here) 📦.

A valid hash to crack 🔑.

📥 Installation
Clone the repository to your local machine:


git clone https://github.com/your-username/Password-Hash-Cracker.git
Navigate to the project directory:


cd Password-Hash-Cracker
Compile the project:


dotnet build
Run the tool:


dotnet run
Alternatively, if you have already built the project, navigate to the bin/debug/net8.0/ folder and run the executable:


./PasswordHashCracker.exe
🛠️ Usage
📝 Dictionary Attack:
To crack a hash using a wordlist:


PasswordHashCracker.exe -h [hash_to_crack] -w [path_to_wordlist]
🔨 Brute Force Attack:
To perform a brute-force attack with a custom length:


PasswordHashCracker.exe -h [hash_to_crack] -b [min_length] [max_length]
Where:

-h [hash] is the hash you want to crack 🔐.

-w [wordlist] is the path to your custom wordlist 📜.

-b [min_length] [max_length] is the range for the brute-force attack 🔢.

🎯 Example:
Cracking an MD5 hash using the default wordlist:


PasswordHashCracker.exe -h 098f6bcd4621d373cade4e832627b4f6 -w wordlist.txt
Cracking a SHA-1 hash using brute force with a minimum length of 4 and maximum length of 6:


PasswordHashCracker.exe -h fcea920f7412b5da7be0cf42b8c93759 -b 4 6
💡 Contributing
Contributions to this project are welcome 🤝. If you have any ideas for improvements or features, feel free to fork this repository, create a pull request, or open an issue 📝.

Please make sure to follow the coding standards and write clear, descriptive commit messages 📚.

⚠️ Disclaimer
This tool is intended for ethical hacking and password recovery only ⚖️. Use it responsibly and ensure you have permission to test the systems you are cracking 🔒. Unauthorized use of this tool may be illegal and unethical 🚫.

