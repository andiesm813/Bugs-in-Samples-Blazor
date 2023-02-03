using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_in_Samples.Pages.MasterView;

namespace TestBugs_in_Samples
{
	public class TestFloatingActionButton
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<FloatingActionButton>();
			Assert.NotNull(componentUnderTest);
		}
	}
}