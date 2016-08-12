using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProject
{
    class Speech
    {
        Random random = new Random();

        public string GetGreeting()
        {
            List<string> greetings = new List<string>();

            greetings.Add("Hello!");
            greetings.Add("Hey there!");
            greetings.Add("Well, hi!");
            greetings.Add("Oh, hi!");
            greetings.Add("Hi hi hi");

            string randomGreeting = greetings[random.Next(0, 4)];
            return randomGreeting;
        }

        public string GetHowAreYou()
        {
            List<string> howAreYouList = new List<string>();

            howAreYouList.Add("How are you?");
            howAreYouList.Add("How are you doing today?");
            howAreYouList.Add("How's it going?");

            string randomHowAreYou = howAreYouList[random.Next(0, 2)];
            return randomHowAreYou;
        }

        public string GetHowAreYouResponse()
        {
            List<string> howAreYouResponses = new List<string>();

            howAreYouResponses.Add("Good!");
            howAreYouResponses.Add("Great!");
            howAreYouResponses.Add("Bad");

            string randomHowAreYouResponses = howAreYouResponses[random.Next(0, 2)];
            return randomHowAreYouResponses;
        }
        public string GetConversationStarter()
        {
            List<string> starters = new List<string>();

            starters.Add("What is your name?");
            starters.Add("Where are you from?");
            starters.Add("What do you do?");
            starters.Add("How old are you?");

            string randomStarters = starters[random.Next(0, 3)];
            return randomStarters;
        }
        public string GetAnswerToStarters(Robot robot)
        {
            string question = GetConversationStarter();

            switch (question)
            {
                case "What is your name?":
                    robot.GetName();
                break;

                case "Where are you from":
                    robot.GetOrigin();
                break;

                case "What do you do?":
                    robot.GetPurpose();
                break;

                case "How old are you?":
                    robot.GetAge();
                break;       
            }
                string answer = Console.ReadLine();
                return answer;
                

                
                }
            }
        }

