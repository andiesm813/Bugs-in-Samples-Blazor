using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_in_Samples.Shared;

namespace TestBugs_in_Samples
{
	public class TestMasterView2
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownHeaderModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownHeaderModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule),
				typeof(IgniteUI.Blazor.Controls.IgbNavDrawerModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<MasterView2>();
			Assert.NotNull(componentUnderTest);
		}
	}
}