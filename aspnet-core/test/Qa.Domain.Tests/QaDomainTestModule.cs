using Qa.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Qa;

[DependsOn(
    typeof(QaEntityFrameworkCoreTestModule)
    )]
public class QaDomainTestModule : AbpModule
{

}
