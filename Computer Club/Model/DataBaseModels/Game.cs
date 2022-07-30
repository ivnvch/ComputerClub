using System.ComponentModel.DataAnnotations.Schema;

namespace Computer_Club.Model.DataBaseModels
{
    [Table("Games")]
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Computer> Computers { get; set; } = null!;
    }
}
