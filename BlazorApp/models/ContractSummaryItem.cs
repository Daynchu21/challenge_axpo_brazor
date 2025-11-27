using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models;

public class ContractSummaryItem
{
    [Required(ErrorMessage = "Label is required")]
    [StringLength(100, ErrorMessage = "Label cannot exceed 100 characters")]
    public string Label { get; set; } = string.Empty;

    [Required(ErrorMessage = "Value is required")]
    [StringLength(500, ErrorMessage = "Value cannot exceed 500 characters")]
    public string Value { get; set; } = string.Empty;

    public string? Icon { get; set; }

    /// <summary>
    /// Indicates if this item should be highlighted or emphasized in the UI
    /// </summary>
    public bool IsHighlighted { get; set; } = false;

    /// <summary>
    /// Custom CSS class for styling this specific item
    /// </summary>
    public string? CustomCssClass { get; set; }
}
