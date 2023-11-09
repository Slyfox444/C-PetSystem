
string animalSpecies = "";
string animalId = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

int maxPets = 8;
string? readResult;
string menuSelection = "";
int petAge = 0;
bool validEntry = false;
string anotherPet = "y";
int petCount = 0;

string[,] ourAnimal = new string[maxPets, 6];

for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalId = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalId = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalId = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalId = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalId = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimal[i, 0] = "ID: " + animalId;
    ourAnimal[i, 1] = "Species: " + animalSpecies;
    ourAnimal[i, 2] = "Age: " + animalAge;
    ourAnimal[i, 3] = "Nickname: " + animalNickname;
    ourAnimal[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimal[i, 5] = "Personality description: " + animalPersonalityDescription;
}

do
{
    //display the menu options

    Console.Clear();
    System.Console.WriteLine("Welcome to the PetFriends App. Your main menu options are: ");
    System.Console.WriteLine("1.List all of our current pet information.");
    System.Console.WriteLine("2.Assign values to the ourAnimals array fields.");
    System.Console.WriteLine("3.Ensure animal ages and physical descriptions are complete.");
    System.Console.WriteLine("4.Ensure animal nicknames and personality descriptions are complete.");
    System.Console.WriteLine("5.Edit an animals age.");
    System.Console.WriteLine("6.Edit an animal’s personality description.");
    System.Console.WriteLine("7.Display all cats with a specified characteristic.");
    System.Console.WriteLine("8.Display all dogs with a specified characteristic.");
    System.Console.WriteLine();
    System.Console.WriteLine("Enter your selection number(or type Exit to exit the program)");


    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }
   





    switch (menuSelection)
    {
        case "1":
            //List of all current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimal[i, 0] != "ID: ")
                {
                    System.Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        System.Console.WriteLine(ourAnimal[i, j]);
                    }
                }
            }
            System.Console.WriteLine("Press the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            //add a new animal friend to the ourAnimals array

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimal[i, 0] != "ID: ")
                {
                    petCount++;
                }
            }
            if (petCount < maxPets)
            {
                System.Console.WriteLine($"We currently have {petCount} pats that need homes. We can manage {maxPets - petCount} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {

                //cat or dog
                do
                {
                    System.Console.WriteLine("\nEnte 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();

                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);
                animalId = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                do
                {

                    System.Console.WriteLine("Enter a pet age or enter ? if you don`t know");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                do
                {
                    System.Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                do
                {
                    System.Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                do
                {
                    System.Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                // store the pet information in the ourAnimals array 
                ourAnimal[petCount, 0] = "ID #: " + animalId;
                ourAnimal[petCount, 1] = "Species: " + animalSpecies;
                ourAnimal[petCount, 2] = "Age: " + animalAge;
                ourAnimal[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimal[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimal[petCount, 5] = "Personality: " + animalPersonalityDescription;



                petCount += 1;

                if (petCount < maxPets)
                {
                    System.Console.WriteLine("Do you want to enter a information for another pet? (y/n): ");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }


            }
            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                System.Console.WriteLine("Press the Enter key to continue");
                readResult = Console.ReadLine();
            }



            break;

        case "3":
            // animal ages and physical descriptions are complete 

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimal[i, 2] == "Age: ?" && ourAnimal[i, 0] != "ID: ")
                {
                    do
                    {
                        System.Console.WriteLine($"Enter an age for {ourAnimal[i, 0]}");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalAge = readResult;
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                    } while (validEntry == false);
                    ourAnimal[i, 2] = "Age: " + animalAge.ToString();
                }

                if(ourAnimal[i,4] == "Physical description: " && ourAnimal[i,0] != "ID: ")
                {
                    do
                    {
                        System.Console.WriteLine($"Enter a physical description for {ourAnimal[i, 0]} (size, color, gender, weight, housebroken)");
                        readResult = Console.ReadLine();
                        if (readResult!= null)
                        {
                            animalPhysicalDescription = readResult.ToLower();
                            if (animalPhysicalDescription == "")
                            {
                                validEntry = false;
                            }
                            else
                                validEntry = true;
                        }
                    } while (validEntry == false);
                    ourAnimal[i, 4] = "Physical description: " + animalPhysicalDescription;
                }
            }
            Console.WriteLine("\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        case "4":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

    }
} while (menuSelection != "exit");

