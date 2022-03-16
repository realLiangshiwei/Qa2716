using Volo.Abp.Modularity;

namespace Qa;

[DependsOn(
    typeof(QaApplicationModule),
    typeof(QaDomainTestModule)
    )]
public class QaApplicationTestModule : AbpModule
{

}
