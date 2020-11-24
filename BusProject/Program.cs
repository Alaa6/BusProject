using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject {
    class Program {  
       public static void Main(string[] args){

            int flag=0;
            int x=0;
            User u = new User();

            renhere();

            void renhere()
            {
              //  User u = new User();

                Console.WriteLine("For Register enter 1");
                Console.WriteLine("Display Timline of buses Enter 2");
                Console.WriteLine("For Booking Enter 3");
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    User u2 = new User();

                    Console.WriteLine("enter your name :");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your age:");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter your mobile:");
                    string mobile = Console.ReadLine();
                    Console.WriteLine("--------------------------------------------");

                    u.register(name, age, mobile);

                    Console.WriteLine("If you want to Repeat the process enter 1 :");
                    int ch = int.Parse(Console.ReadLine());
                    if (ch == 1)
                    {
                        renhere();
                        u = u2;
                    }
                    else
                    {
                    }


                }

                else if (x == 2)
                {
                    Bus bs = new Bus();
                    bs.DisplayTimeonly();

                    Console.WriteLine("If you want to continue the process enter 1  ");
                    int ch = int.Parse(Console.ReadLine());
                    if (ch == 1)
                    {
                        renhere();
                    }

                    else
                    {

                    }


                }

                else if (x == 3)
                {

                    RideTrip.display(u);

                    //RideTrip.Booking();
                    RideTrip rideTrip = new RideTrip();

                    // RideTrip.display();
                    rideTrip.Booking(u);

                    Console.WriteLine("If you want to Repeate the process enter 1  ");
                    int ch = int.Parse(Console.ReadLine());
                    if (ch == 1)
                    {
                        renhere();
                    }

                    else
                    {

                    }

                }

                else
                {
                }



            }
            Console.ReadKey();
            }
            
       
        }

    }
       