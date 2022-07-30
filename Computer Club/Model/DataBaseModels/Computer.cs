using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Computer_Club.Model.DataBaseModels
{
    [Table("Computers")]
    public class Computer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Model { get; set; } = null!;
        [ForeignKey("ComputerClubId")]
        public int ComputerClubId { get; set; }
        public ComputerClub? ComputerClub { get; set; }
        public List<Game>? Games { get; set; }
    }
}
