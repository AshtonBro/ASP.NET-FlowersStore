﻿using FlowersStore.Models;
using System;

namespace FlowersStore.Services
{
    public interface IBasketService
    {
        Basket GetBasket(Guid userId);
    }
}
