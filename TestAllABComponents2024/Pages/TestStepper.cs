using Bunit;
using Microsoft.Extensions.DependencyInjection;
using AllABComponents2024.Pages;
using AllABComponents2024.Financial;

namespace TestAllABComponents2024
{
	[Collection("AllABComponents2024")]
	public class TestStepper
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbStepperModule),
				typeof(IgbInputModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbDatePickerModule),
				typeof(IgbComboModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<Stepper>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
