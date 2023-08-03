using Application.Placas.Common;
using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Placas.GetAll
{
    public record GetPlacasCommand() : IRequest<ErrorOr<IReadOnlyList<PlacasResponse>>>;
}
