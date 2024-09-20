namespace Code_Golf__lol_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validClub = false;
            //decides distance of hole from start
            var puttStats = 
            Random rnd = new Random();
            int holeDistance = rnd.Next(10, 1200);
            // this will be the base for the distance the ball travels
            int puttForce = rnd.Next(2, 7);
            int wedgeForce = rnd.Next(7, 16);
            int ironForce = rnd.Next(16, 20);
            int driveForce = rnd.Next(20, 25);
            //what i will do is multiply the chosen force (between 1 and 10) by the randomly generated number above

            Console.WriteLine("the hole is " + holeDistance + " yards away.");
            Console.WriteLine("which club will you use?");
            Console.WriteLine("1. putter");
            Console.WriteLine("2. driver");
            Console.WriteLine("3. iron");
            Console.WriteLine("4. wedge");
            //trying to make any number above 4 or below 1 invalid ill figure out later
            int clubType = Convert.ToInt32(Console.ReadLine());

            if (clubType > 4)
            {
                Console.WriteLine("Not a valid club!");
            }
            else
            {
                validClub = true;
            }
            if (validClub == true)
            {
                clubStats
            }
            else
            {
                Console.WriteLine("false!");
            }
            }    
            
        }
    }

