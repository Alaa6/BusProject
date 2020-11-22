using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject
{
    class RideTrip
    {
        
        private static int numOfStartStation;
        private static int numOfEndStation;
        private static int numOfSeatsUser =3;
        private static int ticketId = 0;


        public static void setnumOfStartStation(int NumOfStartStation)
        {
            numOfStartStation = NumOfStartStation;
        }
        public static int getnumOfStartStation()
        {
            return numOfStartStation;
        }

        public static void setnumOfEndStation(int NumOfEndStation)
        {
            numOfEndStation = NumOfEndStation;
        }
        public static int getnumOfEndStation()
        {
            return numOfEndStation;
        }

        public static int cost(int numOfStartStation, int numOfEndStation)
        {

            int Cost, age;

            Console.WriteLine("Please enter your age:");
            age = int.Parse(Console.ReadLine());

            if (age > 60)
                Cost = Math.Abs((numOfStartStation - numOfEndStation) * 1);
            else if (age < 5)
                Cost = 0;
            else
                Cost = Math.Abs((numOfStartStation - numOfEndStation) * 2);
            return Cost;
        }

        public static void display()
        {
            Console.WriteLine("Please Choose the Start point :");
            Console.WriteLine("Stations for line1: 1 for " + Route.line1[0] + ", 2 for " + Route.line1[1] + ", 3 for " + Route.line1[2]
                + ", 4 for " + Route.line1[3] + ", 5 for " + Route.line1[4] + ", 6 for " + Route.line1[5] + ", 7 for " + Route.line1[6]);
            Console.WriteLine("--------------------------------------------");
            int numOfStartPoint = int.Parse(Console.ReadLine());
            setnumOfStartStation(numOfStartPoint);
            Console.WriteLine("Please Choose the End point :");
            Console.WriteLine("Stations for line1: 1 for " + Route.line1[0] + ", 2 for " + Route.line1[1] + ", 3 for " + Route.line1[2] + ", 4 for " + Route.line1[3] + ", 5 for " + Route.line1[4] + ", 6 for " + Route.line1[5] + ", 7 for " + Route.line1[6]);
            Console.WriteLine("--------------------------------------------");

            int numOfEndPoint = int.Parse(Console.ReadLine());
            setnumOfEndStation(numOfEndPoint);


            Console.WriteLine("The Trip cost is: {0}", cost(getnumOfStartStation(), getnumOfEndStation()));
        }
        public static int generation()
        {
            return ticketId += 1;
        }

        public static void Booking()
        {
            int  busId  , numOfSeatsBus =5;
            string time , startStation , endStation;
            Bus bus = new Bus();
           
            for (int i = 0; i < Bus.BusTimeLine.GetLength(0); i++)
            {
               
                for (int j = 0; j < Bus.BusTimeLine.GetLength(1); j++)
                {
                   // Console.Write(" Bus number  {0} :  ", i + 1);
                    Console.Write(" Bus No {0} : {1} \n ", i+1 ,Bus.BusTimeLine[i, j]);
                    //   Console.Write(" Bus No {0} : {1} \n ", i+1 ,Bus.BusTimeLine);

                }     
            }
           // Console.WriteLine("Please Choose Bus ID  :");
           // Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Please Choose Bus No :");
            Console.WriteLine("--------------------------------------------");
            int chooseBusNumber  = int.Parse(Console.ReadLine());
          //  Bus.BusTimeLine[chooseBusNumber+1 ,]


            if (numOfSeatsUser < numOfSeatsBus)
            {
                ticketId = generation();
                busId = 2;
                time = "7:00";
                startStation = "helwan";
                endStation = "L tgmo3";
                numOfSeatsBus -= numOfSeatsUser;

                Console.WriteLine("Thank you for your booking , We wish you a happy journey ^_^ \n " +
                    "your ticket ID is :  " + ticketId + "\n Bus ID is : " + busId + " Trip time is : " + time +
                    "Trip time is : " + startStation + " " + endStation 
                    ) ;
            }
            else
            {
                Console.WriteLine("sorry , there are not available seats !");
            }

        }


    }
}
