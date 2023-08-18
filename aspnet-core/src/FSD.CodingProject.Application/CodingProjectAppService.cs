using System;
using System.Collections.Generic;
using System.Text;
using FSD.CodingProject.Localization;
using Volo.Abp.Application.Services;

namespace FSD.CodingProject;

/* Inherit your application services from this class.
 */
public abstract class CodingProjectAppService : ApplicationService
{
    protected CodingProjectAppService()
    {
        LocalizationResource = typeof(CodingProjectResource);
    }
}
