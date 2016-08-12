using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProject
{
    class Conversation
    {
        Robot alien;
        Robot earthling;
        public Conversation(Robot Alien, Robot Earthling)
        {
            alien = Alien;
            earthling = Earthling;
        }
        public void startConversation()
        {
            alien.Greet();
            earthling.RespondToGreeting();
            alien.AskHowAreYou();
            earthling.RespondToHowAreYou();
            alien.StartConversation();
            earthling.AnswerStarter();
            Console.ReadLine();
        }
    }
}
