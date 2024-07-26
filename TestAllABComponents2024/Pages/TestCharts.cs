using Bunit;
using Microsoft.Extensions.DependencyInjection;
using AllABComponents2024.Pages;
using AllABComponents2024.DashboardData;

namespace TestAllABComponents2024
{
	[Collection("AllABComponents2024")]
	public class TestCharts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCategoryChartModule));
			ctx.Services.AddScoped<IDashboardDataService>(sp => new MockDashboardDataService());
			var componentUnderTest = ctx.RenderComponent<Charts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
