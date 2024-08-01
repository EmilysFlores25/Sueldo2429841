using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo2429841.ViewsModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _SueldoActual;
        [ObservableProperty]
        private string? _R;
        [ObservableProperty]
        private string? _NSueldo;

        [RelayCommand]
        public void Aumento()
        {
            double aumento;
            if (SueldoActual < 1000)
            {
                aumento = SueldoActual * 0.15;
            }
            else
            {
                aumento = SueldoActual * 0.12;
            }
            double nuevoSueldo = SueldoActual + aumento;
            NSueldo = $"El sueldo final es: ${nuevoSueldo:F2}";
            R = NSueldo.ToString();
        }
    }
}
