namespace Homework_6_c_;

internal class HDD : IStorage
{
    public string name { get; set; }
    public double capacity_1 { get; set; }
    public int speed { get; set; }
    public double memory { get; set; }
    public int count_media { get; set; }

    public HDD()
    {
        count_media = 1;
    }

    public HDD(string name, double capacity_1, int speed, double memory)
    {
        this.name = name;
        this.capacity_1 = capacity_1;
        this.speed = speed;
        this.memory = memory;
    }

    public void Capacity()
    {
        Console.WriteLine("Capacity: " + memory);
    }

    public void Copy()
    {
        if ((capacity_1 / memory) > 1)
        {
            count_media = Convert.ToInt32(capacity_1 / memory);
        }

        else
        {
            count_media = 1;
        }

        Console.WriteLine("We need " + count_media + " device");

    }

    public void FreeMemory()
    {
        Console.WriteLine("Free Memory: " + ((count_media * memory) - capacity_1));
    }

    public void DeviceInfo()
    {
        Console.WriteLine("Name of Device: " + name);
        Console.WriteLine("Speed of Device: " + speed + "Mbps");
        Console.WriteLine("Memory of Device: " + memory + "Gb");
        Console.WriteLine("Capacity of Information: " + capacity_1 + "Gb");
    }
}
