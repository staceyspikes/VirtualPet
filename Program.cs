using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Giraffe Geronimo = new Giraffe();

            Console.WriteLine("Hey! My name is Geronimo and I'm the mighty giraffe. Please take care of me.");
            Console.WriteLine(" The only things I understand are the numbers 1,2,3");
            Console.WriteLine("The only thing I ask of you is to keep me alive!");





            // Put a switch case statement inside the while loop 
            int hungerLevel = 3;
            int tiredLevel = 7;
            int boredomLevel = 3;
            do
            {
                
                Console.WriteLine(" What would you like to do now, friend? ( 1.Eat / 2. Rest /3. Play");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "1":
                        Geronimo.Eat();
                        break;
                    case "2":
                        Geronimo.Rest();
                        break;
                    case "3":
                        Geronimo.Play();
                        break;
                    case "4":
                        Console.WriteLine(" Sorry that was not a valid number. Please try again");
                        Console.ReadLine();
                        break;
                }
                  
                } while ( hungerLevel <= 10 && tiredLevel <=10 && boredomLevel <= 10) ;

            








            

            
            
            
        }
        

       

        
    }
}
