using API.Entities;
using API.Repositories;
using API.Resources;
using AutoMapper;
using ErrorOr;
using MediatR;

namespace API.Handlers.Queries
{
    public class GetUserByIdQuery : IRequest<ErrorOr<UserResource>>
    {
        public int Id { get; }
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }

        public class GetPersonByIdQueryHandler : IRequestHandler<GetUserByIdQuery, ErrorOr<UserResource>>
        {
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;

            public GetPersonByIdQueryHandler(IUnitOfWork uow, IMapper mapper)
            {
                _uow = uow;
                _mapper = mapper;
            }

            public async Task<ErrorOr<UserResource>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
            {
                var user = await _uow.Repository().GetById<User>(request.Id);
                if (user is null)
                    return Error.NotFound(code: "User not found", description: "Please enter the existing User Id");

                return _mapper.Map<UserResource>(user);
            }
        }
    }
}