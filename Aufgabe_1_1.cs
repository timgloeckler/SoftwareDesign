using System;

namespace L02
{
    class Aufgabe_1_1
    {
        static void Main(string[] args)
        {
            string description = args[0];
            double d = Convert.ToDouble(args[1]);
            
            switch (description)
            {
                case "w": //Cube
                Console.WriteLine(getCubeInfo(d));
                break;

                case "k": //Ball
                Console.WriteLine(getBallInfo(d));
                break;

                case "o": //Oktaeder
                Console.WriteLine(getOktaederInfo(d));
                break;
            }
          
        }

        // Cube A + V

        static public double getCubeSurface(double d)
        {
            double A = Math.Round(6 * (d * d), 2);
            return A;
        }

        static public double getCubeVolume(double d)
        {
            double V = Math.Round(d * d * d, 2);
            return V;
        }

        // Ball A + V

        public static double getBallSurface(double d)
        {
           double A = Math.Round(Math.PI * (d * d), 2);
           return A;

        }
        public static double getBallVolume(double d)
        {
            double V = Math.Round((Math.PI * (d * d * d) / 6), 2);
            return V;
        }

        // Oktaeder A + V

        public static double getOktaederSurface(double d)
        {
            double A = Math.Round(2 * (Math.Sqrt(3) * (d * d)), 2);
            return A;
        }

        public static double getOktaederVolume(double d)
        {
            double V = Math.Round((Math.Sqrt(2) * (d * d * d)) / 3, 2);
            return V;
        }

        // Infos

        static public string getCubeInfo(double d)
        {
            string info = "Würfel:   " + "A= " + getCubeSurface(d) + " | " + "V= " + getCubeVolume(d);
            return info;
        }

         public static string getBallInfo(double d)
        {
            string info = "Kugel:   " + "A= " + getOktaederSurface(d) + " | " + "V= " + getCubeVolume(d);
            return info;
        }

        public static string getOktaederInfo(double d)
        {
            string info = "Oktaeder:   " + "A= " + getOktaederSurface(d) + " | " + "V= " + getOktaederVolume(d);
            return info;
        }
        
    }
}
