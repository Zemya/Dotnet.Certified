// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{

    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    // display the top-level menu options
    Console.Clear();

    Console.WriteLine();
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();



    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    //Console.WriteLine($"You selected menu option {menuSelection}.");
    //Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    //readResult = Console.ReadLine();

    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                bool validEntry = false;

                // get species (cat or dog) - string animalSpecies is a required field
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            //Console.WriteLine($"You entered: {animalSpecies}.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at initial entry.
                do
                {
                    int petAge;
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
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

                // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
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

                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
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

                // get the pet's nickname. animalNickname can be blank
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
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

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                while (anotherPet == "y" && petCount < maxPets)
                {
                    // increment petCount (the array is zero-based, so we increment the counter after adding tot he array)
                    petCount = petCount + 1;

                    // check maxPet limit
                    if (petCount < maxPets)
                    {
                        // another pet?
                        Console.WriteLine("Do you want to enter info for another pet (y/n)?");
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
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                }
            }

            break;



        case "3":
            // Ensure animal ages and physical descriptions are complete
            Console.WriteLine("\nChecking and updating ages and physical descriptions...\n");

            for (int i = 0; i < maxPets; i++)
            {
                // Only process pets that exist (have an ID)
                if (ourAnimals[i, 0] == "ID #: ") continue;

                string currentAge = ourAnimals[i, 2].Replace("Age: ", "").Trim();  // Extract just the age value
                string currentDescription = ourAnimals[i, 4].Replace("Physical description: ", "").Trim();

                // --- Validate and update AGE ---
                bool ageValid = false;
                int petAgeInt = 0;

                // Check if age is already valid
                if (int.TryParse(currentAge, out petAgeInt) && petAgeInt >= 1)
                {
                    ageValid = true;
                }

                while (!ageValid)
                {
                    Console.WriteLine($"Current age for {ourAnimals[i, 0]} ({ourAnimals[i, 1]}): {currentAge}");
                    Console.WriteLine("Enter a valid age (positive integer >= 1) or press Enter to skip:");
                    string? readAge = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(readAge))
                    {
                        Console.WriteLine("No change made. Moving to next pet.\n");
                        ageValid = true; // Skip update
                    }
                    else if (int.TryParse(readAge, out petAgeInt) && petAgeInt >= 1)
                    {
                        // Update the array
                        ourAnimals[i, 2] = "Age: " + petAgeInt.ToString();
                        Console.WriteLine($"Age updated to {petAgeInt}.\n");
                        ageValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a positive whole number >= 1.\n");
                    }
                }

                // --- Validate and update PHYSICAL DESCRIPTION ---
                bool descriptionValid = !string.IsNullOrWhiteSpace(currentDescription) && currentDescription.Length >= 5;

                while (!descriptionValid)
                {
                    Console.WriteLine($"Current physical description for {ourAnimals[i, 0]} ({ourAnimals[i, 1]}):");
                    Console.WriteLine($"  \"{currentDescription}\"");
                    Console.WriteLine("Enter a detailed physical description (at least 5 characters, e.g., size, color, gender, weight):");
                    string? readDesc = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(readDesc))
                    {
                        Console.WriteLine("Description cannot be empty. Please provide a description.\n");
                    }
                    else if (readDesc.Length < 5)
                    {
                        Console.WriteLine("Description is too short. Please provide more detail (at least 5 characters).\n");
                    }
                    else
                    {
                        // Update the array
                        ourAnimals[i, 4] = "Physical description: " + readDesc;
                        Console.WriteLine("\nPhysical description updated.\n");
                        descriptionValid = true;
                    }
                }
            }

            Console.WriteLine("Age and physical description fields are complete for all of our friends.");
            Console.WriteLine("\nPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        case "4":
            // Ensure animal nicknames and personality descriptions are complete
            Console.WriteLine("\nChecking and updating nicknames and personality descriptions...\n");

            for (int i = 0; i < maxPets; i++)
            {
                // Skip empty slots
                if (ourAnimals[i, 0] == "ID #: ") continue;

                string currentNickname = ourAnimals[i, 3].Replace("Nickname: ", "").Trim();
                string currentPersonality = ourAnimals[i, 5].Replace("Personality: ", "").Trim();

                // --- Validate and update NICKNAME ---
                bool nicknameValid = !string.IsNullOrWhiteSpace(currentNickname) && currentNickname.ToLower() != "tbd";

                while (!nicknameValid)
                {
                    Console.WriteLine($"Current nickname for {ourAnimals[i, 0]} ({ourAnimals[i, 1]}): {currentNickname}");
                    Console.WriteLine("Enter a nickname for the pet (or press Enter to keep current / leave blank):");
                    string? readNickname = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(readNickname))
                    {
                        Console.WriteLine("No change made to nickname.\n");
                        nicknameValid = true; // Accept current (including blank)
                    }
                    else
                    {
                        // Update the array
                        ourAnimals[i, 3] = "Nickname: " + readNickname;
                        Console.WriteLine($"Nickname updated to \"{readNickname}\".\n");
                        nicknameValid = true;
                    }
                }

                // --- Validate and update PERSONALITY DESCRIPTION ---
                bool personalityValid = !string.IsNullOrWhiteSpace(currentPersonality) && currentPersonality.ToLower() != "tbd";

                while (!personalityValid)
                {
                    Console.WriteLine($"Current personality description for {ourAnimals[i, 0]} ({ourAnimals[i, 1]}):");
                    Console.WriteLine($"  \"{currentPersonality}\"");
                    Console.WriteLine("Enter a description of the pet's personality (likes/dislikes, energy level, etc.)");
                    Console.WriteLine("or press Enter to keep current / leave as-is:");
                    string? readPersonality = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(readPersonality))
                    {
                        Console.WriteLine("No change made to personality description.\n");
                        personalityValid = true; // Accept current
                    }
                    else
                    {
                        // Update the array
                        ourAnimals[i, 5] = "Personality: " + readPersonality;
                        Console.WriteLine("\nPersonality description updated.\n");
                        personalityValid = true;
                    }
                }
            }

            Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");
            Console.WriteLine("\nPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;
    

        case "5":
            // List all of our current pet information
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            // List all of our current pet information
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            // List all of our current pet information
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            // List all of our current pet information
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }
        ;

} while (menuSelection != "exit");