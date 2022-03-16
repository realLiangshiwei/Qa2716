using System;
using System.Collections.Generic;
using System.Text;
using Qa.Localization;
using Volo.Abp.Application.Services;

namespace Qa;

/* Inherit your application services from this class.
 */
public abstract class QaAppService : ApplicationService
{
    protected QaAppService()
    {
        LocalizationResource = typeof(QaResource);
    }
}

