using Application.Common.Mapping;
using Application.Permissions.Dto;
using Domain.Entities;
using MediatR;

namespace Application.Permissions.Commands
{
    public class UpdatePermissionCommand : IRequest<PermissionDto>, IMapTo<Permission>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<int> GroupPermissionIds { get; set; } = new List<int>();

    }
}
