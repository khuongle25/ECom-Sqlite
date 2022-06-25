﻿using ECom.Models;

namespace EComWeb.Interfaces;

public interface IBasketService
{
    Task<Basket> AddItemToBasketAsync(int buyerId, int productItemId, int quantity);
    Task<Basket> SetQuantitesAsync(int basketId, Dictionary<string, int> quantities);
    Task DeleteBasketAsync(int basketId);
}