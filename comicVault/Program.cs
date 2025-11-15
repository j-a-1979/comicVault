using System;
using System.Collections.Generic;
using System.IO;







// create list to store comics
List<string> comics = new List<string>();
string filePath = "comics.txt";

if (File.Exists(filePath))
{
    comics.AddRange(File.ReadAllLines(filePath));
}

Console.WriteLine("Welcome To comicVault");
Console.WriteLine("---------------------");


while (true)
{
    
    
    Console.WriteLine("\tMENU\t\n");
    Console.WriteLine("1. Add Comics\n");
    Console.WriteLine("2. See your comic list\n");
    Console.WriteLine("3. Placeholder\n");
    Console.WriteLine("4. Placeholder\n");

    Console.Write("Please enter your choice 1-4: ");



    string ?menuChoice = Console.ReadLine();

    // 1 MENU OPTION (1. ADD COMICS)
    // main loop to add comics

    if (menuChoice == "1")
    {
        while (true)
        {
            Console.WriteLine("Enter the name of a comic: ");       // ask for comic name
            string? addComic = Console.ReadLine();                  // read user input

            if (!string.IsNullOrWhiteSpace(addComic))
            {
                comics.Add(addComic);

                File.AppendAllText(filePath, addComic + Environment.NewLine);
                
                Console.WriteLine($"'{addComic}' has been added to your comic vault.");

                Console.WriteLine("Do you want to add another comic? (yes/no): ");
                string? response = Console.ReadLine()?.Trim().ToLower();

                if (response == "yes")
                {
                        continue; // repeat the loop to add another comic
                }

                else if (response == "no")
                {
                    Console.WriteLine("\nBye bye!");
                    break; // goes back to the menu
                }     
        
                
                else
                {
                    Console.WriteLine("Going back to the Menu");
                    break; // goes back to the menu
                }
            
            }

            else
            {
                Console.WriteLine("You must enter a comic name!");
            }
            
                
        }    
        
    

    }
    else if (menuChoice == "2")
    {
        Console.WriteLine("Your comic list:");
        if (comics.Count == 0)
        {
            Console.WriteLine("Your comic vault is empty.");
        }
        else
        {
            foreach (string comic in comics)
            {
                Console.WriteLine($"- {comic}");
            }
        }
    }


    // PLACEHOLDER FOR OTHER MENU OPTIONS
    else
    {
        Console.WriteLine("This option is not yet implemented. Please restart the program and choose option 1 to add comics.");
    }

    
}