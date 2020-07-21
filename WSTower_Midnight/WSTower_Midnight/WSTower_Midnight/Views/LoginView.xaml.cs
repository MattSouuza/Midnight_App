using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTower_Midnight.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {

        public LoginView()
        {
            InitializeComponent();
        }

        private void ButtonClicked_Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrincipalView());
        }

        private void ButtonClicked_Cadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroView());
        }

        private async void Email_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var Email = txtUsuario.Text ?? "";

                if (!string.IsNullOrEmpty(Email) && Email.Length >= 4)
                {
                    var usuarios = await App.Database.GetUsuarioAsync();

                    var usuario = usuarios.Where(p => p.Email == Email && p.Senha != "").FirstOrDefault();

                    if (usuario != null)
                    {
                        var result = await DisplayAlert("", "Encontramos uma senha salva para esse usuário, deseja usar esta senha?", "SIM", "NÃO");

                        if (result)
                        {
                            txtSenha.Text = usuario.Senha;
                            txtSenha.IsPassword = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}