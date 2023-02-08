using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_in_Samples.Pages;

namespace TestBugs_in_Samples
{
	public class TestChips
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbChipModule),
				typeof(IgniteUI.Blazor.Controls.IgbChipModule),
				typeof(IgniteUI.Blazor.Controls.IgbChipModule),
				typeof(IgniteUI.Blazor.Controls.IgbChipModule),
				typeof(IgniteUI.Blazor.Controls.IgbChipModule),
				typeof(IgniteUI.Blazor.Controls.IgbChipModule),
				typeof(IgniteUI.Blazor.Controls.IgbChipModule),
				typeof(IgniteUI.Blazor.Controls.IgbChipModule));
			var componentUnderTest = ctx.RenderComponent<Chips>();
			Assert.NotNull(componentUnderTest);
		}
	}
}