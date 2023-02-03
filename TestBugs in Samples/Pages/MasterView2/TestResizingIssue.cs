using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_in_Samples.Pages.MasterView2;

namespace TestBugs_in_Samples
{
	public class TestResizingIssue
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbBadgeModule),
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbCalendarModule),
				typeof(IgniteUI.Blazor.Controls.IgbListModule));
			var componentUnderTest = ctx.RenderComponent<ResizingIssue>();
			Assert.NotNull(componentUnderTest);
		}
	}
}