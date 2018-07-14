﻿using SynchroLean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynchroLean.Core
{
    public interface IAddUserRequestRepository
    {
        /// <summary>
        /// Add a new invitation to the database.
        /// </summary>
        /// <param name="request">The invitation to be added.</param>
        /// <returns></returns>
        Task AddAsync(AddUserRequest request);

        /// <summary>
        /// Get an invitation from the database.
        /// </summary>
        /// <param name="addUserRequestId">The key to the invitation.</param>
        /// <returns></returns>
        Task<AddUserRequest> GetAddUserRequestAsync(int addUserRequestId);

        /// <summary>
        /// Get all invitations.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<AddUserRequest>> GetAddUserRequestsAsync();

        /// <summary>
        /// Get all invitations a user can accept or decline.
        /// </summary>
        /// <param name="ownerId">The key for the user.</param>
        /// <returns></returns>
        Task<IEnumerable<AddUserRequest>> GetAddUserRequestsPendingApprovalAsync(int ownerId);

        /// <summary>
        /// Get all invitations a user can authorize.
        /// </summary>
        /// <param name="ownerId">The key for the user.</param>
        /// <returns></returns>
        Task<IEnumerable<AddUserRequest>> GetAddUserRequestsPendingAcceptanceAsync(int ownerId);

        /// <summary>
        /// Get all invitations a user has created.
        /// </summary>
        /// <param name="ownerId">The key for the user.</param>
        /// <returns></returns>
        Task<IEnumerable<AddUserRequest>> GetMySentAddUserRequestsAsync(int ownerId);

        /// <summary>
        /// Check if an invitation exists.
        /// </summary>
        /// <param name="addUserRequestId">The key for the invitation.</param>
        /// <returns>True if an invitation with a given key is in the database.</returns>
        Task<Boolean> AddUserRequestExists(int addUserRequestId);

        /// <summary>
        /// Delete an invitation from the database.
        /// </summary>
        /// <param name="addUserRequestId">The key for the invitation to delete.</param>
        /// <returns></returns>
        Task DeleteAddUserRequestAsync(int addUserRequestId);
    }
}