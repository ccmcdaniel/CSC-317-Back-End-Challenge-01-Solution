using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace CSC_317_Back_End_Challenge_01_Solution
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}