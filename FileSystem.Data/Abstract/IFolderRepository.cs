namespace FileSystem.Data.Abstract
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;

    /// <summary>
    /// Interface for manipulating folder entity
    /// </summary>
    public interface IFolderRepository : IRepository
    {
        Task<FileEntity[]> GetAllFilesAsync(string path);

        Task<List<string>> EnumerateFoldersAsync(string path);
        Task<List<string>> EnumerateFilesAsync(string path);
        string GetParentFolder(string path);
    }
}