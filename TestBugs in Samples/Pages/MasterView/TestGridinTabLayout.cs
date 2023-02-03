using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_in_Samples.Pages.MasterView;
using Bugs_in_Samples.Northwind;

namespace TestBugs_in_Samples
{
	public class TestGridinTabLayout
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbGridModule),
				typeof(IgniteUI.Blazor.Controls.IgbTabsModule),
				typeof(IgniteUI.Blazor.Controls.IgbGridModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new NorthwindService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<GridinTabLayout>();
			Assert.NotNull(componentUnderTest);
		}
	}
}