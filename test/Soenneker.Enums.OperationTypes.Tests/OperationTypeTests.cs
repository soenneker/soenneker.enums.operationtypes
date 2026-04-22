using Soenneker.Tests.HostedUnit;

namespace Soenneker.Enums.OperationTypes.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class OperationTypeTests : HostedUnitTest
{
    public OperationTypeTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
