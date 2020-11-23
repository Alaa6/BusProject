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
            u.register(name, age, mobile);
            u.display();
            RideTrip.display(u);

            //RideTrip.Booking();

            Console.ReadKey();
            }
            
        }

    }
       