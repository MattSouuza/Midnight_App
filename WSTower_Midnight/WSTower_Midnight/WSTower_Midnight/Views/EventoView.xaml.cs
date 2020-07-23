using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSTower_Midnight.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTower_Midnight.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventoView : ContentPage
    {
        //Evento evento = new Evento();
        public EventoView()
        {
            InitializeComponent();

            //evento.Imagem = "barada2.jpg";
        }

        protected override async void OnAppearing()
        {   
            base.OnAppearing();
            listViewEvento.ItemsSource = await App.Database1.GetEventoAsync();
        }
    }
}