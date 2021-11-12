using System.ComponentModel.DataAnnotations;

namespace RockyPanelBackend.Models
{
    public class ServerModel
    {
        [Key]
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string Uuid_Short { get; set; }
        public int Node_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int Owner_Id { get; set; }
        public int Memory { get; set; }
        public int Swap { get; set; }
        public int Disk { get; set; }
        public int Io { get; set; }
        public int Cpu { get; set; }
        public bool Oom_Disabled { get; set; }
        public string Allocations { get; set; }
        public int Image_Id { get; set; }
        public string Startup { get; set; }
        public int Backup_Limit { get; set; }
    }
}
