using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RobotProject
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Alien alien = new Alien("CarlBot", "store things", 2);
            Thread.Sleep(100);
            Earthling earthling = new Earthling("GoofBot", "entertain", 3);
            Conversation conversation = new Conversation(alien, earthling);
            conversation.startConversation();
            Console.ReadLine();

        }
    }

}
