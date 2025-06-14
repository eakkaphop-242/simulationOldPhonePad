namespace simulationOldPhonePad;

class Program
{
    private static List<string> userInput = [];
    private static string rawInput = "";

    /// <summary>
    /// Is simulation Old phone pad for send message 
    /// if input 2  ex. '2' = A, '22' = B, '222' = C
    /// the system will create task when you input 1st char = 1 task 
    /// that task can holding 2 sec. 
    /// * = backspace, # = end of input or send button
    /// </summary>
    static void Main(string[] args)
    {
        ConsoleKeyInfo cki;
        Console.TreatControlCAsInput = true;
        Console.WriteLine("Press the Escape (Esc) key to quit: \n");
        OldPhoneService oldPhoneService = new OldPhoneService();
        bool isInput = true;
        do
        {
            // show log key input in console 
            // show use false 
            // not show use true
            cki = Console.ReadKey(true);
            // check user input pad and that first time.
            if (isInput)
            {
                isInput = false;
                // validation in input
                // see detail in  OldPhoneService.cs 
                // function validationInput()
                if (oldPhoneService.validationInput(cki))
                {
                    //the system will append text to rawInput
                    rawInput += cki.KeyChar.ToString();
                    // create task count 2 sec. 
                    _ = Task.Run(() =>
                    {
                        Task.Delay(2000).Wait();
                        // wait 2 sec and add rawInput to list<string> userInput
                        if (cki.KeyChar.ToString() != "#") userInput.Add(rawInput);
                        Console.WriteLine("Message :: '" + rawInput + "'");
                        // clear rawInput for next task 
                        rawInput = "";
                        isInput = true;
                    });
                }
            }
            else
            {
                if (oldPhoneService.validationInput(cki))
                {
                    //append text to rawInput
                    rawInput += cki.KeyChar.ToString();
                }
            }
            //when text # = end of input or send button
            if (cki.KeyChar.ToString() == "#")
            {
                // clear value to defalt true 
                isInput = true;
                // covert list<string> to string 
                string textMessage = String.Join("", userInput);
                // call service OldPhonePad 
                Console.WriteLine("output : " + oldPhoneService.OldPhonePad(textMessage));
                userInput.Clear();
            }
        // Input ESC for Escape program.
        } while (cki.Key != ConsoleKey.Escape);
    }
    
    
}


