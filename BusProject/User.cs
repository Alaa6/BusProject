using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject
{
    class User
    {
        static public int userID = 0;
        public double userCredit { set; get; }
        enum userType { elders, youth, kids_under5 }
        int type;

        public string userName { set; get; }
        int userAge { set; get; }
        string userContact { set; get; }


        public User(string name, int age, string contact)
        {

            generate_id();  
            this.userName = name;
            this.userContact = contact;
        }
        public int getType()
        {

            if (this.userAge < 5)
            {
                type = (int)userType.kids_under5;
                

            }
            else if (this.userAge > 60)
                type = (int)userType.elders;
            else type = (int)userType.youth;

            return type;
        }
        public User()
        {
            User.userID = generate_id();

        }

        public void register(string name, int age, string contact)
        {

            this.userAge = age;

            this.userName = name;
            this.userContact = contact;


        }
        public int generate_id()
        {
            userID++;
            return userID;
        }
        public double recharge_credit(double b)
        {
            this.userCredit += b;
            return this.userCredit;
        }

        public void display()
        {
            Console.WriteLine("User Nsme is: {0}", this.userName);
            Console.WriteLine("User Credit :{0}", this.userCredit);
            Console.WriteLine("User ID is :{0}", User.userID);
            Console.WriteLine("age is:{0}", this.userAge);
            Console.WriteLine("User contact is {0}", this.userContact);
            
        }

    }
}