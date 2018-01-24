using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLab
{
    class PetsProgram
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog(PET_TYPE.Dog, (PET_COLOR.Black | PET_COLOR.White),
                "Bowser");
            Reptile myReptile = new Reptile(PET_TYPE.Reptile, (PET_COLOR.Black | PET_COLOR.White),
                "Bowser");
            Amphibian myFrog = new Amphibian(PET_TYPE.Amphibian, (PET_COLOR.Green),
               "Froggy");

            Pet Reptile2 = new Reptile(PET_TYPE.Reptile, (PET_COLOR.Red),
                "King");
            Pet Amphibian2 = new Reptile(PET_TYPE.Reptile, (PET_COLOR.Black),
                "Queen");



            // Array of base class vars, receiving derived class references.
            Pet[] myPets = new Pet[8];
            myPets[0] = myDog;
            myPets[1] = myReptile;
            myPets[2] = Reptile2;
            myPets[3] = Amphibian2;
            myPets[4] = new Reptile(PET_TYPE.Reptile, (PET_COLOR.Blue),
               "Rocky");
            myPets[5] = new Dog(PET_TYPE.Dog, (PET_COLOR.Black | PET_COLOR.White),
                "Tipsy", "Boxer");
            myPets[6] = new Dog(PET_TYPE.Dog, (PET_COLOR.Brown),
                "Gypsy", "Mutt");
            myPets[7] = null;

            foreach (Pet myPet in myPets)
            {
                // if (myPet != (object)null)
                if (myPet != (Pet)null)
                    Console.WriteLine(myPet);
                else
                    Console.WriteLine("I am not yet a pet.");
            }
            Console.WriteLine(); Console.WriteLine();
            char[] delimeterChars = { '.' };
            foreach (Pet myPet in myPets)
            {
                if (myPet is Dog)
                {
                    Dog thisDog = (Dog)myPet;
                    if (thisDog.DogsBreed == "Mutt")
                        Console.WriteLine("\nSorry, we don't allow ({0}) in this apartment.",
                            thisDog.DogsBreed);
                    else
                    {
                        Console.WriteLine(" \nWe charge extra for the dogs of this breed ({0}) in this apartment.",
                            thisDog.DogsBreed);
                    }
                }

            }
        }
    }
}
