using System;

public class SayaTubeVideo
{
    public int id;
    public string title;
    public int playCount;

    public string Title
    {
        get { return title; }
    }

    public int PlayCount
    {
        get { return playCount; }
    }

    public SayaTubeVideo(string title)
    {
        if (title == null)
        {
            throw new ArgumentException("Judul video tidak boleh null");
        }

        if (title.Length > 200)
        {
            throw new ArgumentException("Judul video tidak boleh lebih dari 200 karakter");
        }

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0)
        {
            throw new ArgumentException("Play count tidak boleh negatif");
        }

        if (count > 25000000)
        {
            throw new ArgumentException("Play count maksimal 25.000.000 per panggilan");
        }

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Terjadi overflow pada play count");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID Video: " + id);
        Console.WriteLine("Judul Video: " + title);
        Console.WriteLine("Jumlah Play: " + playCount);
        Console.WriteLine();
    }
}