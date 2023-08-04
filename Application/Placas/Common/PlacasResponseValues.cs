using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Placas.Common
{
    public record PlacasResponseValues(
        Guid Id,
        string Nombres,
        string Apellidos,
        string Cedula,
        string FechaNacimiento,
        string TipoPlaca,
        string TipoPersonas,
        string TipoAutomovil,
        double ValorTotalPlaca,
        string NumeroPlaca,
        bool Active);

}
