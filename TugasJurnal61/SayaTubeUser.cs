using System;
using System.Collections.Generic;

public class SayaTubeUser
{
    public int id;
    public List<SayaTubeVideo> uploadedVideos;

    public string Username { get; set; }

    public SayaTubeUser(string username)
    {
        if (username == null)
        {
            throw new ArgumentException("Username tidak boleh null");
        }

        if (username.Length > 100)
        {
            throw new ArgumentException("Username tidak boleh lebih dari 100 karakter");
        }

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;

        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            total += uploadedVideos[i].PlayCount;
        }

        return total;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null)
        {
            throw new ArgumentException("Video tidak boleh null");
        }

        if (video.PlayCount >= int.MaxValue)
        {
            throw new ArgumentException("Play count video melebihi batas integer");
        }

        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User: " + Username);

        int jumlahPrint = uploadedVideos.Count;

        if (jumlahPrint > 8)
        {
            jumlahPrint = 8;
        }

        for (int i = 0; i < jumlahPrint; i++)
        {
            Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].Title);
        }

        Console.WriteLine();
    }
}
