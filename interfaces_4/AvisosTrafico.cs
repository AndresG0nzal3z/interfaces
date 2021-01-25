using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces_4
{
    class AvisosTrafico : IAvisos
    {
        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje = "Sancion cometida. Pague antes de 3 dias y " +
                "se beneficiara de una reduccion en la sansion del 50%";
            fecha = "12/7/2020";
        }
        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
        public string GetFecha()
        {
            return fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine("Mensaje: {0} ha sido enviado por {1} el dia {2}", mensaje, remitente, fecha);
        }
        private string remitente;
        private string mensaje;
        private string fecha;
    }
}