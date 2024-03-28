﻿using EmployeeApp.ViewModels;
using EmployeeApp.Views;
using Microsoft.Extensions.Logging;

namespace EmployeeApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            //Views
            builder.Services.AddSingleton<EmployeesList>();

            //ViewModels
            builder.Services.AddSingleton<EmployeesViewModel>();
            return builder.Build();
        }
    }
}
