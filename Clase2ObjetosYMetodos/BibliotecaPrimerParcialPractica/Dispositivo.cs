using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPrimerParcialPractica
{
    public enum SistemaOperativo
    {
        ANDROID, IOS
    };
    public static class Dispositivo
    {
        private static List<Aplicacion> appInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            sistemaOperativo = SistemaOperativo.ANDROID;
            appInstaladas = new List<Aplicacion>();
        }

        public static bool InstalarApp(Aplicacion app)
        {
            bool ret = false;
            if (app.GetSistemaOperativo == SistemaOperativo.ANDROID)
            {
                if(appInstaladas + app)
                    ret = true;
            }

            return ret;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Datos del dispositivo:\n\n");
            stringBuilder.AppendFormat($"Sistema Operativo: {sistemaOperativo}\n");
            stringBuilder.AppendFormat($"App Instaladas:\n");
            foreach (Aplicacion item in appInstaladas)
            { 
                stringBuilder.AppendLine(item.ObtenerInformacionApp());
            }

            return stringBuilder.ToString();
        }
    }

   
}
