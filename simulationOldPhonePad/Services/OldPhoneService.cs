
namespace simulationOldPhonePad
{

    public class OldPhoneService
    {
        /// <summary>
        /// 
        /// </summary>
        Dictionary<string, string> Alphabet = Constants.ALPHABETICAL;


        /// <summary>
        /// Convert raw input (number) to text message 
        /// </summary>
        public string OldPhonePad(string userInput)
        {
            List<string> padText = new List<string>();
            userInput = handleCharacter(userInput);
            for (int index = 0; index < userInput.Length;)
            {
                string currentText = userInput.Substring(index, 1);
                string nextText = index + 1 < userInput.Length ? userInput.Substring(index + 1, 1) : "";
                if (currentText != nextText)
                {
                    padText.Add(userInput.Substring(0, index + 1));
                    userInput = userInput.Remove(0, index + 1);
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            string textMessage = MappingCharacter(padText);
            return errorOutput(textMessage);
        }

        /// <summary>
        /// This function is handle backspace input 
        /// </summary>
        private string handleCharacter(string userInput)
        {
            while (userInput.IndexOf("*") != -1)
            {
                userInput = userInput.Remove(userInput.IndexOf("*") - 1, 2);
            }
            return userInput;
        }

        /// <summary>
        /// This function is Mapping Char ex 222 = C , 2 = A , 22 = B
        /// Handle spacebar and # 
        /// </summary>
        private string MappingCharacter(List<string> userInput)
        {
            string textMessage = "";
            userInput.ForEach((x) =>
            {
                string value;
                x = x.Replace(" ", "").Replace("#", "");
                if (x != "")
                {
                    value = Alphabet.ContainsKey(x) ? Alphabet[x] : "?";
                    textMessage += value;
                }
            });
            return textMessage;
        }

        /// <summary>
        /// This function is replace all characters when found ? 
        /// </summary>
        private string errorOutput(string textMessage)
        {
            if (textMessage.IndexOf("?") != -1)
            {
                for (int i = 0; i < textMessage.Length; i++)
                {
                    if (textMessage.Substring(i, 1) != "?")
                    {
                        textMessage = textMessage.Replace(textMessage.Substring(i, 1), "?");
                    }
                }
            }
            return textMessage;
        }

        /// <summary>
        /// This function is validation raw input 
        /// not allow Alphabet and special characters
        /// </summary>
        public bool validationInput(ConsoleKeyInfo keyInput)
        {
            return keyInput.KeyChar.ToString() != "#"
                   && Char.IsNumber(keyInput.KeyChar)
                   || keyInput.KeyChar.ToString() == "*"
                   || keyInput.Key == ConsoleKey.Spacebar;
        }
    }
}