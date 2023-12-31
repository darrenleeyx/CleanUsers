﻿using CleanUsers.Application.Users.Queries.GetAllUsers;
using CleanUsers.Domain.Common.Models;
using CleanUsers.Domain.Users;

namespace CleanUsers.Application.Common.Abstractions;

public interface IUsersRepository
{
    Task<bool> ExistsIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<bool> ExistsUsernameAsync(string username, CancellationToken cancellationToken = default);
    Task AddAsync(User user, CancellationToken cancellationToken = default);
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<PaginatedList<User>> GetAllAsync(GetAllUsersOptions options, CancellationToken cancellationToken = default);
    Task RemoveAsync(User user, CancellationToken cancellationToken = default);
    Task RemoveRangeAsync(List<User> users, CancellationToken cancellationToken = default);
    Task UpdateAsync(User user, CancellationToken cancellationToken = default);
}
