using System;
using Tamagotchi_Game.Core.Models;
using Tamagotchi_Game.Core.Enums;
using Tamagotchi_Game.Core.Interfaces;
public class Program
{
    public static void Main(string[] args)
    {
        //1.Crearem primerament les stats de la mascota per despres ficarles a aquesta
        Stats initialStats = new Stats(100, 100);
        Chick Kit = new Chick("Kit", EmotionalState.Happy, initialStats, true);

        //2.Crearem el nostre inventari i ficarem menjar dins
        Inventory myInventory = new Inventory();
        myInventory.AddItem(new Meal("Peix", 15));
        myInventory.AddItem(new Snack("Galeta", 5));

        while (Kit.IsAlive)
        {
            Kit.CheckStatus();
            Draw(Kit);

            int option = -1;
            int optionItem = -1;
            bool validInput;
            bool validItem;

            do
            {
                validInput = true;

                Console.WriteLine("Escull una opció (1-4): ");

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());

                    if (option < 1 || option > 4)
                    {
                        Console.WriteLine("Opció no vàlida. Introdueix una opció entre 1 i 4.");
                        validInput = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("S'ha de introduir un nombre.");
                    validInput = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al llegir opció escollida.");
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
                        Console.WriteLine("Que vols donar a la teva mascota.");

                        do
                        {
                            validItem = true;
                            try
                            {
                                optionItem = Convert.ToInt32(Console.ReadLine());

                                if (optionItem < 1 || optionItem > myInventory.ItemsInventory.Length)
                                {
                                    Console.WriteLine("Opció no vàlida. Introdueix una opció valida");
                                    validItem = false;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Opció incorrecte. Escull una de vàlida.");
                                validItem = false;
                            }
                        } while (!validItem);

                        AItem itemConsumed = myInventory.ItemsInventory[optionItem -1];
                        itemConsumed.Use(Kit);
                    }
                    else
                    {
                        Console.WriteLine("El inventari esta buit!");
                    }
                    break;

                case 2:
                    Kit.PetSleep();
                    break;

                case 3:
                    Kit.PetPlay();
                    break;

                case 4:
                    Console.WriteLine("Sortint del menú...");
                    return;

            }

            Console.WriteLine("Pulsa Enter per a continuar...");
            Console.ReadLine();
        }
    }

    public static void Draw(APet pet)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Clear();

        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine("║          TAMAGOTCHI            ║");
        Console.WriteLine($"║    DateOfBirth: {new DateTime(1987, 01, 15):dd/MM/yyyy}     ║");
        Console.WriteLine($"║\t   Type: {pet.GetType().Name.PadRight(15)}║");
        Console.WriteLine("╚════════════════════════════════╝");

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