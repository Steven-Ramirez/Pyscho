using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyscho
{
    class Choices
    {
        private PlayerInfo player = new PlayerInfo();

        // Each choice a player can make will affect sanity or insanity but they will not lower each other. 
        // It is possible the player to achieve a perfect score for both sanity and insanity choices.
        // Line 9 is the perfect sanity ending
        public int sanity;
        public double insanity;
        public string answer;

        public Choices() { }

        public void ChoiceOne()
        {
            Console.WriteLine("To make a choice, type the number that corresponds to your choice.");
            Console.WriteLine("Be warned, your answer do affect your path on this story.");

            Console.WriteLine("1. You think to yourself you read it to fast. You go back and reread what you wrote, maybe you wrote it wrong.");
            Console.WriteLine("2. You remember she did smile are you longer than normal when you first arrived, you look back at the nurse.");
            Console.WriteLine("3. You know you didn't write that, you look back at the paper to see what you wrote.");

            answer = Console.ReadLine();

            if (answer == "1")
            {
                insanity++;
                Console.WriteLine("You do a double take on the sheet, and realize you wrote that out, which is odd, you don't believe what you wrote down but wonder why you wrote it, " +
                    "you fix the issue.");
                player.PaperTop();
            }
            if (answer == "2")
            {
                insanity = insanity + 2;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Narrator: You look back at the nurse, she realizes how long she was smiling, now it is you who is staring too long. She starts to look upset.");
                Console.ResetColor();
                Console.WriteLine("You look back at the sheet and erase the warning, and write down what you wanted to write.");
                player.PaperTop();
            }
            if (answer == "3")
            {
                sanity++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Narrator: You knew you didn't write it down wrong, must have been a mind hiccup, you did have a long day at work before this, you think you're just tired.");
                Console.ResetColor();
                player.PaperTop();

            }
        }

        public void ChoiceTwo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Narrator: On screen you're watching someone screaming, but the volume is low, you turn it up. As you turn up the volume, you noticed the man is yelling at you");
            Console.ResetColor();
            Console.Write("Press enter to continue: ");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YOU'RE USELESS, NOTHING, THE DOCTORED LIED, THE NURS.... ");
            Console.ResetColor();
            Console.Write("Press enter to continue: ");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You sit there wide eyed, you can't believe this is happening. Should you listen to the man, he might have some valuble information, you look at the remote. ");
            Console.ResetColor();
            Console.WriteLine("1. You look at the volume button and decide to turn the volume up to hear what he says, he did mention something about the doctor.");
            Console.WriteLine("2. You look at the volume button and decide to turn it down, you don't want to hear what he is saying but this could be important.");
            Console.WriteLine("3. You look at the volume button, but you decide to shut the tv off, you're tired and watching this man yell reminded you how tired you are.");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                insanity = insanity + 2;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You sit and watch in wonder, you know hes talking about you, hes look directly into your eyes. You almost get lost in the rant. ");
                Console.ResetColor();
                Console.Write("Press enter to continue: ");
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("THE DOCTOR LIED, THE DOCTOR LIED, THE DOCTOR LIED");
                Console.ResetColor();
                Console.Write("Press enter to continue: ");
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Narrator: You knew it! The doctor must have lied to you. You put your trust in him and he lied! You shut the TV off, enough is enough for one day, you head off to bed.");
                Console.Write("Press enter to continue: ");
                Console.ReadLine();
            }

            if (answer == "2")
            {
                insanity++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Narrator: You still aren't sure what is going on, you're watching a muted man yelling about something that seems directed at you. Turning the volume down and made " +
                    "lose interest in his rant. You check the time and think you should sleep, its been a long day.");
                Console.ResetColor();
                Console.Write("Press enter to continue: ");
                Console.ReadLine();
            }

            if (answer == "3")
            {
                sanity = sanity + 2;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Narrator: You shut off the tv, that was weird wasn't it? Must have been a blooper or something. Checking your phone you notice its time, you have work in the morning.");
                Console.ResetColor();
                Console.Write("Press enter to continue: ");
                Console.ReadLine();
            }
        }

        public void ChoiceThree()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Narrator: You arrive at the next station and the train fills up with people. A man takes a seat next to you, and trys to start a conversation with you.");
            Console.ResetColor();
            Console.Write("Press enter to continue: ");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Stranger: Hey...do I know you from somewhere?");
            Console.ResetColor();

            Console.WriteLine("1. No sorry sir, I don't believe you do. Might be mistaking me with someone else.");
            Console.WriteLine("2. Sorry sir I can't say that I know you, where do you think you know me from?.");
            Console.WriteLine("3. You know, I think I saw you at the doctors office the other day, do you go to Dr. Arkenstones office?");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                sanity++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Narrator: The man looks down, then back at you. You can see hes embarrased. He pulls out his phone and keeps to himself." +
                    "You look up and notice that the woman in front of you was already looking at you, she looks away quickly when your eyes meet.");
                Console.ResetColor();
            }

            if (answer == "2")
            {
                insanity++;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Stranger: Oh I know now! I saw you in Dr. Arkenstones office yesterday! Its all coming back to me now!");
                Console.ResetColor();

            }

            if (answer == "3")
            {
                insanity = insanity + 2;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Stranger: Yes! That is where I saw you! ");
                Console.ResetColor();
            }
        }

    }
}
