var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var registrationService = builder.AddProject<Projects.Registration>("registrationservice");



builder.Build().Run();
