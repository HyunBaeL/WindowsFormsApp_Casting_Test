using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Casting_Test
{
    public class Animal
    {
        public string Name {  get; set; }

        public void Speak()
        {
            Console.WriteLine($"{Name} 동물이 소리를 냅니다.");
        }
    }

    public class Dog : Animal
    {
        
        public Dog() : base() { }

        public void DogSound()
        {
            Console.WriteLine("강아지 울음소리 멍멍~");
        }
    }

    public class Cat : Animal
    {
        public Cat() : base() { }

        public void CatSound()
        {
            Console.WriteLine("고양이 울음소리 냐용~");
        }
    }

    public class Bird : Animal
    {
        public Bird() : base() { }

        public void BirdSound()
        {
            Console.WriteLine("새 울음소리 짹짹~");
        }
    }
}
