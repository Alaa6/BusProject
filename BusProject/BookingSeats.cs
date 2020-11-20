using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject
{
    class BookingSeats
    { 
        private int numOfSeatsBus =3 ;
        private int numOfSeatsUser =2 ;

        public void checkSeats() { 

            if(numOfSeatsUser < numOfSeatsBus){
                // BooK();
                numOfSeatsBus -= numOfSeatsUser ;
            }
            else{
                Console.WriteLine("sorry , there are not available seats !")
            }
                

        }
    }
}
