using Bunit;
using Microsoft.Extensions.DependencyInjection;
using AllABComponents2024.Pages;
using AllABComponents2024.Financial;
using AllABComponents2024.Northwind;

namespace TestAllABComponents2024
{
	[Collection("AllABComponents2024")]
	public class TestAllComponents
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbTabsModule),
				typeof(IgbAccordionModule),
				typeof(IgbExpansionPanelModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbTreeModule),
				typeof(IgbSliderModule),
				typeof(IgbRangeSliderModule),
				typeof(IgbStepperModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbInputModule),
				typeof(IgbButtonGroupModule),
				typeof(IgbToggleButtonModule),
				typeof(IgbBadgeModule),
				typeof(IgbCheckboxModule),
				typeof(IgbRadioGroupModule),
				typeof(IgbRadioModule),
				typeof(IgbSwitchModule),
				typeof(IgbRatingModule),
				typeof(IgbDatePickerModule),
				typeof(IgbTextareaModule),
				typeof(IgbSelectModule),
				typeof(IgbComboModule),
				typeof(IgbCalendarModule),
				typeof(IgbCategoryChartModule),
				typeof(IgbGridModule),
				typeof(IgbSnackbarModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<AllComponents>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
