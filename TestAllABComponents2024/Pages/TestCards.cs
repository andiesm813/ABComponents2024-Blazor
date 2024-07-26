using Bunit;
using Microsoft.Extensions.DependencyInjection;
using AllABComponents2024.Pages;

namespace TestAllABComponents2024
{
	[Collection("AllABComponents2024")]
	public class TestCards
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbAvatarModule));
			var componentUnderTest = ctx.RenderComponent<Cards>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
