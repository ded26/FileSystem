namespace FileSystem.Services
{
    using System.Linq;
    using System.Threading.Tasks;
    using Abstract;
    using Data;
    using Data.Abstract;

    /// <summary>
    /// Business logic for managing folders 
    /// </summary>
    public class FolderService : IFolderService
    {
        private readonly IFolderRepository _folderRepository;

        public FolderService(IFolderRepository folderRepository)
        {
            _folderRepository = folderRepository;
        }


        public async Task<CurrentFolder> GetFolderInfoAsync(string path)
        {
            var files = await _folderRepository.GetAllFilesAsync(path);
            var objects = await _folderRepository.EnumerateFoldersAsync(path);
            var folderFiles = await _folderRepository.EnumerateFilesAsync(path);
            return new CurrentFolder
            {
                Path = path,
                Between10And50Mb = files.Count(f => f.Size > 10485760 && f.Size < 52428800),
                Less10Mb = files.Count(f => f.Size < 10485760),
                More100Mb = files.Count(f => f.Size > 104857600),
                Folders = objects,
                Files = folderFiles
            };
        }

        public string GetParentFolder(string path)
        {
           return _folderRepository.GetParentFolder(path);
        }
    }
}