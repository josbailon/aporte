using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte
{
    public abstract class Sujeto
    {
        
        protected IList<Observador> observadores =
            new List<Observador>();

        public void agrega(Observador observador)
        {
            observadores.Add(observador);
        }

        public void suprimir(Observador observador)
        {
            observadores.Remove(observador);
        }

        public void notificar()
        {
            foreach (Observador observador in observadores)
                observador.actualiza();
        }
    }
}