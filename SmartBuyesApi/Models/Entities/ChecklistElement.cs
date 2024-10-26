namespace Models.Entities;

public sealed class ChecklistElement {
    public int Id { get; set; }
    public int ChecklistId { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsChecked { get; set; }
    
    // и это тоже ссылка, Камал!
    public required Checklist Checklist { get; set; }
}
