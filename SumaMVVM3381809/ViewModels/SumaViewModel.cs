using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SumaMVVM3381809.ViewModels
{
    public class SumaViewModel : INotifyPropertyChanged
    {
        private string? _numero1;
        private string? _numero2;
        private string? _resultado;

        public string Numero1
        {
            get => _numero1;
            set
            {
                _numero1 = value;
                OnPropertyChanged();
                CalculateSuma();
            }
        }

        public string Numero2
        {
            get => _numero2;
            set
            {
                _numero2 = value;
                OnPropertyChanged();
                CalculateSuma();
            }
        }

        public string Resultado
        {
            get => _resultado;
            private set
            {
                _resultado = value;
                OnPropertyChanged();
            }
        }

        private void CalculateSuma()
        {
            if (double.TryParse(Numero1, out var num1) && double.TryParse(Numero2, out var num2))
            {
                Resultado = (num1 + num2).ToString();
            }
            else
            {
                Resultado = "Por favor ingrese números válidos.";
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
