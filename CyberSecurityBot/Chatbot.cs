namespace CyberSecurityBot
{
    class Chatbot
    {
        // Create object from ResponseHandler
        private ResponseHandler responseHandler;

        // Constructor
        public Chatbot()
        {
            responseHandler = new ResponseHandler();
        }

        // Method to get bot response
        public string GetResponse(string userInput)
        {
            // Validate empty input
            if (string.IsNullOrWhiteSpace(userInput))
            {
                return "Please enter a message.";
            }

            // Send user message to ResponseHandler
            return responseHandler.GetResponse(userInput);
        }
    }
}