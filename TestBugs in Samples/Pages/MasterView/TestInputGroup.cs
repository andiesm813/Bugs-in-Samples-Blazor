using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_in_Samples.Pages.MasterView;

namespace TestBugs_in_Samples
{
	public class TestInputGroup
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbInputModule));
			var componentUnderTest = ctx.RenderComponent<InputGroup>();
			Assert.NotNull(componentUnderTest);
		}
	}
}