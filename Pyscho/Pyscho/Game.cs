using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyscho
{
    class Game // game will run from here
    {
        
        private PlayerInfo player = new PlayerInfo();
        Choices choice = new Choices();

        string textName = "You";
        string narratorName = "Narrator";
        string doctorsName = "Dr. Arkenstone";
        string strangerName = "Stranger: ";
        
        string today = DateTime.Now.ToShortDateString();

        string playerText;
        public string narratorText;
        string nurseText;
        string doctorsText;
        string strangerText;
        string voiceText;

        string answer;

        public Game()
        {
            DisplayActOne();
        }

   

        public void DisplayActOne()
        {
            player.DisplayActOneDescription();

            nurseText = "Hello sir! How can I help you?";
            ColorChange(nurseText);

            playerText = "Hi, I have an appointment with Dr. Arkenstone at 3:20.";
            ColorChange(playerText);

            nurseText = "Ah, you must be new here, I remember every face I see and yours is new. Please fill out the highlighted part of this sheet, take your time.";
            ColorChange(nurseText);

            narratorText = "You take the sheet from the nurse, you noticed she smiles at you longer thean is considered normal, you don't pay any attention and take a seat to fill out the paper work" +
                "You feel relaxed as you sit down, you take a look at the sheet.";
            ColorChange(narratorText);

            player.NewPlayerInfo();
            textName = player.Name;

            narratorText = "You filled out the highlighted part of the sheet, and look back to double check.";
            ColorChange(narratorText);

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("| First Name:  SHES WATCHING YOU" + "  Middle Initial: " + "SHE PLANNING AGAINST YOU" +" Last Name: " + player.LastName + "         |");
            Console.WriteLine("| Month of Birth: " + player.Month  + "               Date: " + player.Day + "   Year: " + player.Year + "            SSN #: 123 - 45 - 6789  " + "   |");
            Console.WriteLine();

            narratorText = "Did you read that right? You didn't write that, did you?";
            ColorChange(narratorText);


            choice.ChoiceOne(); // executes choice one from Choices class

            narratorText = "You hand the board with the sheet back to the nurse. She looks at you smiling and says.";
            ColorChange(narratorText);

            nurseText = "Thank you very much! The Doctor will be with you shortly.";
            ColorChange(nurseText);

            narratorText = "You take a seat, a few moments later you are called in.";
            ColorChange(narratorText);

            playerText = "What a waste of time...";
            ColorChange(playerText);

            narratorText = "You say to youself as you're leaving, the doctor said there doesn't seem to be anything wrong, you're just a stressed out person, but you already knew that." +
                "You set on your phone that you have checkup appointment in a few days. You arrive at your appartment, at last home. You pop open a nice cold beer and sit down to watch some TV.";
            ColorChange(narratorText);

            choice.ChoiceTwo(); // executes choice two from Choices class

            narratorText = "You wake up feeling great for once. You do your normal morning retuine and head off to work. You arrive at the train station, and for once a train arrives right as you" +
                "get to the platform. You find a seat and space out on your way to work. \n";
            ColorChange(narratorText);

            choice.ChoiceThree(); // executes choice three from Choices class

            if(choice.sanity == 4) // Perfect Sanity Ending for the player
            {
                narratorText = "You go through a busy day of work, and despite that it was busy, you had a great day. You ae extrememly tired though, but work gave you a day off tomorrow for you " +
                    "appointment. You wake up almost feeling better than the day before, which is hard to believe. You arrive at Dr. Arkenstones office and the same nurse who helped you before is " +
                    "there.";
                ColorChange(narratorText);

                nurseText = "Welcome back Mr. " + player.LastName + ". Just check in here and you'll be all set for the doctor.";
                ColorChange(nurseText);

                narratorText = "You say to yourself...";
                ColorChange(narratorText);

                playerText = "Shouldn't be long now, no one else seems to be here.";
                ColorChange(playerText);

                doctorsText = player.Name + " come on in, I'll see you now.";
                ColorChange(doctorsText);

                doctorsText = "So " + player.Name + ", how are you doing since our last talk?";
                ColorChange(doctorsText);

                playerText = "Great actually! Although I told you I was seeing things, I haven't noticed anything out of the normal recently.";
                ColorChange(playerText);

                narratorText = "The doctors run the test that he has been running on you each visit, when he is done he takes a seat in front of you and takes his glasses off.";
                ColorChange(narratorText);

                doctorsText = "The results are good, I am happy to hear that everything is ok. I must be upfront with you. I lied to you the last time you came in. Those things you thought you were seeing, you were" +
                    "seeing whatever you saw, you were hallucinating. The intensity and stress from work had caused you to develop schizophrenia. Now, it was unethical for me to not tell you" +
                    "but I wanted to run an experiement with you. I noticed that people who know they have schizophrenia have a harder time dealing with schizophrenia, I wanted to see how you" +
                    "would deal with the hallucinations without knowing you schizophrenic. I saw how you reacted to the nurse and the paper you wrote on, you saw something, yet I saw you process it" +
                    "and not think anything of it. I followed you home and again saw you see something on the tv, your face told me you weren't watching that man read the headlines, yet you turn off" +
                    "the tv. Finally, you did talk to someone on the train who wasn't there, but you told him you didn't know who he was. You felt great the rest of the day right? You realize what you " +
                    "did right? You somehow beat schizophrenia, the test today returned nothing out of the normal. I know what I did was unethical, but I believe you have show us a new treatment to schizophrenia.";
                ColorChange(doctorsText);

                narratorText = "You feel angry, confused, yet you feel happy as well.";
                ColorChange(narratorText);

                playerText = "Doctor, I can't believe you used me in this experiement, this is completely wrong! I am a human being who needed help and you used me. I helped myself out of this mess," +
                    "I am happy I can help but this will be the last you see of me Doctor.";
                ColorChange(playerText);

                narratorText = "That was the last you've seen of the doctor, although he tricked you and used you, his idea is what helped you overcome the disease in you. Although you are mad" +
                    "you decide to not doing anything about his unethical treatment of you. You head home and enjoy the rest of you day off. Insanity Free.";

                Console.WriteLine("Thank you playing, press enter to quit.");
                Console.ReadKey();
            }

            if(choice.insanity >= 6 || choice.sanity < 4)
            {
                narratorText = "You try to think back, maybe you did see him at the doctors office.";
                ColorChange(narratorText);

                strangerText = "Oh, where are my manners, my name Ethan. What is your name?";
                strangerName = "Ethan";
                ColorChange(strangerText);

                playerText = "Nice to meet you " + strangerName + " my name is " + player.Name;
                ColorChange(playerText);

                narratorText = "You continue talking with Ethan. Somewhere in your conversation you notice a woman across from you staring at you with a look like you're doing something wrong" +
                    "but the second you look at her she looks away. A few stops later Ethan gets off, before he stop comes you two exchange numbers.";
                ColorChange(narratorText);

                strangerText = "I sent you a text, we should get some drinks when we are off work.";
                ColorChange(strangerText);

                narratorText = "You agreed, you haven't gone out in a long time, you work so hard you forget to let go and relieve some stress. You get off of work and meet up with Ethan. Although" +
                    "you ar eboth having fun, Ethan suggest calling it a night.";
                ColorChange(narratorText);

                strangerText = "Tonight was fun " + player.Name + " but I think we should call it a night, I do have to see our doctor tomorrow morning.";
                ColorChange(strangerText);

                playerText = "Oh perfect, I have to go in the morning as well, I can give you a ride if you like? When do you have to be there? My appointment is at 9";
                ColorChange(playerText);

                strangerText = player.Name + " man, I appreicate that, my appointment is at 8 so thats perfect. Thank you so much!";
                ColorChange(strangerText);

                narratorText = "You head home, and go straight to sleep, your long day at work and the alcohol in your system put you to sleep quickly. You wake up and take Ethan and you to the doctors" +
                    "office. You and Ethan head in, and he heads up to the front desk to check in, and you find a seat. While sitting you hear the nurse calling for you, when you turn around Ethan is gone" +
                    ", you head up and ask where you friend had gone.";
                ColorChange(narratorText);

                nurseText = "Sorry sir you must be confused, only you came in and I was calling you to check in first. You're very early sir but that is ok! The doctor is usually open in the morni...";
                ColorChange(nurseText);

                narratorText = "You start to look around, confused. She said you came in with no one. Did you? You had to have come in with him. Who were you talking to last night? Who did you pick up? No she" +
                    "must have been wrong. Before you could ask about Ethan Dr. Arkenstone comes out to greet you.";
                ColorChange(narratorText);

                doctorsText = "Thank you Nurse but I can take it from here, " + player.Name + " come right in.";
                ColorChange(doctorsText);

                playerText = "Doctor where is Ethan, he had an appointment before me, but I'm not sure what happened to him. He said he was here to see you.";
                ColorChange(playerText);

                narratorText = "The Docotor looks upset, an lets our a sigh.";
                ColorChange(narratorText);

                doctorsText = "Have a seat" + player.Name + " I have to explain something to you. Remember that first appointment you came too? You said you were seeing things and I told you that you're" +
                    "fine and that it was just stress, well I lied. You have become schizophrenic. You're seeing things that are not there. I didn't tell you because I had a theory on a new treatment" +
                    ", and I used you to see if this treatment could work. If I told you about your case this treatment couldn't work. You see my idea is that the patient has to overcome these hallucinations" +
                    "but knowing they aren't real. I was there watching you when you first filled out the sheet, you looked confused and whatever you saw on the paper you erased it. I saw how you reacted to " +
                    "the tv you..";
                ColorChange(doctorsText);

                narratorText = "Suddenly you see a familiar friend come into the room";
                ColorChange(narratorText);

                strangerText = "You know hes lying " + player.Name + "! I am real! You know I am! We had drinks together last night! You're telling me you came up with all that on your own?";
                ColorChange(strangerText);

                narratorText = "The doctors stops talking, he knows you're seeing Ethan.";
                ColorChange(narratorText);

                doctorsText = player.Name + " you know he isn't there! If you keep thinking he is there the hallucinations will consume your mind!";
                ColorChange(doctorsText);

                // this if statement occurs when someone has made both insanity and sanity choices
                if(choice.insanity > 1 && choice.insanity <= 5 || choice.sanity >= 1 && choice.sanity <= 4)
                {
                    narratorText = "Both of them are trying to convince you know, you know both of them are real. You have had true interactions with both of them. Dr. Arkenstone has treated you" +
                        "and although he has lied to you, he is real. Yet you think to yourself that you have shared more personal experiences with Ethan. Although you have just met, you have " +
                        "shared laughs, stories, and drinks";
                    ColorChange(narratorText);

                    doctorsText = player.Name + " you need to listen to me, send him out of the room, you can still recover from this.";
                    ColorChange(doctorsText);

                    strangerText = "Listen to me " + player.Name + ", when I went in to see him I over heard him talking to someone about how you're his little experiment, I tried to get back but I " +
                        "had to avoid secruity. Can you really trust this man, he's been lying to you from the start!";

                    Console.WriteLine("1. Ask Ethan to leave");
                    Console.WriteLine("2. Leave with Ethan");
                    answer = Console.ReadLine();

                    if (answer == "1")
                    {
                        playerText = "Ethan... I'm sorry but can you please leave, I don't know what to think but I think you need to leave.";
                        ColorChange(playerText);

                        narratorText = "You stare at Ethan, you can see he is upset. You look away, feeling upset about the situation. When you look up he is gone. You look to the doctor.";
                        ColorChange(narratorText);

                        playerText = "And you, how are you lie to me. What you did is unethical and just wrong. I am human being who need help and you used me. I will find someone else to help me.";
                        ColorChange(playerText);

                        narratorText = "The doctor looks upset, but doesn't put up any resistence to your outrage. You leave the office. Although you feel hurt deep down you feel better. Maybe the" +
                            "doctor had a point. You were suffering and all you needed was the will power to overcome what you had, or maybe you send home a new friend. You head home and enjoy the rest of" +
                            "your day off, in peace and silence.";

                        Console.WriteLine("Thank you playing, press enter to quit.");
                        Console.ReadKey();
                    }

                    if (answer == "2")
                    {
                        playerText = "Enough! Doctor, Ethan is right, how can I trust you? You lied this whole time. I can't be treated by someone who will use me for their sick experiment. What you" +
                            "did was unethical. Lets go Ethan.";
                        ColorChange(playerText);

                        narratorText = "You and Ethan leave. He looks happy you believed him. When you take him home he said he'll call you later. You arrive him and decide to spend your day off by watching" +
                            "TV. Again the man is on there yelling at you, saying you are useless and unwanted. You feel hurt and shut off the TV. You decide to call Ethan early, but when you call a lady" +
                            "answers and insist that a man need Ethan has never lived there. You feel lost and alone. Overtime you start to think your doctor was telling you the truth, you start to hear more" +
                            "voices, you don't know if they are there or not. Going to work is impossible, you tell yourself you're ok but you aren't sure anymore. The lines between reality and fiction have " +
                            "been blurred for you forever.";
                        ColorChange(narratorText);

                        Console.WriteLine("Thank you playing, press enter to quit.");
                        Console.ReadKey();
                    }
                } 
                    

                 if(choice.insanity == 6 && choice.sanity == 0)
                 {
                        playerText = "Enough! Doctor, Ethan is right, how can I trust you? You lied this whole time. I can't be treated by someone who will use me for their sick experiment. What you" +
                            "did was unethical. Lets go Ethan.";
                        ColorChange(playerText);

                        narratorText = "You leave the office with Ethan, you hear Ethan talking but there are other voices now. Filling you head with doubt about Ethan. You felt you made the right choice" +
                            "but you don't know anything anymore. You push Ethan out of the way and run. The voice are getting worse.";
                        ColorChange(narratorText);

                        voiceText = "YOU'RE USELESS, ETHAN LIED, THE DOCTOR LIED";
                        ColorChange(voiceText);

                        narratorText = "You start to walk to your car, but the voices again fill your head with doubt";
                        ColorChange(narratorText);

                        voiceText = "I don't think this is your car, is it? HOW DO YOU NOT KNOW!";
                        ColorChange(voiceText);

                        narratorText = "These voices start to make things impossible for you. You are doubting everything. Maybe you are useless. You wonder around, not sure what to do. You can't find" +
                            "your car. After hours of wondering, you are fed up. You scream back at these voices. The people may stare at you but you have to defend yourself. You can't let these people" +
                            "yelling at you have their way. You continue arguing with the people yellig at you, as you wonder down the street going nowhere.";
                        ColorChange(narratorText);
                        Console.WriteLine("Thank you playing, press enter to quit.");
                        Console.ReadKey();
                 }

            }


        }

        public void PerfectSanity()
        {

        }

        public string ColorChange(string text)
        {
            if (text == playerText)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(textName + ": " + playerText + "\n");
                Console.ResetColor();
            }
            
            if (text == narratorText)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(narratorName + ": " + narratorText + "\n");
                Console.ResetColor();
                Console.Write("Press enter to continue: ");
                Console.ReadLine();
            }

            if(text == nurseText)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Nurse: " + nurseText + "\n");
                Console.ResetColor();
                Console.Write("Press enter to continue: ");
                Console.ReadLine();
            }

            if(text == doctorsText)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(doctorsName + ": " + doctorsText + "\n");
                Console.ResetColor();
                Console.Write("Press enter to continue: ");
                Console.ReadLine();
            }

            if(text == strangerText)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(strangerName + ": " + strangerText + "\n");
                Console.ResetColor();
                Console.Write("Press enter to continue: ");
                Console.ReadLine();
            }
            
            if(text == voiceText)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Voices: " + strangerText + "\n");
                Console.ResetColor();
                Console.Write("Press enter to continue: ");
                Console.ReadLine();
            }
            return text;
        }
        
    }
}
