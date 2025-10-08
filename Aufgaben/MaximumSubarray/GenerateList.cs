using System.Text;

class GenerateList
{
    public void GenerateRandomList()
    {
        string path = Path.GetFullPath("numbers.txt");
        Console.WriteLine("Generating random numbers...");

        int count = 100_000_000;
        var rand = new Random();

        using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 65_536))
        using (var writer = new StreamWriter(fs, Encoding.UTF8, 65_536))
        {
            for (int i = 0; i < count; i++)
            {
                writer.Write(rand.Next(-100_000, 100_001));
                if (i < count - 1)
                    writer.Write(", ");
            }
        }
    }
}