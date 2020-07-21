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
    public partial class CadastroView : ContentPage
    {
        public CadastroView()
        {
            InitializeComponent();
        }

        private async void ButtonClicked_Concluido(object sender, EventArgs e)
        {
            try
            {
                var gravaSenha = SalvarSenha.IsToggled;

                if (gravaSenha)
                {
                    if (string.IsNullOrEmpty(txtSenha.Text))
                    {
                        await DisplayAlert("ATENÇÃO", "Informe a senha", "OK");
                        return;
                    }
                }

                if(string.IsNullOrEmpty(txtNome.Text))
                {
                    await DisplayAlert("ATENÇÃO", "Informe o Nome", "OK");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    if (txtUsuario.Text.Length >= 5)
                    {
                        await App.Database.SaveUsuarioAsync(new Usuario
                        {
                            Nome = txtNome.Text,
                            Email = txtUsuario.Text,
                            Senha = gravaSenha ? txtSenha.Text : "",
                        });
                       
                        txtUsuario.Text = txtSenha.Text = string.Empty;

                        await DisplayAlert("SUCESSO", "O usuário foi cadastrado com sucesso.", "OK");
                    }
                    else
                    {
                        await DisplayAlert("ATENÇÃO", "O nome do usuário deve possuir mais de 4 caracteres.", "OK");
                    }

                }
                else
                {
                    await DisplayAlert("ATENÇÃO", "Informe o Email do usuário.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO", "Ocorreu um erro desconhecido.", "OK");
            }
        }

        private void ButtonClicked_Voltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}