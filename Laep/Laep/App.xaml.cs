﻿using Laep.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Laep
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            #if DEBUG
                HotReloader.Current.Start(this);
            #endif

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            DataResultadosDimensionamentos.CriarBdResultados();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
