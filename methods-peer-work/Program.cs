﻿namespace methods_peer_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // side note: i couldn't get a hold of my partner for this project, so i'll be working from two different clients on different computers. i'll provide screenshots of my progess as proof when i submit this to myCourses

            int jacob1FavNumber;
            int jacob2FavNumber;

            //initialize

            jacob1FavNumber = 64;
            jacob2FavNumber = 256;

            //jacob2's function
            int Subtract(int a, int b)
            {
                int value = a - b;
                return value;
            }
            
            //start of "our" actual program

            Console.WriteLine("Jacob1's favorite number is: " +  jacob1FavNumber);
            Console.WriteLine("Jacob2's favorite number is: " + jacob2FavNumber);
        }
    }
}
