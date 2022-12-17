using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usalesiana.Modelo;
using usalesiana.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace usalesiana.vistas.Detalle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detalleproduc : ContentPage
	{
		public Detalleproduc(Mmodulos parametros)
		{
			InitializeComponent ();
			BindingContext = new VMDetalle(Navigation, parametros);
		}
	}
}