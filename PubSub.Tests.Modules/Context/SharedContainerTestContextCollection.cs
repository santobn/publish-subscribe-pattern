using Xunit;

namespace PubSub.Tests.Modules.Context
{
    [CollectionDefinition("SharedContainerTestContextCollection")]
    public class SharedTestContextCollection : ICollectionFixture<SharedContainerTestContext>
    {
    }
}
