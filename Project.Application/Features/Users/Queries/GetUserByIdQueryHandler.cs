using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Project.Core.Abstractions;
using Project.Core.Entities;
using Project.Core.Errors;

namespace Project.Application.Features.Users.Queries;

public class GetUserByIdQueryHandler( 
    IUnitOfWork _unitOfWork,
    UserManager<User> _userManager) : IRequestHandler<GetUserByIdQuery, User>
{
    public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _unitOfWork.User.GetSingleByConditionAsync(x => x.Id == request.Id);
       
        
        return user;
    }
}

