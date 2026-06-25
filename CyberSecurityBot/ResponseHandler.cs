using System;
using System.Collections.Generic;

namespace CyberSecurityBot
{
    class ResponseHandler
    {
        private Random rand = new Random();

        private string currentTopic = "";

        private List<string> passwordTips = new List<string>()
        {
            "Use strong passwords with symbols and numbers.",
            "Never reuse passwords across accounts.",
            "Avoid using personal details in passwords."
        };

        private List<string> phishingTips = new List<string>()
        {
            "Do not click unknown email links.",
            "Check sender email carefully.",
            "Avoid downloading suspicious attachments."
        };

        public string GetResponse(string input)
        {
            input = input.ToLower();

            // Sentiment
            if (input.Contains("worried"))
                return "It's okay to feel worried. I will help you stay safe.";

            if (input.Contains("frustrated"))
                return "Cybersecurity can be tricky, but I’m here to help.";

            // Keywords
            if (input.Contains("password"))
            {
                currentTopic = "password";
                return passwordTips[rand.Next(passwordTips.Count)];
            }

            if (input.Contains("phishing"))
            {
                currentTopic = "phishing";
                return phishingTips[rand.Next(phishingTips.Count)];
            }

            if (input.Contains("scam"))
            {
                currentTopic = "scam";
                return "Never share personal or banking details online.";
            }

            if (input.Contains("privacy"))
            {
                currentTopic = "privacy";
                return "Keep your accounts private and enable 2FA.";
            }

            // Conversation flow
            if (input.Contains("tell me more"))
            {
                if (currentTopic == "password")
                    return "Change passwords regularly for better security.";

                if (currentTopic == "phishing")
                    return "Phishing emails often pretend to be banks or companies.";

                if (currentTopic == "privacy")
                    return "Limit what you share on social media.";

                if (currentTopic == "scam")
                    return "Scammers often pressure you to act fast.";
            }

            // General
            if (input.Contains("how are you"))
                return "I am safe and ready to help you.";

            if (input.Contains("purpose"))
                return "I help you learn cybersecurity safety.";

            if (input.Contains("what can i ask"))
                return "Ask me about passwords, scams, phishing, and privacy.";

            return "I didn't understand that. Please rephrase.";
        }
    }
}