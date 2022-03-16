using System.Threading.Tasks;

namespace Qa.Data;

public interface IQaDbSchemaMigrator
{
    Task MigrateAsync();
}
