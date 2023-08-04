using Application.Placas.Common;
using ErrorOr;
using MediatR;

namespace Application.Placas.GetByDNI
{
    public record GetByDNICommand(string dni) : IRequest<ErrorOr<IReadOnlyList<PlacasResponseValues>>>;
}
