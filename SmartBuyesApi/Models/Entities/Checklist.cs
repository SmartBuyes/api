namespace Models.Entities;

public sealed class Checklist {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime DateCreate { get; set; } = DateTime.Today.Date;
    public DateTime? DateClose { get; set; }
    public double? TotalPrice { get; set; }

    // тоже ссылка
    public IEnumerable<ChecklistElement> ChecklistElements { get; set; } = [];
    public IEnumerable<UserChecklist> UserChecklists { get; set;} = [];
}
