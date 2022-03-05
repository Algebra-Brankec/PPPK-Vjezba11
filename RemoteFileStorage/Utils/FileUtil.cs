using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteFileStorage.Utils
{
    public static class FileUtil
    {
        public static List<string> extensionWhitelist = new List<string>() { "jpg", "jpeg", "png", "svg", "tiff", "gif" };

        public static bool IsValidExtension(string extension)
        {
            return extensionWhitelist.Contains(extension.ToLower());
        }
    }
}
