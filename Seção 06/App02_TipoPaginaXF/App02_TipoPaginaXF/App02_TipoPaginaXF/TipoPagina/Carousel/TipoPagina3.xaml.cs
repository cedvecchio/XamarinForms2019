using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}

        private void MudarPagina(object sender, EventArgs args)
        {
            //EVENTO DO BOTÃO PARA PRIMEIRO INSTANCIAR O OBJETO NAVIGATION 
            //E DPS CHAMAR A PAGINA1 DENTRO DA PASTA NAVIGATION
            /* App.Current.MainPage = new NavigationPage(new Navigation.Pagina1())
             //PROPRIEDADES PARA ALTERAR AS FORMAS EX.CORES, ALINHAMENTOS, ETC
             { BarBackgroundColor = Color.LightBlue};*/

            App.Current.MainPage = new Tabbed.Abas();
        }
    }
}