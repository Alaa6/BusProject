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
        private int numOfSeatsUser =3;





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
                , busId  , numOfSeatsBus =5;
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
