using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnenviarinformacion_Clicked(object sender, EventArgs e)
        {


            var Rsul = new Class1
            { 
                nombre = txtnombre.Text,
                apellidos = txtapellidos.Text,
                edad = txtedad.Text,
                correo = txtcorreo.Text,

            };

            var scondpnge = new Page2Resultado();
            scondpnge.BindingContext= Rsul;

            Navigation.PushAsync(scondpnge);


        }
               
          

     
           




        
    }

}
