using Bunit;
using Microsoft.Extensions.DependencyInjection;
using AllABComponents2024.Pages;
using AllABComponents2024.Financial;

namespace TestAllABComponents2024
{
	[Collection("AllABComponents2024")]
	public class TestForms
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbInputModule),
				typeof(IgbDatePickerModule),
				typeof(IgbTextareaModule),
				typeof(IgbSelectModule),
				typeof(IgbComboModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<Forms>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
