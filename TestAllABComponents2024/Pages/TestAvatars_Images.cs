using Bunit;
using Microsoft.Extensions.DependencyInjection;
using AllABComponents2024.Pages;

namespace TestAllABComponents2024
{
	[Collection("AllABComponents2024")]
	public class TestAvatars_Images
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbAvatarModule),
				typeof(IgbListModule),
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule));
			var componentUnderTest = ctx.RenderComponent<Avatars_Images>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
