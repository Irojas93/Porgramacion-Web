using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;
using System.Data;

namespace Negocio
{
    public class TurnoNego
    {
        TurnoDom turnoDom = new TurnoDom();
        TurnoRepo turnoRepo = new TurnoRepo();

        public void GuardarTurno(TurnoDom turnoDom)
        {
            turnoRepo.GuardarCliente(turnoDom);
        }

        public void ModificarTurno(int turnoId, TurnoDom turnoDom)
        {
            turnoRepo.ModificarTurno(turnoId, turnoDom);
        }

        public DataTable RecuperarTurno(int turnoId)
        {
            return turnoRepo.RecuperarTurno(turnoId);
        }

        public DataTable ListaTurnos()
        {
            return turnoRepo.listTurnos();
        }
    }
}
