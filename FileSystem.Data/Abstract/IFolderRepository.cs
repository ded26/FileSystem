namespace FileSystem.Data.Abstract
{
    using System.Threading.Tasks;
    using Entities;

    /// <summary>
    /// Interface for manipulating folder entity
    /// </summary>
    public interface IFolderRepository : IRepository
    {
        Task<FileEntity[]> GetAllFilesAsync(string path);
    }
}