using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Speech_Synthesizer_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer robot= new SpeechSynthesizer();

            robot.SelectVoiceByHints(VoiceGender.Female);
            robot.SpeakAsync("Hi, Tell me who are your for further proceedings");

            Console.WriteLine("Enter your user name");
            var name = Console.ReadLine().ToUpper();
            

            if (name=="DEXTER")
            {
                robot.Speak("Welcome back Dexter ");
                Console.WriteLine("*****************************");    
            }
            else 
            {
                robot.Speak(name + "This username is incorrect ");

                robot.Rate = -2;
                robot.Speak("Process Terminated");
                Console.WriteLine("Process Terminated !!!");
            }
            
        }
    }
}
