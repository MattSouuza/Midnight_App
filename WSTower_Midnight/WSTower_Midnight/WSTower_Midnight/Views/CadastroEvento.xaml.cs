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
    public partial class CadastroEvento : ContentPage
    {
        public CadastroEvento()
        {
            InitializeComponent();
        }

        private async void ButtonClicked_Concluido(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtNomeEvento.Text))
                {
                    await DisplayAlert("ATENÇÃO", "Informe o Nome do evento", "OK");
                    return;
                }
                if (string.IsNullOrEmpty(txtDescricao.Text))
                {
                    await DisplayAlert("ATENÇÃO", "Informe a descrição do evento", "OK");
                    return;
                }
                if (string.IsNullOrEmpty(txtLocal.Text))
                {
                    await DisplayAlert("ATENÇÃO", "Informe o local do evento", "OK");
                    return;
                }
                if (string.IsNullOrEmpty(txtData.Text))
                {
                    await DisplayAlert("ATENÇÃO", "Informe a data do evento", "OK");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtDescricao.Text))
                {
                    if (txtDescricao.Text.Length >= 5)
                    {
                        await App.Database1.SaveEventoAsync(new Evento
                        {
                            Nome = txtNomeEvento.Text,
                            Descricao = txtDescricao.Text,
                            Local = txtLocal.Text,
                            Data = txtData.Text
                        });

                        txtNomeEvento.Text = txtDescricao.Text = txtLocal.Text = txtData.Text = string.Empty;

                        await DisplayAlert("SUCESSO", "O Evento foi cadastrado com sucesso.", "OK");
                    }
                    else
                    {
                        await DisplayAlert("ATENÇÃO", "O evento deve possuir uma descricao maior que 10 caracteres.", "OK");
                    }

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