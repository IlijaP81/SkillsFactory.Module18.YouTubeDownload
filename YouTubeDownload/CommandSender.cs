using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload;

internal class CommandSender
{
    Command command;
    public void SetCommand(Command command) { this.command = command; }
    public void GetVideoInfo() { command.GetVideoInfo(); }
    public void DownloadFile() { command.DownloadFile(); }
}
