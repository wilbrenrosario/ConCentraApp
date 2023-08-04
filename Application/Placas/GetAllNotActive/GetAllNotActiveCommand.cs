using Application.Placas.Common;
using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Placas.GetAllNotActive
{
    public record GetAllNotActiveCommand(bool active) : IRequest<ErrorOr<IReadOnlyList<PlacasResponseValues>>>;
}
