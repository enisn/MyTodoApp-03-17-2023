using MyTodoApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace MyTodoApp;

public abstract class MyTodoAppComponentBase : AbpComponentBase
{
    protected MyTodoAppComponentBase()
    {
        LocalizationResource = typeof(MyTodoAppResource);
    }
}
