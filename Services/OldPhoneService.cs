
namespace simulationOldPhonePad
{

    public class OldPhoneService
    {
        Dictionary<string, string> Alphabet = Constants.ALPHABETICAL;

        public void OldPhonePad(string userInput)
        {
            List<string> padText = new List<string>();
            userInput = handleCharacter(userInput);
            for (int index = 0; index < userInput.Length; index++)
            {
                string currentText = userInput.Substring(index, 1);
                string nextText = index + 1 < userInput.Length ? userInput.Substring(index + 1, 1) : "";
                if (currentText != nextText)
                {
                    padText.Add(userInput.Substring(0, index + 1));
                    userInput = userInput.Remove(0, index + 1);
                    index = 0;
                }
            }
            string textMessage = MappingCharacter(padText);
            Console.WriteLine("output : " + errorOutput(textMessage));
        }

        private string handleCharacter(string userInput)
        {
            while (userInput.IndexOf("*") != -1) {
                userInput = userInput.Remove(userInput.IndexOf("*") - 1, 2);
            }
            return userInput;
        }

        private string MappingCharacter(List<string> userInput)
        {
            string textMessage = "";
            userInput.ForEach((x) =>
            {
                string value;
                x = x.Replace(" ", "");
                if (x.Contains(""))
                {
                    value = Alphabet.ContainsKey(x) ? Alphabet[x] : "?";
                    textMessage += value;
                }

            });
            return textMessage;
        }

        private string errorOutput(string textMessage) {
            if (textMessage.IndexOf("?") != -1) { 
                for (int i = 0; i < textMessage.Length; i++)
                {
                    if (textMessage.Substring(i,1) != "?") {
                        textMessage = textMessage.Replace(textMessage.Substring(i, 1), "?");
                    }
                }
            }
            return textMessage;
        }
    }
}