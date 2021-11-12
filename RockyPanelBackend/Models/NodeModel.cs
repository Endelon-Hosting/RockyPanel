using System.ComponentModel.DataAnnotations;

namespace RockyPanelBackend.Models
{
    public class NodeModel
    {
        [Key]
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public int Memory { get; set; }
        public int Disk { get; set; }
        public string Token_Id { get; set; }
        public string Token { get; set; }
        public int Sftp_Port { get; set; }
        public int Port { get; set; }
        public string File_Base { get; set; }
    }
}
