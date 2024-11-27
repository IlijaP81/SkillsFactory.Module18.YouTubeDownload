namespace YouTubeDownload;

/// <summary>
/// Define necessary commands. Append new commands here.
/// </summary>
internal class Command_GetFileInfo : Command
{
    CommandReceiver receiver;
    public Command_GetFileInfo(CommandReceiver receiver)
    {
        this.receiver = receiver;
    }
    public override void GetVideoInfo()
    {
        receiver.GetInfo();
    }
    public override void DownloadFile() {}
}
    
internal class Command_DownloadFile : Command
{
    CommandReceiver receiver;
    public Command_DownloadFile(CommandReceiver receiver)
    {
        this.receiver = receiver;
    }
    public override void DownloadFile()
    {
        receiver.DownloadFile();
    }
    public override void GetVideoInfo() { }
}
