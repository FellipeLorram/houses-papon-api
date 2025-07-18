﻿using HousesPapon.Communication.Responses.Houses;

namespace HousesPapon.Application.UseCases.Houses.GetAvailableHouses
{
    public interface IGetAvailableHousesUseCase
    {
        Task<List<ResponseGetAvailableHouses>> Execute();
    }
}
