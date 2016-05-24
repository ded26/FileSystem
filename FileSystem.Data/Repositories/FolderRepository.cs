namespace FileSystem.Data.Repositories
{
    using System;
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
    }
}