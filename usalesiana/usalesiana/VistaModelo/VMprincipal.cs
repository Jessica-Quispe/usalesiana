using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using usalesiana.Modelo;
using usalesiana.Datos;
using usalesiana.vistas.Detalle;
using usalesiana.VistaModelo;
using Xamarin.Forms;
using System.Linq;
using Xamarin.Forms.Internals;

namespace usalesiana.VistaModelo
{
    public class VMprincipal:BaseViewModel
    {
        #region VARIABLES
        ObservableCollection<Mmodulos> _listamodulos;
        ObservableCollection<MCategorias> _listacategorias;
        #endregion
        #region CONSTRUCTOR
        public VMprincipal(INavigation navigation)
        {
            Navigation = navigation;
            Listarmodulos();
            Listarcategorias();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mmodulos> ListaModulos
        {
            get { return _listamodulos; }
            set { SetValue(ref _listamodulos, value); }
        }
        public ObservableCollection<MCategorias> Listacategorias
        {
            get { return _listacategorias; }
            set { SetValue(ref _listacategorias, value); }
        }
        #endregion
        #region PROCESOS
        private void Seleccionar(MCategorias parametros)
        {
            var index = Listacategorias
               .ToList()
               .FindIndex(p=>p.categoria == parametros.categoria);
            if (index > -1)
            {
                Deseleccionar();
                Listacategorias[index].Select = true;
                Listacategorias[index].Color1 = "#8664FF";
                Listacategorias[index].Color2 = "#BBA8FF";
                Listacategorias[index].Textcolor = "#ffffff";
            }
        }
        private void Deseleccionar()
        {
            Listacategorias.ForEach((item) =>
            {
                item.Select = false;
                item.Color1 = "#ffffff";
                item.Color2 = "#ffffff";
                item.Textcolor = "#2F394B";
   
            });
        }
        public void Listarmodulos()
        {
            var funcion = new Dmodulos();
            ListaModulos=funcion.Listarmodulos();
        }
        public void Listarcategorias()
        {
            var funcion = new Dcategorias();
            Listacategorias = funcion.Mostrarcategorias();
        }

        private async void SeleccionarModulo(Mmodulos parametros)
        {
            await Navigation.PushAsync(new Detalleproduc(parametros));
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Seleccionarcommand => new Command<MCategorias>(Seleccionar);

        public ICommand SeleccionarmoduloCommand => new Command<Mmodulos>(SeleccionarModulo);
        #endregion
    }
}
