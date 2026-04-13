using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbot
{
    internal class Chatbot
    {
        private string userName;

        public void StartChat()
        {
            
            // GET USER NAME WITH VALIDATION
            userName = InputHandler.GetValidName();

            UIHelper.PrintDivider();


            // WELCOME MESSAGE
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Welcome {userName}! I am your Cybersecurity Awareness Assistant.");
            Console.ResetColor();

            UIHelper.PrintDivider();

            
            // HELP / INFO SECTION
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("I can help you with:");
            Console.WriteLine("- Password safety & security");
            Console.WriteLine("- Phishing scams & fake emails");
            Console.WriteLine("- Safe browsing habits");
            Console.WriteLine("- Malware & viruses");
            Console.WriteLine("- Hacking & cyber attacks");
            Console.WriteLine("- Two-factor authentication (2FA)");
            Console.WriteLine("\nType 'help' to see this again anytime.");
            Console.WriteLine("Type 'exit' or 'bye' to quit.");
            Console.ResetColor();

            UIHelper.PrintDivider();

            
            // MAIN CHAT LOOP
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower() ?? "";

                if (string.IsNullOrWhiteSpace(input))
                {
                    UIHelper.PrintBot("Please type something so I can help you.");
                    continue;
                }

                if (input.Contains("exit") || input.Contains("bye"))
                {
                    UIHelper.PrintBot("Goodbye! Stay safe online and protect your digital identity.");
                    break;
                }

                if (input.Contains("help"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nI can help you with:");
                    Console.WriteLine("- Password safety & security");
                    Console.WriteLine("- Phishing scams & fake emails");
                    Console.WriteLine("- Safe browsing habits");
                    Console.WriteLine("- Malware & viruses");
                    Console.WriteLine("- Hacking & cyber attacks");
                    Console.WriteLine("- Two-factor authentication (2FA)\n");
                    Console.ResetColor();
                    continue;
                }

                Respond(input);
            }
        }

        
        // RESPONSE ENGINE 
        private void Respond(string input)
        {
            if (input.Contains("hello") || input.Contains("hi"))
            {
                UIHelper.PrintBot(
                    "Hello " + userName + ". Cybersecurity is the protection of digital systems and data. " +
                    "It is important because many people use the internet daily for communication and banking. " +
                    "Online threats such as hacking and scams are common in digital environments. " +
                    "Understanding these risks helps users stay safe and avoid cyber attacks. " +
                    "I am here to guide you in learning how to protect yourself online."
                );
            }

            else if (input.Contains("how are you"))
            {
                UIHelper.PrintBot(
                    "I am functioning correctly as a cybersecurity assistant. " +
                    "My systems are designed to analyze and respond to online safety questions. " +
                    "Cyber threats constantly change and become more advanced over time. " +
                    "It is important for users to stay updated with security knowledge. " +
                    "My purpose is to help you understand and avoid digital risks."
                );
            }

            else if (input.Contains("purpose") || input.Contains("what do you do"))
            {
                UIHelper.PrintBot(
                    "My purpose is to educate users about cybersecurity concepts. " +
                    "I explain online threats such as phishing, hacking, and malware. " +
                    "I also guide users on safe internet behavior and data protection. " +
                    "Cybersecurity knowledge is essential in today’s digital world. " +
                    "My goal is to improve your awareness and online safety."
                );
            }

            else if (input.Contains("what is cyber") || input.Contains("cybersecurity"))
            {
                UIHelper.PrintBot(
                    "Cybersecurity is the practice of protecting computers and networks. " +
                    "It prevents unauthorized access, damage, and data theft. " +
                    "It is used to secure personal, business, and government information. " +
                    "Without cybersecurity, systems become vulnerable to cyber attacks. " +
                    "It ensures safety and trust in the digital environment."
                );
            }

            else if (input.Contains("password"))
            {
                UIHelper.PrintBot(
                    "A password is a security measure used to protect accounts. " +
                    "Strong passwords include letters, numbers, and special symbols. " +
                    "They are used to prevent unauthorized access to personal data. " +
                    "Weak passwords increase the risk of hacking and identity theft. " +
                    "Good password habits are essential for online safety."
                );
            }

            else if (input.Contains("phishing"))
            {
                UIHelper.PrintBot(
                    "Phishing is a cyber attack where criminals impersonate trusted sources. " +
                    "It is used to trick users into revealing sensitive information. " +
                    "These attacks often come through fake emails or websites. " +
                    "Phishing can lead to stolen passwords and financial loss. " +
                    "Users must always verify messages before responding or clicking links."
                );
            }

            else if (input.Contains("malware") || input.Contains("virus"))
            {
                UIHelper.PrintBot(
                    "Malware is malicious software designed to harm computer systems. " +
                    "It includes viruses, spyware, ransomware, and trojans. " +
                    "It is used to steal data or damage files and systems. " +
                    "Malware spreads through unsafe downloads and links. " +
                    "Protection requires antivirus software and safe browsing habits."
                );
            }

            else if (input.Contains("hacking"))
            {
                UIHelper.PrintBot(
                    "Hacking is the act of gaining unauthorized access to systems. " +
                    "It can be used for both ethical and malicious purposes. " +
                    "Ethical hackers improve security by finding system weaknesses. " +
                    "Malicious hackers steal data or cause system damage. " +
                    "Strong cybersecurity reduces the risk of hacking attacks."
                );
            }

            else if (input.Contains("link") || input.Contains("url"))
            {
                UIHelper.PrintBot(
                    "A link is a clickable address that leads to a website. " +
                    "Cybercriminals often use fake links to steal information. " +
                    "Users should check URLs carefully before clicking them. " +
                    "Secure websites usually start with HTTPS encryption. " +
                    "Safe link usage prevents phishing and malware infections."
                );
            }

            else if (input.Contains("2fa") || input.Contains("two factor"))
            {
                UIHelper.PrintBot(
                    "Two-factor authentication is an extra layer of security. " +
                    "It requires a second verification step beyond a password. " +
                    "This is often a code sent to your phone or email. " +
                    "It protects accounts even if passwords are stolen. " +
                    "It is one of the strongest methods of account security."
                );
            }

            else if (input.Contains("safe browsing") || input.Contains("internet"))
            {
                UIHelper.PrintBot(
                    "Safe browsing is the practice of using the internet securely. " +
                    "It involves avoiding suspicious websites and unsafe downloads. " +
                    "Users should always check for HTTPS connections. " +
                    "Personal information should not be shared carelessly online. " +
                    "Safe browsing reduces exposure to cyber threats."
                );
            }

            else if (input.Contains("help"))
            {
                UIHelper.PrintBot(
                    "I can help you understand cybersecurity topics in detail. " +
                    "These include passwords, phishing, malware, and hacking. " +
                    "I also explain safe browsing and online protection methods. " +
                    "You can ask any question related to cyber safety. " +
                    "I will always provide clear and detailed explanations."
                );
            }

            else
            {
                UIHelper.PrintBot(
                    "I did not understand your question clearly. " +
                    "However, I can still help you learn cybersecurity concepts. " +
                    "You can ask about passwords, phishing, malware, or hacking. " +
                    "I will explain each topic in detail for better understanding. " +
                    "Try asking a specific question for best results."
                );
            }
        }
    }
}
