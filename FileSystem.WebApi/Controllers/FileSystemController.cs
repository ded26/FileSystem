namespace FileSystem.WebApi.Controllers
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using System.Web;
    using System.Web.Http;
    using Data;
    using Models;
    using Services.Abstract;

    public class FileSystemController : ApiController
    {
        private readonly IFolderService _folderService;

        public FileSystemController(IFolderService folderService)
        {
            _folderService = folderService;
        }

        public async Task<CurrentFolder> Get()
        {
            return await _folderService.GetFolderInfoAsync(HttpContext.Current.Request.PhysicalApplicationPath);
        }

        public async Task<CurrentFolder> Post(FolderViewModel model)
        {
            var path = String.Empty;
            path = model.DestinationFolder.Equals("..") ? 
                $"{_folderService.GetParentFolder(model.CurrentFolder)}\\" : 
                $"{model.CurrentFolder}{model.DestinationFolder}\\";
            return await _folderService.GetFolderInfoAsync(path);
        } 
    }
}
