namespace FileSystem.Data.Models.Entities
{
    /// <summary>
    /// Entity, which describes the file on hard disk
    /// </summary>
    public class FileEntity
    {
        public string Name { get; set; }

        public int Size { get; set; }
    }
}
