using Bunit;
using Microsoft.Extensions.DependencyInjection;
using AllABComponents2024.Pages;

namespace TestAllABComponents2024
{
	[Collection("AllABComponents2024")]
	public class TestMouse_Events
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbListModule));
			var componentUnderTest = ctx.RenderComponent<Mouse_Events>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
