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
        private int ticketId =1;





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


        public int generateTicketId (){

          return  ticketId += 1 ;
        }


        public void Booking()
        {
           
  
            string time , startStation , endStation;
            Bus bus = new Bus();
          //  numOfSeatsBus = Bus.BusSeat[1, 1];
              //  Bus.BusSeats[1,2];
          



             bus.DisplayTime2();

            
            

            
               

            Console.WriteLine("Please Choose Bus No :");
            Console.WriteLine("--------------------------------------------");
            int chooseBusNumber  = int.Parse(Console.ReadLine()); 
            object timeChoosed = Bus.BusTimeLine2[chooseBusNumber, 1 ];
             object busId = bus.SelectTime2(timeChoosed) ; 
            
            Console.WriteLine(" How many seats you need ? " );
            Console.WriteLine("--------------------------------------------");
            numOfSeatsUser  = int.Parse(Console.ReadLine());

             numOfSeatsBus =  Bus.BusSeats[chooseBusNumber, 1];
             Console.WriteLine("numOfSeatsBus {0}" ,numOfSeatsBus );

             
    
            if (numOfSeatsUser < numOfSeatsBus)
            {
               
                  int ticketId =  generateTicketId()  ;
                 
              

                  time = "7:00";
                  startStation = "helwan";
                  endStation = "L tgmo3";
                  numOfSeatsBus -= numOfSeatsUser;
                  bus.setNumOfSeatsBus(numOfSeatsBus);

                Console.WriteLine("Thank you for your booking , We wish you a happy journey ^_^ \n " +
                    "your ticket ID is :  " +ticketId+ "\n Bus ID is : " + busId + " Trip time is : " + timeChoosed +
                    " Trip  is : " + startStation + " " + endStation  + " the number of your seats is  " + numOfSeatsUser +" the number of bus seats is "
                      +numOfSeatsBus
                    ) ;
            }
            else
            {
                Console.WriteLine("sorry , there are not available seats !");
            }










        }


    }
}
