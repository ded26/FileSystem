namespace FileSystem.Services.Abstract
{
    using System.Threading.Tasks;
    using Data;

    public interface IFolderService
    {
        Task<CurrentFolder> GetFolderInfoAsync(string path);
        string GetParentFolder(string path);
    }
}