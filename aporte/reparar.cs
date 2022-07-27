using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte
{
    public class reparar : Observador
    {
        protected Dispositivos dispositivos;
        protected string soporte = "";

        public reparar(Dispositivos dispositivos)
        {
            this.dispositivos = dispositivos;
            dispositivos.agrega(this);
            actualizacion();
        }

        protected void actualizacion()
        {
            soporte= "Descripción " + dispositivos.descripcion +
            " orden: " + dispositivos.orden;
            _ = "modelo" + dispositivos.modelo;


        }

        public void actualiza()
        {
            actualizacion ();
            this.rehacer();
        }

        public void rehacer()
        {
            Console.WriteLine(soporte);
        }
    }
}