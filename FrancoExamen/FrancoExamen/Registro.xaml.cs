using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FrancoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        double totalCurso = 1800;
        public Registro(string usuarioConectado)
        {
            InitializeComponent();
            txtUsuarioConecteado.Text = usuarioConectado;
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {

                double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
                double diferencial = totalCurso - montoInicial;
                double cuotaDiferida = 0;

                if (montoInicial > 0 && montoInicial <= totalCurso)
                {
                    if (diferencial != 0)
                    {
                        cuotaDiferida = (diferencial / 3) + (totalCurso * 0.05);
                        cuotaDiferida = Math.Round(cuotaDiferida,2);
                    }
                }

                else
                {
                    throw new Exception($"El monto inicial no es vàlido");
                }

                txtPagoMensual.Text = $"Cuotas(3): $ {cuotaDiferida}";
                await DisplayAlert("Operacìòn exitòsa", "Elemento guardado con exito", "Ok");
                await Navigation.PushAsync(new Resumen(txtUsuarioConecteado.Text,txtUser.Text, cuotaDiferida * 3));
            }
            catch(Exception ex)
            {
                await DisplayAlert("No se pudo realizar la operaciòn", ex.Message, "Ok");
            }
        }
    }
}