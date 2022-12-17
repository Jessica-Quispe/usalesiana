using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using usalesiana.Modelo;

namespace usalesiana.Datos
{
    public class Dcategorias
    {
        public ObservableCollection<MCategorias> Mostrarcategorias()
        {
            return new ObservableCollection<MCategorias>()
            {
             new MCategorias()
             {
              categoria="Informacion",
              icono="https://i.ibb.co/kQ3Wg64/transparencia.png",
              Textcolor="#0E56B9",
              Color1="#ffffff",
              Color2="#ffffff",
              Select=false
             },
             new MCategorias()
             {
              categoria="Chatbot",
              icono="https://i.ibb.co/7tLVKKW/consultor.png",
              Textcolor="#0E56B9",
              Color1="#ffffff",
              Color2="#ffffff",
              Select=false
             },
             new MCategorias()
             {
              categoria="Instalaciones",
              icono="https://i.ibb.co/JB70Kb4/universidad.png",
              Textcolor="#0E56B9",
              Color1="#ffffff",
              Color2="#ffffff",
              Select=false
             },
             new MCategorias()
             {
              categoria="Geolocalizacion",
              icono="https://i.ibb.co/xsJzbPW/ubicacion.png",
              Textcolor="#0E56B9",
              Color1="#ffffff",
              Color2="#ffffff",
              Select=false
             }
            };
        }
    }
}
