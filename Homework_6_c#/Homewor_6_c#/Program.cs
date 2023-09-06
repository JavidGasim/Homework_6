using Homework_6_c_;
using Homework_6_c_;

IStorage flash = new Flash("Flash", 4, 11, 2);
IStorage DVD = new Flash("DVD", 5.7, 17, 2);
IStorage HDD = new Flash("HDD", 1.2, 90, 2);

while (true)
{
    Console.WriteLine("1)Flash");
    Console.WriteLine("2)DVD");
    Console.WriteLine("3)HDD");
    Console.Write("Choose: ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("1)Capacity of Information");
        Console.WriteLine("2)Count of Device");
        Console.WriteLine("3)FreeMemory");
        Console.WriteLine("4)All Informations");

        Console.Write("Choose: ");
        string choice_1 = Console.ReadLine();

        if (choice_1=="1")
        {
            flash.Capacity();
        }

        else if (choice_1 == "2")
        {
            flash.Copy();
        }

        else if (choice_1 == "3")
        {
            flash.FreeMemory();
        }

        else if (choice_1 == "4")
        {
            flash.DeviceInfo();
        }
    }

    else if (choice == "2")
    {
        Console.WriteLine("1)Capacity of Information");
        Console.WriteLine("2)Count of Device");
        Console.WriteLine("3)FreeMemory");
        Console.WriteLine("4)All Informations");

        Console.Write("Choose: ");
        string choice_1 = Console.ReadLine();

        if (choice_1 == "1")
        {
            DVD.Capacity();
        }

        else if (choice_1 == "2")
        {
            DVD.Copy();
        }

        else if (choice_1 == "3")
        {
            DVD.FreeMemory();
        }

        else if (choice_1 == "4")
        {
            DVD.DeviceInfo();
        }
    }

    else if (choice == "3")
    {
        Console.WriteLine("1)Capacity of Information");
        Console.WriteLine("2)Count of Device");
        Console.WriteLine("3)FreeMemory");
        Console.WriteLine("4)All Informations");

        Console.Write("Choose: ");
        string choice_1 = Console.ReadLine();

        if (choice_1 == "1")
        {
            HDD.Capacity();
        }

        else if (choice_1 == "2")
        {
            HDD.Copy();
        }

        else if (choice_1 == "3")
        {
            HDD.FreeMemory();
        }

        else if (choice_1 == "4")
        {
            HDD.DeviceInfo();
        }
    }
}