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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuarioConectado,string usuario , double totalPagar)
        {
            InitializeComponent();
            txtUsuarioConectado.Text = usuarioConectado;
            txtUsuario.Text = usuario;
            txtTotalPagar.Text = $"Total a pagar {totalPagar}";
        }
    }
}