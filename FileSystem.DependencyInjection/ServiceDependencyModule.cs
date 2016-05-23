namespace FileSystem.DependencyInjection
{
    using Ninject.Modules;
    using Services;

    public class ServiceDependencyModule : NinjectModule
    {
        public override void Load()
        {
            Bind<FolderService>().ToSelf();
        }
    }
}