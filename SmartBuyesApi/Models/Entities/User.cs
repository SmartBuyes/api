namespace Models.Entities;

public sealed class User {
    public int Id { get; set; }
    public string Login { get; set; } = string.Empty;
    public string Password  { get; set; } = string.Empty;
    public string Name  { get; set; } = string.Empty;
    public DateTime? DateOfBirth  { get; set; }

    public IEnumerable<UserChecklist> UserChecklists { get; set; } = [];
}