namespace simulationOldPhonePad;

class Program
{
    private static List<string> Arr = [];
    private static string Typing = "";
    //private static List<ModelsA> eiei = new List<ModelsA>();
    static async Task Main(string[] args)
    {
        ConsoleKeyInfo cki;
        Console.TreatControlCAsInput = true;
        Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
        Console.WriteLine("Press the Escape (Esc) key to quit: \n");

        Dictionary<string, string> al = Constants.a;
        Console.WriteLine("ALPHABETICAL DICTIONARY");
        foreach (var item in al)
        {
            Console.WriteLine(item.Key + " / " + item.Value);
        }

        bool inputing = true;
        do
        {

            cki = Console.ReadKey(true);
            // need time to sec for count input
            if (inputing && cki.KeyChar.ToString() != "#")
            {
                inputing = false;
                Typing += cki.KeyChar.ToString();
                Task t = Task.Run(() =>
                {
                    Console.WriteLine("CREATE TASK");
                    Task.Delay(3000).Wait();
                    if (cki.KeyChar.ToString() != "#") Arr.Add(Typing);
                    Typing = "";
                    inputing = true;
                    Console.WriteLine("END TASK");
                });
            }
            else
            {
                Typing += cki.KeyChar.ToString();
                Console.WriteLine("CURRENT TEXT ::" + Typing);
            }

            // Console.WriteLine(" --- You pressed ");
            if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
            if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
            if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");


            // Arr.Add(cki.KeyChar.ToString());
            // //Console.WriteLine(OldPhonePad(cki.KeyChar.ToString()) ? OutPut() : "");
            //Console.WriteLine(cki.KeyChar.ToString() != "#");
            // //Arr.ForEach(Console.Write);
            // if (Test1().Result) { break; }
            //} while (cki.Key != ConsoleKey.Escape);
            //} while (cki.KeyChar.ToString() != "#");

        } while (cki.KeyChar.ToString() != "#");
        //await Task.Delay(500);
        Arr.ForEach(Console.WriteLine);
        // Arr.ForEach((a) => {
        //     Console.WriteLine("TEST :: " , a);
        // });
    }

    public static string OldPhonePad(string text)
    {
        // logic 
        return "";
    }
}


