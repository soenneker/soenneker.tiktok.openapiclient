using Soenneker.Tests.HostedUnit;

namespace Soenneker.TikTok.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class TikTokOpenApiClientTests : HostedUnitTest
{
    public TikTokOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
