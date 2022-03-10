﻿using RaceControl.Services.Interfaces.F1TV.Authorization;
using System.Threading.Tasks;

namespace RaceControl.Services.Interfaces.F1TV
{
    public interface IAuthorizationService
    {
        Task<AuthResponse> AuthenticateAsync(string login, string password);
    }
}