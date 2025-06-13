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
            if (isInput && cki.KeyChar.ToString() != "#")
            {
                isInput = false;
                Typing += cki.KeyChar.ToString();
                _ = Task.Run(() =>
                {
                    Console.WriteLine("CREATE TASK");
                    Task.Delay(3000).Wait();
                    if (cki.KeyChar.ToString() != "#") userInput.Add(Typing);
                    Typing = "";
                    isInput = true;
                    Console.WriteLine("END TASK");
                });
            }
            else
            {
                if (cki.KeyChar.ToString() != "#") Typing += cki.KeyChar.ToString();
                Console.WriteLine("CURRENT TEXT ::" + Typing);
                oldPhoneService.OldPhonePad(userInput);
            }

            // Console.WriteLine(" --- You pressed ");
            if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
            if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
            if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");

            // //Console.WriteLine(OldPhonePad(cki.KeyChar.ToString()) ? OutPut() : "");

            //} while (cki.Key != ConsoleKey.Escape);
            //} while (cki.KeyChar.ToString() != "#");

        } while (cki.KeyChar.ToString() != "#");
        userInput.ForEach(Console.WriteLine);
    }
}


