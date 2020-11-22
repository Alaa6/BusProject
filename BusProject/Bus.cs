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


        // table 1 
        public static object[,] BusTimeLine = new object[12, 2] {{ 1,"7:00 AM" }, { 2, "8:00 AM" }, { 3, "9:00 AM" } ,
                                                                 { 1,"10:00 AM"}, { 2, "11:00 AM"}, { 3, "12:00 AM"} ,
                                                                 { 1,"1:00 PM" }, { 2, "2:00 PM" }, { 3, "3:00 PM" },
                                                                 { 1,"4:00 PM" }, { 2, "5:00 PM" }, { 3, "6:00 PM" }};



        /// table 2


        public static object[,] BusTimeLine2 = new object[12, 2]{{ 4,"7:00 AM" }, { 5, "8:00 AM" }, {6, "9:00 AM" } ,
                                                                 { 4,"10:00 AM"}, { 5, "11:00 AM"}, {6, "12:00 AM"} ,
                                                                 { 4,"1:00 PM" }, { 5, "2:00 PM" }, {6, "3:00 PM" },
                                                                 { 4,"4:00 PM" }, { 5, "5:00 PM" }, {6, "6:00 PM" }};

        // dispaly Table 1 
        public void DisplayTime2()
        {
            for (int i = 0; i < 12; i++)
            {

                for (int j = 0; j < 2; j += 2)
                {



                    Console.WriteLine("Bus ID :{0} ---- Time : {1} ", BusTimeLine2[i, j], BusTimeLine2[i, j + 1]);


                }
            }


        }

        // Display table 2
        public void DisplayTime1()
        {
            for (int i = 0; i < 12; i++)
            {

                for (int j = 0; j < 2; j += 2)
                {



                    Console.WriteLine("Bus ID :{0} ---- Time : {1} ", BusTimeLine2[i, j], BusTimeLine2[i, j + 1]);


                }
            }
        }



        // Select Bus ID based On time from table 1
        public object SelectTime1(object x)
        {
            for (int i = 0; i < 12; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    object xx;
                    if (BusTimeLine2[i, j] == x)
                    {
                        xx = BusTimeLine2[i, j - 1];
                        return xx;
                        break;
                    }
                    //  Console.WriteLine("a[{0},{1}] = {2}", i, j, BusTimeLine2[i, j]);
                }
            }
            return 0;
        }

        // Select Bus ID based On time from table 2
        public object SelectTime2(object x)
        {
            for (int i = 0; i < 12; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    object xx;
                    if (BusTimeLine[i, j] == x)
                    {
                        xx = BusTimeLine[i, j - 1];
                        return xx;
                        break;
                    }
                }
            }
            return 0;
        }
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

        object[,] BusTime1()
        {

            return BusTimeLine;
        }

        object[,] BusTime2()
        {

            return BusTimeLine2;
        }


    }
}
