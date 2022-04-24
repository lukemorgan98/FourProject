﻿using BlazorShop.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorShop.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;

        Task AddToCart(CartItem item);

        Task<List<CartItem>> GetCartItems();

        Task DeleteItem(CartItem item);

        Task EmptyCart();

        Task<string> Checkout();
    }
}
