using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using usalesiana.Modelo;
using Xamarin.Forms;


namespace usalesiana.VistaModelo
{
    class VMDetalle:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public Mmodulos ParametrosRecibe { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMDetalle(INavigation navigation, Mmodulos ParametrosTrae)
        {
            Navigation = navigation;
            ParametrosRecibe = ParametrosTrae;
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS

        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
