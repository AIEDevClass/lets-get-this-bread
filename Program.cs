using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeptembersTask5
{
    class Program
    {
        /* - : private
         * + : public
         * # : protected */
        static void Main(string[] args)
        {
            

            Person[] p = new Person[3]; //==> Empty person
            Person[] loaded = Load(p); //==> Loaded person
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(p[i].Display());
                

            }
            Console.ReadLine();
        }

        public static Person[] Load(Person[] myArray){

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Please enter your name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter your identity : ");
                long identity = long.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your contact number : ");
                long contact = long.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your Address : ");
                string address = Console.ReadLine();
                Console.WriteLine("Please enter your Email address : ");
                string email = Console.ReadLine();
                myArray[i] = new Person(name, identity, contact, address, email);
            }
            return myArray;
        }
        
    }
    class Person
    {
        private string Name;
        private long Identity;
        private long Contact;
        private string Address;
        private string Email;

        public Person( string name, long identity, long contact, string address, string email)
        {
            Name = name;
            Identity = identity;
            Contact = contact;
            Address = address;
            Contact = contact;
            Email = email;
          
        }
        public string getName()
        {
            return Name;
        }
        public long getID()
        {
            return Identity;
        }
        public long getContact()
        {
            return Contact;
        }
        public string getAddress()
        {
            return Address;
        }
        public string getEmail()
        {
            return Email;
        }
        public string Display()
        {
            return "Name: " + Name + "\n Identity: " + Identity + "\n Contact: " + Contact + "\n Address: " + Address + " \n Email: " + Email;
        }
    }
}
