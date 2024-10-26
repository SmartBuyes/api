namespace Models.Entities;

public sealed class UserChecklist {
    public int UserId { get; set; }
    public int ChecklistId { get; set; }
    public bool IsOwner { get; set; }

    // ссылки
    public required User User { get; set; }
    public required Checklist Checklist { get; set; }
}