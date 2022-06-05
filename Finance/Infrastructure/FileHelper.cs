using System.IO.Compression;
using System.Text.Json;

namespace Finance.Infrastructure
{
    public static class FileHelper
    {
        public static string StartFolderConfig = "LocationRoot";
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
            using (FileStream fs = File.OpenRead(fileZipResult))
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    fs.CopyTo(memory);
                    File.Delete(fileZipResult);
                    return memory;

                }
            }
        }
        public static void UnZip(string fileZipResult, string extractPath)
        {
            ZipFile.ExtractToDirectory(fileZipResult, extractPath);
        }
        public static string CreateFolderIfNotExist(
            this IConfiguration configuration,
            params string[] folders
            )
        {
            string folderPath = configuration.GetValue<string>(StartFolderConfig);
            foreach (var folder in folders)
            {
                folderPath = Path.Combine(folderPath, folder);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
            return folderPath;
        }
        public static void SaveFile<T>(
            this IConfiguration configuration,
            string fileName,
            T content,
            params string[] folders) => File.WriteAllText(Path.Combine(configuration.CreateFolderIfNotExist(folders), fileName), JsonSerializer.Serialize(content));
        public static T GetFile<T>(
            this IConfiguration configuration,
            string filePath
        ) => JsonSerializer.Deserialize<T>(File.ReadAllText(Path.Combine(configuration.GetValue<string>(StartFolderConfig), filePath)));


        public static void CopyFile(
            this IConfiguration configuration,
            string sourceFilePath,
            string destinationFilePath
            )
        {
            string startFolder = configuration.GetValue<string>(StartFolderConfig);
            string sourceFile = Path.Combine(startFolder, sourceFilePath);
            string destFile = Path.Combine(startFolder, destinationFilePath);
        }
        public static void MoveFile(
            this IConfiguration configuration
            )
        {
            string startFolder = configuration.GetValue<string>(StartFolderConfig);
        }
        public static void DeleteFile(
            this IConfiguration configuration
            )
        {
            string startFolder = configuration.GetValue<string>("LocationRoot");

            DirectoryInfo dir = new DirectoryInfo(startFolder);

            IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);

            IEnumerable<System.IO.FileInfo> fileQuery =
            from file in fileList
            where file.Extension == ".txt"
            orderby file.Name
            select file;

        }
    }
}
