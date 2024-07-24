using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AllABComponents2024;
using AllABComponents2024.Financial;
using AllABComponents2024.Northwind;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IFinancialService, FinancialService>();
builder.Services.AddScoped<INorthwindService, NorthwindService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbNavDrawerItemModule),
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
        typeof(IgbCardModule),
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
        typeof(IgbSnackbarModule)
    );
}