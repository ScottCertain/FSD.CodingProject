using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace FSD.CodingProject;

[Dependency(ReplaceServices = true)]
public class CodingProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CodingProject";
}
