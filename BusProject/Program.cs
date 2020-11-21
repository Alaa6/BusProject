

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject {
    class Program {  
        static void Main(string[] args){

            Route lines = new Route();
            RideTrip rideTrip = new RideTrip();
            Bus bus = new Bus();
            

                //Stations of all lines:
                Console.WriteLine("Stations for line1: 1 for Helwan, 2 for Helwan University, 3 for Maadi, 4 for Al-Sadat, 5 for Demerdash, 6 for Ain Shams, 7 for Elmarg");
                Console.WriteLine("--------------------------------------------");
                //Console.WriteLine("Stations for line2: 1 for Monib, 2 for Giza, 3 for Cairo University, 4 for Dokki, 5 for Muhnammed Nagib, 6 for Santa Tresa, 7 for Shoubra");
                //Console.WriteLine("--------------------------------------------");
                //Console.WriteLine("Stations for line2: 1 for Airport, 2 for Elnozha, 3 for Cairo Stadium, 4 for Abdo Basha, 5 for Nasser, 6 Zamalek, 7 for Mostafa Mahmoud mosque");
                //Console.WriteLine("--------------------------------------------");

                //Console.WriteLine("Choose the number of line: ");
                //int line = int.Parse(Console.ReadLine());

                //Line1:               
                //Ask for location :
                //if (line == 1)
                //{
                Console.WriteLine("Choose your location: ");
                int location1 = int.Parse(Console.ReadLine());

                //Ask for destination :
                Console.WriteLine("Choose your destination");
                int destination1 = int.Parse(Console.ReadLine());

                //Number of stations:   

                //Math.Abs to return a positive value 
                int numOfStations1 = Math.Abs(location1 - destination1);
                Console.WriteLine("Number of stations ={0} ", numOfStations1);
                Console.ReadLine();
                //  }
                //--------------------------------------------------------------------
                //Line2:
                //Ask for location :
                //else if (line == 2)
                //{
                //        Console.WriteLine("Choose your location: ");
                //        int location2 = int.Parse(Console.ReadLine());

                //        //Ask for destination :
                //        Console.WriteLine("Choose your destination");
                //        int destination2 = int.Parse(Console.ReadLine());

                //        //Number of stations:            
                //        int numOfStations2 = Math.Abs(location2 - destination2);
                //        Console.WriteLine("Number of stations ={0} ", numOfStations2);
                //        Console.ReadLine();
                ////    }
                //-----------------------------------------------------------------------
                //Line3:
                //else if (line == 3)
                //{
                //    //Ask for location :
                //    Console.WriteLine("Choose your location: ");
                //    int location3 = int.Parse(Console.ReadLine());

                //    //Ask for destination :
                //    Console.WriteLine("Choose your destination");
                //    int destination3 = int.Parse(Console.ReadLine());

                //    //Number of stations:            
                //    int numOfStations3 = Math.Abs(location3 - destination3);
                //    Console.WriteLine("Number of stations ={0} ", numOfStations3);
                //    Console.ReadLine();
                //}
                ////------------------------------------------------------------------------
                ////If he chose number greater than 3:
                //else
                //    Console.WriteLine("There are only three lines");



            /*test*/

             RideTrip rt = new RideTrip();
          //  Route lines = new Route();

            Console.WriteLine("Please Choose the Start point :");
            Console.WriteLine("Stations for line1: 1 for "+lines.line1[0]+ ", 2 for "+ lines.line1[1]+", 3 for "+lines.line1[2]
                +", 4 for "+lines.line1[3]+", 5 for "+lines.line1[4]+", 6 for "+lines.line1[5]+", 7 for "+ lines.line1[6]);
            Console.WriteLine("--------------------------------------------");

           
            
            int numOfStartPoint = int.Parse(Console.ReadLine());
            rt.setnumOfStartStation(numOfStartPoint);


            Console.WriteLine("Please Choose the End point :");
            Console.WriteLine("Stations for line1: 1 for "+ lines.line1[0]+ ", 2 for "+ lines.line1[1]+ ", 3 for "+ lines.line1[2]+ ", 4 for "+ lines.line1[3]+ ", 5 for "+ lines.line1[4]+ ", 6 for "+ lines.line1[5]+ ", 7 for "+ lines.line1[6]);
            Console.WriteLine("--------------------------------------------");

            int numOfEndPoint = int.Parse(Console.ReadLine());
            rt.setnumOfEndStation(numOfEndPoint);

            rideTrip.Booking();
          

            Console.WriteLine("The Trip cost is: {0}", rt.cost(rt.getnumOfStartStation(), rt.getnumOfEndStation()));

            Console.ReadKey();
            }
            
        }



    }
       