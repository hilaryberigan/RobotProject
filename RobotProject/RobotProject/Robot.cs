using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProject
{
    class Robot
    {
        protected string name;
        protected string currentLocation;
        protected string origin;
        protected string purpose;
        protected int age;

        Speech speech = new Speech();

        public void ChangeName(string name)
        {
            this.name = name;
        }
        public void GetName()
        {
            Console.WriteLine("My name is " + this.name);
        }
        public void Greet()
        {
            Console.WriteLine(this.name + ": \t" + speech.GetGreeting());
        }
        public void RespondToGreeting()
        {
            Console.WriteLine(this.name + ": \t" + speech.GetGreeting());
        }
        public void AskHowAreYou()
        {
            Console.WriteLine(this.name + ": \t" + speech.GetHowAreYou());
        }
        public void RespondToHowAreYou()
        {
            Console.WriteLine(this.name + ": \t" + speech.GetHowAreYouResponse());
        }
        public void StartConversation()
        {
            Console.WriteLine(this.name + ": \t" + speech.GetConversationStarter());
        }
        
        public void AnswerStarter()
        {
            Console.WriteLine(this.name + ": \t" + speech.GetAnswerToStarters());
        }
        public void Sing()
        {
            Console.WriteLine("La la dee da. La la dee da.");
        }

        public void SetLocation()
        {
            Location location = new Location();
            currentLocation = location.SetInitialLocation();
            Console.WriteLine("I am " + currentLocation + ".");
        }
        public virtual void GetOrigin()
        {
            Console.WriteLine("I'm from " + this.origin + ".");
        }
        public void GetAge()
        {
           Console.WriteLine("I am " + this.age + " years old.");
        }
        public void GetPurpose()
        {
            Console.WriteLine("All day long, I just " + this.purpose + ".");
        }
    }
}
