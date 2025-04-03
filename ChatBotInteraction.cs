using System.Collections.Generic;
using System;
using System.Collections;

public class ChatBotInteraction
{// Lists to store user inputs and corresponding bot responses
    private ArrayList userInputs = new ArrayList();
    private ArrayList botResponses = new ArrayList();
    

    // Constructor to initialize the chatbot and its responses
    public ChatBotInteraction()
    {
        // Initialize user inputs and bot responses
        InitializeResponses();
    }

    // Method to populate user inputs and bot responses
    private void InitializeResponses()
    {
        // Responses for greetings and asking of name
        userInputs.Add("who created you");
        botResponses.Add("I was created my Ayanda Maseko an innovated IT professional.");


        userInputs.Add("how are you");
        botResponses.Add("I'm good thanks hope you are too, and if you aren't always remember that you the GOAT!");

        userInputs.Add("what is your purpose");
        botResponses.Add("My purpose is to make sure you have the best information on cyber security and being safe online!");

        userInputs.Add("what should I ask you");
        botResponses.Add("You can ask me about phishing and how to have a safe password, you can even ask how I'm doing.");

        // Security questions
        userInputs.Add("" +
            " phishing");
        botResponses.Add("To protect yourself from phishing, avoid clicking on suspicious links, don't give out personal information via email or phone, and always verify the source before entering sensitive data.");

        userInputs.Add("what is phishing");
        botResponses.Add("Phishing is when someone pretends to be a legitimate organization or individual in order to steal sensitive information such as passwords, credit card numbers, and more. Always be cautious when receiving unsolicited emails or messages asking for personal information.");

        userInputs.Add("tell me about phishing");
        botResponses.Add("Phishing is a cyber attack where attackers impersonate legitimate organizations to steal sensitive information. Always verify the source before entering sensitive data.");

        userInputs.Add("how to protect against phishing");
        botResponses.Add("To protect against phishing, always check the sender's email address, avoid clicking on suspicious links, and use two-factor authentication.");

        userInputs.Add("safe password");
        botResponses.Add("A strong password is at least 12 characters long and includes a mix of uppercase and lowercase letters, numbers, and symbols. Avoid using common words, names, or easily guessable information.");

        userInputs.Add("password safety");
        botResponses.Add("To keep your passwords safe, use a password manager to generate and store complex passwords. Enable two-factor authentication whenever possible, and never reuse passwords across different accounts.");
    }

    // Method to start the chatbot interaction
    public void StartChat()
    {
        // Display welcome message
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
        TypeEffect("Hello! Welcome to Massa the cybersecurity awareness bot 9.0, I'm here to make sure you have a safe online experience.\n");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
        Console.ResetColor();

        // Ask for the user's name and ensure it's not empty
        string userName = "";
        while (string.IsNullOrEmpty(userName))
        {
            Console.ForegroundColor = ConsoleColor.White;
            TypeEffect("What is your name?: ");
            Console.ResetColor();
            userName = Console.ReadLine()?.Trim();

            // If the user doesn't enter anything, ask again
            if (string.IsNullOrEmpty(userName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                TypeEffect("Massa: I need a valid name to continue.\n");
                Console.ResetColor();
            }
        }

        // Greet the user
        Console.ForegroundColor = ConsoleColor.White;
        TypeEffect($"Hello, {userName}! Great to know you, lets get started. I am here to assist you on cybersecurity. Ask me something. Type 'exit' to end the chat.\n");
        Console.ResetColor();

        // Infinite loop for conversation
        while (true)
        {
            // Prompt for user input
            Console.ForegroundColor = ConsoleColor.White;
            TypeEffect($"{userName}: ");
            Console.ResetColor();
            string userInput = Console.ReadLine()?.Trim();

            // Check if user input is valid and not empty
            if (string.IsNullOrEmpty(userInput))
            {
                Console.ForegroundColor = ConsoleColor.White;
                TypeEffect("Massa: Please enter something.\n");
                Console.ResetColor();
                continue; // Continue to the next iteration of the loop
            }

            // Exit condition
            if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                TypeEffect("Goodbye! And we hope you enjoyed using Massa. Have a great day, till next time.\n");
                Console.ResetColor();
                break; // Exit the loop
            }

            bool foundResponse = false; // Flag to check if a response was found

            // Convert user input to lowercase for comparison
            string userInputLower = userInput.ToLower();

            // Loop to check if there are any keywords
            for (int i = 0; i < userInputs.Count; i++)
            {
                // Convert keywords to lowercase and check if the input contains the keyword
                string keyword = userInputs[i].ToString().ToLower();

                // Check if the user input contains the keyword 
                if (userInputLower.Contains(keyword))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    TypeEffect("Massa: " + botResponses[i] + "\n");
                    Console.ResetColor();
                    foundResponse = true; // Set flag to true if a response is found
                    break; // Exit the loop since a response has been found
                }
            }

            // If no matching keyword was found, type message
            if (!foundResponse)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                TypeEffect("Massa: Sorry, I don't understand that. Can you rephrase?\n");
                Console.ResetColor();
            }
        }
    }

    // Method to create a typing effect for messages
    private void TypeEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(50); // Adjust the speed of typing effect
        }
    }
}

