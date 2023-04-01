using System;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Temporizador
    {
        //creo el delegado
        public delegate void TiempoFinalizadoHandler();

        //declaro el evento
        public event TiempoFinalizadoHandler OnTiempoFinalizado;

        //delegado del sistema
        public event Action<int> OnTiempoRestante;

        public void Ejecutar(int intervaloSegundos)
        {

            Task.Run(() =>
            {
                while (intervaloSegundos > -1)
                {
                    //emito un evento el signo de pregunta valida q el evento este asociado a un manejador
                    OnTiempoRestante?.Invoke(intervaloSegundos);
                    //if (OnTiempoRestante is not null)
                    //{
                    //    OnTiempoRestante.Invoke(intervaloSegundos);
                    //    es lo mismo peor se puede omitir en invoke
                    //    OnTiempoRestante(intervaloSegundos);
                    //}


                    Thread.Sleep(1000);
                    intervaloSegundos--;

                }
                //lanzo el evento
                OnTiempoFinalizado?.Invoke();
                //emitir finalizo
            });
            
        }
    }
}
