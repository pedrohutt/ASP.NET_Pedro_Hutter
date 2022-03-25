using WorkerService;
using Domain;
using Infraestructure;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<ITeamRepository, TeamRepositoryInMemory>();
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
