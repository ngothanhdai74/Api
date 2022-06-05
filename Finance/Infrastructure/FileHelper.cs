using System.IO.Compression;

namespace Finance.Infrastructure
{
    public static class FileHelper
    {
        public static IEnumerable<FileSystemInfo> AllFilesAndFolders(this DirectoryInfo dir)
        {
            foreach (var f in dir.GetFiles())
                yield return f;

            foreach (var d in dir.GetDirectories())
            {

                yield return d;
                foreach (var o in AllFilesAndFolders(d))
                    yield return o;

            }
        }
        public static MemoryStream Zip(string folderForZip)
        {
            var fileZipResult = Guid.NewGuid().ToString() + ".zip";
            ZipFile.CreateFromDirectory(folderForZip, fileZipResult);
            MemoryStream ms = new MemoryStream();
            using (FileStream fs = File.OpenRead(fileZipResult))
            {
                fs.CopyTo(ms);
            }
            File.Delete(fileZipResult);
            return ms;
        }
        public static void UnZip(string fileZipResult, string extractPath)
        {
            ZipFile.ExtractToDirectory(fileZipResult, extractPath);
        }
    }
}
