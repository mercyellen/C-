using System;

namespace CSharpBasics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const uint sample1 = 0x3A;
            uint sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = (float)9.800;
            float mass = (float)14.6;
            double distance = 129.763001;
            Boolean lost = true;
            Boolean expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const String greeting = "Hello";
            String name = "Karen";

            if (sample1.Equals(sample2))
            {
                Console.WriteLine("The samples are equal");
            }
            else Console.WriteLine("The samples are not equal.");

            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else Console.WriteLine("Heart rate is not normal.");

            if (deposits >= 100000000) Console.WriteLine("You are exceedingly wealthy");
            else Console.WriteLine("Sorry you're so poor.");

            float force = mass * acceleration;
            Console.WriteLine("force = {0}", force);
            Console.WriteLine("{0} is the distance.", distance);

            if(lost && expensive) {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            if(lost && !expensive) {
                Console.WriteLine("Here is a coupon for 10% off");
            }

            switch(choice) {
                case 1: 
                    Console.WriteLine("You chose 1");
                    break;
                case 2:
                    Console.WriteLine("You chose 2");
                    break;
                case 3:
                    Console.WriteLine("You chose 3");
                    break;
                default:
                    Console.WriteLine("Case unknown. Choose 1, 2, or 3.");
                    break;
            }

            Console.WriteLine("{0} is an integral", integral);

            for (int i = 5; i < 11; i++) {
                Console.WriteLine("i = {0}", i);
            }

            int age = 0;

            while(age < 6) {
                Console.WriteLine("age = {0}", age);
                age++;
            }

            Console.Write("{0}, ", greeting);
            Console.WriteLine("{0}", name);
        }
    }
}
