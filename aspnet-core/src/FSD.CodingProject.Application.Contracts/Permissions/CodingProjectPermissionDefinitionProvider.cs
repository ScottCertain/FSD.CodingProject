using FSD.CodingProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FSD.CodingProject.Permissions;

public class CodingProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CodingProjectPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CodingProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CodingProjectResource>(name);
    }
}
