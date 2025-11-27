using BlazorApp.Models;

namespace BlazorApp.Services;

public interface IContractService
{
    /// <summary>
    /// Gets the overview data for a contract
    /// </summary>
    Task<ContractOverview> GetContractOverviewAsync(string contractId);

    /// <summary>
    /// Gets all contract overviews
    /// </summary>
    Task<List<ContractOverview>> GetAllContractOverviewsAsync();

    /// <summary>
    /// Creates sample/mock data for development
    /// </summary>
    List<ContractOverview> GetMockContractOverviews();
}
