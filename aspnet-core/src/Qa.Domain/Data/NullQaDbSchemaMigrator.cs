using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Qa.Data;

/* This is used if database provider does't define
 * IQaDbSchemaMigrator implementation.
 */
public class NullQaDbSchemaMigrator : IQaDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
