using Bunit;
using Microsoft.Extensions.DependencyInjection;
using AllABComponents2024.Pages;

namespace TestAllABComponents2024
{
	[Collection("AllABComponents2024")]
	public class TestRadiogroup
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbRadioGroupModule),
				typeof(IgbRadioModule));
			var componentUnderTest = ctx.RenderComponent<Radiogroup>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
