using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject {
    class Program {  
        static void Main(string[] args){
            RideTrip rideTrip = new RideTrip();
            
            RideTrip.display();
            rideTrip.Booking();

            Console.ReadKey();
            }
            
        }

    }
       