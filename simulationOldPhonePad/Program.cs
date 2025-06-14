namespace simulationOldPhonePad;

class Program
{
    private static List<string> userInput = [];
    private static string Typing = "";
    static void Main(string[] args)
    {
        ConsoleKeyInfo cki;
        Console.TreatControlCAsInput = true;
        Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
        Console.WriteLine("Press the Escape (Esc) key to quit: \n");

        OldPhoneService oldPhoneService = new OldPhoneService();
        bool isInput = true;
        do
        {
            cki = Console.ReadKey(true);
            // need time to sec for count input
            if (isInput)
            {
                isInput = false;
                if (cki.KeyChar.ToString() != "#" && Char.IsNumber(cki.KeyChar) || cki.KeyChar.ToString() == "*" || cki.Key == ConsoleKey.Spacebar)
                { 
                        Typing += cki.KeyChar.ToString();
                    _ = Task.Run(() =>
                    {
                        //Console.WriteLine("CREATE TASK");
                        Task.Delay(2000).Wait();
                        if (cki.KeyChar.ToString() != "#") userInput.Add(Typing);
                        //Console.WriteLine("TEXT :: '" + Typing +"'");
                        //clear text typing
                        Typing = "";
                        isInput = true;
                        //Console.WriteLine("END TASK");
                    });
                }
            }
            else
            {
                if (cki.KeyChar.ToString() != "#" && Char.IsNumber(cki.KeyChar) || cki.KeyChar.ToString() == "*" || cki.Key == ConsoleKey.Spacebar)
                {
                    Typing += cki.KeyChar.ToString();
                }
            }
            if (cki.KeyChar.ToString() == "#")
            {
                isInput = true;
                string textMessage = String.Join("", userInput);
                Console.WriteLine("output : " + oldPhoneService.OldPhonePad(textMessage));
                userInput.Clear();
            } 
            if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
            if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
            if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
        } while (cki.Key != ConsoleKey.Escape);
    }
}


