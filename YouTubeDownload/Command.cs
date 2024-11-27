using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload;

abstract class Command
{
    public abstract void GetVideoInfo();
    public abstract void DownloadFile();
}
