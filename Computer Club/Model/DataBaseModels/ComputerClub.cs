namespace Computer_Club.Model.DataBaseModels
{
    public class ComputerClub
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Computer> Computers { get; set; } = null!;
    }
}
