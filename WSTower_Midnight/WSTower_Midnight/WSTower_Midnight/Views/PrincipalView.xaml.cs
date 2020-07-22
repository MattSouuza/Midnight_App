using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSTower_Midnight.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTower_Midnight.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalView : ContentPage
    {
        //PrincipalViewModel _vm;
        public PrincipalView()
        {
            InitializeComponent();
           // BindingContext = _vm = new PrincipalViewModel();
        }

        //private void Handle_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        //{
        //    Debug.WriteLine("Posição " + e.NewValue + " Selecionada.");
        //}

        //private void Handle_Scrolled(object sender, CarouselView.FormsPlugin.Abstractions.ScrolledEventArgs e)
        //{
        //    Debug.WriteLine("Rolada para " + e.NewValue + " por cento.");
        //    Debug.WriteLine("Direção = " + e.Direction);
        //}

        private void ButtonClicked_Sobre(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SobreNosView());
        }

        private void ButtonClicked_Evento(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventoView());
        }
    }
}