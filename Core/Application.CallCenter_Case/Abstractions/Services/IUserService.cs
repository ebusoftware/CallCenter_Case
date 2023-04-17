using Application.CallCenter_Case.Dtos.User;
using Application.CallCenter_Case.Features.Commands.User.CreateUser;
using Domain.CallCenter_Case.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Abstractions.Services
{
    public interface IUserService
    {
        Task<CreateUserDTO> CreateAsync(CreateUserCommand model);
        Task UpdateRefreshToken(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate);
        Task<List<ListUserDTO>> GetAllUsersAsync(int page, int size);
        int TotalUsersCount { get; }
        Task AssignRoleToUserAsnyc(string userId, string[] roles);
        Task<string[]> GetRolesToUserAsync(string userIdOrName);
        Task<AppUser> GetByUserIdAsync(string userId);
    }
}
