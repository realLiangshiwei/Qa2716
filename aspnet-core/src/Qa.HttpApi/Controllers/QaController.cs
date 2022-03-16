using Qa.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Qa.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class QaController : AbpControllerBase
{
    protected QaController()
    {
        LocalizationResource = typeof(QaResource);
    }
}
