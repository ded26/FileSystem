namespace FileSystem.Services
{
    using System;
    using System.Collections.Generic;
    using Data.Abstract;
    using Data.Entities;

    /// <summary>
    /// Business logic for managing folders 
    /// </summary>
    public class FolderService
    {
        private IFolderRepository _folderRepository;

        public FolderService(IFolderRepository folderRepository)
        {
            _folderRepository = folderRepository;
        }

        public IEnumerable<string> GetObjects(string path)
        {
            throw new NotImplementedException();
        }

        public string GetCurrentPath()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FileEntity> GetFilesSize(string path)
        {
            throw new NotImplementedException();
        } 
    }
}