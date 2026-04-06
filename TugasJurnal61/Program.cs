using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaTubeUser user = new SayaTubeUser("Rizky");

            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Interstellar oleh Rizky");
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Inception oleh Rizky");
            SayaTubeVideo video3 = new SayaTubeVideo("Review Film The Dark Knight oleh Rizky");
            SayaTubeVideo video4 = new SayaTubeVideo("Review Film Parasite oleh Rizky");
            SayaTubeVideo video5 = new SayaTubeVideo("Review Film Avengers Endgame oleh Rizky");
            SayaTubeVideo video6 = new SayaTubeVideo("Review Film Joker oleh Rizky");
            SayaTubeVideo video7 = new SayaTubeVideo("Review Film Whiplash oleh Rizky");
            SayaTubeVideo video8 = new SayaTubeVideo("Review Film Oppenheimer oleh Rizky");
            SayaTubeVideo video9 = new SayaTubeVideo("Review Film Your Name oleh Rizky");
            SayaTubeVideo video10 = new SayaTubeVideo("Review Film Spirited Away oleh Rizky");

            video1.IncreasePlayCount(1000);
            video2.IncreasePlayCount(2000);
            video3.IncreasePlayCount(3000);
            video4.IncreasePlayCount(4000);
            video5.IncreasePlayCount(5000);
            video6.IncreasePlayCount(6000);
            video7.IncreasePlayCount(7000);
            video8.IncreasePlayCount(8000);
            video9.IncreasePlayCount(9000);
            video10.IncreasePlayCount(10000);

            user.AddVideo(video1);
            user.AddVideo(video2);
            user.AddVideo(video3);
            user.AddVideo(video4);
            user.AddVideo(video5);
            user.AddVideo(video6);
            user.AddVideo(video7);
            user.AddVideo(video8);
            user.AddVideo(video9);
            user.AddVideo(video10);

            video1.PrintVideoDetails();
            user.PrintAllVideoPlaycount();

            Console.WriteLine("Total play count semua video: " + user.GetTotalVideoPlayCount());
            Console.WriteLine();

            Console.WriteLine("=== Pengujian Precondition dan Exception ===");

            try
            {
                SayaTubeVideo videoError1 = new SayaTubeVideo(null);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error judul null: " + e.Message);
            }

            try
            {
                SayaTubeVideo videoError2 = new SayaTubeVideo(new string('A', 201));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error judul terlalu panjang: " + e.Message);
            }

            try
            {
                video1.IncreasePlayCount(-10);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error play count negatif: " + e.Message);
            }

            try
            {
                video1.IncreasePlayCount(30000000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error play count terlalu besar: " + e.Message);
            }

            try
            {
                SayaTubeUser userError = new SayaTubeUser(null);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error username null: " + e.Message);
            }

            try
            {
                user.AddVideo(null);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error add video null: " + e.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Program selesai.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Terjadi error: " + e.Message);
        }
    }
}

