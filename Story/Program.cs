// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Pedro the racoon invites u to his home, what do you do? A: Politely accept. B: Turn him down");
string name = Console.ReadLine().ToUpper();
if (name == "A")
{
    Console.WriteLine("Pedro brings you to his home and when you enter you notice a foul stench, what do you do? A: Ask about it. B: Ignore it");
    string doStench = Console.ReadLine().ToUpper();
    if (doStench == "A")
    {
        Console.WriteLine("Pedro shows a face of disdain before he picks up an axe resting against the wall and throws it at you and splits your skull open");
    }
    else if (doStench == "B")
    {
        Console.WriteLine("You choose to ignore the stench for now and Pedro takes you into the kitchen and tells you to sit down and take a seat at the dinner table. He then politely ask if you would like a cup of coffee, what do you do? A: Accept the offer. B: Decline the offer");
        string doCoffee = Console.ReadLine().ToUpper();
        if (doCoffee == "A")
        {
            Console.WriteLine("Pedro proceeds to pour you a cup of coffee and then you enjoy a nice chat when you suddenly have to go to the toilet. You ask for directions and Pedro points toward a hallway and tells you it's the door furthest in to the right. You get up from your chair and begin to walk down the hallway, the floor creaks as you walk towards the door. When you reach the door it feels like it has an ominous feel to it and as you put your hand on the handle and is about to open it you hesitate a bit, but then decide to open the door. At first everything seems normal but then you notice it, something is sticking out from the toilet under the lid. You proceed to walk a bit closer to see what it is, and then you see it, it's a hand. You quickly turn around to flee but Pedro is already at the doorway and resting in his hands is a shotgun. He points it toward you and blows your head of.");
        }
        else if (doCoffee == "B")
        {
            Console.WriteLine("Pedro thinks you're a bit rude but doesn't think much about it, he then tells you he's going for a nap and points toward the livingroom and says there's a tv in there you can watch in the meantime, what do you watch? A: The news. B: Cocomelon");
            string doWatch = Console.ReadLine().ToUpper();
            if (doWatch == "A")
            {
                Console.WriteLine("You turn on the news and watch for a bit, when you suddenly hear a scream coming from a room. You're about to get up but then you see Pedro on the news, as a wanted criminal. Then Pedro suddenly barges out from the room where the scream came from. He got a big bloody bag on his shoulder and a knife in his hand. You then come to your senses and start to sprint toward the window, with Pedro close behind you. You barely got away by jumping through the window and then running through the forest all night, but now you are in the middle of nowhere");
            }
            else if (doWatch == "B")
            {
                Console.WriteLine("You turn on Cocomelon and watch for a bit, but then you can hear a door slamming open and heavy thuds coming closer and closer, it's Pedro, and he's holding a butcher's knife in one hand and a rope in the other. As you sit there and tremble he gets behind you and strangles you unconscious with the rope. When you wake up you're hanging upside down in a cellar, then you notice a big puddle of blood beneath you. And then you feel the sharp pain as Pedro continues to cut pieces of you alive and feed you to his children");
            }
            else
            {
                Console.WriteLine("fuk u");
            }
        }
        else
        {
            Console.WriteLine("fuk u");
        }
    }
     else
    {
        Console.WriteLine("fuk u");
    }
}
else if (name == "B")
{
    Console.WriteLine("Pedro took it like an insult and killed you");
}
else
{
    Console.WriteLine("fuk u");
}
Console.ReadLine();