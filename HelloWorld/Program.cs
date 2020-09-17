/* Name: Christian Lachapelle
 * A-Number: A00230066
 * Week/Assignment Number: 2/1
 * IOT1001: Programming and Logic
 */

using System;

namespace HelloWorld
{
    class MainClass
    {
        // Line 14-20 is the XML docstring
        /// <summary>
        /// Assignment 1: Personalized "Hello World!" in C#
        /// </summary>
        /// <remarks>
        /// Print "Hello World!", followed by three pieces of information about
        /// myself on three seperate lines.
        /// </remarks>
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\nHere's three things about me that you might " +
                "not know about me. Or maybe you do!");
            Console.WriteLine("\nMy name is Christian Lachapelle.");
            Console.WriteLine("I'm Gen X.");
            Console.WriteLine("I'm a veteran.");
        }
    }
}
