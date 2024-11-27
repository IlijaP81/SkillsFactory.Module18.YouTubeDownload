using YouTubeDownload;

class Program
{
    static void Main(string[] args)
    {
        var sender = new CommandSender();
        var receiver = new CommandReceiver();

        var videoGetInfo = new Command_GetFileInfo(receiver);
        sender.SetCommand(videoGetInfo);
        sender.GetVideoInfo();

        var contentDownload = new Command_DownloadFile(receiver);    
        sender.SetCommand(contentDownload);
        sender.DownloadFile();
    }
}