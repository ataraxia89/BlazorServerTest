using System;
using System.Threading.Tasks;
using BlazorServerTest.App.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace BlazorServerTest.App.Pages
{
    public class FetchDataBase : ComponentBase
    {
        [Inject]
        public WeatherForecastService ForecastService { get; set; }

        [BindProperty]
        public WeatherForecast[] forecasts { get; set; }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
