
using OrleansDemo;
using System.Threading.Tasks;

namespace OrleansDemo.Abstractions;
public interface IHelloGrain : IGrainWithStringKey
{
    Task<string> SayHello(string name);
}
