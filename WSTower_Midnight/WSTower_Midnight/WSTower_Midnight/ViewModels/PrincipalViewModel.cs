using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace WSTower_Midnight.ViewModels
{
    public class PrincipalViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Command PositionCommand { protected set; get; }

        ObservableCollection<View> _views;
        public ObservableCollection<View> Views
        {
            set
            {
                _views = value;
                OnPropertyChanged("Views");
            }
            get
            {
                return _views;
            }
        }
        public PrincipalViewModel()
        {
            Views = new ObservableCollection<View>()
            {
                new  Image() { Source = "barada.png", Aspect = Aspect.AspectFit, TranslationY = -160 },
                new  Image() { Source = "barada2.jpg", Aspect = Aspect.AspectFit, TranslationY = -160 },
                new  Image() { Source = "barada3.jpg", Aspect = Aspect.AspectFit, TranslationY = -160 },
                new  Image() { Source = "barada4.jpg", Aspect = Aspect.AspectFit, TranslationY = -160 }
            };
            PositionCommand = new Command(() =>
            {
                Debug.WriteLine("Posição selecionada.");
            });
        }
    }
}
