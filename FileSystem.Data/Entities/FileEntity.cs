namespace FileSystem.Data.Entities
{
    /// <summary>
    /// Entity, which describes the file on hard disk
    /// </summary>
    public class FileEntity
    {
        public string Name { get; set; }

        public long Size { get; set; }
    }
}
