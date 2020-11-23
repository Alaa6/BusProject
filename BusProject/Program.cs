using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject {
    class Program {  
        static void Main(string[] args){

            User u = new User();      
            Console.WriteLine("enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your mobile:");
            string mobile = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");

            u.register(name, age, mobile);
            RideTrip.display(u);

            //RideTrip.Booking();
            RideTrip rideTrip = new RideTrip();
            
           // RideTrip.display();
            rideTrip.Booking(u);

            Console.ReadKey();
            }
            
        }

    }
       