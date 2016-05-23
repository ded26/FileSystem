namespace FileSystem.DependencyInjection
{
    using Data.Abstract;
    using Data.Repositories;
    using Ninject.Modules;

    public class DataDependencyModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IFolderRepository>().To<FolderRepository>();
        }
    }
}