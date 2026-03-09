using System;
using Tamagotchi_Game.Core.Models;
using Tamagotchi_Game.Core.Enums;
using Tamagotchi_Game.Core.Interfaces;
public class Program
{
    public static void Main(string[] args)
    {
        bool validPet;
        int optionPet = -1;
        string namePet;

        //1.Crearem primerament les stats de la mascota per despres ficarles a aquesta
        Stats initialStats = new Stats(100, 100);
        APet myPet = null;

        //2.Crearem el nostre inventari i ficarem menjar dins
        Inventory myInventory = new Inventory();
        myInventory.AddItem(new Meal("Fish", 15));
        myInventory.AddItem(new Snack("Cookie", 5));

        //3.Escollir tipus de mascota
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("TAMAGOTCHI");
        Console.ResetColor();
        Console.WriteLine("Choose a pet:");
        Console.WriteLine("1 - Cat");
        Console.WriteLine("2 - Dog");
        Console.WriteLine("3 - Chick");

        do
        {
            validPet = true;
            Console.Write("\nOption: ");
            try
            {
                optionPet = int.Parse(Console.ReadLine());

                if (optionPet < 1 || optionPet > 3) 
                {
                    Console.WriteLine("Invalid option. Try again.");
                    validPet = false;
                }
            }
            catch (Exception) 
            {
                Console.WriteLine("Error reding the input. Int type was espected");
                validPet = false;
            }
        } while (!validPet);

        //Choose a name for the pet
        Console.WriteLine("Pet name:");
        namePet = Console.ReadLine();

        switch (optionPet) 
        {
            case 1:
                myPet = new Cat(namePet, EmotionalState.Happy, initialStats, true);
                break;
            case 2:
                myPet = new Dog(namePet, EmotionalState.Happy, initialStats, true);
                break;
            case 3:
                myPet = new Chick(namePet, EmotionalState.Happy, initialStats, true);
                break;

        }

        //Play area for interacting with the pet
        while (myPet.IsAlive)
        {
            myPet.CheckStatus();
            Draw(myPet);

            int option = -1;
            int optionItem = -1;
            bool validInput;
            bool validItem;

            do
            {
                validInput = true;

                Console.WriteLine("Choose an option (1-4): ");

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());

                    if (option < 1 || option > 4)
                    {
                        Console.WriteLine("Invalid option. Put a valid option between 1 to 4.");
                        validInput = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format, type int was expected.");
                    validInput = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error reading!");
                    validInput = false;
                }
            } while (!validInput);

            switch (option)
            {
                case 1:
                    if (myInventory.ItemsInventory.Length > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("INVENTORY");
                        Console.ResetColor();
                        int index = 1;
                        validItem = true;
                        foreach (AItem itemsAvailable in myInventory.ItemsInventory)
                        {
                            Console.WriteLine($"{index} -> {itemsAvailable.Name}");
                            index++;
                        }
                        Console.WriteLine("What do you want to give your pet?");

                        do
                        {
                            validItem = true;
                            try
                            {
                                optionItem = Convert.ToInt32(Console.ReadLine());

                                if (optionItem < 1 || optionItem > myInventory.ItemsInventory.Length)
                                {
                                    Console.WriteLine("Error! Enter a valid option.");
                                    validItem = false;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Incorrect option. Choose a valid one.");
                                validItem = false;
                            }
                        } while (!validItem);

                        AItem itemConsumed = myInventory.ItemsInventory[optionItem -1];
                        itemConsumed.Use(myPet);
                    }
                    else
                    {
                        Console.WriteLine("The inventory is empty!");
                    }
                    break;

                case 2:
                    myPet.PetSleep();
                    break;

                case 3:
                    myPet.PetPlay();
                    break;

                case 4:
                    Console.WriteLine("Exiting the menu...");
                    return;

            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    public static void Draw(APet pet)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine("║          TAMAGOTCHI            ║");
        Console.WriteLine($"║    DateOfBirth: {DateTime.Today.ToString("dd/MM/yyyy")}     ║");
        Console.WriteLine($"║\t   Type: {pet.GetType().Name.PadRight(15)} ║");
        Console.WriteLine("╚════════════════════════════════╝");
        Console.ResetColor();

        // Convertimos el Enum a String para el ASCII Art
        Console.WriteLine(pet.GetSprites(pet.PetState));
        Console.WriteLine($"Name: {pet.Name} ");
        Console.WriteLine($"Emotional State: {pet.PetState} \n");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Hunger:{DrawBar(pet.PetStats.LvlHungry)}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Energy:{DrawBar(pet.PetStats.LvlEnergy)}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Health:{DrawBar(pet.PetStats.LvlHealthy)}");
        Console.ResetColor();

        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("1 - Eat");
        Console.WriteLine("2 - Sleep");
        Console.WriteLine("3 - Play");
        Console.WriteLine("4 - Exit");
    }

    private static string DrawBar(int value)
    {
        int safeValue = Math.Clamp(value, 0, 100);
        int totalBlocks = 20;
        int filledBlocks = safeValue * totalBlocks / 100;

        return "[" +
               new string('#', filledBlocks) +
               new string('-', totalBlocks - filledBlocks) + $"] {safeValue}%";
    }

}