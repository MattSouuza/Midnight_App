using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTower_Midnight.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroView : ContentPage
    {
        public CadastroView()
        {
            InitializeComponent();
        }

        private void ButtonClicked_Concluido(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrincipalView());
        }

        private void ButtonClicked_Voltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}