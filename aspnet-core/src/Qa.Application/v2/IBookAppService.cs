using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Qa.v2;

public interface IBookAppService: IApplicationService
{
    Task<string> GetAsync();
}

public class BookAppService : ApplicationService , IBookAppService
{
    public Task<string> GetAsync()
    {
        return Task.FromResult("2.0");
    }
}
