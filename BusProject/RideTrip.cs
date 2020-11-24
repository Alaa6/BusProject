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
        private static int ticketId =0;
        private int numOfSeatsUser ;
     


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
            bool check = false;

            do
            {
                //check = false;
                if (numOfEndPoint < numOfStartPoint)
                {
                    Console.WriteLine("There is no Bus route for the choosen point");
                    Console.WriteLine("Please Choose the End point, again:");
                    Console.WriteLine("Stations for line1: 1 for " + Route.line1[0] + ", 2 for " + Route.line1[1] + ", 3 for " + Route.line1[2] + ", 4 for " + Route.line1[3] + ", 5 for " + Route.line1[4] + ", 6 for " + Route.line1[5] + ", 7 for " + Route.line1[6]);
                    Console.WriteLine("--------------------------------------------");
                    numOfEndPoint = int.Parse(Console.ReadLine());
                    check = true;
                }
                else
                {
                    check = false;
                }
            } while (check == true);
            Console.WriteLine("--------------------------------------------");
            setnumOfEndStation(numOfEndPoint);
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
           
            int busIdd=0;
            object timeChoosed=0;
            Console.WriteLine("Please Choose Bus No :");
            Console.WriteLine("--------------------------------------------");
            bus.DisplayTime1();
            Console.WriteLine("--------------------------------------------");

            int chooseBusNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");

            if (chooseBusNumber == 1)
            {
                timeChoosed = "7:00 AM";
                 busIdd = bus.SelectTime1(timeChoosed);
            }

            else if (chooseBusNumber == 2)
            {
                timeChoosed = "8:00 AM";
                 busIdd = bus.SelectTime1(timeChoosed);
            }
            else if (chooseBusNumber == 3)
            {
                timeChoosed = "9:00 AM";
                 busIdd = bus.SelectTime1(timeChoosed);
            }
            else if (chooseBusNumber == 4)
            {
                timeChoosed = "10:00 AM";
                 busIdd = bus.SelectTime1(timeChoosed);
            }
            else if (chooseBusNumber == 5)
            {
                timeChoosed = "11:00 AM";
                 busIdd = bus.SelectTime1(timeChoosed);
            }
            else if (chooseBusNumber == 6)
            {
                timeChoosed = "12:00 AM";
                 busIdd = bus.SelectTime1(timeChoosed);
            }
            else if (chooseBusNumber == 7)
            {
                timeChoosed = "1:00 PM";
                 busIdd = bus.SelectTime1(timeChoosed);
            }
            else if (chooseBusNumber == 8)
            {
                timeChoosed = "2:00 PM";
                 busIdd = bus.SelectTime1(timeChoosed);
            }
            else if (chooseBusNumber == 9)
            {
                timeChoosed = "3:00 PM";
                 busIdd = bus.SelectTime1(timeChoosed);
            }
            else if (chooseBusNumber == 10)
            {
                timeChoosed = "4:00 PM";
                 busIdd = bus.SelectTime1(timeChoosed);
            }
            else if (chooseBusNumber == 11)
            {
                timeChoosed = "5:00 PM";
                 busIdd = bus.SelectTime1(timeChoosed);
            }
            else if (chooseBusNumber == 12)
            {
                timeChoosed = "6:00 PM";
                 busIdd = bus.SelectTime1(timeChoosed);
            }

            else
            {

            }
  
            Console.WriteLine(" How many seats you need ? " );
            Console.WriteLine("--------------------------------------------");
             numOfSeatsUser  = int.Parse(Console.ReadLine());
            // chhoosebusnumber
             numOfSeatsBus =  Bus.BusSeats[busIdd, 1];

            if (numOfSeatsUser < numOfSeatsBus)
            {
               int  ticketId = generation();
                numOfSeatsBus -= numOfSeatsUser;
                bus.setNumOfSeatsBus(numOfSeatsBus);
                Console.WriteLine("\n--------------------------------------------");
                 Console.WriteLine(" | Trip Details | "+
                     "\n--------------------------------------------- " +
                    "\n Ticket ID: "+ ticketId  +
                    "\n Bus ID: " + busIdd + "\n Trip line: " + " From " + Route.line1[getnumOfStartStation()-1] + " To " +Route.line1[getnumOfEndStation()-1] + "\n Time: " + timeChoosed +
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

