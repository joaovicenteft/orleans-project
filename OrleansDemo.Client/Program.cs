using Orleans;
using Orleans.Configuration;
using OrleansDemo.Abstractions;

var client = new ClientBuilder()
    .UseLocalhostClustering()
    .Configure<ClusterOptions>(options =>
    {
        options.ClusterId = "dev";
        options.ServiceId = "OrleansDemoApp";
    })
    .Build();

await client.Connect();

var grain = client.GetGrain<IHelloGrain>("user1");
var response = await grain.SayHello("Orleans");

Console.WriteLine(response);

await client.Close();