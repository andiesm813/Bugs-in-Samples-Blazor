using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_in_Samples.Pages;

namespace TestBugs_in_Samples
{
	public class TestDialog
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbBadgeModule));
			var componentUnderTest = ctx.RenderComponent<Dialog>();
			Assert.NotNull(componentUnderTest);
		}
	}
}