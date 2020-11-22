using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject
{
    class Bus
    {       
        private int busId ;
        private string time;
        private int numOfSeatsBus ;
       

        public void setBusId(int _busId)
        {
            busId = _busId;
             
        }

        public int getBusId()
        {
            return busId ;

        }

        public void setNumOfSeatsBus(int _numOfSeatsBus)
        {
            numOfSeatsBus = _numOfSeatsBus;

        }

        public int getNumOfSeatsBus()
        {
            return numOfSeatsBus;

        }

          
         public void setTime(string _time)
          {
             time = _time;

          }

          public string getTime()
             {
               return time;
             }

    public static object[,] BusTimeLine = new object[12, 2] { { 1,"7:00 AM" }, { 2, "8:00 AM" }, { 3, "9:00 AM" } ,
                                                                 { 1,"10:00 AM"}, { 2, "11:00 AM"}, { 3, "12:00 AM" } ,
                                                                 { 1,"1:00 PM" }, { 2, "2:00 PM" }, { 3, "3:00 PM" },
                                                                 { 1,"4:00 PM" }, { 2, "5:00 PM" }, { 3, "6:00 PM" }};






    /*
     *  id  s  As
         0  1   2
         1   
         2

         */
    public static int[,] BusSeats = new int[3, 3] { { 1,15,15 }, { 2,  25, 15 },
              { 3, 20, 20 } };



        /* 
         parameter from Class Booking 

         */
        public void SeatsAvailable(int BusId, int SeatsTaken)
        {
            int busid = BusId;
            int seatstake = SeatsTaken;

            int oldAvailable, newavailable;


            oldAvailable = BusSeats[busid, 2];
            newavailable = oldAvailable - SeatsTaken;

            BusSeats[busid, 2] = newavailable;


        }


        public int[,] BusSeatesFun()
        {

            return BusSeats;
        }

        object[,] BusTime()
        {

            return BusTimeLine;
        }


      
    }
}
