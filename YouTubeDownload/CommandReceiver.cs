//using YoutubeExplode;
//using Xabe.FFmpeg;
using System.Net;
using VideoLibrary;

namespace YouTubeDownload;

/// <summary>
/// Realise command's logic
/// </summary>
internal class CommandReceiver
{
    /// <summary>
    /// Get information about video file from url
    /// </summary>
    public void GetInfo()
    {
        var youtubeClient = YouTube.Default;

        Console.WriteLine("Укажите ссылку на видео:");
        string link = Console.ReadLine(); // for debugging https://youtu.be/Lr5DWf5L42k?si=0Egtp_NeyAjtYW8W
        try
        {
            var video = youtubeClient.GetVideo(link);
            Console.WriteLine("Информация о видео:");
            Console.WriteLine("название: " + video.FullName);
            Console.WriteLine("формат: " + video.Format);
            Console.WriteLine("продолжительность, сек: " + video.Info.LengthSeconds);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + " В связи с медленной работой хостинга YouTube, " +
                                          " повторите попытку еще раз");
        }
    }

    /// <summary>
    /// Download file from url
    /// </summary>
    public void DownloadFile()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string url = "https://www.google.com/images/icons/ui/doodle_plus/logo.png";

        // Get filename from URL
        Uri uri = new Uri(url);
        string filename = Path.GetFileName(uri.LocalPath);

        var client = new WebClient();
        try
        {
            client.DownloadFile(url, desktopPath + "/" + filename);
            Console.WriteLine("Файл загружен " + desktopPath);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
