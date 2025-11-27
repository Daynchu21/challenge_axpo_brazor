namespace BlazorApp.Models;

/// <summary>
/// Represents a complete contract overview with all relevant sections
/// </summary>
public class ContractOverview
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = string.Empty;
    public List<ContractSummaryItem> Items { get; set; } = new();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    public bool HasItems => Items?.Any() ?? false;
}
