using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TurnoDom
    {
        private DateTime turnoFechaDeRegistro;
        private DateTime turnoFecha;
        private String motivo;
        private String descripcion;
        private int clienteId;

        public DateTime TurnoFechaDeRegistro
        {
            get
            {
                return turnoFechaDeRegistro;
            }

            set
            {
                turnoFechaDeRegistro = value;
            }
        }

        public DateTime TurnoFecha
        {
            get
            {
                return turnoFecha;
            }

            set
            {
                turnoFecha = value;
            }
        }

        public string Motivo
        {
            get
            {
                return motivo;
            }

            set
            {
                motivo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int ClienteId
        {
            get
            {
                return clienteId;
            }

            set
            {
                clienteId = value;
            }
        }
    }
}
