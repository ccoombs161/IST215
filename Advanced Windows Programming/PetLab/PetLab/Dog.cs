using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLab
{
    public class Dog : Pet
    {
        public string DogsBreed { get; set; }

        public Dog(PET_TYPE t, PET_COLOR c, string n ) : base(t, c, n) { }

        public Dog(PET_TYPE t, PET_COLOR c, string n, string breed) :base(t, c, n) { DogsBreed = DogsBreed; }
        public override string WhenHappy() => "I bark and wag my tail";
        public override string Sound() => "Woof Woof";
        public override string ToString()
        {
            return string.Format("{0} I say {1}, and when I am happy {2}.",
                base.ToString(), WhenHappy());
        }

        public void DisplayBreed()
        {
            Console.WriteLine("This dog's name is {0} and breed is {1}", PetName, DogsBreed);
            return;
        }
    }
}
