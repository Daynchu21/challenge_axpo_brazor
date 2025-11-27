using BlazorApp.Constants;
using BlazorApp.Models;

namespace BlazorApp.Services;

public class ContractService : IContractService
{
    private readonly HttpClient httpClient;
    private readonly ILogger<ContractService> logger;

    public ContractService(HttpClient httpClient, ILogger<ContractService> logger)
    {
        this.httpClient = httpClient;
        this.logger = logger;
    }

    public async Task<ContractOverview> GetContractOverviewAsync(string contractId)
    {
        try
        {
            // TODO: Replace with actual API call
            // var response = await httpClient.GetFromJsonAsync<ContractOverview>($"/api/contracts/{contractId}/overview");
            await Task.Delay(100); // Simulate API delay
            return GetMockContractOverviews().FirstOrDefault() ?? new ContractOverview();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error fetching contract overview for ID: {ContractId}", contractId);
            throw;
        }
    }

    public async Task<List<ContractOverview>> GetAllContractOverviewsAsync()
    {
        try
        {
            // TODO: Replace with actual API call
            await Task.Delay(100); // Simulate API delay
            return GetMockContractOverviews();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error fetching all contract overviews");
            throw;
        }
    }

    public List<ContractOverview> GetMockContractOverviews()
    {
        return new List<ContractOverview>
        {
            new()
            {
                Title = "Overview",
                Items = new List<ContractSummaryItem>
                {
                    new() { Label = "Contract Type", Value = "Existing Client – New Business" },
                    new() { Label = "Commodity", Value = "Power" },
                    new() { Label = "Country", Value = "France", Icon = AppConstants.Icons.FranceFlag },
                    new() { Label = "Signature Date", Value = "26/04/2023" },
                    new() { Label = "Period", Value = "01/01/2023 – 31/12/2027" }
                }
            },
            new()
            {
                Title = "Overview",
                Items = new List<ContractSummaryItem>
                {
                    new() { Label = "Contract Type", Value = "Existing Client – New Business" },
                    new() { Label = "Commodity", Value = "Power" },
                    new() { Label = "Country", Value = "France", Icon = AppConstants.Icons.FranceFlag },
                    new() { Label = "Signature Date", Value = "26/04/2023" },
                    new() { Label = "Period", Value = "01/01/2023 – 31/12/2027" }
                }
            }
        };
    }
}
