namespace BlazorApp6.Tests;

using BlazorApp6.Pages;
using Bunit;

public class CounterTests
{
    private TestContext _testContext;

    [SetUp]
    public void SetUp()
    {
        _testContext = new TestContext();
    }

    [TearDown]
    public void TearDown()
    {
        _testContext.Dispose();
    }

    [Test]
    public void Render_NoExceptions()
    {
        _testContext.RenderComponent<Counter>();
    }
}