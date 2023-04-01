using System;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Temporizador
    {
        
        //declaro un delegado
        public delegate void TiempoFinalizadoHandler();

        //declaro el evento
        public event TiempoFinalizadoHandler OnTiempoFinalizado;
        //usando un delegado del sistema q no resive nad y devuelve lo que tengo entre parentesis
        public event Action<int> OnTiempoRestante;
        
        public void Ejecutar(int intervaloSegundos)
        {
            Task.Run(() =>
            {
                while (intervaloSegundos >= 0)
                {
                    if (OnTiempoRestante is not null)
                        OnTiempoRestante.Invoke(intervaloSegundos);
                    //  o  OnTiempoRestante?.Invoke(intervaloSegundos);
                    //emito un evento
                    Thread.Sleep(1000);
                    intervaloSegundos--;
                }
                if(OnTiempoFinalizado is not null)
                    OnTiempoFinalizado.Invoke();
                //emitir evento finalizo

            });
        }
    }

}
