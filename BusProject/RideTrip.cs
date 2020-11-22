using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject
{
    class RideTrip
    {
        
        private int numOfStartStation;
        private int numOfEndStation;
        private int numOfSeatsUser ;
        private int numOfSeatsBus ;





        public void setnumOfStartStation(int numOfStartStation)
        {
            this.numOfStartStation = numOfStartStation;
        }
        public int getnumOfStartStation()
        {
            return numOfStartStation;
        }

        public void setnumOfEndStation(int numOfEndStation)
        {
            this.numOfEndStation = numOfEndStation;
        }
        public int getnumOfEndStation()
        {
            return numOfEndStation;
        }

       
        public int cost(int numOfStartStation, int numOfEndStation)
        {
            int Cost = Math.Abs((numOfStartStation - numOfEndStation) * 2);

            return Cost;
        }


        public void Booking()
        {
            int ticketId  // generated 
                , busId ;
            string time , startStation , endStation;
            Bus bus = new Bus();
            numOfSeatsBus = Bus.BusSeats[1,0];



            Console.WriteLine(" Bus No  | press  | Time       | press " );

            for (int i = 0; i < Bus.BusTimeLine.GetLength(0); i++)
            {
               
                for (int j = 0; j < Bus.BusTimeLine.GetLength(1); j++)
                {
                   // Console.Write(" Bus number  {0} :  ", i + 1);
                    Console.Write(" {0}     | {1}     | {2}      | {3}       \n ",Bus.BusTimeLine[i,0 ] , i+1 , Bus.BusTimeLine[i,1 ] , j+1);
                    Console.WriteLine("--------------------------------------------");
                }     
            }

             for (int i = 0; i < 5; i++) {
            
            for (int j = 0; j < 2; j++) {
               Console.WriteLine("a[{0},{1}] = {2}", i, j, Bus.BusTimeLine[i,j]);
            }
         }

            Console.WriteLine("Please Choose Bus No :");
            Console.WriteLine("--------------------------------------------");
            int chooseBusNumber  = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Please Choose Bus Time :");
            Console.WriteLine("--------------------------------------------");
            int chooseBusTime  = int.Parse(Console.ReadLine()); 

             object choosed = Bus.BusTimeLine[chooseBusNumber,chooseBusTime ];

              Console.WriteLine(" How many seats you need ? " );
              Console.WriteLine("--------------------------------------------");
               numOfSeatsUser  = int.Parse(Console.ReadLine()); 

            
            Console.WriteLine("seats No of user is : {0} and of bus is: {1}" ,numOfSeatsUser ,numOfSeatsBus);
    

            if (numOfSeatsUser < numOfSeatsBus)
            {
                ticketId = 1;
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
