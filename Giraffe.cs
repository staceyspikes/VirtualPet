using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Giraffe
    {
        private string name;
        private int height;
        private int age;
        private string eyeColor;
        private int hungerLevel;
        private int tiredLevel;
        private int boredomLevel; 

        public string Name
        {
            get { return this.name; }
        }
        public int Height
        {
            get { return this.height; }
            
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string EyeColor
        {
            get { return this.eyeColor; }
            set { this.eyeColor = value; }
        }
        public Giraffe()
        {
            this.name = "Geronimo";
            this.hungerLevel = 3;
            this.tiredLevel = 7;
            this.boredomLevel = 3;

            
        }
        public Giraffe(int height, int age, string eyeColor,int hungerLevel, int tiredLevel)
        {
            this.height = height;
            this.age = age;
            this.eyeColor = eyeColor;
            this.hungerLevel = hungerLevel;
            this.tiredLevel = tiredLevel;
            
        }
        public void Eat()
        {
            if (hungerLevel < 7)
            {
                Console.WriteLine(" I am trying to watch my figure, If I eat again I am going to get a double chin.");
                Console.WriteLine(" My hunger level is {0}:", this.hungerLevel);
                Console.WriteLine("My boredom level is {0}:", this.boredomLevel);
                Console.WriteLine("My tired level is {0}:", this.tiredLevel);
            }
            else
            {
                this.tiredLevel += 1;
                this.hungerLevel -= 2;
                Console.WriteLine("Yum thanks for the chocolate.");
                Console.WriteLine(" My hunger level is {0}:", this.hungerLevel);
                Console.WriteLine("My boredom level is {0}:", this.boredomLevel);
                Console.WriteLine("My tired level is {0}", this.tiredLevel);
            }
        }
           
        
        public void Rest()
        {
            if(tiredLevel < 7)
            {
                Console.WriteLine("I'm not ready to nap, I want to party");
                Console.WriteLine("My hunger level is {0}:", this.hungerLevel);
                Console.WriteLine("My boredom level is {0}:", this.boredomLevel);
                Console.WriteLine("My tired level is {0}", this.tiredLevel);
            }
            else
            {
                this.boredomLevel += 2;
                this.tiredLevel -= 2;
                Console.WriteLine(" Time to get my beauty rest. My tired level is now {0}", this.tiredLevel);
                Console.WriteLine("My hunger level is {0}:", this.hungerLevel);
                Console.WriteLine("My boredom level is {0}:", this.boredomLevel);
                
            }
        }
        public void Play()
        {
            if (boredomLevel > 7)
            {
                Console.WriteLine(" This is no time for playing!");
                Console.WriteLine("My hunger level is {0}:", this.hungerLevel);
                Console.WriteLine("My boredom level is {0}:", this.boredomLevel);
                Console.WriteLine("My tired level is {0}", this.tiredLevel);
            }
            else
            {
                this.tiredLevel += 1;
                this.hungerLevel += 2;
                Console.WriteLine(" I love when we have play dates! My boredom level is now {0}", this.boredomLevel );
                Console.WriteLine(" My hunger level is {0}:", this.hungerLevel);
                Console.WriteLine("My tired level is {0}", this.tiredLevel);
            }
        }


    }
}
