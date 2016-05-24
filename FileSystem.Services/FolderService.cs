namespace FileSystem.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Data.Abstract;
    using Data.Entities;

    /// <summary>
    /// Business logic for managing folders 
    /// </summary>
    public class FolderService
    {
        private readonly IFolderRepository _folderRepository;

        public FolderService(IFolderRepository folderRepository)
        {
            _folderRepository = folderRepository;
        }


        public async Task<CurrentFolder> GetRootFolderAsync(string path)
        {
            var files = await _folderRepository.GetAllFilesAsync(path);
            return new CurrentFolder
            {
                Path = path,
                Between10And50Mb = files.Count(f => f.Size > 10485760 && f.Size < 52428800),
                Less10Mb = files.Count(f => f.Size < 10485760),
                More100Mb = files.Count(f => f.Size > 104857600)
            };
        }
    }
}