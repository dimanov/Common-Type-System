/*Problem 4. Person class
Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
Write a program to test this functionality.
 10x to newmast*/

namespace PersonClass
{
    using System;

    using System.Linq;

    public class EntryPoint
    {
        static void Main()
        {
            Person pesho = new Person("Pesho", 30);
            Person gosho = new Person("Gosho", null);

            Console.WriteLine(pesho.ToString());
            Console.WriteLine(gosho.ToString());
        }
    }
}
