using FSD.CodingProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FSD.CodingProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CodingProjectController : AbpControllerBase
{
    protected CodingProjectController()
    {
        LocalizationResource = typeof(CodingProjectResource);
    }
}
