using Foodie.Application.Configurations;
using Foodie.Infrastructure.Configurations;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
    .RegisterInfrastructure(builder.Configuration)
    .RegisterServices();
    builder.Services.AddControllers();

}


var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
