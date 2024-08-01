var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<MySingletonService>();
builder.Services.AddScoped<MyScopedService>();

var host = builder.Build();

host.Services.GetRequiredService<MySingletonService>();

host.Run();

public class MySingletonService
{
    public MySingletonService(MyScopedService scoped)
    {
        Console.WriteLine("Hello, world!");
    }
}

public class MyScopedService;