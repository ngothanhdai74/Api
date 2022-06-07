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
        public static bool IsExistFile(
            this IConfiguration configuration,
            string filePath,
            params string[] folders
            )
        {
            string folderPath = configuration.GetValue<string>(StartFolderConfig);
            foreach (var folder in folders)
            {
                folderPath = Path.Combine(folderPath, folder);
            }
            folderPath = Path.Combine(folderPath, filePath);
            return File.Exists(folderPath);
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
            File.Copy(sourceFile, destFile, true);
        }
        public static void MoveFileOrFolder(
            this IConfiguration configuration,
            string sourcePath,
            string destinationPath,
            bool isMoveFile = false
            )
        {
            string startFolder = configuration.GetValue<string>(StartFolderConfig);
            string source = Path.Combine(startFolder, sourcePath);
            string destination = Path.Combine(startFolder, destinationPath);
            if(isMoveFile) File.Move(source, destination);
            else Directory.Move(source, destination);
        } 
        public static void DeleteFile(
            this IConfiguration configuration,
            string filePath,
            params string[] folders
            )
        {
            string startFolder = configuration.GetValue<string>(StartFolderConfig);
            foreach (var folder in folders)
            {
                startFolder = Path.Combine(startFolder, folder);
            }
            startFolder = Path.Combine(startFolder, filePath);
            File.Delete(startFolder);
        }
    }
}
