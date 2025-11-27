using BlazorApp.components.Accordion;
using Bunit;
using Xunit;

namespace BlazorApp.Tests.Components;

public class AccordionTests : TestContext
{
    [Fact]
    public void Accordion_SeExpande_AlHacerClick()
    {
        // Arrange
        var items = new List<ContractSummaryItem>
        {
            new() { Label = "Contract Type", Value = "Existing Client" },
            new() { Label = "Commodity", Value = "Power" }
        };

        var cut = RenderComponent<Accordion>(parameters => parameters
            .Add(p => p.Title, "Test Accordion")
            .Add(p => p.Items, items));

        // Assert - El accordion debe estar colapsado inicialmente
        var contentDiv = cut.FindAll(".accordion-root");
        Assert.Empty(contentDiv);

        // Act - Hacer click en el header del accordion
        var header = cut.Find(".cursor-pointer");
        header.Click();

        // Assert - El accordion debe estar expandido después del click
        contentDiv = cut.FindAll(".accordion-root");
        Assert.NotEmpty(contentDiv);

        // Verificar que el contenido se muestra
        var accordionBody = cut.FindAll(".accordion-body");
        Assert.Equal(2, accordionBody.Count);
    }

    [Fact]
    public void Accordion_SeColapsa_AlHacerClickDosVeces()
    {
        // Arrange
        var items = new List<ContractSummaryItem>
        {
            new() { Label = "Test Label", Value = "Test Value" }
        };

        var cut = RenderComponent<Accordion>(parameters => parameters
            .Add(p => p.Title, "Test")
            .Add(p => p.Items, items));

        var header = cut.Find(".cursor-pointer");

        // Act - Expandir
        header.Click();
        var contentExpanded = cut.FindAll(".accordion-root");
        Assert.NotEmpty(contentExpanded);

        // Act - Colapsar
        header.Click();
        var contentCollapsed = cut.FindAll(".accordion-root");

        // Assert
        Assert.Empty(contentCollapsed);
    }

    [Fact]
    public void ContractSummaryAccordion_RenderizaCorrectamente_LosItems()
    {
        // Arrange
        var expectedItems = new List<ContractSummaryItem>
        {
            new() { Label = "Contract Type", Value = "Existing Client – New Business" },
            new() { Label = "Commodity", Value = "Power" },
            new() { Label = "Country", Value = "France", Icon = "icons/FR.svg" },
            new() { Label = "Signature Date", Value = "26/04/2023" },
            new() { Label = "Period", Value = "01/01/2023 – 31/12/2027" }
        };

        // Act
        var cut = RenderComponent<Accordion>(parameters => parameters
            .Add(p => p.Title, "Overview")
            .Add(p => p.Items, expectedItems));

        // Expandir el accordion
        var header = cut.Find(".cursor-pointer");
        header.Click();

        // Assert - Verificar que el título se renderiza
        var title = cut.Find(".h-subsection-title");
        Assert.Equal("Overview", title.TextContent);

        // Assert - Verificar que todos los items se renderizan
        var labels = cut.FindAll(".accordion-text-bold");
        Assert.Equal(5, labels.Count);

        // Verificar labels específicos
        Assert.Contains(labels, l => l.TextContent.Contains("Contract Type"));
        Assert.Contains(labels, l => l.TextContent.Contains("Commodity"));
        Assert.Contains(labels, l => l.TextContent.Contains("Country"));

        // Verificar valores
        var values = cut.FindAll(".accordion-text-regular");
        Assert.Equal(5, values.Count);

        // Verificar que el item con icono se renderiza con imagen
        var images = cut.FindAll("img[src='icons/FR.svg']");
        Assert.Single(images);
    }

    [Fact]
    public void Accordion_MuestraIconoChevron_ConClaseCorrecta()
    {
        // Arrange
        var items = new List<ContractSummaryItem>
        {
            new() { Label = "Test", Value = "Value" }
        };

        var cut = RenderComponent<Accordion>(parameters => parameters
            .Add(p => p.Title, "Test")
            .Add(p => p.Items, items));

        // Assert - Inicialmente colapsado
        var chevronCollapsed = cut.Find(".chevron-icon");
        Assert.Contains("collapsed", chevronCollapsed.ClassList);

        // Act - Expandir
        var header = cut.Find(".cursor-pointer");
        header.Click();

        // Assert - Ahora expandido
        var chevronExpanded = cut.Find(".chevron-icon");
        Assert.Contains("expanded", chevronExpanded.ClassList);
    }

    [Fact]
    public void Accordion_TieneAtributosDeAccesibilidad()
    {
        // Arrange
        var items = new List<ContractSummaryItem>
        {
            new() { Label = "Test", Value = "Value" }
        };

        var cut = RenderComponent<Accordion>(parameters => parameters
            .Add(p => p.Title, "Test")
            .Add(p => p.Items, items));

        // Assert - Verificar que el botón tiene aria-label
        var button = cut.Find("button[aria-label='Toggle accordion']");
        Assert.NotNull(button);

        // Verificar que tiene aria-controls
        var ariaControls = button.GetAttribute("aria-controls");
        Assert.Equal("accordion-content", ariaControls);
    }
}
