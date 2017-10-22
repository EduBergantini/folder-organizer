using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Organizer.View.Extensions
{
    internal static class FileInfoExtension
    {
        internal static IList<FileInfo> ToFileInfoList(this string[] filePaths)
        {
            return filePaths.Select(filePath => new FileInfo(filePath)).ToList();
        }
    }
}
