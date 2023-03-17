using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MyTodoApp;

[Dependency(ReplaceServices = true)]
public class MyTodoAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MyTodoApp";
}
