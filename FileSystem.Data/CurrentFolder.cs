namespace FileSystem.Data
{
    using System.Collections.Generic;
    using Entities;

    /// <summary>
    /// Used to pased none sensitive data about folder
    /// </summary>
    public class CurrentFolder
    {
        public string Path { get; set; }

        public int Less10Mb { get; set; }
        public int Between10And50Mb { get; set; }
        public int More100Mb { get; set; }
        public IEnumerable<string> Objects { get; set; }
    }
}