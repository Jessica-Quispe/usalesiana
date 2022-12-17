using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using usalesiana.Modelo;
using static System.Net.WebRequestMethods;

namespace usalesiana.Datos
{
    public class Dmodulos
    {
        public ObservableCollection<Mmodulos> Listarmodulos()
        {
            return new ObservableCollection<Mmodulos>()
            {
                new Mmodulos()
                {
                    descripcion = "Universidad Salesiana de Bolivia",
                    icono ="https://i.ibb.co/pjYJCx8/logouniversidad.jpg"
                },
                new Mmodulos()
                {
                    descripcion="Sede La Paz",
                    icono="https://i.ibb.co/CPHWcFy/Sede-La-Paz-WEB.jpg"
                },
                new Mmodulos()
                {
                    descripcion="Carreras universitarias",
                    icono="https://i.ibb.co/F76KZzq/carreras.jpg"
                },
                new Mmodulos()
                {
                    descripcion="Horarios de Clases",
                    icono="https://i.ibb.co/MZW0Xxj/calendario.jpg"
                }
            };
        }
    }
}
