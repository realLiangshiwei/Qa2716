using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Qa;

[Dependency(ReplaceServices = true)]
public class QaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Qa";
}
