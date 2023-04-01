using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ejm9
{
    public class GestorDatos
    {
        public static string TaerRegistros()
        {
            Thread.Sleep(10000);
            return "La cantidad de registros es 2000";
        }

        //devuvel un taskgenerica con un valor en este caso un string
        public static async Task<string> TraerRegistros2(CancellationToken cancelToken)
        {
            //await esta siendo esperado por otro metodo sin colgar el hilo q lo llamo
            //espera un valor q devuelve este metodo
            string informacion = await Task.Run(async() =>
            {
                //igual al thread.slepp pero hace que el metodo sea async
                await Task.Delay(3000);
                if (cancelToken.IsCancellationRequested)
                {
                    throw new TaskCanceledException("Proceso cancelado por el usuario");
                }
                await Task.Delay(3000);
                return "La cantidad de registros es 2000";
            });

            return informacion;
        }
    }
}
