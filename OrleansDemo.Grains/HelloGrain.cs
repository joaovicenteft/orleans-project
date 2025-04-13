using OrleansDemo.Abstractions;
using Orleans;
using System.Threading.Tasks;

namespace OrleansDemo.Grains;

public class HelloGrain : Grain, IHelloGrain
{
    public Task<string> SayHello(string name)
    {
        return Task.FromResult($"Hello, {name} from grain!");
    }
}