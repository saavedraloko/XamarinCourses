using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FirstTest
{
    public class App : Application
    {
        public App()
        {
            Button btn = new Button();
            btn.Text = "Soy un Botón";
            btn.Clicked += (sender, args) =>
            {
                btn.Text = "Me presionaste, wy";
            };
            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Primer Proyecto Xamarin!"
                        },
                        btn 
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
