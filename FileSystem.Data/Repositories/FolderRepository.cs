namespace FileSystem.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Abstract;
    using Entities;

    /// <summary>
    /// Repositories for working with folder entities
    /// </summary>
    public class FolderRepository : IFolderRepository
    {
        public Task<FileEntity[]> GetAllFilesAsync(string path)
        {
            return Task.Run(() => Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                            .Select(x => new FileInfo(x)).ToArray()
                                            .Select(x => new FileEntity
                                            {
                                                Name = x.FullName,
                                                Size = x.Length
                                            }).ToArray());
        }

        public Task<List<string>> EnumerateFoldersAsync(string path)
        {
            return Task.Run(() =>
            {
                var objects = new List<string>();
                if (!path.Equals(Directory.GetDirectoryRoot(path)))
                    objects.Add("..");
                objects.AddRange(Directory.EnumerateDirectories(path)
                    .Select(d => new DirectoryInfo(d + "\\").Name));
                return objects;
            });
        }

        public Task<List<string>> EnumerateFilesAsync(string path)
        {
            return Task.Run(() =>
            {
                var objects = new List<string>();
                objects.AddRange(Directory.GetFiles(path).Select(Path.GetFileName));
                return objects;
            });
        }

        public string GetParentFolder(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            return dir.Parent.FullName;
        }
    }
}