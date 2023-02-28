using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_in_Samples.Pages;

namespace TestBugs_in_Samples
{
	public class TestTextLinks
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<TextLinks>();
			Assert.NotNull(componentUnderTest);
		}
	}
}