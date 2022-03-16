using System;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.Options;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.Conventions;
using Volo.Abp.DependencyInjection;

namespace Qa;

[ExposeServices(typeof(AbpServiceConvention), typeof(IAbpServiceConvention))]
public class MyAbpServiceConvention : AbpServiceConvention
{
    public static bool ChangeControllerModelApiExplorerGroupName = true;
    
    public MyAbpServiceConvention(IOptions<AbpAspNetCoreMvcOptions> options, IConventionalRouteBuilder conventionalRouteBuilder) : base(options, conventionalRouteBuilder)
    {
    }
    
    protected override void ConfigureApiExplorer(ControllerModel controller)
    {
        if (ChangeControllerModelApiExplorerGroupName && controller.ApiExplorer.GroupName.IsNullOrEmpty())
        {
            controller.ApiExplorer.GroupName = controller.ControllerName;
        }

        if (controller.ApiExplorer.IsVisible == null)
        {
            controller.ApiExplorer.IsVisible = IsVisibleRemoteService(controller.ControllerType);
        }

        foreach (var action in controller.Actions)
        {
            ConfigureApiExplorer(action);
        }
    }

   
}
