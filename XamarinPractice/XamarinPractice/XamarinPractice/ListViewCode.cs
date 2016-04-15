using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace XamarinPractice
{
    public class ListViewCode : ContentPage
    {
        public ListViewCode ()
        {
            var lstView = new ListView();
            lstView.Header = "Dias de la Semana";
            lstView.ItemsSource = new List<String> () { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
            Content = lstView;
        }

    }
}
