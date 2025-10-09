using System.Text;

class GenerateList
{
    public long GenerateRandomList(long count)
    {
        string path = Path.GetFullPath("numbers.txt");
        Console.WriteLine($"Generating {count:N0} random numbers...");

        var rand = new Random();

        using var fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 1_048_576);
        using var writer = new StreamWriter(fs, new UTF8Encoding(false), 1_048_576);

        var sb = new StringBuilder(12_000);
        const int batchSize = 10_000;

        for (long i = 0; i < count; i++)
        {
            sb.Append(rand.Next(-100_000, 100_001));
            if (i < count - 1) sb.Append(',');

            if (i % batchSize == 0 && i != 0)
            {
                writer.Write(sb);
                sb.Clear();
            }
        }

        if (sb.Length > 0)
            writer.Write(sb);

        Console.WriteLine("Done");
        return count;
    }
}