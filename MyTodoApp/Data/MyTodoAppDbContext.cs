using MongoDB.Driver;
using MyTodoApp.Entities;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace MyTodoApp.Data;

[ConnectionStringName("Default")]
public class MyTodoAppDbContext : AbpMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */
    public IMongoCollection<TodoItem> TodoItems => Collection<TodoItem>();

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //builder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}
