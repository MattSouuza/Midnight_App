﻿using System;
using System.IO;
using WSTower_Midnight.Repository;
using WSTower_Midnight.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTower_Midnight
{
    public partial class App : Application
    {
        static UsuarioRepository database;
        public static UsuarioRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new UsuarioRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
