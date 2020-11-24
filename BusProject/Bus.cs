using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject
{
    class Bus
    {       
         private static int numOfSeatsBus =20 ;

        public int getNumOfSeatsBus (){
            return numOfSeatsBus ;
        }

        public void setNumOfSeatsBus (int _numOfSeatsBus){
            numOfSeatsBus =_numOfSeatsBus ;

        }
     
     

      
  


        // table 1 
        public static object[,] BusTimeLine = new object[12, 2] {{ 1,"7:00 AM" }, { 2, "8:00 AM" }, { 3, "9:00 AM" } ,
                                                                 { 1,"10:00 AM"}, { 2, "11:00 AM"}, { 3, "12:00 PM"} ,
                                                                 { 1,"1:00 PM" }, { 2, "2:00 PM" }, { 3, "3:00 PM" },
                                                                 { 1,"4:00 PM" }, { 2, "5:00 PM" }, { 3, "6:00 PM" }};



      
        // dispaly Table 1 
        public void DisplayTime1()
        {
            int count = 0;
            for (int i = 0; i < 12; i++)
            {
                count = count + 1;
                for (int j = 0; j < 2; j += 2)
                {
                    Console.WriteLine("Bus ID :{0} ---- Time : {1} ----- press {2} ", BusTimeLine[i, j], BusTimeLine[i, j + 1], count);
                }
            }


        } public void DisplayTimeonly()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 2; j += 2)
                {



                    Console.WriteLine("Bus ID :{0} ---- Time : {1} ", BusTimeLine[i, j], BusTimeLine[i, j + 1]);


                }
            }


        }
       
        // Select Bus ID based On time from table 1

        public int SelectTime1(object x)
        {
            for (int i = 0; i < 12; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    int xx;
                    object xxx;
                    if (BusTimeLine[i, j] == x)
                    {
                        xxx = BusTimeLine[i, j - 1];
                        xx = Convert.ToInt32(xxx);
                        return xx;
                        break;
                    }
                    //  Console.WriteLine("a[{0},{1}] = {2}", i, j, BusTimeLine2[i, j]);
                }
            }
            return 0;
        }
               

        public static int[,] BusSeats = new int[6,3] { { 1,numOfSeatsBus,15 } ,
                                                        { 2, numOfSeatsBus, 15 },
                                                         { 3, numOfSeatsBus, 20 } ,
                                                          { 4,numOfSeatsBus,15 } ,
                                                        { 5, numOfSeatsBus, 15 },
                                                         { 6, numOfSeatsBus, 20 } };    

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

      
    }
}
