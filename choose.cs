using System;

class Program
{
    static void Main(string[] args)
    {
        /* THE MYSTERIOUS NOISE */

        // Start by asking for the user's name:
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Welcome to our story.");

        //Prologue
        Console.WriteLine("It begins on a cold rainy night. " +
            "You're sitting in your room and hear a noise coming from down the hall. " +
            "Do you go investigate?");

        Console.Write("Type YES OR NO:");
        string noiseChoice = (Console.ReadLine()).ToUpper();

        // Choice 1

        if (noiseChoice == "NO") Console.WriteLine("Not much of an adventure if we don't leave our room!\nTHE END.");
        else if (noiseChoice == "YES")
        {
            Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall." +
                "\nYou walk towards it.Do you open it or knock ? ");
        }
        Console.Write("Type OPEN OR KNOCK:");
        string doorChoice = (Console.ReadLine()).ToUpper();

        //Choice 2

        if (doorChoice == "KNOCK")
        {
            Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: " +
                "\"\"Poor people have it. Rich people need it. If you eat it you die. " +
                "What is it?\"");
            string riddleAnswer = Console.ReadLine().ToUpper();

            if (riddleAnswer == "NOTHING")
            {
                Console.WriteLine("The door opens and NOTHING is there." +
                    "\nYou turn off the light and run back to your room and lock the door." +
                    "\nTHE END.");
            }
            else Console.WriteLine("\nYou answered incorrectly. \nThe door doesn't open.\nTHE END.");
        }
        else if (doorChoice == "OPEN")
        {
            Console.WriteLine("The door is locked! See if one of your three keys will open it.");

        //Choice 3
            Console.WriteLine("Enter a number (1-3):");
            string keyChoice = Console.ReadLine();

            switch (keyChoice)
            {
                case "1": Console.WriteLine("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there.Strange...\nTHE END."); break;
                case "2": Console.WriteLine("You choose the second key. The door doesn't open.\nTHE END."); break;
                case "3": Console.WriteLine("You choose the third key. The door doesn't open.\nTHE END."); break;
                default:
                    break;
            }
        }

        
    }
}

