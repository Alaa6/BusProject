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
        private static int ticketId =1;
        private int numOfSeatsUser ;
        private int numOfSeatsBus ;
     


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

        public static int cost(User u,int numOfStartStation, int numOfEndStation)
        {

            int Cost, age;
            
            age= u.getType();
            
            if (age == 0)
            {
                Console.WriteLine(age);
                Cost = Math.Abs((numOfStartStation - numOfEndStation) * 1);
               // Console.WriteLine(Cost);
            }
            else if (age == 2)
            {
                Cost = 0;
               // Console.WriteLine(Cost);
            }
            else {
                Cost = Math.Abs((numOfStartStation - numOfEndStation) * 2);
               // Console.WriteLine(Cost);
            }
            return Cost;
        }

        public static void display(User u)
        {
            
            Console.WriteLine("Please Choose the Start point :");
            Console.WriteLine("Stations for line1: 1 for " + Route.line1[0] + ", 2 for " + Route.line1[1] + ", 3 for " + Route.line1[2]
                + ", 4 for " + Route.line1[3] + ", 5 for " + Route.line1[4] + ", 6 for " + Route.line1[5] + ", 7 for " + Route.line1[6]);
            Console.WriteLine("--------------------------------------------");
            int numOfStartPoint = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            setnumOfStartStation(numOfStartPoint);
            Console.WriteLine("Please Choose the End point :");
            Console.WriteLine("Stations for line1: 1 for " + Route.line1[0] + ", 2 for " + Route.line1[1] + ", 3 for " + Route.line1[2] + ", 4 for " + Route.line1[3] + ", 5 for " + Route.line1[4] + ", 6 for " + Route.line1[5] + ", 7 for " + Route.line1[6]);
            Console.WriteLine("--------------------------------------------");
            int numOfEndPoint = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            setnumOfEndStation(numOfEndPoint);
        }


        public static int generation()
        {
            return ticketId += 1;
        }



        public  void Booking(User user)
         {
           int numOfSeatsBus =Bus.BusSeats[1,1] ;
            string time , startStation , endStation;
            Bus bus = new Bus();
            Route route = new Route();

           
 

            Console.WriteLine("Please Choose Bus No :");
            Console.WriteLine("--------------------------------------------");
              bus.DisplayTime1();
             Console.WriteLine("--------------------------------------------");

            int chooseBusNumber  = int.Parse(Console.ReadLine()); 
            Console.WriteLine("--------------------------------------------");
            object timeChoosed = Bus.BusTimeLine[chooseBusNumber, 1 ]; 
            object busId = bus.SelectTime1(timeChoosed) ; 

            
            Console.WriteLine(" How many seats you need ? " );
            Console.WriteLine("--------------------------------------------");
             numOfSeatsUser  = int.Parse(Console.ReadLine());
             numOfSeatsBus =  Bus.BusSeats[chooseBusNumber, 1];

            if (numOfSeatsUser < numOfSeatsBus)
            {
               int  ticketId = generation();
                numOfSeatsBus -= numOfSeatsUser;
                bus.setNumOfSeatsBus(numOfSeatsBus);
                Console.WriteLine("\n--------------------------------------------");
                 Console.WriteLine(" | Trip Details | "+
                     "\n--------------------------------------------- " +
                    "\n Ticket ID: "+ ticketId  +
                    "\n Bus ID: " + busId + "\n Trip line: " + " From " + Route.line1[getnumOfStartStation()-1] + " To " +Route.line1[getnumOfEndStation()-1] + "\n Time: " + timeChoosed +
                    "\n Number of seats: " + numOfSeatsUser + "\n Cost: " +cost(user ,getnumOfStartStation(), getnumOfEndStation()) * numOfSeatsUser);
                 user.display();
               
                         }
            else
            {
                Console.WriteLine("sorry , there are not available seats !");
            }

        }


    }
            
}

